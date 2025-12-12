using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.bbdd.Modelos
{
    class BoxI
    {
        public long id { get; set; }        // numeric(18,0) → long
        public string concept { get; set; }   // nvarchar(50) → string
        public string date { get; set; } // nvarchar(50) → string
        public string amount { get; set; }    // nchar(10) → string (recomendado convertir a int si es numérico)

    }
}
