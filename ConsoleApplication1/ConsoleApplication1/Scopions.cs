using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Scopions:arachnids
    {
        private int haspincers;
        private bool canbepoisonous;

        public int Haspincers
        {
            get
            {
                return haspincers;
            }

            set
            {
                haspincers = value;
            }
        }

        public bool Canbepoisonous
        {
            get
            {
                return canbepoisonous;
            }

            set
            {
                canbepoisonous = value;
            }
        }
    }
}
