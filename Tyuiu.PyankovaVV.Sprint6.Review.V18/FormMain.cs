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
using Tyuiu.PyankovaVV.Sprint6.Review.V18.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Review.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        public int[,] valueArray;
        public int countRow;
        public int countColumns;
        public int startX;
        public int endX;
        public int massiveStart;
        public int massiveEnd;
        public int selectedR;

        private void buttonGetMatrix_PVV_Click(object sender, EventArgs e)
        {
            try
            {
                countRow = Convert.ToInt32(textBoxRows_PVV.Text);
                countColumns = Convert.ToInt32(textBoxColumns_PVV.Text);
                startX = Convert.ToInt32(textBoxStartDiap_PVV.Text);

                if (startX < 0)
                    throw new ArgumentException("Начало диапазона должно быть >= 0");

                endX = Convert.ToInt32(textBoxEndDiap_PVV.Text);

                Random rnd = new Random();

                valueArray = new int[countRow, countColumns];

                dataGridViewMatrix_PVV.RowCount = valueArray.GetLength(0);
                dataGridViewMatrix_PVV.ColumnCount = valueArray.GetLength(1);


                for (int i = 0; i < countRow; i++)
                {
                    for (int j = 0; j < countColumns; j++)
                    {
                        if ((j + 1) % 4 == 0)
                            valueArray[i, j] = valueArray[i, j - 1] + valueArray[i, j - 2] + valueArray[i, j - 3];
                        else
                            valueArray[i, j] = rnd.Next(startX, endX);
                        dataGridViewMatrix_PVV.Rows[i].Cells[j].Value = valueArray[i, j];
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_PVV_Click(object sender, EventArgs e)
        {
            try
            {
                massiveStart = Convert.ToInt32(textBoxStartColumn_PVV.Text);
                massiveEnd = Convert.ToInt32(textBoxStopColumn_PVV.Text);
                selectedR = Convert.ToInt32(textBoxNumRow_PVV.Text);


                if (valueArray != null && selectedR >= 0 && selectedR < countRow)
                {
                    int res = DataService.GetMatrix(valueArray, selectedR, massiveStart, massiveEnd);
                    textBoxResult_PVV.Text = Convert.ToString(res);
                }
                else
                {
                    MessageBox.Show("Матрица не инициализирована или выбрана неверная строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные для выполнения вычислений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            dataGridViewMatrix_PVV.RowCount = 20;
            dataGridViewMatrix_PVV.ColumnCount = 20;



            for (int i = 0; i < 20; i++)
            {
                dataGridViewMatrix_PVV.Columns[i].Width = 35;
                dataGridViewMatrix_PVV.Rows[i].Height = 35;
            }

        }

    }
}
