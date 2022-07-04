using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Paracin : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona1dnevnaKarta { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2dnevnaKarta { get; set; }
        public Zona Zona3dnevnaKarta { get; set; }

        public Paracin() : base("Paracin")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 20h,Subotom od 7h do 15h", "(40 din/sat)", 9351);
            Zona1dnevnaKarta = new Zona("Dnevna karta Zona 1", "Ceo dan", "Samo za zonu 1", "(150din/dan)", 9350);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 20h,Subotom od 7h do 15h", "(30 din/sat)", 9352);
            Zona2dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Samo za zonu 2", "(100din/dan)", 9354);
            Zona3dnevnaKarta = new Zona("Dnevna karta Zona 3", "Ceo dan", "Samo za zonu 3", "(40din/dan)", 9353);
            zonaList.Add(Zona1);
            zonaList.Add(Zona1dnevnaKarta);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2dnevnaKarta);
            zonaList.Add(Zona3dnevnaKarta);

        }
    }
}
