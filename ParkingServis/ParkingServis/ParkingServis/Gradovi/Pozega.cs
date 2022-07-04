using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Pozega : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Pozega() : base("Pozega")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 19h,Subotom od 7h do 14h", "(35 din/sat)", 8441);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 19h,Subotom od 7h do 14h", "(25 din/sat)", 8442);
            dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Vazi za zonu 2", "(100din/dan)", 8443);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
