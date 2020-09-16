using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoullete_Rajpal
{
    public class OneClass
    {
        public int LdingRj { get; set; }//Load variable
        public int RjSpinning { get; set; }//Spin Variable 

        public int LoopRjShot(int skippingRjShoot)//This method for shoting time
        {
            if (skippingRjShoot == 6)
            {
                skippingRjShoot = 1;
            }
            else
            {
                skippingRjShoot++;
            }
            return skippingRjShoot;
        }
    }
}
