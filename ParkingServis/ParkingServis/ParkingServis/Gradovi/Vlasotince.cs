using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Vlasotince : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Vlasotince() : base("Vlasotince")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 19h,Subotom od 7h do 13h", "(30 din/sat)", 8601);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 19h,Subotom od 7h do 13h", "(25 din/sat)", 8602);
            dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Vazi za zonu 2", "(100 din/dan)", 8603);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
