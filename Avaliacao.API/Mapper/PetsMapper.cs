using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;

namespace Avaliacao.API.Mapper
{
    public static class PetsMapper
    {
        public static Pets ViewModelToEntity (this PetsViewModel petsVM)
        {
            if (petsVM == null)
            {
                return null;
            }

            var Pets = new Pets()
            {
                Id = petsVM.PetId,
                PetName = petsVM.PetName,
                PetOwner = petsVM.PetOwner,
                StatusHealth = petsVM.StatusHealth,
                Justification = petsVM.PetJustification,
                Accommodation = petsVM.Accommodation
            };

            return Pets;
        }

        public static PetsViewModel EntityToViewModel(this Pets pets)
        {
            if (pets == null)
            {
                return null;
            }

            var PetsViewModel = new PetsViewModel()
            {
                PetId = pets.Id,
                PetName = pets.PetName,
                StatusHealth = pets.StatusHealth,
                PetJustification = pets.Justification,
                PetOwner = pets.PetOwner,
                Accommodation = pets.Accommodation        
            };

            return PetsViewModel;
        }
    }
}
