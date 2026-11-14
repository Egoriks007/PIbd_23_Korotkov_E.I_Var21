using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1.Entities
{
    public class ProvidedService
    {
        public int Id { get; private set; }
        public int DealId { get; private set; }
        public int ServiceId { get; private set; }
        public int Quantity { get; private set; }

        public static ProvidedService CreateElement(int id, int dealId, int serviceId, int quantity)
        {
            return new ProvidedService
            {
                Id = id,
                DealId = dealId,
                ServiceId = serviceId,
                Quantity = quantity
            };
        }
    }
}
