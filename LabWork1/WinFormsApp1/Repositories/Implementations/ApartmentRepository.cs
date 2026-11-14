using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork1.Entities;
using LabWork1.Entities.Enums;
using LabWork1.Repositories;

namespace LabWork1.Repositories.Implementations
{
    internal class ApartmentRepository : IApartmentRepository
    {
        public void CreateApartment(Apartment apartment) { }
        public void DeleteApartment(int id) { }

        public Apartment ReadApartmentById(int id) =>
            Apartment.CreateEntity(0, string.Empty, 0, 0, RenovationType.None);

        public IEnumerable<Apartment> ReadApartments() => new List<Apartment>();

        public void UpdateApartment(Apartment apartment) { }
    }
}
