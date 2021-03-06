using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Surcin : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Surcin() : base("Surcin")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(30 din/sat)", 9081);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(25 din/sat)", 9082);
            dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Vazi za zonu 2", "(100din/dan)", 9080);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
