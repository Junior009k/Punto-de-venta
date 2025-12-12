using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.bbdd.Modelos
{
    class SalesI
    {
        

        public long id { get; set; }        // numeric(18,0) → long
        public long idClient { get; set; }
        public string fullName { get; set; }// numeric(18,0) → long
        public string ageClient { get; set; }// numeric(18,0) → long
        public string total { get; set; }
        public DateTime date { get; set; }
        public string dateS { get; set; }
    }
}
