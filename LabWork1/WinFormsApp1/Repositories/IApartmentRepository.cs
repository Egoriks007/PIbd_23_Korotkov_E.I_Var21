using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork1.Entities;

namespace LabWork1.Repositories
{
    public interface IApartmentRepository
    {
        IEnumerable<Apartment> ReadApartments();
        Apartment ReadApartmentById(int id);
        void CreateApartment(Apartment apartment);
        void UpdateApartment(Apartment apartment);
        void DeleteApartment(int id);
    }
}