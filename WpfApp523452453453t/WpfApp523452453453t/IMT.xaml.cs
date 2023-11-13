using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp523452453453t
{
    /// <summary>
    /// Логика взаимодействия для IMT.xaml
    /// </summary>
    public partial class IMT : Window
    {
        public IMT()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            double weight = double.Parse(textBox1.Text);
            double height = double.Parse(textBox2.Text) / 100;

            answer.Content = (weight / Math.Pow(height, 2)).ToString();

            MessageBox.Show("Масса тела    Эноксапарин натрия\n" +
                "<50 кг            20 мг\n" +
                "50-90 кг         40 мг\n" +
                "91-130 кг       60 мг\n" +
                "131-170 кг     70 мг\n" +
                ">170 кг          0,6 мг/кг", "Режим дозирования низкомолекулярных гепаринов (НМГ)", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
