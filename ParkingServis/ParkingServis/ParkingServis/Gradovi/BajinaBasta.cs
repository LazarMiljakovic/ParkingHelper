using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class BajinaBasta : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona Zona2 { get; set; }

        public Zona Zona2DnevnaKarta { get; set; }

        public BajinaBasta() : base("Bajina Basta")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 120 minuta", "Radnim danima od 8h do 20h,Subotom od 8h do 14h", "(35 din/sat)", 8311);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 8h do 20h,Subotom od 8h do 14h", "(25 din/sat)", 8312);
            Zona2DnevnaKarta = new Zona("Zona 2 Dnevna karta", "Radnim danima od 8h do 20h,Subotom od 8h do 14h", "Vazi samo za zonu 2", "(100din/dan)", 8313);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(Zona2DnevnaKarta);
        }
    }
}
