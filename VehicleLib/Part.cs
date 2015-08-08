using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{
    class Part
    {
        public Guid Guid;
        public string Code;
        public string Name;
        public string Description;

        public List<Assembly> AssemblyList = null;

    }
}
