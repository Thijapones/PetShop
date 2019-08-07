using PetShopLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopLibrary.Services.Interfaces
{
    public interface IPetServices
    {
        Pet PetGetbyId(int id);

        List<Pet> PetQueryAll();

        bool PetInsert(Pet obj);

        bool PetDelete(int petid);

        bool PetUpdate(Pet obj);
    }
}

