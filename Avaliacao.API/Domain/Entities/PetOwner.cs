using System;

namespace Avaliacao.API.Domain.Entities
{
    public class PetOwner
    {
        public Guid Id { get; set; }
        public string OwnerName  { get; set; }
        public string Phone { get; set; }
        public Adress Adress { get; set; }
    }
}
