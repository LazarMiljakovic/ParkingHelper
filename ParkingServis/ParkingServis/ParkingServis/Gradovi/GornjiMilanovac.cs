using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class GornjiMilanovac : Grad
    {
        public Zona ExtraZona { get; set; }
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public GornjiMilanovac() : base("Gornji Milanovac")
        {
            ExtraZona = new Zona("Extra Zona", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(35 din/sat)", 7320);
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(35 din/sat)", 7321);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(20 din/sat)", 7322);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(158 din/dan)", 7325);
            zonaList.Add(ExtraZona);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);

        }
    }
}
