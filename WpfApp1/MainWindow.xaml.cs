using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TextBoxX.Text, out double x))
            {
                MessageBox.Show("Помилка: x введено некоректно.");
                return;
            }

            if (!double.TryParse(TextBoxY.Text, out double y))
            {
                MessageBox.Show("Помилка: y введено некоректно.");
                return;
            }

            if (!double.TryParse(TextBoxZ.Text, out double z))
            {
                MessageBox.Show("Помилка: z введено некоректно.");
                return;
            }

            double numeratorExpression = 3 + Math.Tan(x) - y / 2.0;
            double numerator = Math.Cbrt(numeratorExpression);

            double denominator =
                Math.Pow(x, 2) + Math.Pow(z, 3) + 4;

            if (Math.Abs(denominator) < 1e-10)
            {
                MessageBox.Show("Помилка: знаменник дорівнює нулю.");
                return;
            }

            double s = numerator / denominator;
            s = Math.Round(s, 3);

            ResultText.Text = $"s = {s:F3}";
        }
    }
}