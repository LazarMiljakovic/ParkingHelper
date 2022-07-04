using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Smederevo : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }
        public Zona Zona3 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Smederevo() : base("Smederevo")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(40 din/sat)", 8661);
            Zona2 = new Zona("Zona 2", "Maksimalno 240 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(33 din/sat)", 8662);
            Zona3 = new Zona("Zona 3", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(27 din/sat)", 8663);
            dnevnaKarta = new Zona("Dnevna karta za Zonu 3", "Ceo dan", "Vazi za zonu 3", "(120din/dan)", 8664);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(Zona3);
            zonaList.Add(dnevnaKarta);
        }
    }
}
