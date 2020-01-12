using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PL
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTU4MDlAMzEzNjJlMzIyZTMwVW9pVjZ4SkZyNzFsMVNpOVZkSHdYT3lBUkM4Vit3WW52eVh6UDM5OEVuND0=");
        }
    }
}
