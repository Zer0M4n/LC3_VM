using LC3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LC3
{
    internal class Program
    {
        //Class LC HARDWARE
        
        //MEMORY 16 BITS
        const int Memory_Mx = 1 << 16;
        short[] Memory = new short[Memory_Mx]; //The memory wiill be stored in array
        
        //Register storage
        short[] Reg = new short[(int)lc3_Hardware.Register.R_COUNT];

        static void Main(string[] args)
        {
        }
    }
}
