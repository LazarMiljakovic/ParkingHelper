using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Becej : Grad
    {
        public Zona CentralnaZona { get; set; }
        public Zona DnevnaKarta { get; set; }

        public Becej() : base("Becej")
        {
            CentralnaZona = new Zona("Centralna Zona", "Neograniceno", "Radnim danima od 7h do 19h,Subotom od 7h do 12h", "(30 din/sat)", 8521);
            DnevnaKarta = new Zona("Dnevna Karta", "Dnevna karta za centralnu zonu", "Radnim danima od 7h do 19h,Subotom od 7h do 12h", "(120 din/dan)", 8522);
            zonaList.Add(CentralnaZona);
            zonaList.Add(DnevnaKarta);
        }
    }
}
