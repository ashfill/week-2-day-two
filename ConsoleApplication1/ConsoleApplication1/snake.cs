using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class snake:reptiles
    {
        private int numberoflegs;
        private int hasbones;

        public int Numberoflegs
        {
            get
            {
                return numberoflegs;
            }

            set
            {
                numberoflegs = value;
            }
        }

        public int Hasbones
        {
            get
            {
                return hasbones;
            }

            set
            {
                hasbones = value;
            }
        }
    }
}
