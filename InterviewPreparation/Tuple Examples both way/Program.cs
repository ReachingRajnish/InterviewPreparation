using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreparation.Tuple_Examples_both_way
{
    #region Tuple Examples both way

    /*
    public class Program
    {
        public static Tuple<string, string, int> ReturnMultipleValues()
        {
            var result = Tuple.Create<string, string, int>("value1", "value2", 3);
            return result;
        }
        public static void Main()
        {
            var returnedvalues = ReturnMultipleValues();
            Console.WriteLine(returnedvalues.Item1);
             or can write like below
            Console.WriteLine(returnedvalues.Item1);
            Console.WriteLine(returnedvalues.Item2);
            Console.WriteLine(returnedvalues.Item3);
        }
    }

    */

    
    //public class Program
    //{
    //    public static (string, string, int) ReturnMultipleValues()
    //    {
    //        return ("value1", "value2", 3);
    //    }
    //    public static void Main()
    //    {
    //        (string val1, string val2, int val3) = ReturnMultipleValues();
    //        Console.WriteLine("{0} {1} {2}", val1, val2, val3);
    //    }
    //}

    #endregion
}
