using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Loznica : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Loznica() : base("Loznica")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(46 din/sat)", 9051);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(30 din/sat)", 9052);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(144din/dan)", 9050);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
