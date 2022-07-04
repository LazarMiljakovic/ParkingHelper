using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Despotovac : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Despotovac() : base("Despotovac")
        {
            Zona1 = new Zona("Zona 1", "", "", "", 8351);
            Zona2 = new Zona("Zona 2", "", "", "", 8352);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "", 8353);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);

        }
    }
}
