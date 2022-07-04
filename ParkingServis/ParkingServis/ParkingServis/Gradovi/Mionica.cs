using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Mionica : Grad
    {
        public Zona CrvenaZona { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Mionica() : base("Mionica")
        {
            CrvenaZona = new Zona("Crvena Zona", "Neograniceno", "Radnim danima od 7h do 17h,Subotom od 7h do 13h", "(24 din/sat)", 8411);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "", "(110din/dan)", 8412);
            zonaList.Add(CrvenaZona);
            zonaList.Add(dnevnaKarta);
        }
    }
}
