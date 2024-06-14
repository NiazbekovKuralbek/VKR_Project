using System;
using System.Text;
using System.Windows.Forms;

namespace VKR_Project
{
    public partial class Form1 : Form
    {
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
            var newtonMethod = new NewtonMethod();
            newtonMethod.Search_parametr_m(Function, InputX0, inputR, inputEpsilon, inputDelta, inputMax, ParametrM, progressBar1, dataGridView1, this);
        }

        private void button3_Click(object sender, EventArgs e)
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





        //public void OpenExcel()
        //{
        //    try
        //    {
        //        string function;
        //        Decimal startPoint;
        //        if (InitialPoint.Text == "" ||
        //            !Decimal.TryParse(InitialPoint.Text, out startPoint))
        //        {
        //            MessageBox.Show("Field x0 is empty or in the wrong format",
        //                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        if (check_logarithm(ValidateFunc(Function.Text)))
        //        {
        //            return;
        //        }
        //        if (checkOpenExcel == true)
        //        {
        //            try
        //            {
        //                book.Save();
        //                book.Close();
        //                xls.Quit();
        //            }
        //            catch
        //            {

        //            }
        //            book = null;
        //            sheet = null;
        //            xls = null;
        //            checkOpenExcel = false;
        //        }
        //        xls = new Excel.Application();
        //        book = xls.Workbooks.Open
        //            (System.IO.Directory.GetCurrentDirectory() + nameOfExcel);
        //        sheet = book.Sheets["Russian"];
        //        this.SendToBack();
        //        xls.Visible = true;
        //        sheet.Activate();
        //        function = Function.Text;

        //        sheet.Cells[4, 9] = startPoint;
        //        sheet.Cells[4, 10] = startPoint + 2;
        //        sheet.Cells[2, 1] = "f(x)=" + Function.Text;

        //        StringBuilder builder = new StringBuilder(function);
        //        builder.Replace("exp", ":");
        //        builder.Replace("x", "D4");
        //        builder.Replace(":", "exp");
        //        function = builder.ToString();
        //        sheet.Range["E4:E10003"].Value = "=" + function;
        //        checkOpenExcel = true;
        //        book.Save();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Function specified in wrong format or Excel file is open",
        //            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
