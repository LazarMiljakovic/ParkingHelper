using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Cacak : Grad
    {
        public Zona ExtraZona { get; set; }
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona3 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Cacak() : base("Cacak")
        {
            ExtraZona = new Zona("Extra Zona", "Maksimalno 120 minuta", "Radnim danima od 7h do 22h,Subotom od 7h do 15h", "(65 din/sat)", 9320);
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 22h,Subotom od 7h do 15h", "(50 din/sat)", 9321);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 22h,Subotom od 7h do 15h", "(30 din/sat)", 9322);
            Zona3 = new Zona("Zona 3", "Neograniceno", "Radnim danima od 7h do 16h,Subotom od 7h do 15h", "(19 din/sat)", 9323);
            dnevnaKarta = new Zona("Dnevna karta ", "Ceo dan", "Vazi za zonu 2 i zonu 3", "(190din/dan)", 9325);
            zonaList.Add(ExtraZona);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(Zona3);
            zonaList.Add(dnevnaKarta);
        }
    }
}
