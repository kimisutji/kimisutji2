using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb_5_purbuev2
{
    public partial class Form1 : Form
    {
        int[] array = null;
        public Form1()
        {
            InitializeComponent();
        }
        // Создание массива
        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCount.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Введите корректное количество элементов!");
                return;
            }

            array = new int[n];
            Random rnd = new Random();
            listBoxArray.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-20, 21); // от -20 до 20
                listBoxArray.Items.Add(array[i]);
            }

            MessageBox.Show("Массив создан!");
        }

        // Проверка массива
        private bool CheckArray()
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Сначала создайте массив!");
                return false;
            }
            return true;
        }

        // A) Среднее геометрическое индексов максимального и минимального
        private void btnGeom_Click(object sender, EventArgs e)
        {
            if (!CheckArray()) return;

            int maxIndex = Array.IndexOf(array, array.Max());
            int minIndex = Array.IndexOf(array, array.Min());

            double result = Math.Sqrt(maxIndex * minIndex);

            lblGeom.Text = "Среднее геометрическое: " + result.ToString("F3");
        }

        // Б) Разность суммы положительных и произведения отрицательных
        private void btnDiff_Click(object sender, EventArgs e)
        {
            if (!CheckArray()) return;

            int sumPos = array.Where(x => x > 0).Sum();

            var negatives = array.Where(x => x < 0).ToList();
            int productNeg;

            if (negatives.Count == 0)
                productNeg = 0;
            else
            {
                productNeg = 1;
                foreach (int x in negatives)
                    productNeg *= x;
            }

            int result = sumPos - productNeg;

            lblDiff.Text = "Разность: " + result.ToString();
        }

        // В) Количество положительных элементов
        private void btnCount_Click(object sender, EventArgs e)
        {
            if (!CheckArray()) return;

            int count = array.Count(x => x > 0);
            lblCount.Text = "Количество положительных: " + count;
        }
    }
}
