using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Subotica : Grad
    {
        public Zona Zona1 { get; set; }
        public Zona Zona1Dnevna { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona2i4Dnevna { get; set; }
        public Zona Zona3 { get; set; }
        public Zona Zona4 { get; set; }

        public Subotica() : base("Subotica")
        {
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(38,94 din/sat)", 9241);
            Zona1Dnevna = new Zona("Zona 1 dnevna", "Bez ogranicenja", "Dnevna(poslovna) karta za zonu 1", "(300 din/dan)", 9245);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(29,47 din/sat)", 9242);
            Zona2i4Dnevna = new Zona("Zona 2 i 4 dnevna", "Bez ogranicenja", "Dnevna(poslovna) karta za zonu 2 i 4", "(190,80 din/dan)", 9246);
            Zona3 = new Zona("Zona 3", "Neograniceno", "Naplata od 5h do 15h", "(82,10 din/sat)", 9243);
            Zona4 = new Zona("Zona 4", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(20,42 din/sat)", 9244);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(Zona3);  
            zonaList.Add(Zona4);
            zonaList.Add(Zona1Dnevna);
            zonaList.Add(Zona2i4Dnevna);

        }
    }
}
