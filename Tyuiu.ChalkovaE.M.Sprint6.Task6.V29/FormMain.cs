using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.ChalkovaE.M.Sprint6.Task6.V29.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string path;
        DataService ds = new DataService();
        private void buttonDone_CEM_Click(object sender, EventArgs e)
        {
            textBoxDataOut_CEM.Text = ds.CollectTextFromFile(path);
        }

        private void buttonOpen_CEM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CEM.ShowDialog();
            path = openFileDialogTask_CEM.FileName;
            textBoxDataIn_CEM.Text = File.ReadAllText(path);
            groupBoxDataIn_CEM.Text = groupBoxDataIn_CEM.Text + " " + openFileDialogTask_CEM.FileName;
            buttonDone_CEM.Enabled = true;
        }

        private void buttonInfo_CEM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
