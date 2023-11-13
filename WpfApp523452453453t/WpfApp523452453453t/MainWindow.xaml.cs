using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp523452453453t
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int balls;
        
        public void onePlus(object sender, RoutedEventArgs e)
        {
            balls += 1;
        }

        public void twoPlus(object sender, RoutedEventArgs e)
        {
            balls += 2;
        }

        public void threePlus(object sender, RoutedEventArgs e)
        {
            balls += 3;
        }

        public void fourPlus(object sender, RoutedEventArgs e)
        {
            balls += 4;
        }

        public void oneMinus(object sender, RoutedEventArgs e)
        {
            balls -= 1;
        }

        public void twoMinus(object sender, RoutedEventArgs e)
        {
            balls -= 2;
        }

        public void threeMinus(object sender, RoutedEventArgs e)
        {
            balls -= 3;
        }

        public void fourMinus(object sender, RoutedEventArgs e)
        {
            balls -= 4;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Количество баллов: " + balls.ToString(), "Подсчёт выполнен", MessageBoxButton.OK, MessageBoxImage.Information);
            balls = 0;
        }

        private void CalculateIMT(object sender, RoutedEventArgs e)
        {
            IMT iMT = new IMT();
            iMT.Show();
        }

        private void WithoutVTEO(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Гетерозиготная мутация гена фактора V (мутация Лейден F5 G1691A)\n" +
                " Гетерозиготная мутация гена фактора II (протромбина) F2 G20210А",
                "Тромбофилия низкого риска", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AssociatedDiseases(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Онкологическое заболевание" +
                "\n Пароксизмальная ночная гемоглобинурия" +
                "\n Сердечная недостаточность" +
                "\n Активная системная красная волчанка" +
                "\n Воспалительная полиартропатия" +
                "\n Воспалительное заболевание кишечника" +
                "\n Нефротический синдром" +
                "\n Сахарный диабет I типа с нефропатией" +
                "\n Серповидноклеточная анемия" +
                "\n Наркомания с внутривенным введением наркотиков в настоящее время",
                "Заболевания", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void HighRiskThrombophiliacs(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Антифосфолипидный синдром (АФС) \n" +
                " Гомозиготная мутация гена фактора V (мутация Лейден F5 G1691A) или rs 6025 (далее – мутация F5)" +
                "\n Гомозиготная мутация гена фактора II (протромбина) F2 G20210А или rs 179996 (далее – мутация F2)" +
                "\n Сочетание гетерозиготных мутаций факторов V (Лейден) и II (протромбина)" +
                "\n Дефицит АТ" +
                "\n Дефицит протеина С" +
                "\n Дефицит протеина S", "Тромбофилия высокого риска", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
