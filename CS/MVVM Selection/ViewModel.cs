using MVVM_Selection.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Xml.Linq;

namespace MVVM_Selection.ViewModel {
    public class DashboardViewModel : INotifyPropertyChanged {
        static DashboardViewModel instance;
        readonly List<CountryStatisticInfo> countriesData;
        CountryStatisticInfo selectedCountry;

        public event PropertyChangedEventHandler PropertyChanged;

        public static DashboardViewModel Instance {
            get {
                if (instance == null) instance = new DashboardViewModel();
                return instance;
            }
        }

        public List<CountryStatisticInfo> CountriesData {
            get { return countriesData; }
        }
        public CountryStatisticInfo SelectedCountry {
            get { return selectedCountry; }
            set {
                if (selectedCountry != value) {
                    selectedCountry = value;
                    OnPropertyChanged("SelectedCountry");
                }
            }
        }

        public void PopulateData(string filepath) {
            countriesData.AddRange(CountriesInfoDataReader.Load(filepath));
            selectedCountry = countriesData[0];
        }

        DashboardViewModel() {
            countriesData = new List<CountryStatisticInfo>();
        }

        void OnPropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChangedEventHendler = PropertyChanged;
            if (propertyChangedEventHendler != null)
                propertyChangedEventHendler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    class CountriesInfoDataReader {
        static List<PopulationStatisticByYear> LoadStatistic(XElement populationDynamic) {
            List<PopulationStatisticByYear> statistic = new List<PopulationStatisticByYear>();
            foreach (XElement populationDynamicItem in populationDynamic.Elements("PopulationStatisticByYear")) {
                int year = int.Parse(populationDynamicItem.Element("Year").Value);
                long population = long.Parse(populationDynamicItem.Element("Population").Value);
                double urbanPercent = double.Parse(populationDynamicItem.Element("UrbanPercent").Value, CultureInfo.InvariantCulture);
                PopulationStatisticByYear popDynamicItem = new PopulationStatisticByYear(year, (double)population / 1000000.0, urbanPercent);
                statistic.Add(popDynamicItem);
            }
            return statistic;
        }

        public static List<CountryStatisticInfo> Load(string path) {
            XDocument doc = XDocument.Load(path);
            List<CountryStatisticInfo> data = new List<CountryStatisticInfo>();
            foreach (XElement countryInfo in doc.Root.Elements("CountryInfo")) {
                string name = countryInfo.Element("Name").Value;
                double areaSqKm = uint.Parse(countryInfo.Element("AreaSqrKilometers").Value);
                List<PopulationStatisticByYear> statistic = LoadStatistic(countryInfo.Element("Statistic"));
                CountryStatisticInfo countryInfoInstance = new CountryStatisticInfo(name, areaSqKm / 1000000, statistic);
                data.Add(countryInfoInstance);
            }
            return data;
        }
    }
}
