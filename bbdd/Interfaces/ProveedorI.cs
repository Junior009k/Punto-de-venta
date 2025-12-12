using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.bbdd.Modelos
{
    class ProveedorI
    {
        public long id { get; set; }        // numeric(18,0) → long
        public string name { get; set; }   // nvarchar(50) → string
        public string RNC { get; set; } // nvarchar(50) → string
    }
}
