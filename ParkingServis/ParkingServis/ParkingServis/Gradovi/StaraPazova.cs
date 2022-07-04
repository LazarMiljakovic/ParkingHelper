using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class StaraPazova : Grad
    {
        public Zona Bela { get; set; }

        public Zona Crvena { get; set; }

        public Zona dnevnaKarta { get; set; }

        public StaraPazova() : base("Stara Pazova")
        {
            Bela = new Zona("Bela Zona", "Neograniceno", "Radnim danima od 7h do 15h", "(35 din/sat)", 8201);
            Crvena = new Zona("Crvena Zona", "Neograniceno", "Radnim danima od 7h do 15h", "(25 din/sat)", 8202);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(100din/dan)", 8203);
            zonaList.Add(Bela);
            zonaList.Add(Crvena);
            zonaList.Add(dnevnaKarta);
        }
    }
}
