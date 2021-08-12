using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Entities
{
    public class Accommodation
    {
        public Guid Id { get; set; }
        public StatusAccommodation Status { get; set; }
        public string Description { get; set; }
        	 
    }
}
