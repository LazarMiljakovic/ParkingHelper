using System;
using System.Collections.Generic;
using System.Text;
using ParkingServis.Models;

namespace ParkingServis.Gradovi
{
    public class Grad
    {
        public string Naziv { get; set; }
        public IList<Zona> zonaList;
        
        public Grad(string naziv)
        {
            Naziv = naziv;
            zonaList = new List<Zona>();
            
        }
    }
}
