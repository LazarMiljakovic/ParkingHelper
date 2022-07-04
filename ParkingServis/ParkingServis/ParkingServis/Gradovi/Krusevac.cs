using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Krusevac : Grad
    {
        public Zona ExtraZona { get; set; }
        public Zona Zona1 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Krusevac() : base("Krusevac")
        {
            ExtraZona = new Zona("Extra Zona", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(40 din/sat)", 9371);
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(35 din/sat)", 9372);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za sve zone", "(150 din/dan)", 9370);
            zonaList.Add(ExtraZona);
            zonaList.Add(Zona1);
            zonaList.Add(dnevnaKarta);

        }

    }
}
