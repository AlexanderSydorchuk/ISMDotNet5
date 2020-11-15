namespace ISMDotNet5
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
            this.num_N = new System.Windows.Forms.NumericUpDown();
            this.num_M = new System.Windows.Forms.NumericUpDown();
            this.tb_ryadky = new System.Windows.Forms.TextBox();
            this.tb_stovpy = new System.Windows.Forms.TextBox();
            this.b_accept = new System.Windows.Forms.Button();
            this.dtg_Matrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_AmountOfColsWithZero = new System.Windows.Forms.Label();
            this.b_Random = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_AmountOfPositiveNums = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_MaxRepeatingNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_AmountOfRowsWithoutZero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.b_Trans = new System.Windows.Forms.Button();
            this.lb_RowWithBiggestAmountOfSimilarNums = new System.Windows.Forms.Label();
            this.lb_MultiplyRowsWithoutNegNums = new System.Windows.Forms.Label();
            this.lb_SumColsWithoutNegNums = new System.Windows.Forms.Label();
            this.lb_MaxDiagonalSum = new System.Windows.Forms.Label();
            this.lb_MinDiagonalSum = new System.Windows.Forms.Label();
            this.lb_SumColsWithNegNums = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // num_N
            // 
            this.num_N.Location = new System.Drawing.Point(202, 13);
            this.num_N.Name = "num_N";
            this.num_N.Size = new System.Drawing.Size(120, 20);
            this.num_N.TabIndex = 0;
            this.num_N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_N.ValueChanged += new System.EventHandler(this.num_N_ValueChanged);
            // 
            // num_M
            // 
            this.num_M.Location = new System.Drawing.Point(202, 39);
            this.num_M.Name = "num_M";
            this.num_M.Size = new System.Drawing.Size(120, 20);
            this.num_M.TabIndex = 1;
            this.num_M.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_ryadky
            // 
            this.tb_ryadky.Location = new System.Drawing.Point(68, 11);
            this.tb_ryadky.Name = "tb_ryadky";
            this.tb_ryadky.Size = new System.Drawing.Size(128, 20);
            this.tb_ryadky.TabIndex = 2;
            this.tb_ryadky.Text = "Кількість рядків:";
            // 
            // tb_stovpy
            // 
            this.tb_stovpy.Location = new System.Drawing.Point(68, 39);
            this.tb_stovpy.Name = "tb_stovpy";
            this.tb_stovpy.Size = new System.Drawing.Size(128, 20);
            this.tb_stovpy.TabIndex = 2;
            this.tb_stovpy.Text = "Кількість стовпців:";
            // 
            // b_accept
            // 
            this.b_accept.Location = new System.Drawing.Point(68, 79);
            this.b_accept.Name = "b_accept";
            this.b_accept.Size = new System.Drawing.Size(93, 23);
            this.b_accept.TabIndex = 3;
            this.b_accept.Text = "Застосувати";
            this.b_accept.UseVisualStyleBackColor = true;
            this.b_accept.Click += new System.EventHandler(this.b_accept_Click);
            // 
            // dtg_Matrix
            // 
            this.dtg_Matrix.AllowUserToAddRows = false;
            this.dtg_Matrix.AllowUserToDeleteRows = false;
            this.dtg_Matrix.AllowUserToResizeColumns = false;
            this.dtg_Matrix.AllowUserToResizeRows = false;
            this.dtg_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Matrix.Location = new System.Drawing.Point(12, 108);
            this.dtg_Matrix.Name = "dtg_Matrix";
            this.dtg_Matrix.RowHeadersWidth = 30;
            this.dtg_Matrix.Size = new System.Drawing.Size(662, 166);
            this.dtg_Matrix.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кількість стовпців, які мають хоча б один нуль:\r\n";
            // 
            // lb_AmountOfColsWithZero
            // 
            this.lb_AmountOfColsWithZero.AutoSize = true;
            this.lb_AmountOfColsWithZero.Location = new System.Drawing.Point(260, 292);
            this.lb_AmountOfColsWithZero.Name = "lb_AmountOfColsWithZero";
            this.lb_AmountOfColsWithZero.Size = new System.Drawing.Size(13, 13);
            this.lb_AmountOfColsWithZero.TabIndex = 6;
            this.lb_AmountOfColsWithZero.Text = "0";
            // 
            // b_Random
            // 
            this.b_Random.Location = new System.Drawing.Point(182, 79);
            this.b_Random.Name = "b_Random";
            this.b_Random.Size = new System.Drawing.Size(140, 23);
            this.b_Random.TabIndex = 7;
            this.b_Random.Text = "Заповнити рандомно";
            this.b_Random.UseVisualStyleBackColor = true;
            this.b_Random.Click += new System.EventHandler(this.b_Random_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кількість додатних елементів:";
            // 
            // lb_AmountOfPositiveNums
            // 
            this.lb_AmountOfPositiveNums.AutoSize = true;
            this.lb_AmountOfPositiveNums.Location = new System.Drawing.Point(177, 315);
            this.lb_AmountOfPositiveNums.Name = "lb_AmountOfPositiveNums";
            this.lb_AmountOfPositiveNums.Size = new System.Drawing.Size(13, 13);
            this.lb_AmountOfPositiveNums.TabIndex = 6;
            this.lb_AmountOfPositiveNums.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mаксимальне із чисел, що зустрічається в заданій матриці більше одного разу:";
            // 
            // lb_MaxRepeatingNum
            // 
            this.lb_MaxRepeatingNum.AutoSize = true;
            this.lb_MaxRepeatingNum.Location = new System.Drawing.Point(429, 338);
            this.lb_MaxRepeatingNum.Name = "lb_MaxRepeatingNum";
            this.lb_MaxRepeatingNum.Size = new System.Drawing.Size(13, 13);
            this.lb_MaxRepeatingNum.TabIndex = 6;
            this.lb_MaxRepeatingNum.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кількість рядків, які не мають жодного нуля:\r\n";
            // 
            // lb_AmountOfRowsWithoutZero
            // 
            this.lb_AmountOfRowsWithoutZero.AutoSize = true;
            this.lb_AmountOfRowsWithoutZero.Location = new System.Drawing.Point(260, 360);
            this.lb_AmountOfRowsWithoutZero.Name = "lb_AmountOfRowsWithoutZero";
            this.lb_AmountOfRowsWithoutZero.Size = new System.Drawing.Size(13, 13);
            this.lb_AmountOfRowsWithoutZero.TabIndex = 6;
            this.lb_AmountOfRowsWithoutZero.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hомер рядка, в якому знаходиться найдовша серія однакових елементів:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Добуток елементів в тих рядках, які не містять від’ємних елементів:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(438, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Максимум серед сум елементів діагоналей, паралельних головній діагоналі матриці:\r" +
    "\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(348, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Сума елементів в тих стовпцях, які не містять від’ємних елементів:\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(462, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Мінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі ма" +
    "триці:\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(390, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Сума елементів в тих стовпцях, які  містять хоча б один від’ємний елемент:\r\n";
            // 
            // b_Trans
            // 
            this.b_Trans.Location = new System.Drawing.Point(341, 79);
            this.b_Trans.Name = "b_Trans";
            this.b_Trans.Size = new System.Drawing.Size(101, 23);
            this.b_Trans.TabIndex = 9;
            this.b_Trans.Text = "Транспонувати";
            this.b_Trans.UseVisualStyleBackColor = true;
            this.b_Trans.Click += new System.EventHandler(this.b_Trans_Click);
            // 
            // lb_RowWithBiggestAmountOfSimilarNums
            // 
            this.lb_RowWithBiggestAmountOfSimilarNums.AutoSize = true;
            this.lb_RowWithBiggestAmountOfSimilarNums.Location = new System.Drawing.Point(400, 382);
            this.lb_RowWithBiggestAmountOfSimilarNums.Name = "lb_RowWithBiggestAmountOfSimilarNums";
            this.lb_RowWithBiggestAmountOfSimilarNums.Size = new System.Drawing.Size(13, 13);
            this.lb_RowWithBiggestAmountOfSimilarNums.TabIndex = 6;
            this.lb_RowWithBiggestAmountOfSimilarNums.Text = "0";
            // 
            // lb_MultiplyRowsWithoutNegNums
            // 
            this.lb_MultiplyRowsWithoutNegNums.AutoSize = true;
            this.lb_MultiplyRowsWithoutNegNums.Location = new System.Drawing.Point(372, 404);
            this.lb_MultiplyRowsWithoutNegNums.Name = "lb_MultiplyRowsWithoutNegNums";
            this.lb_MultiplyRowsWithoutNegNums.Size = new System.Drawing.Size(13, 13);
            this.lb_MultiplyRowsWithoutNegNums.TabIndex = 6;
            this.lb_MultiplyRowsWithoutNegNums.Text = "0";
            // 
            // lb_SumColsWithoutNegNums
            // 
            this.lb_SumColsWithoutNegNums.AutoSize = true;
            this.lb_SumColsWithoutNegNums.Location = new System.Drawing.Point(366, 450);
            this.lb_SumColsWithoutNegNums.Name = "lb_SumColsWithoutNegNums";
            this.lb_SumColsWithoutNegNums.Size = new System.Drawing.Size(13, 13);
            this.lb_SumColsWithoutNegNums.TabIndex = 6;
            this.lb_SumColsWithoutNegNums.Text = "0";
            // 
            // lb_MaxDiagonalSum
            // 
            this.lb_MaxDiagonalSum.AutoSize = true;
            this.lb_MaxDiagonalSum.Location = new System.Drawing.Point(456, 427);
            this.lb_MaxDiagonalSum.Name = "lb_MaxDiagonalSum";
            this.lb_MaxDiagonalSum.Size = new System.Drawing.Size(13, 13);
            this.lb_MaxDiagonalSum.TabIndex = 6;
            this.lb_MaxDiagonalSum.Text = "0";
            // 
            // lb_MinDiagonalSum
            // 
            this.lb_MinDiagonalSum.AutoSize = true;
            this.lb_MinDiagonalSum.Location = new System.Drawing.Point(480, 472);
            this.lb_MinDiagonalSum.Name = "lb_MinDiagonalSum";
            this.lb_MinDiagonalSum.Size = new System.Drawing.Size(13, 13);
            this.lb_MinDiagonalSum.TabIndex = 6;
            this.lb_MinDiagonalSum.Text = "0";
            // 
            // lb_SumColsWithNegNums
            // 
            this.lb_SumColsWithNegNums.AutoSize = true;
            this.lb_SumColsWithNegNums.Location = new System.Drawing.Point(408, 494);
            this.lb_SumColsWithNegNums.Name = "lb_SumColsWithNegNums";
            this.lb_SumColsWithNegNums.Size = new System.Drawing.Size(13, 13);
            this.lb_SumColsWithNegNums.TabIndex = 6;
            this.lb_SumColsWithNegNums.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 541);
            this.Controls.Add(this.b_Trans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_Random);
            this.Controls.Add(this.lb_SumColsWithNegNums);
            this.Controls.Add(this.lb_MinDiagonalSum);
            this.Controls.Add(this.lb_SumColsWithoutNegNums);
            this.Controls.Add(this.lb_MaxDiagonalSum);
            this.Controls.Add(this.lb_MultiplyRowsWithoutNegNums);
            this.Controls.Add(this.lb_RowWithBiggestAmountOfSimilarNums);
            this.Controls.Add(this.lb_AmountOfRowsWithoutZero);
            this.Controls.Add(this.lb_MaxRepeatingNum);
            this.Controls.Add(this.lb_AmountOfPositiveNums);
            this.Controls.Add(this.lb_AmountOfColsWithZero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_Matrix);
            this.Controls.Add(this.b_accept);
            this.Controls.Add(this.tb_stovpy);
            this.Controls.Add(this.tb_ryadky);
            this.Controls.Add(this.num_M);
            this.Controls.Add(this.num_N);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_N;
        private System.Windows.Forms.NumericUpDown num_M;
        private System.Windows.Forms.TextBox tb_ryadky;
        private System.Windows.Forms.TextBox tb_stovpy;
        private System.Windows.Forms.Button b_accept;
        private System.Windows.Forms.DataGridView dtg_Matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_AmountOfColsWithZero;
        private System.Windows.Forms.Button b_Random;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_AmountOfPositiveNums;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_MaxRepeatingNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_AmountOfRowsWithoutZero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button b_Trans;
        private System.Windows.Forms.Label lb_RowWithBiggestAmountOfSimilarNums;
        private System.Windows.Forms.Label lb_MultiplyRowsWithoutNegNums;
        private System.Windows.Forms.Label lb_SumColsWithoutNegNums;
        private System.Windows.Forms.Label lb_MaxDiagonalSum;
        private System.Windows.Forms.Label lb_MinDiagonalSum;
        private System.Windows.Forms.Label lb_SumColsWithNegNums;
    }
}

