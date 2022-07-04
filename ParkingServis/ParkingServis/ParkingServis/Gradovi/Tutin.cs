using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Tutin : Grad
    {
        public Zona Zona1 { get; set; }

        public Tutin() : base("Tutin")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "", 9201);
            zonaList.Add(Zona1);
        }
    }
}
