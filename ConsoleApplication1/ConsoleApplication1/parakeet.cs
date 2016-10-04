using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class parakeet
    {
        private int parakeetspecies;//115 ones
        private int beakgrowth;//3 inches per year

        public int Parakeetspecies
        {
            get
            {
                return parakeetspecies;
            }

            set
            {
                parakeetspecies = value;
            }
        }

        public int Beakgrowth
        {
            get
            {
                return beakgrowth;
            }

            set
            {
                beakgrowth = value;
            }
        }
    }
}
