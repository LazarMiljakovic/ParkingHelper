using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class VelikoGradiste : Grad
    {
        public Zona Crvena { get; set; }
        public Zona dnevnaKarta { get; set; }

        public VelikoGradiste() : base("Veliko Gradiste")
        {
            Crvena = new Zona("Crvena Zona", "Neograniceno", "Radnim danima i subotom od 7h do 13h", "(36 din/sat)", 8821);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za sve zone", "(200din/dan)", 8822);
            zonaList.Add(Crvena);
            zonaList.Add(dnevnaKarta);
        }
    }
}
