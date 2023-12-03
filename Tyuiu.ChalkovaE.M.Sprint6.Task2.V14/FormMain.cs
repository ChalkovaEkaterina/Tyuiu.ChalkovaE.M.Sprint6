using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ChalkovaE.M.Sprint6.Task2.V14.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonResult_CEM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxDataStartV_CEM.Text);
                int stopValue = Convert.ToInt32(textBoxDataStopV_CEM.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_CEM.Titles.Add("График функции 5-3x + (1+sin(x))/(2x-0.5)");

                this.chartFunction_CEM.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_CEM.ChartAreas[0].AxisX.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_CEM.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction_CEM.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_CEM_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_CEM.BackColor = Color.Red;
        }

        private void buttonResult_CEM_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_CEM.BackColor = Color.Green;
        }

        private void buttonResult_CEM_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_CEM.BackColor = Color.Blue;
        }

        private void buttonHelp_CEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-23-2 Чалкова Екатерина Максимовна", "Сообщение");
        }
    }
}
