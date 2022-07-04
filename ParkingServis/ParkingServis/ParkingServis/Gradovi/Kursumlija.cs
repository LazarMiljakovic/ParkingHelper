using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Kursumlija : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Kursumlija() : base("Kursumlija")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 15h,Subotom od 7h do 14h", "(30 din/sat)", 9971);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za zonu 1", "(180din/dan)", 9970);
            zonaList.Add(Zona1);
            zonaList.Add(dnevnaKarta);
        }
    }
}
