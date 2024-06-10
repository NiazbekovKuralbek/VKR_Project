using System;
using System.Drawing;
using System.Windows.Forms;
using aziretParser;

namespace VKR_Project
{
    public class NewtonMethod
    {
        private int k, cond;
        private string func, DFunc, DDFunc;
        private decimal SolutionOfTask, ValueOfFunction, RelError;

        // Subroutine to output results of the searching into the interface form
        public void Out(TextBox SolutionOfTaskBox, TextBox ValueOfFunctionBox, TextBox RelErrorBox, TextBox NumberOfIterationsBox, Form1 form)
        {
            SolutionOfTaskBox.Text = SolutionOfTask.ToString();
            ValueOfFunctionBox.Text = ValueOfFunction.ToString();
            RelErrorBox.Text = RelError.ToString("0e0");
            NumberOfIterationsBox.Text = k.ToString();
            form.expDfxBox.Text = DFunc;
            form.expDDfxBox.Text = DDFunc;
        }

        // Subroutine-function to compute the function f(X)’s value for a given argument X
        private decimal F(decimal a)
        {
            return aziretParser.Computer.Compute(func, a);
        }

        private decimal DF(decimal a)
        {
            return aziretParser.Computer.Compute(DFunc, a);
        }

        private decimal DDF(decimal a)
        {
            return aziretParser.Computer.Compute(DDFunc, a);
        }

        // Subroutine to get input data from the interface and run Newton Method
        public void Start(ComboBox funcBox, TextBox pointBox, TextBox rBox, TextBox tolBox, TextBox deltaBox, TextBox k_maxBox, ProgressBar progressBar1, DataGridView dataGridView1, Form1 form)
        {
            try
            {
                decimal x0, x1 = 0, fx0, fx1 = 0, fxminustol, fxplustol;
                decimal dp, dp0 = 0, dfx0, ddfx0, dfx1 = 0, ddfx1 = 0, r, Tolerance, Delta;
                int k_max;

                func = funcBox.Text;
                r = decimal.Parse(rBox.Text);
                Tolerance = Convert.ToDecimal(double.Parse(tolBox.Text));
                Delta = Convert.ToDecimal(double.Parse(deltaBox.Text));
                x0 = decimal.Parse(pointBox.Text);
                k_max = int.Parse(k_maxBox.Text);

                DFunc = aziretParser.Derivative.ReturnDerivative(func);
                DDFunc = aziretParser.Derivative.ReturnDerivative(DFunc);
                k = 0;
                cond = 0;
                fx0 = F(x0);
                dfx0 = DF(x0);
                ddfx0 = DDF(x0);
                dp = dfx0 / ddfx0;

                while (k < k_max && cond == 0)
                {
                    k++;
                    if (Math.Abs(ddfx0) <= Tolerance)
                    {
                        cond = 1;
                    }
                    if (k == 1)
                    {
                        dp0 = dp;
                    }
                    if (Math.Sign(dp0) == Math.Sign(dp))
                    {
                        x1 = x0 - dp;
                    }
                    else
                    {
                        x1 = x0 - dp / r;
                    }
                    dp0 = dp;
                    fx1 = F(x1);
                    dfx1 = DF(x1);
                    ddfx1 = DDF(x1);
                    dp = dfx1 / ddfx1;
                    RelError = 2 * Math.Abs(dp) / (Math.Abs(x1) + Delta);
                    if (RelError <= Delta)
                    {
                        if (cond != 1)
                        {
                            cond = 2;
                        }
                    }
                    x0 = x1;
                    dfx0 = dfx1;
                    ddfx0 = ddfx1;

                    progressBar1.Visible = true;
                    progressBar1.Maximum = k_max;
                    progressBar1.Value = k;

                    // Добавление данных в DataGridView
                    dataGridView1.Rows.Add(k, x1, fx1, dfx1, ddfx1);
                }

                progressBar1.Visible = false;

                fxminustol = F(x1 - Delta);
                fxplustol = F(x1 + Delta);
                SolutionOfTask = x1;
                ValueOfFunction = fx1;

                form.TextBox2.Text = fxminustol.ToString();
                form.textBox3.Text = fxplustol.ToString();
                form.Label18.Text = (fx1 - fxminustol).ToString("0e0");
                form.Label20.Text = (fx1 + fxplustol).ToString("0e0");
                form.dfxBox.Text = dfx1.ToString();
                form.ddfxBox.Text = ddfx1.ToString();
                form.condBox.Text = cond.ToString();

                if (cond == 2)
                {
                    if (fx1 < fxminustol && fx1 < fxplustol)
                    {
                        form.Label21.ForeColor = Color.Green;
                        form.Label21.Text = "Результат X* является минимумом функции потому, что" +
                                            " f(X*) < f(X*-Delta) and f(X*) < f(X*+Delta).";
                        return;
                    }
                    else if (fx1 > fxminustol && fx1 > fxplustol)
                    {
                        form.Label21.ForeColor = Color.Green;
                        form.Label21.Text = "Результат X* является максимумом функции потому, что" +
                                            " f(X*) > f(X*-Delta) and f(X*) > f(X*+Delta).";
                        return;
                    }
                    else if (fx1 < fxminustol && fx1 > fxplustol)
                    {
                        form.Label21.ForeColor = Color.DarkRed;
                        form.Label21.Text = "X* - точка перегиба." +
                                            " Результат X* не является экстремумом функции потому, что" +
                                            " f(X*) < f(X*-Delta) and f(X*) > f(X*+Delta).";
                    }
                    else if (fx1 > fxminustol && fx1 < fxplustol)
                    {
                        form.Label21.ForeColor = Color.DarkRed;
                        form.Label21.Text = "Решение не найдено. X* - точка перегиба." +
                                            " Результат X* не является экстремумом функции потому, что" +
                                            " f(X*) > f(X*-Delta) and f(X*) < f(X*+Delta).";
                    }
                }
                else if (cond == 1)
                {
                    form.Label21.ForeColor = Color.DarkRed;
                    form.Label21.Text = "Решение не найдено. Призошло деление на ноль.";
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
