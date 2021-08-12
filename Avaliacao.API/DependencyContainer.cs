using Avaliacao.API.Application.Interfaces;
using Avaliacao.API.Application.Services;
using Avaliacao.API.Data.Repositories;
using Avaliacao.API.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Avaliacao.API
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IPetsService, PetsService>();
            services.AddScoped<IPetOwnerService, PetOwnerService>();
            services.AddScoped<IAdressService, AdressService>();
            services.AddScoped<IAccommodationService, AccommodationService>();
            services.AddScoped<IStatusAccommodationService, StatusAccommodationService>();

            services.AddScoped<IStatusAccommodationRepository, StatusAccommodationRepository>();            
            services.AddScoped<IAccommodationRepository, AccommodationRepository>();
            services.AddScoped<IStatusHealthRepository, StatusHealthRepository>();
            services.AddScoped<IPetsRepository, PetsRepository>();
            services.AddScoped<IPetOwnerRepository, PetOwnerRepository>();
            services.AddScoped<IAdressRepository, AdressRepository>();
        }
    }
}
