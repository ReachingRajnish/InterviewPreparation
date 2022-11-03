using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreparation.Generics
{
    #region Generics

    /*
     
    public class Program
    {
        //Generics use case - it allows us to make classes and methods - type independent or type safe/ to remove duplicate code
        //Ex. if we create List class and Book Class with Add method and indexer to return the index position
        //we will have to write duplicate code for both and any issue we need to fix both the places.With Generics we can reuse the code.
        public static void Main()
        {
            // Not optimized - Duplicate code

            //var equal = Calculator.AreEqual(5, 5);
            //Console.WriteLine("Is 5 and 5 are equal {0} ", equal);

            // Can't compare string

            //var stringEqual = Calculator.AreEqual("Test", "Test1");
            //Console.WriteLine("Is Test and Test1 are equal {0} ", stringEqual);

            // Generic Implementation
            var genericIntEqual = GenericCalculator<int>.AreEqual(5, 5);
            Console.WriteLine("Is 5 and 5 are equal {0} ", genericIntEqual);

            var genericStringEqual = GenericCalculator<string>.AreEqual("Test", "Test1");
            Console.WriteLine("Is Test and Test1 are equal {0} ", genericStringEqual);


           // Console.WriteLine("{0} {1} {2}");
        }
    }

    public class Calculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1.Equals(value2);
        }
    }

    public class CalculatorUsingObject
    {
        // Boxing and unboxing is the issue here
        public static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }
    }

    public class GenericCalculator<T>
    {
        // Generic implementation
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    */

    #endregion
}
