using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Jagodina : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }

        public Jagodina() : base("Jagodina")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(42 din/sat)", 3501);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(36 din/sat)", 3502);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
        }
    }
}
