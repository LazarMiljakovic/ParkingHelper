using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class VrnjackaBanja : Grad
    {
        public Zona ExtraZona { get; set; }
        public Zona Zona1 { get; set; }
        public Zona Zona1dnevnaKarta { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2dnevnaKarta { get; set; }

        public VrnjackaBanja() : base("Vrnjacka Banja")
        {
            ExtraZona = new Zona("Extra Zona", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(45 din/sat)", 9630);
            Zona1 = new Zona("Zona 1", "Maksimalno 180 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(40 din/sat)", 9631);
            Zona1dnevnaKarta = new Zona("Dnevna karta Zona 1", "Ceo dan", "Vazi za zonu 1", "(155din/dan)", 9633);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(40 din/sat)", 9632);
            Zona2dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Samo za zonu 2", "(155din/dan)", 9634);
            zonaList.Add(ExtraZona);
            zonaList.Add(Zona1);
            zonaList.Add(Zona1dnevnaKarta);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2dnevnaKarta);
        }
    }
}
