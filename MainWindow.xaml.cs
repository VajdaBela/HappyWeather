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

namespace HappyWeather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<VremePodatak> vremena = new List<VremePodatak>();
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            MainDataGrid.ItemsSource = vremena;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainCartesionChart.Visibility = Visibility.Visible;
            ChoicesStackPanel.Visibility = Visibility.Visible;
            MainDataGrid.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainCartesionChart.Visibility = Visibility.Hidden;
            ChoicesStackPanel.Visibility = Visibility.Hidden;
            MainDataGrid.Visibility = Visibility.Visible;
        }
    }

    public class VremePodatak
    {
        public DateTime VremeMerenja { get; set; }
        public double Temperatura { get; set; }
        public double VazdusniPritisak { get; set; }
        public double Vidljivost { get; set; }
        public double Vlaznost { get; set; }
    }
}
