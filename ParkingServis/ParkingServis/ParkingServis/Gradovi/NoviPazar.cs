using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class NoviPazar : Grad
    {
        public Zona ExtraZona { get; set; }
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public NoviPazar() : base("Novi Pazar")
        {
            ExtraZona = new Zona("Extra Zona", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(50 din/sat)", 8630);
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 8h do 14h", "(40 din/sat)", 8631);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(30 din/sat)", 8632);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za zonu 2", "(200 din/dan)", 8634);
            zonaList.Add(ExtraZona);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
