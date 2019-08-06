using PetShopLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopLibrary.Repository.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        List<T> QueryAll();

        bool Insert(T obj);

        bool Delete(int petid);

        bool Update(T obj);
    }
}
