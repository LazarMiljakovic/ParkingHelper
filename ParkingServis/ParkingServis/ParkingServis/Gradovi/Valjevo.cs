using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Valjevo : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Valjevo() : base("Valjevo")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 180 minuta", "Radnim danima od 7h do 20h,Subotom od 7h do 14h", "(40 din/sat)", 9141);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 20h,Subotom od 7h do 14h", "(25 din/sat)", 9142);
            dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Vazi za zonu 2", "(112din/dan)", 9140);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
