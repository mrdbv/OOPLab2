using System;
using System.Windows;

namespace Task4WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageText.Text = "";
            TextBlockD.Text = "";

            if (!double.TryParse(TextBoxA.Text, out double a))
            {
                MessageBox.Show("Помилка: a введено некоректно.");
                return;
            }

            if (!double.TryParse(TextBoxB.Text, out double b))
            {
                MessageBox.Show("Помилка: b введено некоректно.");
                return;
            }

            if (!double.TryParse(TextBoxC.Text, out double c))
            {
                MessageBox.Show("Помилка: c введено некоректно.");
                return;
            }

            if (Math.Abs(a) < 1e-10)
            {
                MessageBox.Show("Помилка: a не може дорівнювати 0.");
                return;
            }

            double D = Math.Pow(b, 2) - 4 * a * c;

            TextBlockD.Text = $"D = {D:F3}";

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                LabelX1.Visibility = Visibility.Visible;
                TextBoxX1.Visibility = Visibility.Visible;

                LabelX2.Visibility = Visibility.Visible;
                TextBoxX2.Visibility = Visibility.Visible;

                TextBoxX1.Text = x1.ToString("F3");
                TextBoxX2.Text = x2.ToString("F3");
            }
            else if (Math.Abs(D) < 1e-10)
            {
                double x = -b / (2 * a);

                LabelX1.Visibility = Visibility.Visible;
                TextBoxX1.Visibility = Visibility.Visible;

                LabelX2.Visibility = Visibility.Collapsed;
                TextBoxX2.Visibility = Visibility.Collapsed;

                TextBoxX1.Text = x.ToString("F3");
            }
            else
            {
                LabelX1.Visibility = Visibility.Collapsed;
                TextBoxX1.Visibility = Visibility.Collapsed;

                LabelX2.Visibility = Visibility.Collapsed;
                TextBoxX2.Visibility = Visibility.Collapsed;

                MessageText.Text = "Дійсних коренів немає.";
            }
        }
    }
}