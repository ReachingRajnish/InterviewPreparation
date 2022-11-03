using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreparation.Const_and_Readonly
{
    //class Program
    //{
    //    const int PhoneNumber = 10;
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(PhoneNumber);
    //        var test = new Test();
    //        Console.WriteLine(test.SocialNumber);
    //    }
    //}

    class Test
    {
        const int PhoneNumber = 10;
        public readonly int SocialNumber;
        public Test()
        {
            SocialNumber = 20;
        }
        void test()
        {
            //readonly int SocialNumber;
            Console.WriteLine(PhoneNumber);
            //const int SocialNumber = 20;           
            Console.WriteLine(SocialNumber);
        }
    }
}
