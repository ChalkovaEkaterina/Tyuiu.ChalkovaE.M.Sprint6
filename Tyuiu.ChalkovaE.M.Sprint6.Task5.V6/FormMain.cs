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

using Tyuiu.ChalkovaE.M.Sprint6.Task5.V6.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\ekaterinachalkova\source\repos\Tyuiu.ChalkovaE.M.Sprint6\Tyuiu.ChalkovaE.M.Sprint6.Task5.V6\bin\Debug\InPutFileTask5V6.txt";

        private void buttonDone_CEM_Click(object sender, EventArgs e)
        {
            dataGridViewNums_CEM.ColumnCount = 2;
            dataGridViewNums_CEM.Columns[0].Width = 20;
            dataGridViewNums_CEM.Columns[1].Width = 50;

            this.chartDiag_CEM.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartDiag_CEM.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_CEM.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_CEM.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_CEM.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_CEM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();

        }

        private void buttonInfo_CEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-23-2 Чалкова Екатерина Максимовна", "Сообщение");
        }
    }

}
