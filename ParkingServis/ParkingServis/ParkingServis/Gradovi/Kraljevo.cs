using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;
namespace ParkingServis.Gradovi
{
    public class Kraljevo : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Kraljevo() : base("Kraljevo")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 20h,Subotom od 8h do 15h", "(39 din/sat)", 9361);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 20h,Subotom od 8h do 15h", "(28 din/sat)", 9362);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za zonu 2 i 3", "(160din/dan)", 9365);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
