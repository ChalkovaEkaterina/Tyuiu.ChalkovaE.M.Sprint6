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

using Tyuiu.ChalkovaE.M.Sprint6.Task4.V28.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint6.Task4.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_CEM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartV_CEM.Text);
                int stopValue = Convert.ToInt32(textBoxStopV_CEM.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_CEM.Titles.Add("График функции cos(2x) + sin(x)/(x + 2,5) + 2x ");

                this.chartFunction_CEM.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_CEM.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxDataOutPut_CEM.Text = "";

                chartFunction_CEM.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_CEM.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxDataOutPut_CEM.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_CEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИИПб-23-2 Чалкова Екатерина Максимовна", "Сообщение");
        }

        private void buttonSafe_CEM_Click(object sender, EventArgs e)
        {
            
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxDataOutPut_CEM.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxDataInPut_CEM_Enter(object sender, EventArgs e)
        {

        }
    }
}
