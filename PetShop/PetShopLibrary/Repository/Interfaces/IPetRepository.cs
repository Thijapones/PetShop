using PetShopLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopLibrary.Repository.Interfaces
{
    public interface IPetRepository : IRepository<Pet>
    {
        List<Pet> PetQueryAll();

        bool PetInsert(Pet obj);

        bool PetDelete(int petid);

        bool PetUpdate(Pet obj);

        Pet GetPetbyId(int id);
    }
}
