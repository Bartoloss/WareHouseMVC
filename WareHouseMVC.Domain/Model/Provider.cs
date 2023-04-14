using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseMVC.Domain.Model
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ProviderContactInformation ProviderContactInformation { get; set; }

        public virtual ICollection<ProviderContactDetail> ProviderContactDetails { get; set; }
        public virtual ICollection<ProviderAddress> ProviderAddresses { get; set; }
    }
}
