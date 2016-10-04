using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Spiders:arachnids
    {
        private bool canspinweb;
        private bool cancrawlupwalls;

        public bool Canspinweb
        {
            get
            {
                return canspinweb;
            }

            set
            {
                canspinweb = value;
            }
        }

        public bool Cancrawlupwalls
        {
            get
            {
                return cancrawlupwalls;
            }

            set
            {
                cancrawlupwalls = value;
            }
        }
    }
}
