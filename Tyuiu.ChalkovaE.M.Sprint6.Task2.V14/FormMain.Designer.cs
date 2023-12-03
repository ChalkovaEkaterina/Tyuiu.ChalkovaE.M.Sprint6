
namespace Tyuiu.ChalkovaE.M.Sprint6.Task2.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxConditionText_CEM = new System.Windows.Forms.GroupBox();
            this.textBoxDataInPut_CEM = new System.Windows.Forms.TextBox();
            this.textBoxStartV_CEM = new System.Windows.Forms.TextBox();
            this.textBoxStopV_CEM = new System.Windows.Forms.TextBox();
            this.textBoxDataStartV_CEM = new System.Windows.Forms.TextBox();
            this.textBoxDataStopV_CEM = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_CEM = new System.Windows.Forms.GroupBox();
            this.buttonHelp_CEM = new System.Windows.Forms.Button();
            this.buttonResult_CEM = new System.Windows.Forms.Button();
            this.textBoxDataOutPut_CEM = new System.Windows.Forms.TextBox();
            this.chartFunction_CEM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_CEM = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxResult_CEM = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_CEM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConditionText_CEM
            // 
            this.groupBoxConditionText_CEM.Location = new System.Drawing.Point(12, 52);
            this.groupBoxConditionText_CEM.Name = "groupBoxConditionText_CEM";
            this.groupBoxConditionText_CEM.Size = new System.Drawing.Size(728, 104);
            this.groupBoxConditionText_CEM.TabIndex = 0;
            this.groupBoxConditionText_CEM.TabStop = false;
            this.groupBoxConditionText_CEM.Text = "Написать программу, которая выводит таблицу значений функции: 5-3x + (1+sin(x))/(" +
    "2x-0.5). Значения занести в DataGrid View. ";
            // 
            // textBoxDataInPut_CEM
            // 
            this.textBoxDataInPut_CEM.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDataInPut_CEM.Location = new System.Drawing.Point(12, 355);
            this.textBoxDataInPut_CEM.Name = "textBoxDataInPut_CEM";
            this.textBoxDataInPut_CEM.Size = new System.Drawing.Size(245, 31);
            this.textBoxDataInPut_CEM.TabIndex = 1;
            this.textBoxDataInPut_CEM.Text = "Ввод данных:";
            // 
            // textBoxStartV_CEM
            // 
            this.textBoxStartV_CEM.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStartV_CEM.Location = new System.Drawing.Point(12, 392);
            this.textBoxStartV_CEM.Name = "textBoxStartV_CEM";
            this.textBoxStartV_CEM.Size = new System.Drawing.Size(134, 31);
            this.textBoxStartV_CEM.TabIndex = 2;
            this.textBoxStartV_CEM.Text = "Старт шага:";
            // 
            // textBoxStopV_CEM
            // 
            this.textBoxStopV_CEM.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStopV_CEM.Location = new System.Drawing.Point(194, 392);
            this.textBoxStopV_CEM.Name = "textBoxStopV_CEM";
            this.textBoxStopV_CEM.Size = new System.Drawing.Size(144, 31);
            this.textBoxStopV_CEM.TabIndex = 3;
            this.textBoxStopV_CEM.Text = "Конец шага:";
            // 
            // textBoxDataStartV_CEM
            // 
            this.textBoxDataStartV_CEM.Location = new System.Drawing.Point(12, 429);
            this.textBoxDataStartV_CEM.Name = "textBoxDataStartV_CEM";
            this.textBoxDataStartV_CEM.Size = new System.Drawing.Size(134, 31);
            this.textBoxDataStartV_CEM.TabIndex = 4;
            // 
            // textBoxDataStopV_CEM
            // 
            this.textBoxDataStopV_CEM.Location = new System.Drawing.Point(194, 429);
            this.textBoxDataStopV_CEM.Name = "textBoxDataStopV_CEM";
            this.textBoxDataStopV_CEM.Size = new System.Drawing.Size(144, 31);
            this.textBoxDataStopV_CEM.TabIndex = 5;
            // 
            // groupBoxCondition_CEM
            // 
            this.groupBoxCondition_CEM.Location = new System.Drawing.Point(12, 18);
            this.groupBoxCondition_CEM.Name = "groupBoxCondition_CEM";
            this.groupBoxCondition_CEM.Size = new System.Drawing.Size(208, 28);
            this.groupBoxCondition_CEM.TabIndex = 0;
            this.groupBoxCondition_CEM.TabStop = false;
            this.groupBoxCondition_CEM.Text = "Условие:";
            // 
            // buttonHelp_CEM
            // 
            this.buttonHelp_CEM.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_CEM.Location = new System.Drawing.Point(376, 372);
            this.buttonHelp_CEM.Name = "buttonHelp_CEM";
            this.buttonHelp_CEM.Size = new System.Drawing.Size(123, 88);
            this.buttonHelp_CEM.TabIndex = 6;
            this.buttonHelp_CEM.Text = "Справка";
            this.buttonHelp_CEM.UseVisualStyleBackColor = false;
            this.buttonHelp_CEM.Click += new System.EventHandler(this.buttonHelp_CEM_Click);
            // 
            // buttonResult_CEM
            // 
            this.buttonResult_CEM.BackColor = System.Drawing.Color.Green;
            this.buttonResult_CEM.Location = new System.Drawing.Point(525, 372);
            this.buttonResult_CEM.Name = "buttonResult_CEM";
            this.buttonResult_CEM.Size = new System.Drawing.Size(215, 88);
            this.buttonResult_CEM.TabIndex = 7;
            this.buttonResult_CEM.Text = "Выполнить";
            this.buttonResult_CEM.UseVisualStyleBackColor = false;
            this.buttonResult_CEM.Click += new System.EventHandler(this.buttonResult_CEM_Click);
            this.buttonResult_CEM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_CEM_MouseDown);
            this.buttonResult_CEM.MouseEnter += new System.EventHandler(this.buttonResult_CEM_MouseEnter);
            this.buttonResult_CEM.MouseLeave += new System.EventHandler(this.buttonResult_CEM_MouseLeave);
            // 
            // textBoxDataOutPut_CEM
            // 
            this.textBoxDataOutPut_CEM.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDataOutPut_CEM.Location = new System.Drawing.Point(877, 18);
            this.textBoxDataOutPut_CEM.Name = "textBoxDataOutPut_CEM";
            this.textBoxDataOutPut_CEM.Size = new System.Drawing.Size(206, 31);
            this.textBoxDataOutPut_CEM.TabIndex = 8;
            this.textBoxDataOutPut_CEM.Text = "Вывод данных:";
            // 
            // chartFunction_CEM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_CEM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_CEM.Legends.Add(legend1);
            this.chartFunction_CEM.Location = new System.Drawing.Point(1111, 18);
            this.chartFunction_CEM.Name = "chartFunction_CEM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_CEM.Series.Add(series1);
            this.chartFunction_CEM.Size = new System.Drawing.Size(568, 442);
            this.chartFunction_CEM.TabIndex = 9;
            this.chartFunction_CEM.Text = "chart1";
            // 
            // dataGridViewFunction_CEM
            // 
            this.dataGridViewFunction_CEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_CEM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction_CEM.Location = new System.Drawing.Point(877, 88);
            this.dataGridViewFunction_CEM.Name = "dataGridViewFunction_CEM";
            this.dataGridViewFunction_CEM.RowHeadersVisible = false;
            this.dataGridViewFunction_CEM.RowHeadersWidth = 82;
            this.dataGridViewFunction_CEM.RowTemplate.Height = 33;
            this.dataGridViewFunction_CEM.Size = new System.Drawing.Size(206, 372);
            this.dataGridViewFunction_CEM.TabIndex = 10;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Width = 50;
            // 
            // groupBoxResult_CEM
            // 
            this.groupBoxResult_CEM.Location = new System.Drawing.Point(877, 52);
            this.groupBoxResult_CEM.Name = "groupBoxResult_CEM";
            this.groupBoxResult_CEM.Size = new System.Drawing.Size(165, 30);
            this.groupBoxResult_CEM.TabIndex = 11;
            this.groupBoxResult_CEM.TabStop = false;
            this.groupBoxResult_CEM.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 688);
            this.Controls.Add(this.groupBoxResult_CEM);
            this.Controls.Add(this.dataGridViewFunction_CEM);
            this.Controls.Add(this.chartFunction_CEM);
            this.Controls.Add(this.textBoxDataOutPut_CEM);
            this.Controls.Add(this.buttonResult_CEM);
            this.Controls.Add(this.buttonHelp_CEM);
            this.Controls.Add(this.groupBoxCondition_CEM);
            this.Controls.Add(this.textBoxDataStopV_CEM);
            this.Controls.Add(this.textBoxDataStartV_CEM);
            this.Controls.Add(this.textBoxStopV_CEM);
            this.Controls.Add(this.textBoxStartV_CEM);
            this.Controls.Add(this.textBoxDataInPut_CEM);
            this.Controls.Add(this.groupBoxConditionText_CEM);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 14 | Чалкова Е.М.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_CEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditionText_CEM;
        private System.Windows.Forms.TextBox textBoxDataInPut_CEM;
        private System.Windows.Forms.TextBox textBoxStartV_CEM;
        private System.Windows.Forms.TextBox textBoxStopV_CEM;
        private System.Windows.Forms.TextBox textBoxDataStartV_CEM;
        private System.Windows.Forms.TextBox textBoxDataStopV_CEM;
        private System.Windows.Forms.GroupBox groupBoxCondition_CEM;
        private System.Windows.Forms.Button buttonHelp_CEM;
        private System.Windows.Forms.Button buttonResult_CEM;
        private System.Windows.Forms.TextBox textBoxDataOutPut_CEM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CEM;
        private System.Windows.Forms.DataGridView dataGridViewFunction_CEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.GroupBox groupBoxResult_CEM;
    }
}

