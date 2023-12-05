
namespace Tyuiu.ChalkovaE.M.Sprint6.Task4.V28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_CEM = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_CEM = new System.Windows.Forms.TextBox();
            this.groupBoxDataInPut_CEM = new System.Windows.Forms.GroupBox();
            this.textBoxStartV_CEM = new System.Windows.Forms.TextBox();
            this.textBoxStopV_CEM = new System.Windows.Forms.TextBox();
            this.groupBoxStartV_CEM = new System.Windows.Forms.GroupBox();
            this.groupBoxStopV_CEM = new System.Windows.Forms.GroupBox();
            this.groupBoxDataOutPut_CEM = new System.Windows.Forms.GroupBox();
            this.textBoxDataOutPut_CEM = new System.Windows.Forms.TextBox();
            this.buttonDone_CEM = new System.Windows.Forms.Button();
            this.buttonSafe_CEM = new System.Windows.Forms.Button();
            this.buttonInfo_CEM = new System.Windows.Forms.Button();
            this.chartFunction_CEM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CEM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_CEM
            // 
            this.groupBoxCondition_CEM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_CEM.Name = "groupBoxCondition_CEM";
            this.groupBoxCondition_CEM.Size = new System.Drawing.Size(241, 34);
            this.groupBoxCondition_CEM.TabIndex = 0;
            this.groupBoxCondition_CEM.TabStop = false;
            this.groupBoxCondition_CEM.Text = "Условие:";
            // 
            // textBoxCondition_CEM
            // 
            this.textBoxCondition_CEM.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxCondition_CEM.Location = new System.Drawing.Point(6, 30);
            this.textBoxCondition_CEM.Multiline = true;
            this.textBoxCondition_CEM.Name = "textBoxCondition_CEM";
            this.textBoxCondition_CEM.Size = new System.Drawing.Size(743, 168);
            this.textBoxCondition_CEM.TabIndex = 1;
            this.textBoxCondition_CEM.Text = resources.GetString("textBoxCondition_CEM.Text");
            // 
            // groupBoxDataInPut_CEM
            // 
            this.groupBoxDataInPut_CEM.Location = new System.Drawing.Point(865, 30);
            this.groupBoxDataInPut_CEM.Name = "groupBoxDataInPut_CEM";
            this.groupBoxDataInPut_CEM.Size = new System.Drawing.Size(227, 37);
            this.groupBoxDataInPut_CEM.TabIndex = 2;
            this.groupBoxDataInPut_CEM.TabStop = false;
            this.groupBoxDataInPut_CEM.Text = "Ввод данных:";
            this.groupBoxDataInPut_CEM.Enter += new System.EventHandler(this.groupBoxDataInPut_CEM_Enter);
            // 
            // textBoxStartV_CEM
            // 
            this.textBoxStartV_CEM.Location = new System.Drawing.Point(865, 103);
            this.textBoxStartV_CEM.Name = "textBoxStartV_CEM";
            this.textBoxStartV_CEM.Size = new System.Drawing.Size(100, 31);
            this.textBoxStartV_CEM.TabIndex = 0;
            // 
            // textBoxStopV_CEM
            // 
            this.textBoxStopV_CEM.Location = new System.Drawing.Point(1120, 103);
            this.textBoxStopV_CEM.Name = "textBoxStopV_CEM";
            this.textBoxStopV_CEM.Size = new System.Drawing.Size(100, 31);
            this.textBoxStopV_CEM.TabIndex = 1;
            // 
            // groupBoxStartV_CEM
            // 
            this.groupBoxStartV_CEM.Location = new System.Drawing.Point(865, 72);
            this.groupBoxStartV_CEM.Name = "groupBoxStartV_CEM";
            this.groupBoxStartV_CEM.Size = new System.Drawing.Size(164, 25);
            this.groupBoxStartV_CEM.TabIndex = 3;
            this.groupBoxStartV_CEM.TabStop = false;
            this.groupBoxStartV_CEM.Text = "Старт шага:";
            // 
            // groupBoxStopV_CEM
            // 
            this.groupBoxStopV_CEM.Location = new System.Drawing.Point(1120, 72);
            this.groupBoxStopV_CEM.Name = "groupBoxStopV_CEM";
            this.groupBoxStopV_CEM.Size = new System.Drawing.Size(159, 25);
            this.groupBoxStopV_CEM.TabIndex = 0;
            this.groupBoxStopV_CEM.TabStop = false;
            this.groupBoxStopV_CEM.Text = "Конец шага:";
            // 
            // groupBoxDataOutPut_CEM
            // 
            this.groupBoxDataOutPut_CEM.Location = new System.Drawing.Point(6, 213);
            this.groupBoxDataOutPut_CEM.Name = "groupBoxDataOutPut_CEM";
            this.groupBoxDataOutPut_CEM.Size = new System.Drawing.Size(458, 50);
            this.groupBoxDataOutPut_CEM.TabIndex = 0;
            this.groupBoxDataOutPut_CEM.TabStop = false;
            this.groupBoxDataOutPut_CEM.Text = "Вывод данных:";
            // 
            // textBoxDataOutPut_CEM
            // 
            this.textBoxDataOutPut_CEM.Location = new System.Drawing.Point(6, 282);
            this.textBoxDataOutPut_CEM.Multiline = true;
            this.textBoxDataOutPut_CEM.Name = "textBoxDataOutPut_CEM";
            this.textBoxDataOutPut_CEM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDataOutPut_CEM.Size = new System.Drawing.Size(458, 681);
            this.textBoxDataOutPut_CEM.TabIndex = 0;
            // 
            // buttonDone_CEM
            // 
            this.buttonDone_CEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_CEM.Location = new System.Drawing.Point(1299, 30);
            this.buttonDone_CEM.Name = "buttonDone_CEM";
            this.buttonDone_CEM.Size = new System.Drawing.Size(142, 76);
            this.buttonDone_CEM.TabIndex = 4;
            this.buttonDone_CEM.Text = "Выполнить";
            this.buttonDone_CEM.UseVisualStyleBackColor = false;
            this.buttonDone_CEM.Click += new System.EventHandler(this.buttonDone_CEM_Click);
            // 
            // buttonSafe_CEM
            // 
            this.buttonSafe_CEM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSafe_CEM.Location = new System.Drawing.Point(1447, 29);
            this.buttonSafe_CEM.Name = "buttonSafe_CEM";
            this.buttonSafe_CEM.Size = new System.Drawing.Size(142, 77);
            this.buttonSafe_CEM.TabIndex = 5;
            this.buttonSafe_CEM.Text = "Сохранить";
            this.buttonSafe_CEM.UseVisualStyleBackColor = false;
            this.buttonSafe_CEM.Click += new System.EventHandler(this.buttonSafe_CEM_Click);
            // 
            // buttonInfo_CEM
            // 
            this.buttonInfo_CEM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_CEM.Location = new System.Drawing.Point(1683, 30);
            this.buttonInfo_CEM.Name = "buttonInfo_CEM";
            this.buttonInfo_CEM.Size = new System.Drawing.Size(142, 79);
            this.buttonInfo_CEM.TabIndex = 6;
            this.buttonInfo_CEM.Text = "Справка";
            this.buttonInfo_CEM.UseVisualStyleBackColor = false;
            this.buttonInfo_CEM.Click += new System.EventHandler(this.buttonInfo_CEM_Click);
            // 
            // chartFunction_CEM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_CEM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_CEM.Legends.Add(legend1);
            this.chartFunction_CEM.Location = new System.Drawing.Point(865, 204);
            this.chartFunction_CEM.Name = "chartFunction_CEM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_CEM.Series.Add(series1);
            this.chartFunction_CEM.Size = new System.Drawing.Size(923, 750);
            this.chartFunction_CEM.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 975);
            this.Controls.Add(this.chartFunction_CEM);
            this.Controls.Add(this.buttonInfo_CEM);
            this.Controls.Add(this.buttonSafe_CEM);
            this.Controls.Add(this.buttonDone_CEM);
            this.Controls.Add(this.textBoxDataOutPut_CEM);
            this.Controls.Add(this.groupBoxDataOutPut_CEM);
            this.Controls.Add(this.groupBoxStopV_CEM);
            this.Controls.Add(this.groupBoxStartV_CEM);
            this.Controls.Add(this.textBoxStartV_CEM);
            this.Controls.Add(this.textBoxStopV_CEM);
            this.Controls.Add(this.groupBoxDataInPut_CEM);
            this.Controls.Add(this.textBoxCondition_CEM);
            this.Controls.Add(this.groupBoxCondition_CEM);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 28 | Чалкова Е.М.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_CEM;
        private System.Windows.Forms.TextBox textBoxCondition_CEM;
        private System.Windows.Forms.GroupBox groupBoxDataInPut_CEM;
        private System.Windows.Forms.TextBox textBoxStartV_CEM;
        private System.Windows.Forms.TextBox textBoxStopV_CEM;
        private System.Windows.Forms.GroupBox groupBoxStartV_CEM;
        private System.Windows.Forms.GroupBox groupBoxStopV_CEM;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_CEM;
        private System.Windows.Forms.TextBox textBoxDataOutPut_CEM;
        private System.Windows.Forms.Button buttonDone_CEM;
        private System.Windows.Forms.Button buttonSafe_CEM;
        private System.Windows.Forms.Button buttonInfo_CEM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CEM;
    }
}

