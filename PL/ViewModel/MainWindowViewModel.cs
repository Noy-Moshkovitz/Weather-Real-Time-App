using BE;
using PL.Model;
using PL.View;
using PL.ViewModel;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PL.MainWindowViewModel1
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        Model.MainWindowModel mainWindowModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public MainWindowViewModel()
        {
            mainWindowModel = new Model.MainWindowModel();

            CurControl = new CurrentViewModel();
            WeeklyControl = new WeeklyViewModel();
            MapControl = new MapViewModel();
        }


        private MapViewModel mapControl;
        public MapViewModel MapControl
        {
            get
            {
                return mapControl;
            }
            set
            {
                mapControl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("mapControl"));
            }
        }
        private WeeklyViewModel weeklyControl;
        public WeeklyViewModel WeeklyControl
        {
            get
            {
                return weeklyControl;
            }
            set
            {
                weeklyControl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("weeklyControl"));
            }
        }
        
        /*private Char chartControl;
        public CurrentViewModel ChartControl
        {
            get
            {
                return chartControl;
            }
            set
            {
                chartControl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("chartControl"));
            }
        }*/
        private CurrentViewModel curControl;
        public CurrentViewModel CurControl
        {
            get
            {
                return curControl;
            }
            set
            {
                curControl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("curControl"));
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

    }

    
    
}
