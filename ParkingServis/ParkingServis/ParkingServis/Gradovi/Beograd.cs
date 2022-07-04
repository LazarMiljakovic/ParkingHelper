using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;


namespace ParkingServis.Gradovi
{
    public class Beograd : Grad
    {
        public Zona ZonaA { get; set; }
        public Zona Zona1 { get; set; }
        public Zona Zona2 { get; set; }
        public Zona Zona3 { get; set; }
        public Zona BezOgranicenja { get; set; }
        public Zona BezOgranicenjaDnevnaKarta { get; set; }
        public Zona Blok42iVidin { get; set; }
        public Zona Blok42iVidinViseSatna { get; set; }
        public Zona SavaPromenada { get; set; }
        public Zona SavaPromenadaViseSatna { get; set; }

        public Beograd() : base("Beograd")
        {
            ZonaA = new Zona("Zona A", "Maksimalno 30 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(100 din/30 minuta)", 9114);
            Zona1 = new Zona("Zona 1", "Maksimalno 90 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(56 din/sat, 100din dodatnih 30 minuta)", 9111);
            Zona2 = new Zona("Zona 2", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(48 din/sat, 180din dodatnih sat vremena)", 9112);
            Zona3 = new Zona("Zona 3", "Maksimalno 180 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(41 din/sat, 140din dodatnih sat vremena)", 9113);
            BezOgranicenja = new Zona("Bez ogranicenja", "Nema ogranicenja", "Radnim danima od 8h do 21h(na nekim mestima do 17h),Subotom od 8h do 14h", "(31 din/sat)", 9119);
            BezOgranicenjaDnevnaKarta = new Zona("Bez ogranicenja - dnevna karta", "Dnevna karta", "Radnim danima od 8h do 21h(na nekim mestima do 17h),Subotom od 8h do 14h", "(150 din/dan)", 9118);
            Blok42iVidin = new Zona("Blok42 i Vidin kapija", "Maksimalno 60 minuta", "Od 00h do 24h", "(50 din/sat)", 8115);
            Blok42iVidinViseSatna = new Zona("Blok42 i Vidin kapija - Visestana karta", "Visesatno parkiranje", "Vazi od trenutka slanja poruke do ponoci", "(450din)", 8116);
            SavaPromenada = new Zona("Sava Promenada", "Maksimalno 60 minuta", "Od 00h do 24h", "(70 din/sat)", 8117);
            SavaPromenadaViseSatna = new Zona("Sava Promenada - Visestana karta", "Visesatno parkiranje", "Vazi od trenutka slanja poruke do ponoci", "(630din)", 8110);
            zonaList.Add(ZonaA);
            zonaList.Add(Zona1);
            zonaList.Add(Zona2);
            zonaList.Add(Zona3);
            zonaList.Add(BezOgranicenja);
            zonaList.Add(BezOgranicenjaDnevnaKarta);
            zonaList.Add(Blok42iVidin);
            zonaList.Add(Blok42iVidinViseSatna);
            zonaList.Add(SavaPromenada);
            zonaList.Add(SavaPromenadaViseSatna);
        }



    }
}
