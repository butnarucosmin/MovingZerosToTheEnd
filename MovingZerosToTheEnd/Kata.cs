using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingZerosToTheEnd
{
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int[] result = arr;
            int count = 0;

            foreach(int value in arr)
            {
                if (value == 0)
                {
                    count++;
                    result = result.Where(val => val != 0).ToArray();
                }
            }
            for (int i = 0; i < count; i++)
            {
                result = result.Concat(new int[] { 0 }).ToArray();
            }

            return result;
        }
    }
}
