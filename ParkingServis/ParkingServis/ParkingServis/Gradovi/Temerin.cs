using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Temerin : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Temerin() : base("Temerin")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 20h,Subotom od 7h do 13h", "(30 din/sat)", 8811);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za zonu 1", "(80din/dan)", 8812);
            zonaList.Add(Zona1);
            zonaList.Add(dnevnaKarta);
        }
    }
}
