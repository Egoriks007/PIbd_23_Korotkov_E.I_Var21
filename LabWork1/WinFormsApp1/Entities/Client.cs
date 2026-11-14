using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LabWork1.Entities.Enums;

namespace LabWork1.Entities
{
    public class Client
    {
        public int Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;
        public ClientType Type { get; private set; }

        public static Client CreateEntity(int id, string fullName, string phone, ClientType type)
        {
            return new Client
            {
                Id = id,
                FullName = fullName ?? string.Empty,
                Phone = phone ?? string.Empty,
                Type = type
            };
        }
    }
}
