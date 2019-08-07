using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopLibrary.Entities
{
    [BsonIgnoreExtraElements]
    public sealed class Pet : Entity
        {
            public string PetName { get; set; }
            public string Species { get; set; }
            public string Brand { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public string PetOwner { get; set; }
        }
}
