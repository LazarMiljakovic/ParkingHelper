using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Sokobanja : Grad
    {
        public Zona Zona1 { get; set; }

        public Zona PosebnaZona { get; set; }

        public Zona dnevnaKarta { get; set; }

        public Sokobanja() : base("Sokobanja")
        {
            Zona1 = new Zona("Zona 1", "Maksimalno 180 minuta u sezoni, neograniceno van sezone", "", "(32 din/sat)", 9108);
            PosebnaZona = new Zona("Posebna Zona", "Neograniceno", "", "(40 din/sat)", 9109);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za obe zone", "(100din/dan)", 9110);
            zonaList.Add(Zona1);
            zonaList.Add(PosebnaZona);
            zonaList.Add(dnevnaKarta);
        }
    }
}
