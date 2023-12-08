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

using Tyuiu.ChalkovaE.M.Sprint6.Task7.V19.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint6.Task7.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_CEM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_CEM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string path = $@"C:\Users\ekaterinachalkova\source\repos\Tyuiu.ChalkovaE.M.Sprint6\InPutFileTask7V19.csv";
            string file = File.ReadAllText(openFilePath);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpen_CEM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CEM.ShowDialog();
            openFilePath = openFileDialogTask_CEM.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_CEM.ColumnCount = columns;
            dataGridViewIn_CEM.RowCount = rows;
            dataGridViewOut_CEM.ColumnCount = columns;
            dataGridViewOut_CEM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_CEM.Columns[i].Width = 25;
                dataGridViewOut_CEM.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_CEM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_CEM.Enabled = true;
        }

        private void buttonDone_CEM_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_CEM.Rows[r].Cells[c].Value = arrayValues[r, c];

                }
            }
            buttonSave_CEM.Enabled = true;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_CEM.ColumnCount = 50;
            dataGridViewOut_CEM.ColumnCount = 50;

            dataGridViewIn_CEM.RowCount = 50;
            dataGridViewOut_CEM.RowCount = 50;
            panelInPut_CEM.Width = this.Width / 2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_CEM.Columns[i].Width = 25;
                dataGridViewOut_CEM.Columns[i].Width = 25;
            }
        }

        private void buttonSave_CEM_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_CEM.FileName = "OutPutFileTask7V19.csv";
            saveFileDialogMatrix_CEM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_CEM.ShowDialog();

            string path = saveFileDialogMatrix_CEM.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_CEM.RowCount;
            int columns = dataGridViewOut_CEM.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_CEM.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_CEM.Rows[i].Cells[j].Value;
                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpen_CEM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_CEM.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_CEM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_CEM.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_CEM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_CEM.ToolTipTitle = "Сохранить файл";
        }

        private void buttonInfo_CEM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_CEM.ToolTipTitle = "Справка";
        }

        private void buttonInfo_CEM_Click_1(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
