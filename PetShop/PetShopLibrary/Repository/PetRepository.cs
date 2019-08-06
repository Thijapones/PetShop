using MongoDB.Driver;
using PetShopLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopLibrary.Repository
{
    public sealed class PetRepository : Repository<Pet>
    { 
        public PetRepository(string connectionString, string databaseName) : base(connectionString, databaseName)
        {

        }
    }
}
