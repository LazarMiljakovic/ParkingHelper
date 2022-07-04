using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Leskovac : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Leskovac() : base("Leskovac")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(27 din/sat)", 8160);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(22 din/sat)", 8161);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(100din/dan)", 8162);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
