using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Knjazevac : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Knjazevac() : base("Knjazevac")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(40 din/sat)", 8191);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(30 din/sat)", 8192);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(120din/dan)", 8193);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
