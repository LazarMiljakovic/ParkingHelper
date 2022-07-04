using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Lazarevac : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Lazarevac() : base("Lazarevac")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 180 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(36 din/sat)", 9281);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(29 din/sat)", 9282);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za Zonu 2", "(119din/dan)", 9280);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
