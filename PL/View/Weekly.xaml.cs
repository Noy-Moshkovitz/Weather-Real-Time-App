using Newtonsoft.Json;
using PL.Model;
using PL.MainWindowViewModel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace PL.View
{
    /// <summary>
    /// Interaction logic for Weekly.xaml
    /// </summary>
    public partial class Weekly : UserControl
    {
        WeeklyViewModel weeklyViewModel { get; set; }

        public Weekly()
        {
            InitializeComponent();
            weeklyViewModel = new WeeklyViewModel();
            this.DataContext = weeklyViewModel;
        }

    }
}
