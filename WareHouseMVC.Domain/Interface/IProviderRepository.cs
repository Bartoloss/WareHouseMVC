using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseMVC.Domain.Model;

namespace WareHouseMVC.Domain.Interface
{
    public interface IProviderRepository
    {
        void DeleteProvider(int providerId);

        int AddProvider(Provider provider);

        Provider? GetProviderById(int providerId);
    }
}
