using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Ub : Grad
    {
        public Zona ExtraZona { get; set; }

        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Ub() : base("Ub")
        {
            ExtraZona = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 19h,Subotom od 7h do 12h", "(80 din/sat)", 9043);
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 19h,Subotom od 7h do 12h", "(40 din/sat)", 9041);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 15h", "(25 din/sat)", 9042);
            dnevnaKarta = new Zona("Dnevna karta Zona 2", "Ceo dan", "Vazi za zonu 2", "(120 din/dan)", 9040);
            zonaList.Add(ExtraZona);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
