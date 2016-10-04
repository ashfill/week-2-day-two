using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class arachnids:Animals
    {
        private int havelegs;
        private int havetwobodysections;

        public int Havelegs
        {
            get
            {
                return havelegs;
            }

            set
            {
                havelegs = value;
            }
        }

        public int Havetwobodysections
        {
            get
            {
                return havetwobodysections;
            }

            set
            {
                havetwobodysections = value;
            }
        }
    }
}
