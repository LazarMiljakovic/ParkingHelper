using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Kragujevac : Grad
    {
        public Zona Zona0 { get; set; }
        public Zona Zona0dnevnaKarta { get; set; }
        public Zona Zona1 { get; set; }
        public Zona Zona1dnevnaKarta { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2dnevnaKarta { get; set; }

        public Kragujevac() : base("Kragujevac")
        {
            Zona0 = new Zona("Zona 0", "Maksimalno 180 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(55-78 din/sat)", 8340);
            Zona0dnevnaKarta = new Zona("Dnevna karta Zona 0", "Ceo dan", "Samo za zonu 0", "(781din/dan)", 8346);
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(35 din/sat)", 8341);
            Zona1dnevnaKarta = new Zona("Dnevna karta Zona 1", "Ceo dan", "Samo za zonu 1", "(110din/dan)", 8343);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(24 din/sat)", 8342);
            Zona2dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Samo za zonu 2", "(99din/dan)", 8344);
            zonaList.Add(Zona0);
            zonaList.Add(Zona0dnevnaKarta);
            zonaList.Add(Zona1);
            zonaList.Add(Zona1dnevnaKarta);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2dnevnaKarta);
        }
    }
}
