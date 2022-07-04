using System;
using System.Collections.Generic;
using System.Text;


namespace ParkingServis.Models
{
    public class Zona
    {
        public string Naziv { get; set; }

        public string MaxZadrzavanje { get; set; }

        public string VremeNaplate { get; set; }

        public string Cena { get; set; }

        public int BrojZaPoruku { get; set; }

        public Zona(string naziv,string maxZadrzavanje,string vremeNaplate,string cena,int brojZaPoruku)
        {
            Naziv = naziv;
            MaxZadrzavanje = maxZadrzavanje;
            VremeNaplate = vremeNaplate;
            Cena = cena;
            BrojZaPoruku = brojZaPoruku;
        }
        public Zona()
        {

        }
    }
}
