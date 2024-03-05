using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTest
{
    public class BinaryGap
    {

        public static string DecimalToBinary(int n)
        {
            if (n == 0)
                return "0"; // Special case for zero

            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }

            return  binary;
        }

        public static int ReturnBinaryGap(string binaryString)
        {
            // Remove any leading or trailing zeros
            binaryString = binaryString.Trim('0');

            // Initialize variables
            int maxGap = 0;
            int currentGap = 0;

            // Iterate through the binary string
            foreach (char c in binaryString)
            {
                if (c == '0')
                {
                    // Increment the current gap
                    currentGap++;
                }
                else
                {
                    // Update the maximum gap if needed
                    maxGap = Math.Max(maxGap, currentGap);
                    // Reset the current gap
                    currentGap = 0;
                }
            }

            return maxGap;


            //char[] binaryCharList = binaryStr.ToCharArray();
            //for (int i = 0; i < binaryCharList.Length; i++)
            //{
            //    if (binaryCharList[i] == 0)
            //        break;
            //}
            //return 0;
        }
    }
}
