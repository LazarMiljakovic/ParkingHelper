using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class SremskaMitrovica : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona1Dnevna { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2Dnevna { get; set; }
        public Zona Zona3 { get; set; }
        public Zona Zona3Dnevna { get; set; }
        public Zona Zona4 { get; set; }
        public Zona Zona4Dnevna { get; set; }

        public SremskaMitrovica() : base("Sremska Mitrovica")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 19h,Subotom od 7h do 14h", "(50 din/sat)", 8221);
            Zona1Dnevna = new Zona("Zona 1 dnevna", "Bez ogranicenja", "Dnevna karta za zonu 1", "(250 din/dan)", 8224);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima i subotom od 7h do 14h", "(35 din/sat)", 8222);
            Zona2Dnevna = new Zona("Zona 2 dnevna", "Bez ogranicenja", "Dnevna karta za zonu 2", "(120 din/dan)", 8225);
            Zona3 = new Zona("Zona 3", "Neograniceno", "Radnim danima 7h do 15h", "(35,5 din/sat)", 8223);
            Zona3Dnevna = new Zona("Zona 3 dnevna", "Bez ogranicenja", "Dnevna karta za zonu 3", "(120 din/dan)", 8226);
            Zona4 = new Zona("Zona 4", "Neograniceno", "Sezonski od 10.juna do 10. septembra, svaki dan od 8h do 20h", "(50 din/sat)", 8227);
            Zona4Dnevna = new Zona("Zona 4 dnevna", "Bez ogranicenja", "Sezonski od 10.juna do 10. septembra", "(170 din/dan)", 8228);
            zonaList.Add(Zona1);
            zonaList.Add(Zona1Dnevna);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2Dnevna);
            zonaList.Add(Zona3);
            zonaList.Add(Zona3Dnevna);
            zonaList.Add(Zona4);
            zonaList.Add(Zona4Dnevna);

        }
    }
}
