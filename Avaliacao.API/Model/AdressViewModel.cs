using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Model
{
    public class AdressViewModel
    {
        public Guid AdressId { get; set; }
        public string AdressName { get; set; }
        public string AdressNumber { get; set; }
        public string AdressCity { get; set; }
        public string AdressState { get; set; }
        public string AdressCountry { get; set; }
        public string AdressPostalCode { get; set; }
    }
}
