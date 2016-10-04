using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class birds:Animals
    {
        private int havewings;
        private bool canfly;

        public int Havewings
        {
            get
            {
                return havewings;
            }

            set
            {
                havewings = value;
            }
        }

        public bool Canfly
        {
            get
            {
                return canfly;
            }

            set
            {
                canfly = value;
            }
        }
    }
}
