using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Entities
{
    public class Pets
    {
        public Guid Id { get; set; }
        public string PetName { get; set; }
        public PetOwner PetOwner { get; set; }        
        public Guid StatusHealthId { get; set; }
        public StatusHealth StatusHealth { get; set; }
        public string Justification { get; set; }
        public Accommodation Accommodation { get; set; }

    }
}
