using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;
namespace ParkingServis.Gradovi
{
    public class Dimitrovgrad : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona1dnevnaKarta { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2dnevnaKarta { get; set; }

        public Dimitrovgrad() : base("Dimitrovgrad")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 19h,Subotom od 7h do 15h", "(30 din/sat)", 8451);
            Zona1dnevnaKarta = new Zona("Dnevna karta Zona 1", "Ceo dan", "Samo za zonu 1", "(120din/dan)", 8453);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 19h,Subotom od 7h do 15h", "(20 din/sat)", 8452);
            Zona2dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Samo za zonu 2", "(100din/dan)", 8454);
            zonaList.Add(Zona1);
            zonaList.Add(Zona1dnevnaKarta);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2dnevnaKarta);
        }
    }
}
