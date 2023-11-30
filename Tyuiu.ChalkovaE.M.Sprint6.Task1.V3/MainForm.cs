using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ChalkovaE.M.Sprint6.Task1.V3.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint6.Task1.V3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonGetResult_CEM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartV_CEM.Text);
                int stopValue = Convert.ToInt32(textBoxStopV_CEM.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_CEM.Text = "";
                textBoxResult_CEM.AppendText("+------------+----------------+" + Environment.NewLine);
                textBoxResult_CEM.AppendText("|     X      |      F(x)      |" + Environment.NewLine);
                textBoxResult_CEM.AppendText("+------------+----------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}       |      {1, 6:f2}     | ", startValue, valueArray[i]);
                    textBoxResult_CEM.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_CEM.AppendText("+------------+----------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonInfo_CEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-23-2 Чалкова Екатерина Максимовна", "Сообщение");
        }
    }
}
