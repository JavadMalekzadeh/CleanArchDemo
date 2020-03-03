using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Driver.Core;

namespace CleanArch.Infra.Data.Context
{
    public class Setting
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
    public interface IGameContext
    {
       
        IMongoCollection<Game> Games { get; }
    }
    class UniversityDBContext
    {

    }
}
