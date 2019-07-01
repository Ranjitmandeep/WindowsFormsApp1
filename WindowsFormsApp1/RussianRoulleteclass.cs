using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RussianRoulleteclass
    {
        public int bulletespinedgun;
        public int Winningbullete = 0;
        public int loadfired = 0;
        public int totalshottofire;
        public int lodedshots = 6;
        public int Shootbullete()
        {
            if (lodedshots > 0 && bulletespinedgun == 1)
            {

                loadfired = 1;




            }
            else if (lodedshots > 0 && bulletespinedgun != 1)
            {
                loadfired = 2;

            }
            return loadfired;
        }
    }
}
