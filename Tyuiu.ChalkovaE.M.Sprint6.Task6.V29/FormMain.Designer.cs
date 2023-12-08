
namespace Tyuiu.ChalkovaE.M.Sprint6.Task6.V29
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
            this.groupBoxCondition_CEM = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_CEM = new System.Windows.Forms.TextBox();
            this.groupBoxDataIn_CEM = new System.Windows.Forms.GroupBox();
            this.groupBoxDataOut_CEM = new System.Windows.Forms.GroupBox();
            this.textBoxDataIn_CEM = new System.Windows.Forms.TextBox();
            this.textBoxDataOut_CEM = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_CEM = new System.Windows.Forms.OpenFileDialog();
            this.toolTipInfo_CEM = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfo_CEM = new System.Windows.Forms.Button();
            this.buttonDone_CEM = new System.Windows.Forms.Button();
            this.buttonOpen_CEM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxCondition_CEM
            // 
            this.groupBoxCondition_CEM.Location = new System.Drawing.Point(12, 169);
            this.groupBoxCondition_CEM.Name = "groupBoxCondition_CEM";
            this.groupBoxCondition_CEM.Size = new System.Drawing.Size(321, 43);
            this.groupBoxCondition_CEM.TabIndex = 0;
            this.groupBoxCondition_CEM.TabStop = false;
            this.groupBoxCondition_CEM.Text = "Условие:";
            // 
            // textBoxCondition_CEM
            // 
            this.textBoxCondition_CEM.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxCondition_CEM.Location = new System.Drawing.Point(12, 218);
            this.textBoxCondition_CEM.Multiline = true;
            this.textBoxCondition_CEM.Name = "textBoxCondition_CEM";
            this.textBoxCondition_CEM.Size = new System.Drawing.Size(872, 94);
            this.textBoxCondition_CEM.TabIndex = 0;
            this.textBoxCondition_CEM.Text = resources.GetString("textBoxCondition_CEM.Text");
            // 
            // groupBoxDataIn_CEM
            // 
            this.groupBoxDataIn_CEM.Location = new System.Drawing.Point(12, 318);
            this.groupBoxDataIn_CEM.Name = "groupBoxDataIn_CEM";
            this.groupBoxDataIn_CEM.Size = new System.Drawing.Size(598, 78);
            this.groupBoxDataIn_CEM.TabIndex = 0;
            this.groupBoxDataIn_CEM.TabStop = false;
            this.groupBoxDataIn_CEM.Text = "Ввод:";
            // 
            // groupBoxDataOut_CEM
            // 
            this.groupBoxDataOut_CEM.Location = new System.Drawing.Point(698, 318);
            this.groupBoxDataOut_CEM.Name = "groupBoxDataOut_CEM";
            this.groupBoxDataOut_CEM.Size = new System.Drawing.Size(550, 78);
            this.groupBoxDataOut_CEM.TabIndex = 0;
            this.groupBoxDataOut_CEM.TabStop = false;
            this.groupBoxDataOut_CEM.Text = "Вывод:";
            // 
            // textBoxDataIn_CEM
            // 
            this.textBoxDataIn_CEM.Location = new System.Drawing.Point(12, 416);
            this.textBoxDataIn_CEM.Multiline = true;
            this.textBoxDataIn_CEM.Name = "textBoxDataIn_CEM";
            this.textBoxDataIn_CEM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDataIn_CEM.Size = new System.Drawing.Size(586, 477);
            this.textBoxDataIn_CEM.TabIndex = 0;
            // 
            // textBoxDataOut_CEM
            // 
            this.textBoxDataOut_CEM.Location = new System.Drawing.Point(698, 416);
            this.textBoxDataOut_CEM.Multiline = true;
            this.textBoxDataOut_CEM.Name = "textBoxDataOut_CEM";
            this.textBoxDataOut_CEM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDataOut_CEM.Size = new System.Drawing.Size(584, 477);
            this.textBoxDataOut_CEM.TabIndex = 1;
            // 
            // openFileDialogTask_CEM
            // 
            this.openFileDialogTask_CEM.FileName = "openFileDialog1";
            // 
            // toolTipInfo_CEM
            // 
            this.toolTipInfo_CEM.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo_CEM.ToolTipTitle = "Подсказка";
            // 
            // buttonInfo_CEM
            // 
            this.buttonInfo_CEM.Image = global::Tyuiu.ChalkovaE.M.Sprint6.Task6.V29.Properties.Resources.cog;
            this.buttonInfo_CEM.Location = new System.Drawing.Point(1158, 29);
            this.buttonInfo_CEM.Name = "buttonInfo_CEM";
            this.buttonInfo_CEM.Size = new System.Drawing.Size(124, 97);
            this.buttonInfo_CEM.TabIndex = 4;
            this.toolTipInfo_CEM.SetToolTip(this.buttonInfo_CEM, "Сведения о программе.\r\n");
            this.buttonInfo_CEM.UseVisualStyleBackColor = true;
            this.buttonInfo_CEM.Click += new System.EventHandler(this.buttonInfo_CEM_Click);
            // 
            // buttonDone_CEM
            // 
            this.buttonDone_CEM.Enabled = false;
            this.buttonDone_CEM.Image = global::Tyuiu.ChalkovaE.M.Sprint6.Task6.V29.Properties.Resources.page_white_go;
            this.buttonDone_CEM.Location = new System.Drawing.Point(155, 29);
            this.buttonDone_CEM.Name = "buttonDone_CEM";
            this.buttonDone_CEM.Size = new System.Drawing.Size(124, 97);
            this.buttonDone_CEM.TabIndex = 3;
            this.toolTipInfo_CEM.SetToolTip(this.buttonDone_CEM, "Производит поиск символов \"i\" в файле и выводит все слова с имеющимся символом.\r\n" +
        "");
            this.buttonDone_CEM.UseVisualStyleBackColor = true;
            this.buttonDone_CEM.Click += new System.EventHandler(this.buttonDone_CEM_Click);
            // 
            // buttonOpen_CEM
            // 
            this.buttonOpen_CEM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpen_CEM.Image = global::Tyuiu.ChalkovaE.M.Sprint6.Task6.V29.Properties.Resources.folder_go;
            this.buttonOpen_CEM.Location = new System.Drawing.Point(12, 29);
            this.buttonOpen_CEM.Name = "buttonOpen_CEM";
            this.buttonOpen_CEM.Size = new System.Drawing.Size(124, 97);
            this.buttonOpen_CEM.TabIndex = 2;
            this.toolTipInfo_CEM.SetToolTip(this.buttonOpen_CEM, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpen_CEM.UseVisualStyleBackColor = true;
            this.buttonOpen_CEM.Click += new System.EventHandler(this.buttonOpen_CEM_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.buttonInfo_CEM);
            this.Controls.Add(this.buttonDone_CEM);
            this.Controls.Add(this.buttonOpen_CEM);
            this.Controls.Add(this.textBoxDataOut_CEM);
            this.Controls.Add(this.textBoxDataIn_CEM);
            this.Controls.Add(this.groupBoxDataOut_CEM);
            this.Controls.Add(this.groupBoxDataIn_CEM);
            this.Controls.Add(this.textBoxCondition_CEM);
            this.Controls.Add(this.groupBoxCondition_CEM);
            this.MaximumSize = new System.Drawing.Size(16000, 10000);
            this.MinimumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 29 | Чалкова Е.М";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_CEM;
        private System.Windows.Forms.TextBox textBoxCondition_CEM;
        private System.Windows.Forms.GroupBox groupBoxDataIn_CEM;
        private System.Windows.Forms.GroupBox groupBoxDataOut_CEM;
        private System.Windows.Forms.TextBox textBoxDataIn_CEM;
        private System.Windows.Forms.TextBox textBoxDataOut_CEM;
        private System.Windows.Forms.Button buttonOpen_CEM;
        private System.Windows.Forms.Button buttonDone_CEM;
        private System.Windows.Forms.Button buttonInfo_CEM;
        private System.Windows.Forms.ToolTip toolTipInfo_CEM;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_CEM;
    }
}

