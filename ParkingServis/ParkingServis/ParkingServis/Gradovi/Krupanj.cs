using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Krupanj : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Krupanj() : base("Krupanj")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 19h,Subotom od 7h do 14h", "(20 din/sat)", 8151);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za zonu 1", "(100din/dan)", 8152);
            zonaList.Add(Zona1);
            zonaList.Add(dnevnaKarta);
        }
    }
}
