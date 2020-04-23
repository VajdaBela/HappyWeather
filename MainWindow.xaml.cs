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
        object graphPage;
        object tablePage;
        public MainWindow()
        {
            InitializeComponent();
            graphPage = new GraphPage();
            tablePage = new TablePage();
            MainFrame.Content = graphPage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = graphPage;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = tablePage;
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
