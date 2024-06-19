using System;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using aziretParser;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using MaterialSkin;


namespace VKR_Project
{
    public partial class Form1 : Form
    {
        Excel.Application xls;
        Excel.Workbook book;
        Excel.Worksheet sheet;
        private const string nameOfExcel = @"\LookingForOnePoint.xlsm";
        bool checkOpenExcel = false; // True if Excel open
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Настройка DataGridView
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Iteration";
            dataGridView1.Columns[1].Name = "X";
            dataGridView1.Columns[2].Name = "F(X)";
            dataGridView1.Columns[3].Name = "F'(X)";

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Очистка полей перед вызовом метода
            ClearFields();

            // Вызов метода Search_parametr_m после очистки полей
            var newtonMethod = new NewtonMethod();
            newtonMethod.Search_parametr_m(Function, InputX0, inputR, inputEpsilon, inputDelta, inputMax, ParametrM, progressBar1, dataGridView1, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Вызов метода для очистки полей
            ClearFields();
        }

        private void ClearFields()
        {
            TimeBox.Clear();
            NumberOfIterationsBox.Clear();
            RelErrorBox.Clear();
            Solution.Clear();
            ValueOfFunction.Clear();
            TextBox2.Clear();
            textBox3.Clear();
            dfxBox.Clear();
            condBox.Clear();
            dataGridView1.Rows.Clear(); // Очистка DataGridView
            expDfxBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenExcel();
        }

        public string ValidateFunc(string expression)
        {
            string new_expression = expression;
            string english_letters = "abcdefghijklmnopqrstuwxyz";
            string result = "";
            string[] unary_functions = { "sin", "cos", "tg", "tan", "ctg", "cot", "cta", "sec", "csc", "cosec", "asin", "arsin",
                                             "arcsin", "acos", "atg", "atan", "arctg", "acrctan", "actg", "acot", "actan", "arcctg",
                                             "arccot", "arcctan", "ln", "log2", "lg", "log10", "rad", "sqrt", "sinh", "cosh",
                                             "tgh", "tanh", "coth", "ctgh", "ctanh", "sech", "csch", "cosech", "deg", "exp"};

            for (int i = 0; i < unary_functions.Length; i++)
            {
                expression = expression.Replace(unary_functions[i], "");
            }

            for (int i = 0; i < expression.Length; i++)
            {
                if (english_letters.Contains(expression[i]))
                {
                    result += expression[i];
                }
            }

            if (result.All(ch => ch == result[0]))
            {
                new_expression = new_expression.Replace(result[0], 'x');
                return new_expression;
            }
            return " ";
        }

        bool check_logarithm(string expression)
        {
            if (expression.Contains("log") || expression.Contains("ln") || expression.Contains("log10") || expression.Contains("log2"))
            {
                if (Convert.ToDecimal(InputX0.Text) <= 0)
                {
                    MessageBox.Show("If you entered function with 'log' or 'ln' value of X0 must greater than zero!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        public void OpenExcel()
        {
            try
            {
                string function;
                decimal startPoint;
                if (InputX0.Text == "" || !decimal.TryParse(InputX0.Text, out startPoint))
                {
                    MessageBox.Show("Field x0 is empty or in the wrong format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (check_logarithm(ValidateFunc(Function.Text)))
                {
                    return;
                }
                if (checkOpenExcel == true)
                {
                    try
                    {
                        book.Save();
                        book.Close();
                        xls.Quit();
                    }
                    catch
                    {

                    }
                    book = null;
                    sheet = null;
                    xls = null;
                    checkOpenExcel = false;
                }
                xls = new Excel.Application();
                book = xls.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + nameOfExcel);
                sheet = book.Sheets["Russian"];
                this.SendToBack();
                xls.Visible = true;
                sheet.Activate();
                function = Function.Text;

                sheet.Cells[4, 9] = startPoint;
                sheet.Cells[4, 10] = startPoint + 2;
                sheet.Cells[2, 1] = "f(x)=" + Function.Text;

                StringBuilder builder = new StringBuilder(function);
                builder.Replace("exp", ":");
                builder.Replace("x", "D4");
                builder.Replace(":", "exp");
                function = builder.ToString();
                sheet.Range["E4:E10003"].Value = "=" + function;
                checkOpenExcel = true;
                book.Save();
            }
            catch
            {
                MessageBox.Show("Function specified in wrong format or Excel file is open", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (checkOpenExcel == true)
            {
                try
                {
                    book.Save();
                    book.Close();
                    xls.Quit();
                }
                catch
                {

                }
                book = null;
                sheet = null;
                xls = null;
                checkOpenExcel = false;
            }
            xls = new Excel.Application();
            book = xls.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + nameOfExcel);
            sheet = book.Sheets["Russian"];
            sheet.Activate();
            InputX0.Text = sheet.Cells[4, 9].Value.ToString();
            book.Save();
            book.Close();
            xls.Quit();
            xls = null;
            sheet = null;
            book = null;

        }

        private void buttonSpeed_Click(object sender, EventArgs e)
        {

        }

        private void Sigma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
