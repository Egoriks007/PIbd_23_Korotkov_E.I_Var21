using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LabWork1.Entities
{
    public class Service
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public decimal Cost { get; private set; }

        public static Service CreateEntity(int id, string name, decimal cost)
        {
            return new Service
            {
                Id = id,
                Name = name ?? string.Empty,
                Cost = cost
            };
        }
    }
}
