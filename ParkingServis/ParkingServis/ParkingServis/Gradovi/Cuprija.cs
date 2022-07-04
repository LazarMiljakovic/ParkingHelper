using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Cuprija : Grad
    {
        public Zona ExtraZona { get; set; }
        public Zona Zona1 { get; set; }
        public Zona Zona1dnevnaKarta { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2dnevnaKarta { get; set; }

        public Cuprija() : base("Cuprija")
        {
            ExtraZona = new Zona("Extra Zona", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(36 din/sat)", 3520);
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(36 din/sat)", 3521);
            Zona1dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Samo za zonu 1", "(145din/dan)", 3523);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(25 din/sat)", 3522);
            Zona2dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Samo za zonu 2", "(90din/dan)", 3524);
            zonaList.Add(ExtraZona);
            zonaList.Add(Zona1);
            zonaList.Add(Zona1dnevnaKarta);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2dnevnaKarta);
        }
    }
}
