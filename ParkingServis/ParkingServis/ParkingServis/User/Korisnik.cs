using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Gradovi;
using ParkingServis.User;
using System.IO;
using System.Reflection;
using System.Runtime;
using Xamarin.Essentials;
using SQLite;


namespace ParkingServis.User
{
    public class Korisnik
    {
        public IList<Grad> gradovi;
        public IList<Tablice> tablice;
        public bool TabIma = false;
        public Korisnik()
        {
            gradovi = new List<Grad>();

            #region Gradovi

            Aleksandrovac aleksandrovac = new Aleksandrovac();
            Arandjelovac arandjelovac = new Arandjelovac();
            BackaPalanka backaPalanka = new BackaPalanka();
            BajinaBasta bajinaBasta = new BajinaBasta();
            Becej becej = new Becej();
            BelaCrkva belaCrkva = new BelaCrkva();
            Beograd beograd = new Beograd();
            Bujanovac bujanovac = new Bujanovac();
            Cacak cacak = new Cacak();
            Cicevac cicevac = new Cicevac();
            Cuprija cuprija = new Cuprija();
            Despotovac despotovac = new Despotovac();
            Dimitrovgrad dimitrovgrad = new Dimitrovgrad();
            GornjiMilanovac gornjiMilanovac = new GornjiMilanovac();
            Indjija indjija = new Indjija();
            Ivanjica ivanjica = new Ivanjica();
            Jagodina jagodina = new Jagodina();
            Kikinda kikinda = new Kikinda();
            Knjazevac knjazevac = new Knjazevac();
            Kragujevac kragujevac = new Kragujevac();
            Kraljevo kraljevo = new Kraljevo();
            Krupanj krupanj = new Krupanj();
            Krusevac krusevac = new Krusevac();
            Kursumlija kursumlija = new Kursumlija();
            Lazarevac lazarevac = new Lazarevac();
            Leskovac leskovac = new Leskovac();
            Loznica loznica = new Loznica();
            Mionica mionica = new Mionica();
            Mladenovac mladenovac = new Mladenovac();
            Negotin negotin = new Negotin();
            Nis nis = new Nis();
            NoviPazar noviPazar = new NoviPazar();
            NoviSad noviSad = new NoviSad();
            Obrenovac obrenovac = new Obrenovac();
            Osecina osecina = new Osecina();
            Pancevo pancevo = new Pancevo();
            Paracin paracin = new Paracin();
            PetrovacNaMlavi petrovacNaMlavi = new PetrovacNaMlavi();
            Pirot pirot = new Pirot();
            Pozarevac pozarevac = new Pozarevac();
            Pozega pozega = new Pozega();
            Prokuplje prokuplje = new Prokuplje();
            Raska raska = new Raska();
            Ruma ruma = new Ruma();
            Sabac sabac = new Sabac();
            Senta senta = new Senta();
            Sid sid = new Sid();
            Smederevo smederevo = new Smederevo();
            SmederevskaPalanka smederevskaPalanka = new SmederevskaPalanka();
            Sokobanja sokobanja = new Sokobanja();
            Sombor sombor = new Sombor();
            SremskaMitrovica sremskaMitrovica = new SremskaMitrovica();
            SremskiKarlovci sremskiKarlovci = new SremskiKarlovci();
            StaraPazova staraPazova = new StaraPazova();
            Subotica subotica = new Subotica();
            Surcin surcin = new Surcin();
            Temerin temerin = new Temerin();
            Topola topola = new Topola();
            Trstenik trstenik = new Trstenik();
            Tutin tutin = new Tutin();
            Ub ub = new Ub();
            Uzice uzice = new Uzice();
            Valjevo valjevo = new Valjevo();
            VelikoGradiste velikoGradiste = new VelikoGradiste();
            Vlasotince vlasotince = new Vlasotince();
            Vranje vranje = new Vranje();
            VrnjackaBanja vrnjackaBanja = new VrnjackaBanja();
            Vrsac vrsac = new Vrsac();
            Zajecar zajecar = new Zajecar();
            Zlatibor zlatibor = new Zlatibor();
            Zrenjanin zrenjanin = new Zrenjanin();

            #endregion

            #region DodavanjeGradova

            gradovi.Add(aleksandrovac);
            gradovi.Add(arandjelovac);
            gradovi.Add(aleksandrovac);
            gradovi.Add(backaPalanka);
            gradovi.Add(bajinaBasta);
            gradovi.Add(becej);
            gradovi.Add(belaCrkva);
            gradovi.Add(beograd);
            gradovi.Add(bujanovac);
            gradovi.Add(cacak);
            gradovi.Add(cicevac);
            gradovi.Add(cuprija);
            gradovi.Add(despotovac);
            gradovi.Add(dimitrovgrad);
            gradovi.Add(gornjiMilanovac);
            gradovi.Add(indjija);
            gradovi.Add(ivanjica);
            gradovi.Add(jagodina);
            gradovi.Add(kikinda);
            gradovi.Add(knjazevac);
            gradovi.Add(kragujevac);
            gradovi.Add(kraljevo);
            gradovi.Add(krupanj);
            gradovi.Add(krusevac);
            gradovi.Add(kursumlija);
            gradovi.Add(lazarevac);
            gradovi.Add(leskovac);
            gradovi.Add(loznica);
            gradovi.Add(mionica);
            gradovi.Add(mladenovac);
            gradovi.Add(negotin);
            gradovi.Add(nis);
            gradovi.Add(noviPazar);
            gradovi.Add(noviSad);
            gradovi.Add(obrenovac);
            gradovi.Add(osecina);
            gradovi.Add(pancevo);
            gradovi.Add(paracin);
            gradovi.Add(petrovacNaMlavi);
            gradovi.Add(pirot);
            gradovi.Add(pozarevac);
            gradovi.Add(pozega);
            gradovi.Add(prokuplje);
            gradovi.Add(raska);
            gradovi.Add(ruma);
            gradovi.Add(sabac);
            gradovi.Add(senta);
            gradovi.Add(sid);
            gradovi.Add(smederevo);
            gradovi.Add(smederevskaPalanka);
            gradovi.Add(sokobanja);
            gradovi.Add(sombor);
            gradovi.Add(sremskaMitrovica);
            gradovi.Add(sremskiKarlovci);
            gradovi.Add(staraPazova);
            gradovi.Add(subotica);
            gradovi.Add(surcin);
            gradovi.Add(temerin);
            gradovi.Add(topola);
            gradovi.Add(trstenik);
            gradovi.Add(tutin);
            gradovi.Add(ub);
            gradovi.Add(uzice);
            gradovi.Add(valjevo);
            gradovi.Add(velikoGradiste);
            gradovi.Add(vlasotince);
            gradovi.Add(vranje);
            gradovi.Add(vrnjackaBanja);
            gradovi.Add(vrsac);
            gradovi.Add(zajecar);
            gradovi.Add(zlatibor);
            gradovi.Add(zrenjanin);


            #endregion

            #region Tablice
            tablice = new List<Tablice>();
            VratiSveTablice();


            #endregion



        }

        public async void VratiSveTablice()
        {
            try
            {
                tablice = await App.Database.GetTabliceAsync();
                if (tablice.Count > 0)
                {
                    TabIma = true;
                }
            }
            catch (Exception)
            {

            }
            
        }

        public async void SacuvajTablicu(Tablice lista)
        {
            await App.Database.AddTablice(lista);

        }
    }
}
