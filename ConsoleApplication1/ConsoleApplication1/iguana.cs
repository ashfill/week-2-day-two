using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class iguana:reptiles
    {
        private bool canregrowtail;
        private bool coldblooded;
        public iguana()
        {

        }
        public bool Canregrowtail
        {
            get
            {
                return canregrowtail;
            }

            set
            {
                canregrowtail = value;
            }
        }

        public bool Coldblooded
        {
            get
            {
                return coldblooded;
            }

            set
            {
                coldblooded = value;
            }
        }
    }
}
