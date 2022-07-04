using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class SremskiKarlovci : Grad
    {
        public Zona ZonaKarlovci { get; set; }

        public Zona ZonaKarlovciDnevna { get; set; }

        public Zona ZonaKarlovciBus { get; set; }

        public SremskiKarlovci() : base("Sremski Karlovci")
        {
            ZonaKarlovci = new Zona("Zona Sr. Karlovci", "Neograniceno", "Svim danima od 8h do 20h", "(45 din/sat)", 8831);
            ZonaKarlovciBus = new Zona("Zona Sr. Karlovci - Bus", "Neograniceno", "Svim danima od 8h do 20h", "(100 din/sat)", 8832);
            ZonaKarlovciDnevna = new Zona("Zona Sr. Karlovci - Dnevna", "Ceo dan", "Vazi za vreme manifestacija u gradu", "(200din/dan)", 8833);
            zonaList.Add(ZonaKarlovci);
            zonaList.Add(ZonaKarlovciBus);
            zonaList.Add(ZonaKarlovciDnevna);
        }
    }
}
