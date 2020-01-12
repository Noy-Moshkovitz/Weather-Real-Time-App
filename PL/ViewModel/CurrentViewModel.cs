using BE;
using PL.Command;
using PL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PL.MainWindowViewModel1
{
   public class CurrentViewModel : INotifyPropertyChanged
    {
        Model.CurrentModel currentModel { get; set; }
        WeatherDB weatherDB;
        public event PropertyChangedEventHandler PropertyChanged;
        public SearchCommand SearchCommand { get; set; }

        public CurrentViewModel()
        {                        
            currentModel = new Model.CurrentModel(userCity);
            UserCity = "jerusalem";
            weatherDB = currentModel.getWeeklyForecast(UserCity);
            SearchCommand = new Command.SearchCommand(this);            
        }

        private void CurrentViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "userCity")
            {
                weatherDB = currentModel.getWeeklyForecast(UserCity);
                CityN = weatherDB.cityN;
                Temp = weatherDB.temp_0.ToString() + "\u00B0" + " C";
                Humdity = weatherDB.humdity.ToString() + " %";
                WindSpeed = weatherDB.windSpeed_0.ToString() + " meter/sec";
                WeatherDesc = weatherDB.description_0;
                Coords = "Geo Coordinates: " + "[" + weatherDB.latCoord.ToString() + " , " + weatherDB.lonCoord.ToString() + "]";
                string ic = weatherDB.icon_0;
                Icon = setIcon(ic);                
            }
        }

        public CurrentViewModel(string city)
        {            
            currentModel = new Model.CurrentModel(city);
            UserCity = city;
            weatherDB = currentModel.getWeeklyForecast(city);
            SearchCommand = new Command.SearchCommand(this);
        }

 
        private string userCity;
        private string cityN;
        private string temp;
        private string humdity;
        private string windSpeed;
        private string weatherDesc;
        private string coords;
        private BitmapImage icon;


        public string UserCity
        {
            get
            {
                return userCity;
            }
            set
            {
                userCity = value;
                PropertyChanged += CurrentViewModel_PropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("userCity"));                
            }
        }

        protected void OnPropertyChanged(string propertyName)
        { 
              
            PropertyChangedEventHandler handler = PropertyChanged;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public string CityN
        {
            get
            {
                return weatherDB.cityN;
            }
            set
            {
                cityN = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string Temp
        {
            get
            {
                return weatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string Humdity
        {
            get
            {
                return weatherDB.humdity.ToString() + " %"; 
            }
            set
            {
                humdity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string WindSpeed
        {
            get
            {
                return weatherDB.windSpeed_0.ToString() + " meter/sec";
            }
            set
            {
                windSpeed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string WeatherDesc
        {
            get
            {
                return weatherDB.description_0;
            }
            set
            {
                weatherDesc = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string Coords
        {
            get
            {
                return "Geo Coordinates: " + "[" + weatherDB.latCoord.ToString() + " , " + weatherDB.lonCoord.ToString() + "]";
            }
            set
            {
                coords = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }


        public BitmapImage Icon
        {
            get
            {
                string ic= weatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon = value;
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
