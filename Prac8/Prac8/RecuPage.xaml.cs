using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.ObjectModel;

namespace Prac8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecuPage : ContentPage
    {
        public RecuPage()
        {
        }

        public RecuPage(object selectedItem)
        {
            InitializeComponent();
            var dato = selectedItem as _13090337;
            BindingContext = dato;
        }
        private async void Button_Recuperar_Clicked(object sender, EventArgs e)
        {
            var datos = new _13090337
            {
                ID = Entry_ID.Text,
            };
            await DataPage.tabla.UndeleteAsync(datos);
            await Navigation.PushAsync(new DataPage());

        }
    }
}