using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Aleksandrovac : Grad
    { 
        
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Aleksandrovac(): base("Aleksandrovac")
        {
            Zona1 = new Zona("Zona 1","Maksimalno 120 minuta","Radnim danima od 7h do 20h,Subotom od 7h do 14h","(30 din/sat)",8371);
            Zona2 = new Zona("Zona 2","Neograniceno","Radnim danima od 7h do 20h,Subotom od 7h do 14h","(25 din/sat)",8372);
            dnevnaKarta = new Zona("Dnevna karta","Ceo dan","Vazi za obe zone","(100din/dan)",8374);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);
        }
    }
}
