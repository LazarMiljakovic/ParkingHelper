using ParkingServis.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.Gradovi
{
    public class Sombor : Grad
    {
        public Zona ExtraZona { get; set; }
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona3 { get; set; }
        public Zona dnevnaKarta { get; set; }

        public Sombor() : base("Sombor")
        {
            ExtraZona = new Zona("Extra Zona", "Maksimalno 120 minuta", "Radnim danima od 7h do 20h,Subotom od 7h do 13h", "(43 din/sat)", 9250);
            Zona1 = new Zona("Zona 1", "Neograniceno", "Radnim danima od 7h do 20h,Subotom od 7h do 13h", "(37 din/sat)", 9251);
            Zona2 = new Zona("Zona 2", "Neograniceno", "Radnim danima od 7h do 20h,Subotom od 7h do 13h", "(25 din/sat)", 9252);
            Zona3 = new Zona("Zona 3", "Celodnevna karta", "Radnim danima od 7h do 15h,Subotom od 7h do 13h", "(52 din/dan)", 9253);
            dnevnaKarta = new Zona("Dnevna karta", "Ceo dan", "Vazi za sve zone u kojima nema ogranicenja i kombinovano", "(175 din/dan)", 9255);
            zonaList.Add(ExtraZona);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(Zona3);
            zonaList.Add(dnevnaKarta);

        }
    }
}
