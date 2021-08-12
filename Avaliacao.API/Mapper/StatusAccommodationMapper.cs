using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;

namespace Avaliacao.API.Mapper
{
    public static class StatusAccommodationMapper
    {
        public static StatusAccommodationViewModel EntityToViewModel(this StatusAccommodation StatusAcc)
        {
            if (StatusAcc == null)
            {
                return null;
            }
             
            var StatusAccViewModel = new StatusAccommodationViewModel()
            {
                StatusAccId = StatusAcc.Id,
                AccDescription = StatusAcc.Description
            };

            return StatusAccViewModel;
        }

        public static StatusAccommodation ViewModelToEntity(this StatusAccommodationViewModel StatusAccVM)
        {
            if (StatusAccVM == null)
            {
                return null;
            }

            var StatusAcc = new StatusAccommodation()
            {
                Id = StatusAccVM.StatusAccId,
                Description = StatusAccVM.AccDescription
            };

            return StatusAcc;
        }
    }
}
