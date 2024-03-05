using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number");
            //var numStr= Console.ReadLine();
            //string binaryRepresentation = BinaryGap.DecimalToBinary(Convert.ToInt32(numStr));
            //Console.WriteLine($"The binary representation of {numStr} is {binaryRepresentation}");
            //Console.WriteLine($"The Gap binary is {BinaryGap.ReturnBinaryGap(binaryRepresentation)}");
            int[] inputArr = new int[] { 1, 2, 3 ,4 };
            Console.WriteLine(inputArr);
            CyclicRotation.Solution(inputArr, 3);
            Console.WriteLine(inputArr.ToString());
            Console.ReadKey();
        }
    }
}
