using PetShopLibrary.Entities;
using PetShopLibrary.Repository.Interfaces;
using PetShopLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace PetShopLibrary.Services
{
    public class PetServices : IPetServices
    {
        private readonly IPetRepository _petRepository;

        public PetServices(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public Pet PetGetbyId(int id)
        {
            return _petRepository.GetPetbyId(id);
        }

        public List<Pet> PetQueryAll()
        {
            return _petRepository.PetQueryAll();
        }

        public bool PetInsert(Pet obj)
        {
            return _petRepository.PetInsert(obj);
        }

        public bool PetDelete(int petid)
        {
            return _petRepository.PetDelete(petid);
        }

        public bool PetUpdate(Pet obj)
        {
            return _petRepository.PetUpdate(obj);
        }
    }
}
