using BE;
using PL.Command;
using PL.MainWindowViewModel1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace PL.ViewModel
{
    public class MapViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Model.MapModel mapModel { get; set; }
        WeatherDB HaifaWeatherDB, TiberiasWeatherDB, Kiryat_ShmonaWeatherDB, Tel_AvivWeatherDB, Beer_ShevaWeatherDB, JerusalemWeatherDB, EilatWeatherDB;
        public SmallWeeklyViewModel childViewModel { get; set; }

        public SearchCommand SearchCommand { get; set; }
        string city = "haifa";

        public MapViewModel()
        {
            mapModel = new Model.MapModel();

            HaifaWeatherDB = mapModel.getWeeklyForecast("Haifa");
            TiberiasWeatherDB = mapModel.getWeeklyForecast("Tiberias");
            Kiryat_ShmonaWeatherDB = mapModel.getWeeklyForecast("Kiryat Shmona");
            Tel_AvivWeatherDB = mapModel.getWeeklyForecast("Tel Aviv");
            Beer_ShevaWeatherDB = mapModel.getWeeklyForecast("Beer Sheva");
            JerusalemWeatherDB = mapModel.getWeeklyForecast("Jerusalem");
            EilatWeatherDB = mapModel.getWeeklyForecast("Eilat");

            UserControl = new SmallWeeklyViewModel(city);

            SearchCommand = new Command.SearchCommand(this);

        }

        private ICommand _navigateCommandJerusalem;
        public ICommand NavigateCommandJerusalem
        {
            get
            {
                return _navigateCommandJerusalem ?? (_navigateCommandJerusalem = new RelayCommand(
                          x => { UpdateSmallWeather("jerusalem"); }));
            }
        }

        private ICommand _navigateCommandEilat;
        public ICommand NavigateCommandEilat
        {
            get
            {
                return _navigateCommandEilat ?? (_navigateCommandEilat = new RelayCommand(
                          x => { UpdateSmallWeather("Eilat"); }));
            }
        }

        private ICommand _navigateCommandHaifa;
        public ICommand NavigateCommandHaifa
        {
            get
            {
                return _navigateCommandHaifa ?? (_navigateCommandHaifa = new RelayCommand(
                          x => { UpdateSmallWeather("Haifa"); }));
            }
        }

        private ICommand _navigateCommandTel_Aviv;
        public ICommand NavigateCommandTel_Aviv
        {
            get
            {
                return _navigateCommandTel_Aviv ?? (_navigateCommandTel_Aviv = new RelayCommand(
                          x => { UpdateSmallWeather("Tel Aviv"); }));
            }
        }

        private ICommand _navigateCommandBeer_Sheva;
        public ICommand NavigateCommandBeer_Sheva
        {
            get
            {
                return _navigateCommandBeer_Sheva ?? (_navigateCommandBeer_Sheva = new RelayCommand(
                          x => { UpdateSmallWeather("Beer Sheva"); }));
            }
        }

        private ICommand _navigateCommandTiberias;
        public ICommand NavigateCommandTiberias
        {
            get
            {
                return _navigateCommandTiberias ?? (_navigateCommandTiberias = new RelayCommand(
                          x => { UpdateSmallWeather("Tiberias"); }));
            }
        }

        private ICommand _navigateCommandKiryat_Shmona;
        public ICommand NavigateCommandKiryat_Shmona
        {
            get
            {
                return _navigateCommandKiryat_Shmona ?? (_navigateCommandKiryat_Shmona = new RelayCommand(
                          x => { UpdateSmallWeather("Kiryat Shmona"); }));
            }
        }

        public void UpdateSmallWeather(string cityName)
        {            
            PropertyChanged += MapViewModel_PropertyChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(cityName));
        }





        private SmallWeeklyViewModel userControl;
        public SmallWeeklyViewModel UserControl
        {
            get
            {
                return userControl;
            }
            set
            {
                userControl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }



        private void MapViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "jerusalem" || e.PropertyName == "Eilat" || e.PropertyName == "Kiryat Shmona" || e.PropertyName == "Tiberias" || e.PropertyName == "Beer Sheva" || e.PropertyName == "Tel Aviv" || e.PropertyName == "Haifa")
            {
                string city = e.PropertyName;
                if (city != null)
                    this.UserControl = new SmallWeeklyViewModel(city);
            }
        }


        private string temp_Haifa, temp_Tiberias, temp_Kiryat_Shmona, temp_Tel_Aviv, temp_Beer_Sheva, temp_Jerusalem, temp_Eilat;
        private BitmapImage icon_Haifa, icon_Tiberias, icon_Kiryat_Shmona, icon_Tel_Aviv, icon_Beer_Sheva, icon_Jerusalem, icon_Eilat;


        protected void OnPropertyChanged(string propertyName)
        {

            PropertyChangedEventHandler handler = PropertyChanged;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Temp_Haifa
        {
            get
            {
                return HaifaWeatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_Haifa = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_Tiberias
        {
            get
            {
                return TiberiasWeatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_Tiberias = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_Kiryat_Shmona
        {
            get
            {
                return Kiryat_ShmonaWeatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_Kiryat_Shmona = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_Tel_Aviv
        {
            get
            {
                return Tel_AvivWeatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_Tel_Aviv = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_Beer_Sheva
        {
            get
            {
                return Beer_ShevaWeatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_Beer_Sheva = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_Jerusalem
        {
            get
            {
                return JerusalemWeatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_Jerusalem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_Eilat
        {
            get
            {
                return EilatWeatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_Eilat = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }


        public BitmapImage Icon_Haifa
        {
            get
            {
                string ic = HaifaWeatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon_Haifa = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_Tiberias
        {
            get
            {
                string ic = TiberiasWeatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon_Tiberias = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_Kiryat_Shmona
        {
            get
            {
                string ic = Kiryat_ShmonaWeatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon_Kiryat_Shmona = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_Tel_Aviv
        {
            get
            {
                string ic = Tel_AvivWeatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon_Tel_Aviv = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_Beer_Sheva
        {
            get
            {
                string ic = Beer_ShevaWeatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon_Beer_Sheva = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_Jerusalem
        {
            get
            {
                string ic = JerusalemWeatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon_Jerusalem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_Eilat
        {
            get
            {
                string ic = EilatWeatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon_Eilat = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        BitmapImage setIcon(string iconId)
        {
            string iconName = findIcon(iconId);
            string img_location = @"C:\Users\DELL\Desktop\Academic\3rd year 2nd sem\windows project\perfectGraph 3d\WeatherApp_7109\PL\Icons\" + iconName;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(img_location);            
            image.EndInit();
            return image;
        }

        string findIcon(string iconId)
        {
            string iconName = "";
            if (iconId == "01d")
                iconName = "sunny.png";
            else if (iconId == "02d")
                iconName = "partly_cloudy.png";
            else if (iconId == "03d")
                iconName = "cloudy.png";
            else if (iconId == "04d")
                iconName = "cloudy.png";
            else if (iconId == "09d")
                iconName = "rain.png";
            else if (iconId == "10d")
                iconName = "rain.png";
            else if (iconId == "11d")
                iconName = "thunderstorm.png";
            else if (iconId == "13d")
                iconName = "snow.png";
            else if (iconId == "50d")
                iconName = "mist.png";
            else if (iconId == "01n")
                iconName = "sunny_night.png";
            else if (iconId == "02n")
                iconName = "partly_cloudy_night.png";
            else if (iconId == "03n")
                iconName = "cloudy.png";
            else if (iconId == "04n")
                iconName = "cloudy.png";
            else if (iconId == "09n")
                iconName = "rain.png";
            else if (iconId == "10n")
                iconName = "rain.png";
            else if (iconId == "11n")
                iconName = "thunderstorm.png";
            else if (iconId == "13n")
                iconName = "snow.png";
            else if (iconId == "50n")
                iconName = "mist_night.png";
            else
                iconName = "partly_cloudy.png";
            return iconName;
        }
    }
}
