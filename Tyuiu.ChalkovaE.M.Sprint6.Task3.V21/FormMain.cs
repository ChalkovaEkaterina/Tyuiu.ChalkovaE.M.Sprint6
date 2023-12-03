using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ChalkovaE.M.Sprint6.Task3.V21.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint6.Task3.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[,] { { 26, -15, 7, 1, 4 }, { 14, 26, 22, 17, 27 },
                { -8, 31, 22, 34, 4 }, { -18, 16, -2, 16, 27 }, { 5, 2, -4, 16, 15 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMtrx1_CEM.ColumnCount = columns;
            dataGridViewMtrx1_CEM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMtrx1_CEM.Columns[i].Width = 25;
            }
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMtrx1_CEM.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }


        }

        private void buttonResult_CEM_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;
            dataGridViewMatrix_CEM.RowCount = rows;
            dataGridViewMatrix_CEM.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_CEM.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_CEM.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }

            }
        }

        private void buttonInfo_CEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-23-2 Чалкова Е.М.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
