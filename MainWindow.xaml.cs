using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Collections.ObjectModel;
using System.Net;
using System.IO;
using System.IO.Compression;
using Newtonsoft.Json;

namespace HappyWeather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<City> Allcities;
        public ObservableCollection<City> filteredCities { get; set; }
        public ObservableCollection<City> selectedCities { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            filteredCities = new ObservableCollection<City>();
            filteredCities.Add(new City { name = "Novi Sad"});
            filteredCities.Add(new City { name = "Beograd" });

            selectedCities = new ObservableCollection<City>();

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

            ReadCities();
            Allcities.Sort(City.CompareCity);
            updateFilteredListBox();
            MainDataGrid.ItemsSource = vremena;
        }

        public void updateFilteredListBox()
        {
            filteredCities.Clear();
            string searchString = SearchTextBox.Text;
            int numberAdded = 0;
            foreach(City city in Allcities)
            {
                if(city.name.Contains(searchString))
                {
                    filteredCities.Add(city);
                    numberAdded += 1;
                }
                if(numberAdded >= 100)
                {
                    break;
                }
            }
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
        private void ReadCities()
        {
            WebClient wb = new WebClient();
            wb.DownloadFile("http://bulk.openweathermap.org/sample/city.list.json.gz", Path.GetTempPath() + "city.list.json.gz");
            using (FileStream file = new FileStream(Path.GetTempPath() + "city.list.json.gz", FileMode.Open))
            using (GZipStream decompresor = new GZipStream(file, CompressionMode.Decompress))
            using (StreamReader jsonText = new StreamReader(decompresor, Encoding.UTF8))
            {
                JsonSerializer serializer = new JsonSerializer();
                Allcities = (List<City>)serializer.Deserialize(jsonText, typeof(List<City>));
            }
        }

        private void SearchTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            updateFilteredListBox();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            City city = (City)FilteredListBox.SelectedItem;
            selectedCities.Add(city);
            filteredCities.Remove(city);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            City city = (City)SelectedListBox.SelectedItem;
            selectedCities.Remove(city);
            updateFilteredListBox();
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

    public class City
    {
        public string id;
        public string name;
        public string state;
        public string country;
        public Coordinate coord;

        public override string ToString()
        {
            return name;
        }

        public static int CompareCity(City x, City y)
        {
            return x.name.ToLower().CompareTo(y.name.ToLower());
        }
    }

    public class Coordinate
    {
        public string lon;
        public string lat;
    }
}
