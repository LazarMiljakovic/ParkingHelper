using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Zrenjanin : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona1Dnevna { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2Dnevna { get; set; }
        public Zona Zona3 { get; set; }
        public Zona Zona3Dnevna { get; set; }

        public Zrenjanin() : base("Zrenjanin")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(50 din/sat)", 8230);
            Zona1Dnevna = new Zona("Zona 1 dnevna", "Bez ogranicenja", "Dnevna karta za zonu 1", "(210 din/dan)", 8235);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(40 din/sat)", 8231);
            Zona2Dnevna = new Zona("Zona 2 dnevna", "Bez ogranicenja", "Dnevna karta za zonu 2", "(210 din/dan)", 8236);
            Zona3 = new Zona("Zona 3", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(30 din/sat)", 8232);
            Zona3Dnevna = new Zona("Zona 3 dnevna", "Bez ogranicenja", "Dnevna karta za zonu 3", "(250 din/dan)", 8237);
            zonaList.Add(Zona1);
            zonaList.Add(Zona1Dnevna);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2Dnevna);
            zonaList.Add(Zona3);
            zonaList.Add(Zona3Dnevna);

        }
    }
}
