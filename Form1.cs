using System;
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
            dataGridView1.Columns[4].Name = "F''(X)";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var newtonMethod = new NewtonMethod();
            newtonMethod.Start(Function, InputX0, inputR, inputEpsilon, inputDelta, inputMax, progressBar1, dataGridView1, this);
        }
    }
}
