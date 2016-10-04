using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class reptiles:Animals
    {
        private bool haveclaws;
        private bool havetails;

        public bool Haveclaws
        {
            get
            {
                return haveclaws;
            }

            set
            {
                haveclaws = value;
            }
        }

        public bool Havetails
        {
            get
            {
                return havetails;
            }

            set
            {
                havetails = value;
            }
        }
    }
}
