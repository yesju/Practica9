using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;

namespace Prac8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPage : ContentPage
    {
        public SelectPage(object selectedItem)
        {
            
            var dato = selectedItem as _13090337;
            BindingContext = dato;
            InitializeComponent();

            // var dato = selectedItem as TESHDatos;
            // BindingContext = dato;

            // string db;
            // db = DependencyService.Get<ISQLite>().GetLocalFilePath("Practica.db");
            // database = new SQLiteConnection(db);
          
        }
        private async void Button_Actualizar_Clicked(object sender, EventArgs e)
        {
            var datos = new _13090337
            {
                ID = Entry_ID.Text,
                Nombre = Entry_Nombre.Text,
                Apellido = Entry_Apellido.Text,
                Direccion = Entry_Direccion.Text,
                Telefono = Convert.ToInt32(Entry_Telefono.Text),
                Carrera = Entry_Carrera.Text,
                Semestre = Entry_Semestre.Text,
                Correo = Entry_Correo.Text,
                GitHub = Entry_GitHub.Text
            };
            //database.Update(datos);
            //Navigation.PushAsync(new DataPage());
            await DataPage.tabla.UpdateAsync(datos);
            //await Navigation.PushAsync(new DataPage());
            await Navigation.PopAsync();
        }
        private async void Button_Eliminar_Clicked(object sender, EventArgs e)
        {
            var datos = new _13090337
            {
                ID = Entry_ID.Text,

            };
           
            await DataPage.tabla.DeleteAsync(datos);

            await Navigation.PopAsync();
        }
    }
}