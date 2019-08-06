
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using PetShopLibrary.Repository.Interfaces;
using PetShopLibrary.Entities;
using PetShopLibrary.Repository;

namespace PetShopLibrary.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly ConnectionFactory _connectionFactory;
        private readonly string _databaseName;
        private readonly IMongoCollection<T> _collection;

        protected Repository(string connectionString, string databaseName)
        {
            _connectionFactory = new ConnectionFactory(connectionString);
            _databaseName = databaseName;
            _collection = _connectionFactory.GetDataBase(_databaseName).GetCollection<T>(nameof(T));
        }
        public List<T> QueryAll()
        {
            var data = _collection.AsQueryable().ToList();

            return data;
        }

        public bool Insert(T obj)
        {
            _collection.InsertOne(obj);

            return true;
        }

        public bool Delete(int petid)
        {
            _collection.DeleteOne((a) => a.Id == petid);

            return true;
        }

        public bool Update(T obj)
        {
            _collection.ReplaceOne((a) => a.Id == obj.Id, obj);
            return true;
        }

        protected IMongoCollection<T> GetCollection()
        {
            return _collection;
        }
    }
}
