using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Model
{
    public class AccommodationViewModel
    {
        public Guid AccommodationId { get; set; }
        public StatusAccommodation AccommodationStatus { get; set; }
        public string AccommodationDescription { get; set; }
        
    }
}
