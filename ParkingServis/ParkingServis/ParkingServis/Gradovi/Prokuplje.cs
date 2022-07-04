using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Prokuplje : Grad
    {
        public Zona ExtraZona { get; set; }
        public Zona Zona1 { get; set; }

        public Prokuplje() : base("Prokuplje")
        {
            ExtraZona = new Zona("Extra Zona", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(60 din/sat)", 9270);
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(36 din/sat)", 9271);
            zonaList.Add(ExtraZona); 
            zonaList.Add(Zona1);
            
        }
    }
}
