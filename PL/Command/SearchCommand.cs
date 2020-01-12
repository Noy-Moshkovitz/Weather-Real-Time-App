using PL.MainWindowViewModel1;
using PL.Model;
using PL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PL.Command
{
    public class SearchCommand : ICommand
    {
        //static string city = "haifa";//limhok

        private CurrentViewModel currentViewModel;
        private WeeklyViewModel weeklyViewModel;
        private MapViewModel mapViewModel;
        private SmallWeeklyViewModel smallWeeklyViewModel;

        public SearchCommand(CurrentViewModel curVM)//
        {
            this.currentViewModel = curVM;

        }

        public SearchCommand(WeeklyViewModel weekVM)//
        {
            this.weeklyViewModel = weekVM;

        }

        public SearchCommand(SmallWeeklyViewModel SweekVM)//
        {
            this.smallWeeklyViewModel = SweekVM;

        }

        public SearchCommand(MapViewModel map)//
        {
            this.mapViewModel = map;

        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            var result = true;//false
            /*if (!(string.IsNullOrEmpty(result.ToString())))//????
                result = true;*/

            return result;
        }

        public void Execute(object parameter)
        {
            var data = parameter as string;
           
            if (data != null)
            {                
                //MessageBox.Show(data);               
            }            
        }
    }
}

/*
 * 
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BL;
using CurrencyV2.models;
using CurrencyV2.viewModel;
using DataProtocol_BE;

namespace CurrencyV2.commands
{
    public class CalculateChartCommand : ICommand
    {
        ZoomingAndPanningVM vm;

        public CalculateChartCommand(ZoomingAndPanningVM d)
        {
            vm = d;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return (vm.Combo1 != null&& vm.Combo2 != null);
        }

        public void Execute(object parameter)
        {
            ZoomingAndPanningVM.Values.Clear();
            new CalculateChartCommandModel().GetVluesInPeriodAsync(ZoomingAndPanningVM.Values, vm.Combo1 , vm.Combo2, DateTime.Now.Subtract(new TimeSpan(vm.Amount, 0, 0, 0)), DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0)));
        }
    }
}
*/
