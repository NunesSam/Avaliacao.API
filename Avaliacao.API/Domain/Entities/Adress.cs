using System;

namespace Avaliacao.API.Domain.Entities
{
    public class Adress
    {
        public Guid Id { get; set; }
        public string AdressName { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
