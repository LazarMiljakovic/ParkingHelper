using ParkingServis.User;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis
{
    public class DatebaseHelper
    {

        private readonly SQLiteAsyncConnection _database;

        public DatebaseHelper(string dbpath)
        {
            _database = new SQLiteAsyncConnection(dbpath);
            _database.CreateTableAsync<Tablice>();

        }

        public Task<List<Tablice>> GetTabliceAsync ()
        {
            return _database.Table<Tablice>().ToListAsync();
        }

        public Task<int> AddTablice(Tablice tablice)
        {
            return _database.InsertAsync(tablice);

        }



    }
}
