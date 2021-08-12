using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;

namespace Avaliacao.API.Mapper
{
    public static class AccommodationMapper
    {
        public static AccommodationViewModel EntityToViewModel(this Accommodation Acc)
        {
            if (Acc == null)
            {
                return null;
            }
             
            var AccommodationViewModel = new AccommodationViewModel()
            {
                AccommodationId = Acc.Id,
                AccommodationStatus = Acc.Status,
                AccommodationDescription = Acc.Description
            };

            return AccommodationViewModel;
        }

        public static Accommodation ViewModelToEntity(this AccommodationViewModel AccVM)
        {
            if (AccVM == null)
            {
                return null;
            }

            var Accommodation = new Accommodation()
            {
                Id = AccVM.AccommodationId,
                Status = AccVM.AccommodationStatus,
                Description = AccVM.AccommodationDescription
            };

            return Accommodation;
        }
    }
}
