
namespace Tyuiu.ChalkovaE.M.Sprint6.Task5.V6
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
            this.groupBoxCondition_CEM = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_CEM = new System.Windows.Forms.TextBox();
            this.groupBoxDataOutPut_CEM = new System.Windows.Forms.GroupBox();
            this.buttonDone_CEM = new System.Windows.Forms.Button();
            this.buttonOpen_CEM = new System.Windows.Forms.Button();
            this.buttonInfo_CEM = new System.Windows.Forms.Button();
            this.dataGridViewNums_CEM = new System.Windows.Forms.DataGridView();
            this.chartDiag_CEM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_CEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_CEM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_CEM
            // 
            this.groupBoxCondition_CEM.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_CEM.Name = "groupBoxCondition_CEM";
            this.groupBoxCondition_CEM.Size = new System.Drawing.Size(206, 33);
            this.groupBoxCondition_CEM.TabIndex = 0;
            this.groupBoxCondition_CEM.TabStop = false;
            this.groupBoxCondition_CEM.Text = "Условие:";
            // 
            // textBoxCondition_CEM
            // 
            this.textBoxCondition_CEM.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxCondition_CEM.Location = new System.Drawing.Point(12, 39);
            this.textBoxCondition_CEM.Multiline = true;
            this.textBoxCondition_CEM.Name = "textBoxCondition_CEM";
            this.textBoxCondition_CEM.Size = new System.Drawing.Size(717, 87);
            this.textBoxCondition_CEM.TabIndex = 1;
            this.textBoxCondition_CEM.Text = "Прочитать данные из файла InPutFileTask5V6.txt. Вывести в dataGridView. Дан списо" +
    "к из 20 чисел. Вывести все числа, кратные 3. Построить диаграмму по этим значени" +
    "ям. ";
            // 
            // groupBoxDataOutPut_CEM
            // 
            this.groupBoxDataOutPut_CEM.Location = new System.Drawing.Point(8, 132);
            this.groupBoxDataOutPut_CEM.Name = "groupBoxDataOutPut_CEM";
            this.groupBoxDataOutPut_CEM.Size = new System.Drawing.Size(198, 29);
            this.groupBoxDataOutPut_CEM.TabIndex = 2;
            this.groupBoxDataOutPut_CEM.TabStop = false;
            this.groupBoxDataOutPut_CEM.Text = "Вывод данных:";
            // 
            // buttonDone_CEM
            // 
            this.buttonDone_CEM.BackColor = System.Drawing.Color.Salmon;
            this.buttonDone_CEM.Location = new System.Drawing.Point(759, 39);
            this.buttonDone_CEM.Name = "buttonDone_CEM";
            this.buttonDone_CEM.Size = new System.Drawing.Size(190, 87);
            this.buttonDone_CEM.TabIndex = 3;
            this.buttonDone_CEM.Text = "Выполнить";
            this.buttonDone_CEM.UseVisualStyleBackColor = false;
            this.buttonDone_CEM.Click += new System.EventHandler(this.buttonDone_CEM_Click);
            // 
            // buttonOpen_CEM
            // 
            this.buttonOpen_CEM.BackColor = System.Drawing.Color.MistyRose;
            this.buttonOpen_CEM.Location = new System.Drawing.Point(969, 39);
            this.buttonOpen_CEM.Name = "buttonOpen_CEM";
            this.buttonOpen_CEM.Size = new System.Drawing.Size(190, 87);
            this.buttonOpen_CEM.TabIndex = 4;
            this.buttonOpen_CEM.Text = "Открыть файл";
            this.buttonOpen_CEM.UseVisualStyleBackColor = false;
            this.buttonOpen_CEM.Click += new System.EventHandler(this.buttonOpen_CEM_Click);
            // 
            // buttonInfo_CEM
            // 
            this.buttonInfo_CEM.BackColor = System.Drawing.Color.Tomato;
            this.buttonInfo_CEM.Location = new System.Drawing.Point(1758, 39);
            this.buttonInfo_CEM.Name = "buttonInfo_CEM";
            this.buttonInfo_CEM.Size = new System.Drawing.Size(190, 87);
            this.buttonInfo_CEM.TabIndex = 5;
            this.buttonInfo_CEM.Text = "Справка";
            this.buttonInfo_CEM.UseVisualStyleBackColor = false;
            this.buttonInfo_CEM.Click += new System.EventHandler(this.buttonInfo_CEM_Click);
            // 
            // dataGridViewNums_CEM
            // 
            this.dataGridViewNums_CEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_CEM.ColumnHeadersVisible = false;
            this.dataGridViewNums_CEM.Location = new System.Drawing.Point(12, 191);
            this.dataGridViewNums_CEM.Name = "dataGridViewNums_CEM";
            this.dataGridViewNums_CEM.RowHeadersVisible = false;
            this.dataGridViewNums_CEM.RowHeadersWidth = 82;
            this.dataGridViewNums_CEM.RowTemplate.Height = 33;
            this.dataGridViewNums_CEM.Size = new System.Drawing.Size(303, 731);
            this.dataGridViewNums_CEM.TabIndex = 6;
            // 
            // chartDiag_CEM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiag_CEM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDiag_CEM.Legends.Add(legend1);
            this.chartDiag_CEM.Location = new System.Drawing.Point(583, 177);
            this.chartDiag_CEM.Name = "chartDiag_CEM";
            this.chartDiag_CEM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_CEM.Series.Add(series1);
            this.chartDiag_CEM.Size = new System.Drawing.Size(1355, 760);
            this.chartDiag_CEM.TabIndex = 7;
            this.chartDiag_CEM.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1960, 958);
            this.Controls.Add(this.chartDiag_CEM);
            this.Controls.Add(this.dataGridViewNums_CEM);
            this.Controls.Add(this.buttonInfo_CEM);
            this.Controls.Add(this.buttonOpen_CEM);
            this.Controls.Add(this.buttonDone_CEM);
            this.Controls.Add(this.groupBoxDataOutPut_CEM);
            this.Controls.Add(this.textBoxCondition_CEM);
            this.Controls.Add(this.groupBoxCondition_CEM);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 6 | Чалкова Е.М.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_CEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_CEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_CEM;
        private System.Windows.Forms.TextBox textBoxCondition_CEM;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_CEM;
        private System.Windows.Forms.Button buttonDone_CEM;
        private System.Windows.Forms.Button buttonOpen_CEM;
        private System.Windows.Forms.Button buttonInfo_CEM;
        private System.Windows.Forms.DataGridView dataGridViewNums_CEM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_CEM;
    }
}

