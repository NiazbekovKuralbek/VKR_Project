namespace VKR_Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputDelta = new System.Windows.Forms.TextBox();
            this.labelDelta = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.inputEpsilon = new System.Windows.Forms.TextBox();
            this.inputR = new System.Windows.Forms.TextBox();
            this.labelEpsilon = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.LabelX0 = new System.Windows.Forms.Label();
            this.inputMax = new System.Windows.Forms.TextBox();
            this.InputX0 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Function = new System.Windows.Forms.ComboBox();
            this.labelFunction = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Solution = new System.Windows.Forms.TextBox();
            this.ValueOfFunction = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.expDDfxBox = new System.Windows.Forms.TextBox();
            this.expDfxBox = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.ddfxBox = new System.Windows.Forms.TextBox();
            this.dfxBox = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.NumberOfIterationsBox = new System.Windows.Forms.TextBox();
            this.RelErrorBox = new System.Windows.Forms.TextBox();
            this.condBox = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSolution = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDelta
            // 
            this.inputDelta.Location = new System.Drawing.Point(9, 196);
            this.inputDelta.Name = "inputDelta";
            this.inputDelta.Size = new System.Drawing.Size(149, 20);
            this.inputDelta.TabIndex = 5;
            this.inputDelta.Text = "1e-14";
            // 
            // labelDelta
            // 
            this.labelDelta.AutoSize = true;
            this.labelDelta.Location = new System.Drawing.Point(9, 180);
            this.labelDelta.Name = "labelDelta";
            this.labelDelta.Size = new System.Drawing.Size(142, 13);
            this.labelDelta.TabIndex = 4;
            this.labelDelta.Text = "Допустимая ошибка Delta:";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(9, 227);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(91, 13);
            this.labelR.TabIndex = 6;
            this.labelR.Text = "Коэффициент R:";
            // 
            // inputEpsilon
            // 
            this.inputEpsilon.Location = new System.Drawing.Point(9, 142);
            this.inputEpsilon.Name = "inputEpsilon";
            this.inputEpsilon.Size = new System.Drawing.Size(149, 20);
            this.inputEpsilon.TabIndex = 3;
            this.inputEpsilon.Text = "1e-28";
            // 
            // inputR
            // 
            this.inputR.Location = new System.Drawing.Point(9, 243);
            this.inputR.Name = "inputR";
            this.inputR.Size = new System.Drawing.Size(149, 20);
            this.inputR.TabIndex = 7;
            this.inputR.Text = "10";
            // 
            // labelEpsilon
            // 
            this.labelEpsilon.AutoSize = true;
            this.labelEpsilon.Location = new System.Drawing.Point(9, 126);
            this.labelEpsilon.Name = "labelEpsilon";
            this.labelEpsilon.Size = new System.Drawing.Size(151, 13);
            this.labelEpsilon.TabIndex = 2;
            this.labelEpsilon.Text = "Допустимая ошибка Epsilon:";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(9, 271);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(192, 13);
            this.labelMax.TabIndex = 8;
            this.labelMax.Text = "Максимальное число итераций Max:";
            // 
            // LabelX0
            // 
            this.LabelX0.AutoSize = true;
            this.LabelX0.Location = new System.Drawing.Point(9, 77);
            this.LabelX0.Name = "LabelX0";
            this.LabelX0.Size = new System.Drawing.Size(152, 13);
            this.LabelX0.TabIndex = 0;
            this.LabelX0.Text = "Начальное приближение X0:";
            // 
            // inputMax
            // 
            this.inputMax.Location = new System.Drawing.Point(9, 287);
            this.inputMax.Name = "inputMax";
            this.inputMax.Size = new System.Drawing.Size(149, 20);
            this.inputMax.TabIndex = 9;
            this.inputMax.Text = "100";
            // 
            // InputX0
            // 
            this.InputX0.Location = new System.Drawing.Point(9, 93);
            this.InputX0.Name = "InputX0";
            this.InputX0.Size = new System.Drawing.Size(149, 20);
            this.InputX0.TabIndex = 1;
            this.InputX0.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Function);
            this.groupBox1.Controls.Add(this.labelFunction);
            this.groupBox1.Controls.Add(this.InputX0);
            this.groupBox1.Controls.Add(this.inputMax);
            this.groupBox1.Controls.Add(this.LabelX0);
            this.groupBox1.Controls.Add(this.labelMax);
            this.groupBox1.Controls.Add(this.labelEpsilon);
            this.groupBox1.Controls.Add(this.inputR);
            this.groupBox1.Controls.Add(this.inputEpsilon);
            this.groupBox1.Controls.Add(this.labelR);
            this.groupBox1.Controls.Add(this.labelDelta);
            this.groupBox1.Controls.Add(this.inputDelta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 400);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 363);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(262, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Параметр m:";
            // 
            // Function
            // 
            this.Function.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Function.FormattingEnabled = true;
            this.Function.Items.AddRange(new object[] {
            "(x-4)^2",
            "x^2-2*x-1",
            "x^2-4*sin(x)",
            "(x^2-4*sin(x))^2",
            "(4-x^2)^2",
            "0,4+x-0,1*x^2",
            "0,5*x^2-sin(x)",
            "2*x-2-sin(x)",
            "(x-2)^2-ln(x)",
            "x*exp(-x)",
            "(x^2-4*sin(x))^2",
            "x^3-5*x^2+x+5"});
            this.Function.Location = new System.Drawing.Point(9, 38);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(249, 21);
            this.Function.TabIndex = 12;
            this.Function.TabStop = false;
            this.Function.Text = "(x-4)^2";
            // 
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Location = new System.Drawing.Point(9, 22);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(73, 13);
            this.labelFunction.TabIndex = 10;
            this.labelFunction.Text = "Функция f(x):";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(18, 454);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(126, 41);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Run NM";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Solution);
            this.groupBox2.Controls.Add(this.ValueOfFunction);
            this.groupBox2.Controls.Add(this.Label23);
            this.groupBox2.Controls.Add(this.Label22);
            this.groupBox2.Controls.Add(this.expDDfxBox);
            this.groupBox2.Controls.Add(this.expDfxBox);
            this.groupBox2.Controls.Add(this.ddfxBox);
            this.groupBox2.Controls.Add(this.dfxBox);
            this.groupBox2.Controls.Add(this.Label10);
            this.groupBox2.Controls.Add(this.Label9);
            this.groupBox2.Controls.Add(this.TextBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.Label21);
            this.groupBox2.Controls.Add(this.Label16);
            this.groupBox2.Controls.Add(this.TimeBox);
            this.groupBox2.Controls.Add(this.NumberOfIterationsBox);
            this.groupBox2.Controls.Add(this.RelErrorBox);
            this.groupBox2.Controls.Add(this.condBox);
            this.groupBox2.Controls.Add(this.Label11);
            this.groupBox2.Controls.Add(this.Label15);
            this.groupBox2.Controls.Add(this.Label14);
            this.groupBox2.Controls.Add(this.Label13);
            this.groupBox2.Controls.Add(this.Label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelSolution);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 624);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // Solution
            // 
            this.Solution.Location = new System.Drawing.Point(37, 281);
            this.Solution.Name = "Solution";
            this.Solution.ReadOnly = true;
            this.Solution.Size = new System.Drawing.Size(293, 20);
            this.Solution.TabIndex = 61;
            // 
            // ValueOfFunction
            // 
            this.ValueOfFunction.Location = new System.Drawing.Point(44, 312);
            this.ValueOfFunction.Name = "ValueOfFunction";
            this.ValueOfFunction.ReadOnly = true;
            this.ValueOfFunction.Size = new System.Drawing.Size(293, 20);
            this.ValueOfFunction.TabIndex = 60;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(12, 420);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(105, 13);
            this.Label23.TabIndex = 59;
            this.Label23.Text = "Expression of  f \'\' (X):";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(12, 394);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(103, 13);
            this.Label22.TabIndex = 58;
            this.Label22.Text = "Expression of  f \' (X):";
            // 
            // expDDfxBox
            // 
            this.expDDfxBox.Location = new System.Drawing.Point(123, 417);
            this.expDDfxBox.Name = "expDDfxBox";
            this.expDDfxBox.ReadOnly = true;
            this.expDDfxBox.Size = new System.Drawing.Size(246, 20);
            this.expDDfxBox.TabIndex = 57;
            // 
            // expDfxBox
            // 
            this.expDfxBox.Location = new System.Drawing.Point(123, 391);
            this.expDfxBox.Name = "expDfxBox";
            this.expDfxBox.ReadOnly = true;
            this.expDfxBox.Size = new System.Drawing.Size(246, 20);
            this.expDfxBox.TabIndex = 56;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(296, 678);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(45, 13);
            this.Label20.TabIndex = 55;
            this.Label20.Text = "Label20";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(200, 678);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(90, 13);
            this.Label19.TabIndex = 54;
            this.Label19.Text = "f(X*) - f(X*+Delta):";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(296, 652);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(45, 13);
            this.Label18.TabIndex = 53;
            this.Label18.Text = "Label18";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(199, 652);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(87, 13);
            this.Label17.TabIndex = 52;
            this.Label17.Text = "f(X*) - f(X*-Delta):";
            // 
            // ddfxBox
            // 
            this.ddfxBox.Location = new System.Drawing.Point(76, 365);
            this.ddfxBox.Name = "ddfxBox";
            this.ddfxBox.ReadOnly = true;
            this.ddfxBox.Size = new System.Drawing.Size(293, 20);
            this.ddfxBox.TabIndex = 51;
            // 
            // dfxBox
            // 
            this.dfxBox.Location = new System.Drawing.Point(76, 338);
            this.dfxBox.Name = "dfxBox";
            this.dfxBox.ReadOnly = true;
            this.dfxBox.Size = new System.Drawing.Size(293, 20);
            this.dfxBox.TabIndex = 50;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(12, 368);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(40, 13);
            this.Label10.TabIndex = 49;
            this.Label10.Text = "f \'\' (X*):";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(12, 341);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(38, 13);
            this.Label9.TabIndex = 48;
            this.Label9.Text = "f \' (X*):";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(80, 545);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(289, 20);
            this.TextBox2.TabIndex = 47;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 515);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(289, 20);
            this.textBox3.TabIndex = 46;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(13, 585);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(53, 13);
            this.Label21.TabIndex = 45;
            this.Label21.Text = "Message:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(13, 548);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(61, 13);
            this.Label16.TabIndex = 44;
            this.Label16.Text = "f(X*+Delta):";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(269, 476);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new System.Drawing.Size(100, 20);
            this.TimeBox.TabIndex = 43;
            // 
            // NumberOfIterationsBox
            // 
            this.NumberOfIterationsBox.Location = new System.Drawing.Point(269, 449);
            this.NumberOfIterationsBox.Name = "NumberOfIterationsBox";
            this.NumberOfIterationsBox.ReadOnly = true;
            this.NumberOfIterationsBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfIterationsBox.TabIndex = 42;
            // 
            // RelErrorBox
            // 
            this.RelErrorBox.Location = new System.Drawing.Point(76, 476);
            this.RelErrorBox.Name = "RelErrorBox";
            this.RelErrorBox.ReadOnly = true;
            this.RelErrorBox.Size = new System.Drawing.Size(100, 20);
            this.RelErrorBox.TabIndex = 41;
            // 
            // condBox
            // 
            this.condBox.Location = new System.Drawing.Point(76, 449);
            this.condBox.Name = "condBox";
            this.condBox.ReadOnly = true;
            this.condBox.Size = new System.Drawing.Size(100, 20);
            this.condBox.TabIndex = 40;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(12, 452);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(35, 13);
            this.Label11.TabIndex = 39;
            this.Label11.Text = "Cond:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(12, 518);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(58, 13);
            this.Label15.TabIndex = 38;
            this.Label15.Text = "f(X*-Delta):";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(204, 479);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(59, 13);
            this.Label14.TabIndex = 37;
            this.Label14.Text = "Time (sec):";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(204, 452);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(16, 13);
            this.Label13.TabIndex = 36;
            this.Label13.Text = "k:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(12, 479);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(48, 13);
            this.Label12.TabIndex = 35;
            this.Label12.Text = "RelError:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(10, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "f(x*):";
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Location = new System.Drawing.Point(10, 284);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(21, 13);
            this.labelSolution.TabIndex = 1;
            this.labelSolution.Text = "X*:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Draw Graph";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Take values from Excel-file";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 35);
            this.button3.TabIndex = 19;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 649);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label18);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputDelta;
        private System.Windows.Forms.Label labelDelta;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox inputEpsilon;
        private System.Windows.Forms.TextBox inputR;
        private System.Windows.Forms.Label labelEpsilon;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label LabelX0;
        private System.Windows.Forms.TextBox inputMax;
        private System.Windows.Forms.TextBox InputX0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.ComboBox Function;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox expDDfxBox;
        internal System.Windows.Forms.TextBox expDfxBox;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox ddfxBox;
        internal System.Windows.Forms.TextBox dfxBox;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox TimeBox;
        internal System.Windows.Forms.TextBox NumberOfIterationsBox;
        internal System.Windows.Forms.TextBox RelErrorBox;
        internal System.Windows.Forms.TextBox condBox;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button startButton;
        internal System.Windows.Forms.TextBox Solution;
        internal System.Windows.Forms.TextBox ValueOfFunction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
