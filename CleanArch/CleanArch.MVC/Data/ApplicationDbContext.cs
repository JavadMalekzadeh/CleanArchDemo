using CleanArch.MVC.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.MVC.Data
{
    public class ApplicationDbContext
    {
        private readonly IMongoDatabase _database = null;

        public ApplicationDbContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        //public IMongoCollection<Note> Notes
        //{
        //    get
        //    {
        //        return _database.GetCollection<Note>("Note");
        //    }
        //}
    }
}
