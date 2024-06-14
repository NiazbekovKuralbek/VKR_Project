using System;
using System.Drawing;
using System.Windows.Forms;
using aziretParser;
using info.lundin.math;
using System.Threading;
using Extreme.Statistics;

namespace VKR_Project
{
    public class NewtonMethod
    {
        private int k, cond;
        private string func, DFunc;
        private decimal SolutionOfTask, ValueOfFunction, RelError;

        public void Out(TextBox SolutionOfTaskBox, TextBox ValueOfFunctionBox, TextBox RelErrorBox, TextBox NumberOfIterationsBox, Form1 form)
        {
            SolutionOfTaskBox.Text = SolutionOfTask.ToString();
            ValueOfFunctionBox.Text = ValueOfFunction.ToString();
            RelErrorBox.Text = RelError.ToString("0e0");
            NumberOfIterationsBox.Text = k.ToString();
            form.expDfxBox.Text = DFunc;
        }

        private decimal F(decimal a)
        {
            return aziretParser.Computer.Compute(func, a);
        }

        private decimal DF(decimal a)
        {
            return aziretParser.Computer.Compute(DFunc, a);
        }

        public void Search_parametr_m(ComboBox funcBox, TextBox pointBox, TextBox rBox, TextBox tolBox, TextBox deltaBox, TextBox k_maxBox, TextBox parametrMBox, ProgressBar progressBar1, DataGridView dataGridView1, Form1 form)
        {
            try
            {
                decimal x0, x1 = 0, fx0, fx1 = 0;
                decimal dp, dfx0, dfx1 = 0, r, Tolerance, Delta, m;
                int k_max;

                func = funcBox.Text;
                r = decimal.Parse(rBox.Text);
                Tolerance = Convert.ToDecimal(double.Parse(tolBox.Text));
                Delta = Convert.ToDecimal(double.Parse(deltaBox.Text));
                x0 = decimal.Parse(pointBox.Text);
                k_max = int.Parse(k_maxBox.Text);
                m = decimal.Parse(parametrMBox.Text);

                DFunc = aziretParser.Derivative.ReturnDerivative(func);
                k = 0;

                fx0 = F(x0);  // Предполагаем, что функция F определена и возвращает значение функции в точке x0
                dfx0 = DF(x0);  // Предполагаем, что функция DF определена и возвращает значение производной функции в точке x0

                form.expDfxBox.Text = DFunc;

                k++;
                dp = m * (fx0 / dfx0);
                x1 = x0 - dp;

                fx1 = F(x1);
                dfx1 = DF(x1);

                RelError = 2 * Math.Abs(dp) / (Math.Abs(x1) + Delta);
                cond = 0;
                if (RelError <= Delta)
                {
                    cond = 2;
                }

                progressBar1.Visible = true;
                progressBar1.Maximum = k_max;
                progressBar1.Value = k;

                // Добавление данных в DataGridView
                dataGridView1.Rows.Add(k, x1, fx1, dfx1);

                // Передача значений в Start для продолжения итераций
                ContinueIterations(funcBox, pointBox, rBox, tolBox, deltaBox, k_maxBox, x1, fx1, dfx1, cond, k, RelError, progressBar1, dataGridView1, form, m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!" + Environment.NewLine +
                                "Проверьте введенные данные и попробуйте снова.I1");
            }
        }

        private void ContinueIterations(ComboBox funcBox, TextBox pointBox, TextBox rBox, TextBox tolBox, TextBox deltaBox, TextBox k_maxBox, decimal x0, decimal fx0, decimal dfx0, int cond, int k, decimal RelError, ProgressBar progressBar1, DataGridView dataGridView1, Form1 form, decimal m)
        {
            try
            {
                decimal x1 = x0, fx1 = fx0;
                decimal dp, dfx1 = dfx0, r, Tolerance, Delta;
                int k_max;

                r = decimal.Parse(rBox.Text);
                Tolerance = Convert.ToDecimal(double.Parse(tolBox.Text));
                Delta = Convert.ToDecimal(double.Parse(deltaBox.Text));
                k_max = int.Parse(k_maxBox.Text);

                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();

                while (k < k_max && cond == 0)
                {
                    k++;
                    dp = m * (fx0 / dfx0);
                    x1 = x0 - dp;

                    fx1 = F(x1);
                    dfx1 = DF(x1);

                    RelError = 2 * Math.Abs(dp) / (Math.Abs(x1) + Delta);
                    if (RelError <= Delta)
                    {
                        cond = 2;
                    }
                    x0 = x1;
                    fx0 = fx1;
                    dfx0 = dfx1;

                    progressBar1.Visible = true;
                    progressBar1.Maximum = k_max;
                    progressBar1.Value = k;

                    // Добавление данных в DataGridView
                    dataGridView1.Rows.Add(k, x1, fx1, dfx1);
                }

                progressBar1.Visible = false;

                stopwatch.Stop();
                form.TimeBox.Text = stopwatch.Elapsed.TotalSeconds.ToString("0.00");
                form.NumberOfIterationsBox.Text = k.ToString();
                form.RelErrorBox.Text = RelError.ToString("0e0");

                SolutionOfTask = x1;
                ValueOfFunction = fx1;

                form.Solution.Text = SolutionOfTask.ToString();
                form.ValueOfFunction.Text = ValueOfFunction.ToString();

                form.TextBox2.Text = F(x1 - Delta).ToString();
                form.textBox3.Text = F(x1 + Delta).ToString();
                form.Label18.Text = "";
                form.Label20.Text = "";
                form.dfxBox.Text = dfx1.ToString();
                form.condBox.Text = cond.ToString();

                if (cond == 2)
                {
                    if (Math.Abs(fx1) <= Tolerance)
                    {
                        form.Label21.ForeColor = Color.Green;
                        form.Label21.Text = "Результат X* является корнем функции потому, что f(X*) ≈ 0.";
                    }
                    else
                    {
                        form.Label21.ForeColor = Color.DarkRed;
                        form.Label21.Text = "Решение не является корнем функции, так как f(X*) не равно нулю.";
                    }
                }
                else
                {
                    form.Label21.ForeColor = Color.DarkRed;
                    form.Label21.Text = "Было достигнуто максимальное количество итераций!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!" + Environment.NewLine +
                                "Для определения корректных данных рекомендуем открыть Excel-файл, нажав на кнопку 'Draw Graph'," +
                                " подобрать подходящую начальную точку X0, сохранить файл, затем в программе нажать на кнопку 'Take values from Excel-file'." + Environment.NewLine +
                                "Также проверьте введенную функцию. В качестве переменных используйте 'x'.");
            }
        }


    }
}
