using ParkingServis.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkingServis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TablicaStrana : ContentPage
    {
        public Korisnik Korisnik { get; }


        public TablicaStrana(Korisnik korisnik)
        {
            InitializeComponent();

            Korisnik = korisnik;
        }

        private async void Backward_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Check_Tapped(object sender, EventArgs e)
        {
            var status = await Permissions.RequestAsync<Permissions.StorageWrite>();
            if (TablicaEn.Text != "" && status == PermissionStatus.Granted)
            {
                Tablice tab = new Tablice { Tablica = TablicaEn.Text };
                Korisnik.SacuvajTablicu(tab);
                await Navigation.PopModalAsync();

            }
            else
            {
                await DisplayAlert("Upozorenje", "Niste popunili mesto za tablicu","OK");
            }
        }
    }
}