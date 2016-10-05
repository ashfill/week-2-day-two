using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class tucan:birds
    {
        private int livesinsmallflock;//flock of 6
        private bool livesintreehole;

        public tucan()
        {

        }
        public int Livesinsmallflock
        {
            get
            {
                return livesinsmallflock;
            }

            set
            {
                livesinsmallflock = value;
            }
        }

        public bool Livesintreehole
        {
            get
            {
                return livesintreehole;
            }

            set
            {
                livesintreehole = value;
            }
        }
    }
}
