using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Vrsac : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }
        public Zona StaraZelenaPijaca { get; set; }

        public Vrsac() : base("Vrsac")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(30 din/sat)", 8131);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(25 din/sat)", 8132);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(200 din/dan)", 8133);
            StaraZelenaPijaca = new Zona("Stara zelena pijaca", "Ceo dan", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(70 din/dan)", 8134);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
            zonaList.Add(StaraZelenaPijaca);
        }
    }
}
