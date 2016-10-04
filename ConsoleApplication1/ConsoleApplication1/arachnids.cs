using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class arachnids:Animals
    {
        private int havelegs;
        private int bodysections;

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

        public int Bodysections
        {
            get
            {
                return bodysections;
            }

            set
            {
                bodysections = value;
            }
        }
    }
}
