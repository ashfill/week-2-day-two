using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Animals
    {
        private bool canswim;
        private bool carnivors;
        private bool haveskin;

        public bool Canswim
        {
            get
            {
                return canswim;
            }

            set
            {
                canswim = value;
            }
        }

        public bool Carnivors
        {
            get
            {
                return carnivors;
            }

            set
            {
                carnivors = value;
            }
        }

        public bool Haveskin
        {
            get
            {
                return haveskin;
            }

            set
            {
                haveskin = value;
            }
        }
    }
    }
}
