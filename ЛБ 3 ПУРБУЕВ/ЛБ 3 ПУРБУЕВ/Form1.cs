using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ЛБ_3_ПУРБУЕВ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y, x, a;

            // Проверка, что данные для x и a введены
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // Преобразование из текста в число
                a = Convert.ToDouble(textBox1.Text);
                x = Convert.ToDouble(textBox2.Text);

                if (x <= 0)
                    y = Math.Sin(x * x + a * x);
                else if (x > 0 && x <= a)
                    y = 1 - (1 + Math.Sqrt(x * x + a * a)) / (Math.Exp(Math.Sin(x)) * (1 + x));
                else
                    y = (Math.Cos(x * x - a * a) / Math.Sqrt(1 - Math.Sin(a - x))) - ((1 - Math.Sin(a - x)) / Math.Exp(Math.Sin(x)));

                // Вывод результата в textBox3
                textBox3.Text = y.ToString();
            }
            else
            {
                // Сообщение, если не введены данные
                MessageBox.Show("Введите пожалуйста данные А и Х", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            double value;
            if (!double.TryParse(textBox1.Text, out value))
            {
                MessageBox.Show("Пожалуйста, введите числовое значение для А.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus(); // возвращаем фокус обратно
                textBox1.SelectAll(); // выделить весь текст
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            double value;
            if (!double.TryParse(textBox2.Text, out value))
            {
                MessageBox.Show("Пожалуйста, введите числовое значение для Х.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus(); // возвращаем фокус обратно
                textBox2.SelectAll(); // выделить весь текст
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            // Обработчик для TextBox1
        
            ClearResult();
        }

        // Обработчик для TextBox2
        private void TextBox2_Enter(object sender, EventArgs e)
        {
            ClearResult();
        }

        // Общая подпрограмма для очистки TextBox3
        private void ClearResult()
        {
            textBox3.Clear();
        }
    }
    }

        
            
    


