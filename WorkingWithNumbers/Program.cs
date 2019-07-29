using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( 5 + 8 );// will print out the sum of the two 

            Console.WriteLine( 5 % 2);// modulus will give us remainder (%)

            Console.WriteLine( 4 + 2 * 3);//BODMAS will use multiplcation first 

            Console.WriteLine((4 + 2) * 3); //parenthesis will do inside brackets first 

            Console.WriteLine(5 + 8.1);//returns decimal 
            Console.WriteLine(5 / 2); //should be decimal answer but only intergers used 
            Console.WriteLine(5 / 2.0); // will return decimal answer 


            int num = 6;
            num++; //auto increment 1 to num

            //Method is a block of code where we can call a method and it will complete the code 

            Console.WriteLine(Math.Abs(-40)); //absolute valve
            Console.WriteLine(Math.Pow(3, 2)); //power of
            Console.WriteLine(Math.Sqrt(36));//square root of 36 
            Console.WriteLine(Math.Max(4, 90));//will return the bigger number (90)
            Console.WriteLine(Math.Round(4.3)); //round the number 


            Console.ReadLine();
        }
    }
}
