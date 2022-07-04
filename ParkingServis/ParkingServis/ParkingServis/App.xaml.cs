using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkingServis
{
    public partial class App : Application
    {
        private static DatebaseHelper database;
        public static DatebaseHelper Database
        {
            get
            {
                if(database == null)
                {
                    database = new DatebaseHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"tablice.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
           

            MainPage = new Glavna();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
