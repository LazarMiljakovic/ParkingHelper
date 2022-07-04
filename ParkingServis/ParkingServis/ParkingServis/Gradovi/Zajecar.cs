using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Zajecar : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona1dnevnaKarta { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2dnevnaKarta { get; set; }

        public Zajecar() : base("Zajecar")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "", 9191);
            Zona1dnevnaKarta = new Zona("Dnevna karta Zona 1", "Ceo dan", "Samo za zonu 1", "", 9194);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "", 9192);
            Zona2dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Samo za zonu 2", "", 9193);
            zonaList.Add(Zona1);
            zonaList.Add(Zona1dnevnaKarta);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2dnevnaKarta);
        }
    }
}
