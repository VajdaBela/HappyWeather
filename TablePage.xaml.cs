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
    /// Interaction logic for TablePage.xaml
    /// </summary>
    public partial class TablePage : Page
    {
        public TablePage()
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
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            vremena.Add(new VremePodatak { VremeMerenja = new DateTime(), Temperatura = 10, VazdusniPritisak = 11, Vidljivost = 12, Vlaznost = 13 });
            MainDataGrid.ItemsSource = vremena;
        }
    }
}
