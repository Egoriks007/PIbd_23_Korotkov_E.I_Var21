using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1.Entities.Enums
{
    [Flags]
    public enum RenovationType
    {
        None = 0,
        Rough = 1,       // Черновая
        Cosmetic = 2,    // Косметическая
        Designer = 4     // Дизайнерская
    }
}
