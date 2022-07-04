using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Senta : Grad
    {
        public Zona CrvenaZona { get; set; }
        public Zona PlavaZona { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Senta() : base("Senta")
        {
            CrvenaZona = new Zona("Crvena Zona", "Neograniceno", "Radnim danima od 7h do 19h,Subotom od 7h do 12h", "(35 din/sat)", 8241);
            PlavaZona = new Zona("Plava Zona", "Neograniceno", "Radnim danima od 7h do 19h,Subotom od 7h do 12h", "(25 din/sat)", 8242);
            dnevnaKarta = new Zona("Dnevna karta Plava Zona", "Ceo dan", "Vazi za plavu zonu", "(100din/dan)", 8243);
            zonaList.Add(CrvenaZona);
            zonaList.Add(PlavaZona);
            zonaList.Add(dnevnaKarta);
        }
    }
}
