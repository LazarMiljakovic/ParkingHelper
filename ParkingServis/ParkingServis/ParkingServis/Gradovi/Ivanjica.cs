using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Ivanjica : Grad
    {
        public Zona Zona { get; set; }
        public Zona Zona2 { get; set; }

        public Ivanjica() : base("Ivanjica")
        {
            Zona = new Zona("Zona", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(35 din/sat)", 8321);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(25 din/sat)", 8322);
            zonaList.Add(Zona);
            zonaList.Add(Zona2);
        }

    }
}
