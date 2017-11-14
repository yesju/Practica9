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
    public partial class DeletPage : ContentPage
    {
        public ObservableCollection<_13090337> Items { get; set; }
        public static MobileServiceClient Cliente;
        public static IMobileServiceTable<_13090337> Tabla;
        public DeletPage()
        {
            InitializeComponent();
            Cliente = new MobileServiceClient(AzureConnection.AzureURL);
            Tabla = Cliente.GetTable<_13090337>();
        }
        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new RecuPage(e.SelectedItem as _13090337));
        }



        private async void Button_Mostrar_Eliminados_Clicked(object sender, EventArgs e)
        {

            IEnumerable<_13090337> elementos = await Tabla.IncludeDeleted().Where(_13090337 => _13090337.Deleted == true).ToEnumerableAsync();
            Items = new ObservableCollection<_13090337>(elementos);
            BindingContext = this;
        }
    }
    }