using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class BelaCrkva : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Turisticka { get; set; }
        public Zona DnevnaKarta { get; set; }

        public BelaCrkva() : base("Bela Crkva")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 8h do 21h,Subotom od 8h do 14h", "(35 din/sat)", 7131);
            Turisticka = new Zona("Turisticka Zona", "Neograniceno", "Svim danima od 8h do 21h", "(35 din/sat)", 7133);
            DnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(150din/dan)", 7134);
            zonaList.Add(Zona1);
            zonaList.Add(Turisticka);
            zonaList.Add(DnevnaKarta);
        }
    }
}
