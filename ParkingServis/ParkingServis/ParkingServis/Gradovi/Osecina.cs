using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Osecina : Grad
    {
        public Zona PlavaZona { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Osecina() : base("Osecina")
        {
            PlavaZona = new Zona("Plava Zona", "Neograniceno", "Radnim danima od 7h do 17h,Subotom od 7h do 13h", "(24 din/sat)", 8141);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za plavu zonu", "(110din/dan)", 8142);
            zonaList.Add(PlavaZona);
            zonaList.Add(dnevnaKarta);
        }
    }
}
