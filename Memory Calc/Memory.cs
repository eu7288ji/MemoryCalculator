using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Calc
{
    public class Memory
    {    
        public Memory()
        {
        }

        static double valueMem = 0;
        public double saveMem(double memoryValue)
        {
            valueMem = memoryValue;
            return memoryValue;
        }
    }
}
