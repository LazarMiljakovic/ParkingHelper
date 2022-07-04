using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;


namespace ParkingServis.Gradovi
{
    public class Arandjelovac : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2Dnevna { get; set; }
        public Zona Zona3 { get; set; }
        public Zona Zona3Dnevna { get; set; }

        public Arandjelovac() : base("Arandjelovac")
        {
            Zona1 = new Zona("Zona 1","Maksimalno 180 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h","prvi sat 42 din, drugi sat 54 din, treci sat 78 din",9341);
            Zona2 = new Zona("Zona 2", "Bez ogranicenja", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(30 din/sat)", 9342);
            Zona2Dnevna = new Zona("Zona 2 dnevna", "Bez ogranicenja", "Dnevna karta za zonu 2", "(210 din/dan)", 9343);
            Zona3 = new Zona("Zona 3", "Bez ogranicenja", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(50 din/sat)", 9344);
            Zona3Dnevna = new Zona("Zona 3 dnevna", "Bez ogranicenja", "Dnevna karta za zonu 3", "(250 din/dan)", 9345);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2Dnevna);
            zonaList.Add(Zona3);
            zonaList.Add(Zona3Dnevna);

        }
    }
}
