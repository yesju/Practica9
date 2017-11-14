using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Prac8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        public ObservableCollection<_13090337> Items { get; set; }
        //SQLiteConnection Database;
        public static MobileServiceClient cliente;
        public static IMobileServiceTable<_13090337> tabla;
        public static MobileServiceUser usuario;
       
        public DataPage()
        {
            InitializeComponent();
            //string db;
            //db = DependencyService.Get<ISQLite>().GetLocalFilePath("Practica.db");
            /// database = new SQLiteConnection(db);
            //database.CreateTable<TESHDatos>();
            //Items = new ObservableCollection<TESHDatos>(database.Table<TESHDatos>());
            //BindingContext = this;
            cliente = new MobileServiceClient(AzureConnection.AzureURL);
            tabla = cliente.GetTable<_13090337>();
            if (usuario != null) { Leertabla(); };
            //Leertabla();
           
        }
        private void Evento_Insertar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }
        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new SelectPage(e.SelectedItem as _13090337));
        }
        private async void Leertabla()
        {
            IEnumerable<_13090337> elementos = await tabla.ToEnumerableAsync();
            Items = new ObservableCollection<_13090337>(elementos);
            BindingContext = this;
            lista.ItemsSource = Items;
           

        }


        private void Evento_Eliminados(object sender, EventArgs e) 

            {
            Navigation.PushAsync(new DeletPage());
        }

    private async void Button_Clicked(object sender, EventArgs e)
        {
            usuario = await App.Authenticador.Autheticate();
            if (App.Authenticador != null)
            {
                if (usuario != null)
                {
                    await DisplayAlert("Usuario Autenticado", usuario.UserId, "OK");
                    Leertabla();
                }
                if (usuario == null)
                {
                    Boton_Insertar.IsVisible = false;
                    Boton_Insertar.IsEnabled = false;
                    Boton_Eliminados.IsVisible = false;
                    Boton_Eliminados.IsEnabled = false;
                }
            }
        }
            protected override void OnAppearing()
        {
            base.OnAppearing();
            if (usuario != null)
            {
                Leertabla();
            }
        }

    }
    }
