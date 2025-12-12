using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.bbdd.Modelos
{
    class ClientI
    {
        

        public long Id { get; set; }        // numeric(18,0) → long
        public string Name { get; set; }   // nvarchar(50) → string
        public string LastName { get; set; } // nvarchar(50) → string
        public string Age { get; set; }
        public string Fullname { get; set; }// nchar(10) → string (recomendado convertir a int si es numérico)

    }
}
