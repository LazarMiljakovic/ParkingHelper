using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Obrenovac : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Obrenovac() : base("Obrenovac")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 6h do 20h,Subotom od 6h do 14h", "(40 din/sat)", 9871);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 6h do 20h,Subotom od 6h do 14h", "(35 din/sat)", 9872);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za zonu 2", "(120din/dan)", 9870);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
