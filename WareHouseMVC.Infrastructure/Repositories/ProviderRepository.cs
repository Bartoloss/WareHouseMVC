using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Domain.Interface;
using WareHouseMVC.Domain.Model;

namespace WareHouseMVC.Infrastructure.Repositories
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly Context _context;
        public ProviderRepository(Context context)
        {
            _context = context;
        }
        public int AddProvider(Provider provider)
        {
            _context.Add(provider);
            _context.SaveChanges();
            return provider.Id;
        }

        public void DeleteProvider(int providerId)
        {
            Provider? provider = _context.Providers.Find(providerId);
            if (provider != null)
            {
                _context.Providers.Remove(provider);
                _context.SaveChanges();
            }
        }

        public Provider? GetProviderById(int providerId)
        {
            Provider? provider = _context.Providers.FirstOrDefault(i => i.Id == providerId);
            return provider;
        }
    }
}
