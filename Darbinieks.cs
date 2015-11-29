using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdControl
{
    public enum amats { Programmētājs, Testētējs, Vadītājs };
    class Darbinieks
    {
        private string vards;
        private string uzvards;
        private DateTime dz_datums;
        private amats amatss;


        public string Vards
        {
            get { return vards; }
            set { vards = value; }
        }
        public string Uzvards
        {
            get { return uzvards; }
            set { uzvards = value; }
        }
        public string PilnaisVards
        { get { return vards + " " + uzvards; } }

        public DateTime Dz_datums
        {
            get { return dz_datums; }
            set { dz_datums = value; }
        }
        public amats Amatss
        {
            get { return amatss; }
            set { amatss = value; }
        }

        public Darbinieks(string vards, string uzvards, DateTime dz_datums, amats amatss)
        {
            this.vards = vards;
            this.uzvards = uzvards;
            this.dz_datums = dz_datums;
            this.amatss = amatss;
        }
    }
}
