using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.bbdd.Modelos
{
    class SalesDetailsI
    {
        

        public long id { get; set; }        // numeric(18,0) → long
        public long idSales { get; set; }        // numeric(18,0) → long
        public long idProduct { get; set; }        // numeric(18,0) → long
        public string nameProduct { get; set; }   // nvarchar(50) → string
        public string priceProduct { get; set; }   // nvarchar(50) → string
        public string amount { get; set; }   // nvarchar(50) → string
        public string total { get; set; } // nvarchar(50) → string

    }
}
