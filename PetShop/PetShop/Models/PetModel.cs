using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class PetModel
    {
        public int Id { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Brand { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
