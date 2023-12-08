
namespace Tyuiu.ChalkovaE.M.Sprint6.Task7.V19
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_CEM = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_CEM = new System.Windows.Forms.PictureBox();
            this.buttonOK_CEM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_CEM)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_CEM
            // 
            this.labelInfo_CEM.AutoSize = true;
            this.labelInfo_CEM.Location = new System.Drawing.Point(295, 12);
            this.labelInfo_CEM.Name = "labelInfo_CEM";
            this.labelInfo_CEM.Size = new System.Drawing.Size(551, 250);
            this.labelInfo_CEM.TabIndex = 2;
            this.labelInfo_CEM.Text = resources.GetString("labelInfo_CEM.Text");
            // 
            // pictureBoxAvatar_CEM
            // 
            this.pictureBoxAvatar_CEM.Image = global::Tyuiu.ChalkovaE.M.Sprint6.Task7.V19.Properties.Resources.ava;
            this.pictureBoxAvatar_CEM.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_CEM.Name = "pictureBoxAvatar_CEM";
            this.pictureBoxAvatar_CEM.Size = new System.Drawing.Size(257, 333);
            this.pictureBoxAvatar_CEM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_CEM.TabIndex = 1;
            this.pictureBoxAvatar_CEM.TabStop = false;
            // 
            // buttonOK_CEM
            // 
            this.buttonOK_CEM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOK_CEM.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOK_CEM.Location = new System.Drawing.Point(712, 305);
            this.buttonOK_CEM.Name = "buttonOK_CEM";
            this.buttonOK_CEM.Size = new System.Drawing.Size(123, 40);
            this.buttonOK_CEM.TabIndex = 3;
            this.buttonOK_CEM.Text = "OK";
            this.buttonOK_CEM.UseVisualStyleBackColor = false;
            this.buttonOK_CEM.Click += new System.EventHandler(this.buttonOK_CEM_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 379);
            this.Controls.Add(this.buttonOK_CEM);
            this.Controls.Add(this.labelInfo_CEM);
            this.Controls.Add(this.pictureBoxAvatar_CEM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сведения о программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_CEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_CEM;
        private System.Windows.Forms.Label labelInfo_CEM;
        private System.Windows.Forms.Button buttonOK_CEM;
    }
}