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

namespace Lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Settings settings = new Settings();
        static int maxDraw = 0;
        static int maxValue = 0;

        public MainWindow()
        {
            InitializeComponent();
            Wallet wallet = new Wallet(1000);
            TotalMoney.Content = wallet.Money.ToString();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            settings.AmountOfDrawing = ((int)AmountofNumbers.Value);
            settings.MaxNumber = ((int)MaxNumber.Value);
            settings.CostPerTicket = CostPerTicket.Value;
            LottoCost.Content = settings.CostPerTicket.ToString();
            maxValue = settings.MaxNumber;
            maxDraw = settings.AmountOfDrawing;

        }


        private void GenerateOne_Click(object sender, RoutedEventArgs e)
        {
            RandomGenerator lottoWheel = new RandomGenerator(maxDraw,maxValue);
            var lottoNumbers = lottoWheel.TonightsNumbers;
            string? s_lottoNumbers = null;
            for (int i = 0; i <= maxDraw; i++)
            {
                s_lottoNumbers += lottoNumbers[i];
                s_lottoNumbers += " ";
            }
            LottoDrawings.Text = s_lottoNumbers;
            


        }
    }
}
