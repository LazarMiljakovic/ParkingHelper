using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Indjija : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }

        public Indjija() : base("Indjija")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(35 din/sat)", 9221);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(35 din/2 sata)", 9222);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
        }
    }
}
