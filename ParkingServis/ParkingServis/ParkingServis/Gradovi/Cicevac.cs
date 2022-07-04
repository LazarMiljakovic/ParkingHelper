using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Cicevac : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Cicevac() : base("Cicevac")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(30 din/sat)", 7370);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za zonu 1", "(120din/dan)", 7371);
            zonaList.Add(Zona1);
            zonaList.Add(dnevnaKarta);
        }
    }
}
