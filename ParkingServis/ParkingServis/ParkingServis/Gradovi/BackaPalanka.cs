using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;


namespace ParkingServis.Gradovi
{
    public class BackaPalanka : Grad
    {
        public Zona ExtraZona { get; set; }
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public BackaPalanka():base("Backa Palanka")
        {
            ExtraZona = new Zona("Extra Zona", "", "Radnim danima od 7h do 20h,Subotom od 7h do 14h", "(50 din/sat)", 8420);
            Zona1 = new Zona("Zona 1", "", "Radnim danima od 7h do 20h,Subotom od 7h do 14h", "(36 din/sat)", 8421);
            Zona2 = new Zona("Zona 2", "", "Radnim danima od 7h do 20h,Subotom od 7h do 14h", "(22 din/sat)", 8422);
            dnevnaKarta = new Zona("Dnevna karta ", "Ceo dan", "Samo za zonu 2", "", 8423);
            zonaList.Add(ExtraZona);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(dnevnaKarta);

        }

    }
}
