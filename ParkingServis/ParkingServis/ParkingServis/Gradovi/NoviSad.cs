using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class NoviSad : Grad
    {
        public Zona CrvenaZona { get; set; }
        public Zona PlavaZona { get; set; }
        public Zona BelaZona { get; set; }
        public Zona DnevnaKarta { get; set; }
        public Zona Strand { get; set; }
        public Zona Najlon { get; set; }
        public Zona Sajam { get; set; }

        public NoviSad() : base("Novi Sad")
        {
            CrvenaZona = new Zona("Crvena Zona", "Maksimalno 120 minuta", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(53 din/sat)", 8211);
            PlavaZona = new Zona("Plava Zona", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(44 din/sat)", 8212);
            BelaZona = new Zona("Bela Zona", "Neograniceno", "Radnim danima od 7h do 21h,Subotom od 7h do 14h", "(30 din/sat)", 8218);
            DnevnaKarta = new Zona("Dnevna Karta", "Dnevna karta", "Vazi za belu zonu i pojedine delove plave zone gde je nadznaceno tablom", "(95 din/dan)", 8215);
            Strand = new Zona("Strand", "Neograniceno", "Dnevna karta", "(35 din/dan)", 8213);
            Najlon = new Zona("Najlon", "Neograniceno", "Dnevna karta", "(75 din/dan)", 8214);
            Sajam = new Zona("Sajam", "Neograniceno", "Dnevna karta, naplata za vreme trajanja sajamskih manifestacija", "(250 din/dan)", 8288);
            zonaList.Add(CrvenaZona);
            zonaList.Add(PlavaZona);
            zonaList.Add(BelaZona);
            zonaList.Add(DnevnaKarta);
            zonaList.Add(Strand);
            zonaList.Add(Najlon);
            zonaList.Add(Sajam);
        }
    }
}
