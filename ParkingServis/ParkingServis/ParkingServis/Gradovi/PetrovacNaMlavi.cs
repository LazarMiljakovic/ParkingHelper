using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class PetrovacNaMlavi : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }

        public PetrovacNaMlavi() : base("Petrovac na Mlavi")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(40 din/sat)", 8611);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 15h", "(30 din/sat)", 8612);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
        }
    }
}
