using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork1.Entities.Enums;

namespace LabWork1.Entities
{
    public class Apartment
    {
        public int Id { get; private set; }
        public string Address { get; private set; } = string.Empty;
        public double Area { get; private set; }
        public decimal Price { get; private set; }
        public RenovationType Renovation { get; private set; }

        public static Apartment CreateEntity(int id, string address, double area, decimal price, RenovationType renovation)
        {
            return new Apartment
            {
                Id = id,
                Address = address ?? string.Empty,
                Area = area,
                Price = price,
                Renovation = renovation
            };
        }
    }
}