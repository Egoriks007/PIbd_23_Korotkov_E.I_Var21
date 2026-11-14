using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1.Entities
{
    public class Deal
    {
        public int Id { get; private set; }
        public int ClientId { get; private set; }
        public int ApartmentId { get; private set; }
        public DateTime DealDate { get; private set; }
        public decimal TotalAmount { get; private set; }

        public static Deal CreateOperation(int id, int clientId, int apartmentId, decimal totalAmount)
        {
            return new Deal
            {
                Id = id,
                ClientId = clientId,
                ApartmentId = apartmentId,
                TotalAmount = totalAmount,
                DealDate = DateTime.Now
            };
        }
    }
}
