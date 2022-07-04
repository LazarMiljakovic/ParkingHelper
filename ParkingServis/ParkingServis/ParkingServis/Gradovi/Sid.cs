using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Sid : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Sid() : base("Sid")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 19h,Subotom od 7h do 14h", "(40 din/sat)", 8621);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 19h,Subotom od 7h do 14h", "(30 din/sat)", 8622);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(180din/dan)", 8623);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
