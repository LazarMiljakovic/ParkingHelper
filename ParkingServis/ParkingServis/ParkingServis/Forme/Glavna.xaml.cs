using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingServis.User;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ParkingServis.Gradovi;
using System.Collections.ObjectModel;
using ParkingServis.Models;
using Plugin.Messaging;
using Xamarin.Essentials;

namespace ParkingServis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Glavna : ContentPage
    {
        public Korisnik korisnik;
        public Tablice tablicaTrenutna;
        public Grad gradTrenutni;
        public ObservableCollection<Zona> DataSource { get; set; }
        public int id;

        public Glavna()
        {
            
            korisnik = new Korisnik();
            tablicaTrenutna = new Tablice();
            InitializeComponent();
            TablicaSetLook();

        }
        private void TablicaSetLook()
        {
            if (korisnik.TabIma == true)
            {
                tablicaTrenutna = new Tablice {Tablica = korisnik.tablice[0].Tablica };
                Tablicaa.Text = tablicaTrenutna.Tablica;
            }
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            StackLayout stackLayout = (StackLayout)button.Parent;
            Label label = (Label)stackLayout.Children[4];

            string text = label.Text;

            if (text != null)
            {

                var smsMessenger = CrossMessaging.Current.SmsMessenger;
                if (smsMessenger.CanSendSms)
                {
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        bool odg = await DisplayAlert("Upozorenje", "Da li sigurno zelite da posaljete poruku", "DA", "NE");
                        if (odg)
                        {
                            smsMessenger.SendSms(text, tablicaTrenutna.Tablica);
                        }
                    }
                    else if (Device.RuntimePlatform == Device.Android)
                    {
                        bool odg = await DisplayAlert("Upozorenje", "Da li sigurno zelite da posaljete poruku", "DA", "NE");
                        if (odg)
                        {
                            smsMessenger.SendSmsInBackground(text, tablicaTrenutna.Tablica);
                        }
                    }


                }

            }




        }

        private async void City_Tapped(object sender, EventArgs e)
        {
            string[] Gradovi = new string[korisnik.gradovi.Count + 1];
            int i = 0;
            foreach (var grad in korisnik.gradovi)
            {
                Gradovi[i] = grad.Naziv;
                i++;
            }
            string action = await DisplayActionSheet("Izaberi grad", "Cancel", null, Gradovi);
            //string action = await DisplayActionSheet("Izaberi grad", "Cancel", null, "Aleksandrovac","Arandjelovac", "Backa Palanka", "Bajina Basta", "Becej", "Bela Crkva", "Beograd", "Bujanovac", "Cacak", "Cicevac", "Cuprija", "Despotovac", "Dimitrovgrad", "Gornji Milanovac", "Indjija", "Ivanjica", "Jagodina", "Kikinda", "Knjazevac", "Kragujevac", "Kraljevo", "Krupanj", "Krusevac", "Kursumlija", "Lazarevac", "Leskovac", "Loznica","Mionica", "Mladenovac", "Negotin", "Nis", "Novi Pazar", "Novi Sad", "Obrenovac", "Osecina", "Pancevo", "Paracin", "Petrovac na Mlavi", "Pirot", "Pozega", "Prokuplje", "Raska", "Ruma", "Sabac", "Senta", "Sid", "Smederevo", "Smederevska Palanka", "Sokobanja", "Sombor", "Sremska Mitrovica", "Sremski Karlovci", "Stara Pazova", "Subotica", "Surcin","Temerin", "Topola", "Trstenik", "Tutin", "Ub", "Uzice", "Valjevo", "Veliko Gradiste", "Vlasotince", "Vranje", "Vrnjacka Banja", "Vrsac", "Zajecar", "Zlatibor", "Zrenjanin");
            foreach (var grad in korisnik.gradovi)
            {
                if (grad.Naziv == action)
                {
                    gradTrenutni = grad;
                    Gradd.Text = grad.Naziv;
                    DataSource = new ObservableCollection<Zona>();
                    ListV.ItemsSource = DataSource;
                    ListV.RowHeight = 200;
                    foreach (Zona a in gradTrenutni.zonaList)
                    {
                        DataSource.Add(new Zona() { Naziv = a.Naziv, MaxZadrzavanje ="Zadrzavanje: "+a.MaxZadrzavanje, VremeNaplate = "Vreme naplate: " + a.VremeNaplate, Cena = "Cena: " + a.Cena, BrojZaPoruku = a.BrojZaPoruku });
                    }
                }
            }
        }

        private async Task TablicaSet()
        {
            korisnik.VratiSveTablice();
            string[] Tablice = new string[korisnik.tablice.Count + 1];
            int i = 0;
            foreach (var tabla in korisnik.tablice)
            {
                Tablice[i] = tabla.Tablica;
                i++;
            }
            Tablice[i] = "Kreiraj novu tablicu";

            string action = await DisplayActionSheet("Izaberi tablice", "Cancel", null, Tablice);

            if (action == "Kreiraj novu tablicu")
            {
                await Navigation.PushModalAsync(new TablicaStrana(korisnik));

            }

            foreach (var tabla in korisnik.tablice)
            {

                if (tabla.Tablica == action)
                {
                    
                    tablicaTrenutna = tabla;
                    Tablicaa.Text = tabla.Tablica;
                }
            }
        }

        private async void Licence_Tapped(object sender, EventArgs e)
        {
           
            await TablicaSet();
        }

        private async void Tablice_Tapped(object sender, EventArgs e)
        {

            await TablicaSet();
        }
    }
}