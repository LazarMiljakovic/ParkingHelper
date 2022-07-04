using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Zlatibor : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Zlatibor() : base("Zlatibor")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 180 minuta", "Svim danima od 7h do 21h", "(50 din/sat)", 8531);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Svim danima od 7h do 21h", "(40 din/sat)", 8532);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(500din/dan)", 8533);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
