using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core;

namespace CleanArch.Infra.Data.Context
{
    public class Setting
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
    public interface IUniversityDBContext
    {      
        IMongoCollection<Course> Courses { get; }
    }
    public class UniversityDBContext : IUniversityDBContext
    {
        public readonly IMongoDatabase _db;
        public UniversityDBContext(IOptions<Setting> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<Course> Courses => _db.GetCollection<Course>("Coursers");
    }
}
