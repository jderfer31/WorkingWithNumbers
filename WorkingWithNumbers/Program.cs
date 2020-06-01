using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# distinquishes between whole number and decimal numbers
            //Console.WriteLine( 5 + 8 ); //C# actually performs this math operation as would if / * - +
            //Console.WriteLine( 5 % 2 ); // this is read as 5 mod 2 and prints the remainder
            // C# also follows order of operations PEMDAS
            //C# only returns decimal numbers if you use decimal numbers in the math operation, if you use two integers and you would expect a decimal, you will get an integer only
            //int num = 6; this creates a variable called num and whatever that value is, is returned with Console.WriteLine( num );
            //using num++; will add 1 to the variable number and return the value, same with num--; except subtracting
            //One of the methods we can use is a Math method by simply typing Console.WriteLine( Math. ); and you will see options
            //Console.WriteLine( Math.Abs(-40) ); returns absolute value which is 40
            //int num = 6;
            //num++;
            //Console.WriteLine(Math.Pow(3, 2)); This returns a power answer 3 to the 2 power is 9
            //Console.WriteLine(Math.Sqrt(36)); returns square root value
            //Console.WriteLine(Math.Max(4, 90)); returns the max value and Min does the opposite
            //Console.WriteLine(Math.Round(4.875)); rounds the value 
            //Google C# math methods

            Console.WriteLine(Math.Round(4.875));

            
        }


    }


}



