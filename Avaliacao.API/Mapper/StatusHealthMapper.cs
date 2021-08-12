using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;

namespace Avaliacao.API.Mapper
{
    public static class StatusHealthMapper
    {
        public static StatusHealthViewModel EntityToViewModel(this StatusHealth StatusH)
        {
            if (StatusH == null)
            {
                return null;
            }
             
            var StatusHViewModel = new StatusHealthViewModel()
            {
                StatusHealthId = StatusH.Id,
                StatusHealthDescription = StatusH.Description
            };

            return StatusHViewModel;
        }

        public static StatusHealth ViewModelToEntity(this StatusHealthViewModel StatusHVM)
        {
            if (StatusHVM == null)
            {
                return null;
            }

            var StatusH = new StatusHealth()
            {
                Id = StatusHVM.StatusHealthId,
                Description = StatusHVM.StatusHealthDescription
            };

            return StatusH;
        }
    }
}
