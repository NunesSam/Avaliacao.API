using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;

namespace Avaliacao.API.Mapper
{
    public static class PetOwnerMapper
    {
        public static PetOwnerViewModel EntityToViewModel(this PetOwner owner)
        {
            if (owner == null)
            {
                return null;
            }

            var PetOwnerViewModel = new PetOwnerViewModel()
            {
                PetOwnerId = owner.Id,
                PetOwnerName = owner.OwnerName,
                PetOwnerPhone = owner.Phone,
                PetOwnerAdress = owner.Adress,
                
            };

            return PetOwnerViewModel;
        }

        public static PetOwner ViewModelToEntity(this PetOwnerViewModel ower)
        {
            if (ower == null)
            {
                return null;
            }

            var PetOwner = new PetOwner()
            {
                Id = ower.PetOwnerId,
                OwnerName = ower.PetOwnerName,
                Phone = ower.PetOwnerPhone,
                Adress = ower.PetOwnerAdress
            };

            return PetOwner;
        }
    }
}
