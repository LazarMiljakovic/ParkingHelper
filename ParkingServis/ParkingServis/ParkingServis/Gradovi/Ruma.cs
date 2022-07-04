using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Ruma : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona1dnevnaKarta { get; set; }
        public Zona Zona2dnevnaKarta { get; set; }
        public Zona Zona2dnevnaKartaTeretna { get; set; }

        public Ruma() : base("Ruma")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 20h,Subotom od 7h do 14h", "(37 din/sat)", 9721);
            Zona1dnevnaKarta = new Zona("Dnevna karta Zona 1", "Ceo dan", "Samo za zonu 1", "(117 din/dan)", 9722);
            Zona2dnevnaKarta = new Zona("Dnevna karta Zona 2: Putnicka vozila", "Ceo dan", "Samo za zonu 2 : Putnicka vozila", "(90 din/dan)", 9723);
            Zona2dnevnaKartaTeretna = new Zona("Dnevna karta Zona 2: Teretna vozila","Ceo dan", "Samo za zonu 2 : Teretna vozila", "(175 din/dan)", 9724);

            zonaList.Add(Zona1);
            zonaList.Add(Zona1dnevnaKarta);
            zonaList.Add(Zona2dnevnaKarta);
            zonaList.Add(Zona2dnevnaKartaTeretna);
        }
    }
}
