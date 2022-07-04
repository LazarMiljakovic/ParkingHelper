using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingServis.User
{
    [Table("Tablice")]
    public class Tablice
    {
        [PrimaryKey]
        [Column("Tablica")]
        public string Tablica { get; set; }



    }
}
