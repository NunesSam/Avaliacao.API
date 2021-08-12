using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Model
{
    public class PetOwnerViewModel
    {
        public Guid PetOwnerId { get; set; }
        public string PetOwnerName { get; set; }
        public string PetOwnerPhone { get; set; }
        public Adress PetOwnerAdress { get; set; }
       
    }
    
}

