using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTest
{
    public class CyclicRotation
    {
        public static int[] Solution(int[] inputArray, int countRotate)
        {
            int helperInt = 0;
            int len = inputArray.Length;
            for (int i = 0; i < countRotate; i++)
            {

                for (int j = 0; j < len; j++)
                {
                    if (j == 0)
                    {
                        helperInt = inputArray[0];
                        continue;
                    }
                    if (j == len - 1)
                    {
                        inputArray[j - 1] = inputArray[j];

                        inputArray[j] = helperInt;
                        continue;
                    }

                    inputArray[j-1] = inputArray[j ];

                }
            }
            return inputArray;
        }
    }
}
