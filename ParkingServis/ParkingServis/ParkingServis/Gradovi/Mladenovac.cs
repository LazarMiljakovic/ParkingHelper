using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Mladenovac : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Mladenovac() : base("Mladenovac")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 180 minuta", "Radnim danima od 7h do 20h,Subotom od 7h do 14h", "(42 din/1. i 2.sat, 84 din/3.sat)", 9821);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 20h,Subotom od 7h do 14h", "(30 din/sat)", 9822);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za zonu 2", "(180din/dan)", 9820);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
