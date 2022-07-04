using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Negotin : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona1dnevnaKarta { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2dnevnaKarta { get; set; }

        public Negotin() : base("Negotin")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 8h do 15h,Subotom od 8h do 14h", "(40 din/sat)", 9391);
            Zona1dnevnaKarta = new Zona("Dnevna karta Zona 1", "Ceo dan", "Samo za zonu 1", "(200 din/dan)", 9390);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 8h do 15h,Subotom od 8h do 14h", "(30 din/sat)", 9392);
            Zona2dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Samo za zonu 2", "(150 din/dan)", 9394);
            zonaList.Add(Zona1);
            zonaList.Add(Zona1dnevnaKarta);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2dnevnaKarta);
        }
    }
}
