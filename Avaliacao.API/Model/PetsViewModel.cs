using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Model
{
    public class PetsViewModel
    {       
        public Guid PetId { get; set; }
        public string PetName { get; set; }
        public StatusHealth StatusHealth { get; set; }
        public string PetJustification { get; set; }             
        public PetOwner PetOwner { get; set; }
        public Accommodation Accommodation { get; set; }
    }
}
