using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Pancevo : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }
        public Zona Zona3 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Pancevo() : base("Pancevo")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(35 din/sat)", 9131);
            Zona2 = new Zona("Zona 2", "Maksimalno 240 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(30 din/sat)", 9132);
            Zona3 = new Zona("Zona 3", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(20 din/sat)", 9134);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za zonu 3", "(80din/dan)", 9133);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(Zona3);
            zonaList.Add(dnevnaKarta);
        }
    }
}
