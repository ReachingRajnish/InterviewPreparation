using System;
using System.Linq;

namespace InterviewPreparation.LinQ
{
    public class Program
    {
        public static void Main()
        {
            int[] n1 = {1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};

            Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : ");
            Console.Write("\n-----------------------------------------------------------------------------");

            var query = from VrNum in n1
                        where VrNum > 0
                        where VrNum < 12
                        select VrNum;

            Console.Write("\nThe numbers within the range of 1 to 11 are : \n");

            foreach (var VrNum in query)
            {
                Console.Write("{0}  ", VrNum);
            }

            Console.Write("\n\n");
        }
    }
}
