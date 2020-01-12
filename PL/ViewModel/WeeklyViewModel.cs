using BE;
using PL.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PL.MainWindowViewModel1
{
    public class WeeklyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Model.WeeklyModel weeklyModel { get; set; }
        WeatherDB weatherDB;
        
        public SearchCommand SearchCommand { get; set; }

        public WeeklyViewModel()
        {
            weeklyModel = new Model.WeeklyModel(userCity);
            UserCity = "jerusalem";
            weatherDB = weeklyModel.getWeeklyForecast(UserCity);
            SearchCommand = new Command.SearchCommand(this);
        }

       

        public WeeklyViewModel(string city)
        {            
            weeklyModel = new Model.WeeklyModel(city);
            UserCity = city;
            weatherDB = weeklyModel.getWeeklyForecast(city);
            SearchCommand = new Command.SearchCommand(this);            
        }

        private void WeeklyViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "userCity")
            {
                weatherDB = weeklyModel.getWeeklyForecast(UserCity);
                string ic;
                CityN = weatherDB.cityN;

                //day0
                Day_0 = weatherDB.day_0;
                Temp_0 = weatherDB.temp_0.ToString() + "\u00B0" + " C";
                Condition_0 = weatherDB.cond_0.ToString();
                WindSpeed_0 = weatherDB.windSpeed_0.ToString() + "  km/h";
                WeatherDesc_0 = weatherDB.description_0;
                ic = weatherDB.icon_0;
                Icon_0 = setIcon(ic);

                //day1          
                Day_1 = weatherDB.day_1;
                Temp_1 = weatherDB.temp_1.ToString() + "\u00B0" + " C";
                Condition_1 = weatherDB.cond_1.ToString();
                WindSpeed_1 = weatherDB.windSpeed_1.ToString() + "  km/h";
                WeatherDesc_1 = weatherDB.description_1;
                ic = weatherDB.icon_1;
                Icon_1 = setIcon(ic);

                //day2
                Day_2 = weatherDB.day_2;
                Temp_2 = weatherDB.temp_2.ToString() + "\u00B0" + " C";
                Condition_2 = weatherDB.cond_2.ToString();
                WindSpeed_2 = weatherDB.windSpeed_2.ToString() + "  km/h";
                WeatherDesc_2 = weatherDB.description_2;
                ic = weatherDB.icon_2;
                Icon_2 = setIcon(ic);

                //day3
                Day_3 = weatherDB.day_3;
                Temp_3 = weatherDB.temp_3.ToString() + "\u00B0" + " C";
                Condition_3 = weatherDB.cond_3.ToString();
                WindSpeed_3 = weatherDB.windSpeed_3.ToString() + "  km/h";
                WeatherDesc_3 = weatherDB.description_3;
                ic = weatherDB.icon_3;
                Icon_3 = setIcon(ic);

                //day4
                Day_4 = weatherDB.day_4;
                Temp_4 = weatherDB.temp_4.ToString() + "\u00B0" + " C";
                Condition_4 = weatherDB.cond_4.ToString();
                WindSpeed_4 = weatherDB.windSpeed_4.ToString() + "  km/h";
                WeatherDesc_4 = weatherDB.description_4;
                ic = weatherDB.icon_4;
                Icon_4 = setIcon(ic);

                //day5
                Day_5 = weatherDB.day_5;
                Temp_5 = weatherDB.temp_5.ToString() + "\u00B0" + " C";
                Condition_5 = weatherDB.cond_5.ToString();
                WindSpeed_5 = weatherDB.windSpeed_5.ToString() + "  km/h";
                WeatherDesc_5 = weatherDB.description_5;
                ic = weatherDB.icon_5;
                Icon_5 = setIcon(ic);

                //day6
                Day_6 = weatherDB.day_6;
                Temp_6 = weatherDB.temp_6.ToString() + "\u00B0" + " C";
                Condition_6 = weatherDB.cond_6.ToString();
                WindSpeed_6 = weatherDB.windSpeed_6.ToString() + "  km/h";
                WeatherDesc_6 = weatherDB.description_6;
                ic = weatherDB.icon_6;
                Icon_6 = setIcon(ic);
            }
        }
        

        private string userCity;
        private string cityN;
        private string day_0, day_1, day_2, day_3, day_4, day_5, day_6;
        private string temp_0, temp_1, temp_2, temp_3, temp_4, temp_5, temp_6;
        private string condition_0, condition_1, condition_2, condition_3, condition_4, condition_5, condition_6;
        private string windSpeed_0, windSpeed_1, windSpeed_2, windSpeed_3, windSpeed_4, windSpeed_5, windSpeed_6;
        private string weatherDesc_0, weatherDesc_1, weatherDesc_2, weatherDesc_3, weatherDesc_4, weatherDesc_5, weatherDesc_6;
        
        private BitmapImage icon_0, icon_1, icon_2, icon_3, icon_4, icon_5, icon_6;


        public string UserCity
        {
            get
            {
                return userCity;
            }
            set
            {
                userCity = value;
                PropertyChanged += WeeklyViewModel_PropertyChanged;
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

        public string Day_0
        {
            get
            {
                return weatherDB.day_0;
            }
            set
            {
                day_0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_1
        {
            get
            {
                return weatherDB.day_1;
            }
            set
            {
                day_1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_2
        {
            get
            {
                return weatherDB.day_2;
            }
            set
            {
                day_2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_3
        {
            get
            {
                return weatherDB.day_3;
            }
            set
            {
                day_3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_4
        {
            get
            {
                return weatherDB.day_4;
            }
            set
            {
                day_4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_5
        {
            get
            {
                return weatherDB.day_5;
            }
            set
            {
                day_5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Day_6
        {
            get
            {
                return weatherDB.day_6;
            }
            set
            {
                day_6 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string Temp_0
        {
            get
            {
                return weatherDB.temp_0.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_1
        {
            get
            {
                return weatherDB.temp_1.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_2
        {
            get
            {
                return weatherDB.temp_2.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_3
        {
            get
            {
                return weatherDB.temp_3.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_4
        {
            get
            {
                return weatherDB.temp_4.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_5
        {
            get
            {
                return weatherDB.temp_5.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Temp_6
        {
            get
            {
                return weatherDB.temp_6.ToString() + "\u00B0" + " C";
            }
            set
            {
                temp_6 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string Condition_0
        {
            get
            {
                return weatherDB.cond_0.ToString();
            }
            set
            {
                condition_0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Condition_1
        {
            get
            {
                return weatherDB.cond_1.ToString();
            }
            set
            {
                condition_1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Condition_2
        {
            get
            {
                return weatherDB.cond_2.ToString();
            }
            set
            {
                condition_2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Condition_3
        {
            get
            {
                return weatherDB.cond_3.ToString();
            }
            set
            {
                condition_3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Condition_4
        {
            get
            {
                return weatherDB.cond_4.ToString();
            }
            set
            {
                condition_4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Condition_5
        {
            get
            {
                return weatherDB.cond_5.ToString();
            }
            set
            {
                condition_5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string Condition_6
        {
            get
            {
                return weatherDB.cond_6.ToString();
            }
            set
            {
                condition_6 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string WindSpeed_0
        {
            get
            {
                return weatherDB.windSpeed_0.ToString() + " km/h";
            }
            set
            {
                windSpeed_0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WindSpeed_1
        {
            get
            {
                return weatherDB.windSpeed_1.ToString() + " km/h";
            }
            set
            {
                windSpeed_1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WindSpeed_2
        {
            get
            {
                return weatherDB.windSpeed_2.ToString() + "  km/h";
            }
            set
            {
                windSpeed_2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WindSpeed_3
        {
            get
            {
                return weatherDB.windSpeed_3.ToString() + "  km/h";
            }
            set
            {
                windSpeed_3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WindSpeed_4
        {
            get
            {
                return weatherDB.windSpeed_4.ToString() + "  km/h";
            }
            set
            {
                windSpeed_4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WindSpeed_5
        {
            get
            {
                return weatherDB.windSpeed_5.ToString() + "  km/h";
            }
            set
            {
                windSpeed_5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WindSpeed_6
        {
            get
            {
                return weatherDB.windSpeed_6.ToString() + "  km/h";
            }
            set
            {
                windSpeed_6 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public string WeatherDesc_0
        {
            get
            {
                return weatherDB.description_0;
            }
            set
            {
                weatherDesc_0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WeatherDesc_1
        {
            get
            {
                return weatherDB.description_1;
            }
            set
            {
                weatherDesc_1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WeatherDesc_2
        {
            get
            {
                return weatherDB.description_2;
            }
            set
            {
                weatherDesc_2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WeatherDesc_3
        {
            get
            {
                return weatherDB.description_3;
            }
            set
            {
                weatherDesc_3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WeatherDesc_4
        {
            get
            {
                return weatherDB.description_4;
            }
            set
            {
                weatherDesc_4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WeatherDesc_5
        {
            get
            {
                return weatherDB.description_5;
            }
            set
            {
                weatherDesc_5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public string WeatherDesc_6
        {
            get
            {
                return weatherDB.description_6;
            }
            set
            {
                weatherDesc_6 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        public BitmapImage Icon_0
        {
            get
            {
                string ic = weatherDB.icon_0;

                return setIcon(ic);
            }
            set
            {
                icon_0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_1
        {
            get
            {
                string ic = weatherDB.icon_1;

                return setIcon(ic);
            }
            set
            {
                icon_1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_2
        {
            get
            {
                string ic = weatherDB.icon_2;

                return setIcon(ic);
            }
            set
            {
                icon_2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_3
        {
            get
            {
                string ic = weatherDB.icon_3;

                return setIcon(ic);
            }
            set
            {
                icon_3 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_4
        {
            get
            {
                string ic = weatherDB.icon_4;

                return setIcon(ic);
            }
            set
            {
                icon_4 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_5
        {
            get
            {
                string ic = weatherDB.icon_5;

                return setIcon(ic);
            }
            set
            {
                icon_5 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        public BitmapImage Icon_6
        {
            get
            {
                string ic = weatherDB.icon_6;

                return setIcon(ic);
            }
            set
            {
                icon_6 = value;
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
            //picture.Source = image;
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
