using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Pozarevac : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2dnevnaKarta { get; set; }
        public Zona BZona { get; set; }

        public Pozarevac() : base("Pozarevac")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 180 minuta", "Radnim danima od 8h do 20h,Subotom od 8h do 14h", "(45 din/sat)", 8121);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 8h do 20h,Subotom od 8h do 14h", "(33 din/sat)", 8122);
            Zona2dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Vazi za zonu 2", "(150din/dan)", 8123);
            BZona = new Zona("B Zona", "Maksimalno 120 minuta", "Radnim danima od 8h do 20h,Subotom od 8h do 14h", "(60 din/sat)", 8120);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2dnevnaKarta);
            zonaList.Add(BZona);
        }
    }
}
