using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Topola : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Topola() : base("Topola")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(33 din/sat)", 8444);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(27 din/sat)", 8445);
            dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Vazi za zonu 2", "", 8447);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
