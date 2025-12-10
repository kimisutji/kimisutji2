using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛБ_6_ПУРБУЕВ
{
    public partial class Form1 : Form
    {
        int[,] matrix;
        int rows, cols;
        public Form1()
        {
            InitializeComponent();
        }
        // -------------------------
        // СОЗДАНИЕ МАТРИЦЫ
        // -------------------------
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRows.Text, out rows) || rows <= 0 ||
                !int.TryParse(txtCols.Text, out cols) || cols <= 0)
            {
                MessageBox.Show("Введите корректные размеры матрицы!");
                return;
            }

            matrix = new int[rows, cols];
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Создаём столбцы
            for (int j = 0; j < cols; j++)
                dataGridView1.Columns.Add("c" + j, "C" + j);

            // Заполняем строки
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                dataGridView1.Rows.Add(); // создаём пустую строку

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rnd.Next(-20, 21);
                    dataGridView1[j, i].Value = matrix[i, j]; // выводим поэлементно
                }
            }

            lblResult.Text = "Матрица создана!";
        }

        // Проверка
        private bool CheckMatrix()
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала создайте матрицу!");
                return false;
            }
            return true;
        }

        // -------------------------
        // A) Произведение положительных кратных 3
        // -------------------------
        private void btnA_Click(object sender, EventArgs e)
        {
            if (!CheckMatrix()) return;

            int product = 1;
            bool found = false;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (matrix[i, j] > 0 && matrix[i, j] % 3 == 0)
                    {
                        product *= matrix[i, j];
                        found = true;
                    }

            lblResult.Text = found
                ? $"Произведение положительных кратных 3: {product}"
                : "Подходящих элементов нет.";
        }

        // -------------------------
        // B) Количество отрицательных на побочной диагонали
        // побочная диагональ — индексы: (i, cols - i - 1)
        // -------------------------
        private void btnB_Click(object sender, EventArgs e)
        {
            if (!CheckMatrix()) return;

            int count = 0;

            int diagLen = Math.Min(rows, cols); // на случай не квадратной матрицы

            for (int i = 0; i < diagLen; i++)
            {
                int j = cols - i - 1;
                if (matrix[i, j] < 0) count++;
            }

            lblResult.Text = $"Отрицательных на побочной диагонали: {count}";
        }

        private void txtRows_TextChanged(object sender, EventArgs e)
        {

        }

        // -------------------------
        // C) В матрице 6x6:
        // произведение (суммы чётных чисел 3 строки)
        //         × (суммы отрицательных чисел 1 столбца)
        // -------------------------
        private void btnC_Click(object sender, EventArgs e)
        {
            if (!CheckMatrix()) return;

            if (rows != 6 || cols != 6)
            {
                MessageBox.Show("Это задание работает только для матрицы 6×6!");
                return;
            }

            // 1) Сумма чётных чисел 3-й строки (индекс = 2)
            int sumEven = 0;
            for (int j = 0; j < 6; j++)
            {
                if (matrix[2, j] % 2 == 0)
                    sumEven += matrix[2, j];
            }

            // 2) Сумма отрицательных чисел первого столбца
            int sumNeg = 0;
            for (int i = 0; i < 6; i++)
            {
                if (matrix[i, 0] < 0)
                    sumNeg += matrix[i, 0];
            }

            int result = sumEven * sumNeg;

            lblResult.Text = $"Результат задания C: {result}";
        }
    }
}

