using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prac8;
using Xamarin.Forms;

namespace Prac8
{
    public partial class App : Application
    {
        public static ISQLAzure Authenticador { get; private set; }
        public static void Init(ISQLAzure authenticator)
        {
            Authenticador = authenticator;
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DataPage());
        }

        protected override void OnStart()// poner el evento de autencyicacion
        {


        } 

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        
    }
}
