using System;
using System.Collections.Generic;
using System.Text;

namespace Hash_sets_and_loops
{
    public class HashsetCalculation
    {
        public static int Calculate(int[] integers)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach(int integer in integers)
            {
                if (!seen.Add(integer))
                {
                    return integer;
                }
            }
            return -1;
        }
    }
}
