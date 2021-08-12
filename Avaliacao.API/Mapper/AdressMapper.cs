using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Mapper
{
    public static class AdressMapper
    {
        public static Adress ViewModelToEntity(this AdressViewModel adressVM)
        {
            if (adressVM == null)
            {
                return null;
            }

            var AdressVM = new Adress()
            {
                Id = adressVM.AdressId,
                AdressName = adressVM.AdressName,
                Number = adressVM.AdressNumber,
                City = adressVM.AdressCity,
                State = adressVM.AdressState,
                Country = adressVM.AdressCountry,
                PostalCode = adressVM.AdressPostalCode
            };

            return AdressVM;
        }

        public static AdressViewModel EntityToViewModel(this Adress adress)
        {
            if (adress == null)
            {
                return null;
            }

            var AdressViewModel = new AdressViewModel()
            {
                AdressId = adress.Id,
                AdressName = adress.AdressName,
                AdressNumber = adress.Number,
                AdressCity = adress.City,
                AdressState = adress.State,
                AdressCountry = adress.Country,
                AdressPostalCode = adress.PostalCode

            };

            return AdressViewModel;
        }
    }
}

