using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System.Collections.Generic;

namespace BusinessLayer.services
{
    public class ProviderService
    {
        private readonly ProviderRepository providerRepository = new ProviderRepository();

        public List<Provider> GetAllProviders()
        {
            return providerRepository.GetAllProviders();
        }

        public void AddProvider(Provider provider)
        {
            providerRepository.AddProvider(provider);
        }

        public void UpdateProvider(Provider provider)
        {
            providerRepository.UpdateProvider(provider);
        }

        public void DeleteProvider(int providerID)
        {
            providerRepository.DeleteProvider(providerID);
        }
    }
}
