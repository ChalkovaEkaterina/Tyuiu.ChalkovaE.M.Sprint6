
namespace Tyuiu.ChalkovaE.M.Sprint6.Task7.V19
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_CEM = new System.Windows.Forms.Panel();
            this.panelCond_CEM = new System.Windows.Forms.Panel();
            this.textBoxCondition_CEM = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_CEM = new System.Windows.Forms.GroupBox();
            this.panelInPut_CEM = new System.Windows.Forms.Panel();
            this.dataGridViewIn_CEM = new System.Windows.Forms.DataGridView();
            this.groupBoxDataInPut_CEM = new System.Windows.Forms.GroupBox();
            this.panelOutPut_CEM = new System.Windows.Forms.Panel();
            this.dataGridViewOut_CEM = new System.Windows.Forms.DataGridView();
            this.groupBoxDataOutPut_CEM = new System.Windows.Forms.GroupBox();
            this.openFileDialogTask_CEM = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_CEM = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButtons_CEM = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfo_CEM = new System.Windows.Forms.Button();
            this.buttonSave_CEM = new System.Windows.Forms.Button();
            this.buttonDone_CEM = new System.Windows.Forms.Button();
            this.buttonOpen_CEM = new System.Windows.Forms.Button();
            this.panelTop_CEM.SuspendLayout();
            this.panelCond_CEM.SuspendLayout();
            this.panelInPut_CEM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_CEM)).BeginInit();
            this.panelOutPut_CEM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_CEM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_CEM
            // 
            this.panelTop_CEM.Controls.Add(this.buttonInfo_CEM);
            this.panelTop_CEM.Controls.Add(this.buttonSave_CEM);
            this.panelTop_CEM.Controls.Add(this.buttonDone_CEM);
            this.panelTop_CEM.Controls.Add(this.buttonOpen_CEM);
            this.panelTop_CEM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CEM.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CEM.Name = "panelTop_CEM";
            this.panelTop_CEM.Size = new System.Drawing.Size(1163, 132);
            this.panelTop_CEM.TabIndex = 0;
            this.toolTipButtons_CEM.SetToolTip(this.panelTop_CEM, "Открыть файл для обработки данных в формате CSV\r\n");
            // 
            // panelCond_CEM
            // 
            this.panelCond_CEM.Controls.Add(this.textBoxCondition_CEM);
            this.panelCond_CEM.Controls.Add(this.groupBoxCondition_CEM);
            this.panelCond_CEM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCond_CEM.Location = new System.Drawing.Point(0, 132);
            this.panelCond_CEM.Name = "panelCond_CEM";
            this.panelCond_CEM.Size = new System.Drawing.Size(1163, 150);
            this.panelCond_CEM.TabIndex = 1;
            // 
            // textBoxCondition_CEM
            // 
            this.textBoxCondition_CEM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCondition_CEM.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxCondition_CEM.Location = new System.Drawing.Point(0, 36);
            this.textBoxCondition_CEM.Multiline = true;
            this.textBoxCondition_CEM.Name = "textBoxCondition_CEM";
            this.textBoxCondition_CEM.Size = new System.Drawing.Size(1147, 78);
            this.textBoxCondition_CEM.TabIndex = 0;
            this.textBoxCondition_CEM.Text = resources.GetString("textBoxCondition_CEM.Text");
            // 
            // groupBoxCondition_CEM
            // 
            this.groupBoxCondition_CEM.Location = new System.Drawing.Point(10, 3);
            this.groupBoxCondition_CEM.Name = "groupBoxCondition_CEM";
            this.groupBoxCondition_CEM.Size = new System.Drawing.Size(222, 27);
            this.groupBoxCondition_CEM.TabIndex = 4;
            this.groupBoxCondition_CEM.TabStop = false;
            this.groupBoxCondition_CEM.Text = "Условие:";
            // 
            // panelInPut_CEM
            // 
            this.panelInPut_CEM.Controls.Add(this.dataGridViewIn_CEM);
            this.panelInPut_CEM.Controls.Add(this.groupBoxDataInPut_CEM);
            this.panelInPut_CEM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_CEM.Location = new System.Drawing.Point(0, 282);
            this.panelInPut_CEM.Name = "panelInPut_CEM";
            this.panelInPut_CEM.Size = new System.Drawing.Size(548, 415);
            this.panelInPut_CEM.TabIndex = 2;
            // 
            // dataGridViewIn_CEM
            // 
            this.dataGridViewIn_CEM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewIn_CEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_CEM.ColumnHeadersVisible = false;
            this.dataGridViewIn_CEM.Location = new System.Drawing.Point(3, 59);
            this.dataGridViewIn_CEM.Name = "dataGridViewIn_CEM";
            this.dataGridViewIn_CEM.RowHeadersVisible = false;
            this.dataGridViewIn_CEM.RowHeadersWidth = 82;
            this.dataGridViewIn_CEM.RowTemplate.Height = 33;
            this.dataGridViewIn_CEM.Size = new System.Drawing.Size(542, 353);
            this.dataGridViewIn_CEM.TabIndex = 0;
            // 
            // groupBoxDataInPut_CEM
            // 
            this.groupBoxDataInPut_CEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataInPut_CEM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataInPut_CEM.Name = "groupBoxDataInPut_CEM";
            this.groupBoxDataInPut_CEM.Size = new System.Drawing.Size(548, 415);
            this.groupBoxDataInPut_CEM.TabIndex = 3;
            this.groupBoxDataInPut_CEM.TabStop = false;
            this.groupBoxDataInPut_CEM.Text = "Ввод:";
            // 
            // panelOutPut_CEM
            // 
            this.panelOutPut_CEM.Controls.Add(this.dataGridViewOut_CEM);
            this.panelOutPut_CEM.Controls.Add(this.groupBoxDataOutPut_CEM);
            this.panelOutPut_CEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_CEM.Location = new System.Drawing.Point(548, 282);
            this.panelOutPut_CEM.Name = "panelOutPut_CEM";
            this.panelOutPut_CEM.Size = new System.Drawing.Size(615, 415);
            this.panelOutPut_CEM.TabIndex = 0;
            // 
            // dataGridViewOut_CEM
            // 
            this.dataGridViewOut_CEM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOut_CEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_CEM.ColumnHeadersVisible = false;
            this.dataGridViewOut_CEM.Location = new System.Drawing.Point(23, 59);
            this.dataGridViewOut_CEM.Name = "dataGridViewOut_CEM";
            this.dataGridViewOut_CEM.RowHeadersVisible = false;
            this.dataGridViewOut_CEM.RowHeadersWidth = 82;
            this.dataGridViewOut_CEM.RowTemplate.Height = 33;
            this.dataGridViewOut_CEM.Size = new System.Drawing.Size(592, 356);
            this.dataGridViewOut_CEM.TabIndex = 4;
            // 
            // groupBoxDataOutPut_CEM
            // 
            this.groupBoxDataOutPut_CEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataOutPut_CEM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataOutPut_CEM.Name = "groupBoxDataOutPut_CEM";
            this.groupBoxDataOutPut_CEM.Size = new System.Drawing.Size(615, 415);
            this.groupBoxDataOutPut_CEM.TabIndex = 0;
            this.groupBoxDataOutPut_CEM.TabStop = false;
            this.groupBoxDataOutPut_CEM.Text = "Вывод:";
            // 
            // openFileDialogTask_CEM
            // 
            this.openFileDialogTask_CEM.FileName = "openFileDialog1";
            // 
            // toolTipButtons_CEM
            // 
            this.toolTipButtons_CEM.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // buttonInfo_CEM
            // 
            this.buttonInfo_CEM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_CEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_CEM.Image = global::Tyuiu.ChalkovaE.M.Sprint6.Task7.V19.Properties.Resources.information;
            this.buttonInfo_CEM.Location = new System.Drawing.Point(993, 9);
            this.buttonInfo_CEM.Name = "buttonInfo_CEM";
            this.buttonInfo_CEM.Size = new System.Drawing.Size(167, 117);
            this.buttonInfo_CEM.TabIndex = 3;
            this.toolTipButtons_CEM.SetToolTip(this.buttonInfo_CEM, "Cведения о программе");
            this.buttonInfo_CEM.UseVisualStyleBackColor = true;
            this.buttonInfo_CEM.Click += new System.EventHandler(this.buttonInfo_CEM_Click_1);
            this.buttonInfo_CEM.MouseEnter += new System.EventHandler(this.buttonInfo_CEM_MouseEnter);
            // 
            // buttonSave_CEM
            // 
            this.buttonSave_CEM.Enabled = false;
            this.buttonSave_CEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_CEM.Image = global::Tyuiu.ChalkovaE.M.Sprint6.Task7.V19.Properties.Resources.page_white_put;
            this.buttonSave_CEM.Location = new System.Drawing.Point(356, 9);
            this.buttonSave_CEM.Name = "buttonSave_CEM";
            this.buttonSave_CEM.Size = new System.Drawing.Size(167, 120);
            this.buttonSave_CEM.TabIndex = 2;
            this.toolTipButtons_CEM.SetToolTip(this.buttonSave_CEM, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_CEM.UseVisualStyleBackColor = true;
            this.buttonSave_CEM.Click += new System.EventHandler(this.buttonSave_CEM_Click);
            this.buttonSave_CEM.MouseEnter += new System.EventHandler(this.buttonSave_CEM_MouseEnter);
            // 
            // buttonDone_CEM
            // 
            this.buttonDone_CEM.Enabled = false;
            this.buttonDone_CEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_CEM.Image = global::Tyuiu.ChalkovaE.M.Sprint6.Task7.V19.Properties.Resources.page_go;
            this.buttonDone_CEM.Location = new System.Drawing.Point(183, 9);
            this.buttonDone_CEM.Name = "buttonDone_CEM";
            this.buttonDone_CEM.Size = new System.Drawing.Size(167, 120);
            this.buttonDone_CEM.TabIndex = 1;
            this.toolTipButtons_CEM.SetToolTip(this.buttonDone_CEM, "Выполнить обработку данных");
            this.buttonDone_CEM.UseVisualStyleBackColor = true;
            this.buttonDone_CEM.Click += new System.EventHandler(this.buttonDone_CEM_Click);
            this.buttonDone_CEM.MouseEnter += new System.EventHandler(this.buttonDone_CEM_MouseEnter);
            // 
            // buttonOpen_CEM
            // 
            this.buttonOpen_CEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_CEM.Image = global::Tyuiu.ChalkovaE.M.Sprint6.Task7.V19.Properties.Resources.folder_page;
            this.buttonOpen_CEM.Location = new System.Drawing.Point(10, 9);
            this.buttonOpen_CEM.Name = "buttonOpen_CEM";
            this.buttonOpen_CEM.Size = new System.Drawing.Size(167, 120);
            this.buttonOpen_CEM.TabIndex = 0;
            this.toolTipButtons_CEM.SetToolTip(this.buttonOpen_CEM, "Открыть файл для обрабоки данных в формате CSV\r\n");
            this.buttonOpen_CEM.UseVisualStyleBackColor = true;
            this.buttonOpen_CEM.Click += new System.EventHandler(this.buttonOpen_CEM_Click);
            this.buttonOpen_CEM.MouseEnter += new System.EventHandler(this.buttonOpen_CEM_MouseEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 697);
            this.Controls.Add(this.panelOutPut_CEM);
            this.Controls.Add(this.panelInPut_CEM);
            this.Controls.Add(this.panelCond_CEM);
            this.Controls.Add(this.panelTop_CEM);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 19 | Чалкова Е.М.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_CEM.ResumeLayout(false);
            this.panelCond_CEM.ResumeLayout(false);
            this.panelCond_CEM.PerformLayout();
            this.panelInPut_CEM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_CEM)).EndInit();
            this.panelOutPut_CEM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_CEM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CEM;
        private System.Windows.Forms.Button buttonDone_CEM;
        private System.Windows.Forms.Button buttonOpen_CEM;
        private System.Windows.Forms.Panel panelCond_CEM;
        private System.Windows.Forms.Panel panelInPut_CEM;
        private System.Windows.Forms.Panel panelOutPut_CEM;
        private System.Windows.Forms.Button buttonSave_CEM;
        private System.Windows.Forms.Button buttonInfo_CEM;
        private System.Windows.Forms.TextBox textBoxCondition_CEM;
        private System.Windows.Forms.GroupBox groupBoxCondition_CEM;
        private System.Windows.Forms.GroupBox groupBoxDataInPut_CEM;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_CEM;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_CEM;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_CEM;
        private System.Windows.Forms.ToolTip toolTipButtons_CEM;
        private System.Windows.Forms.DataGridView dataGridViewIn_CEM;
        private System.Windows.Forms.DataGridView dataGridViewOut_CEM;
    }
}

