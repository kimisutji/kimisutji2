namespace ЛБ_2_ЧАСТЬ_2_ПУРБУЕВ
{
    public partial class Form1 : Form
    {
        private double x;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // X
            textBox1.Text = "3.251";
            // y
            textBox2.Text = "0.325";
            // z
            textBox3.Text = "0.466*10^-4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X
            double x = double.Parse(textBox1.Text);
            // Вывод значения Х в окно
            textBox4.Text += Environment.NewLine + 
                "x = " + x.ToString();
            // Считывание значения Y
             double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно
            textBox4.Text += Environment.NewLine + 
                "Y = " + y.ToString();
            // Считывание значения Z
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно
            textBox4.Text += Environment.NewLine +
                "Z = " + z.ToString();
            // Вычисляем арифметическое выражение
            double a = Math.Tan(x + y) *
            Math.Tan(x + y);
            double b = Math.Exp(y - z);
            double c = Math.Sqrt(Math.Cos(x * x) +
            Math.Sin(z * z)); double u = a - b * c;
            // Выводим результат в окно
            textBox4.Text += Environment.NewLine + 
                "Результат U = " + u.ToString();

        }
    }
}
