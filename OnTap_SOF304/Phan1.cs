using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_SOF304
{
    public class Phan1
    {
        public static int Array(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int array = 1;
            foreach (int number in numbers)
            {
                array *= number;
            }
            return array;
        }
    }
}
