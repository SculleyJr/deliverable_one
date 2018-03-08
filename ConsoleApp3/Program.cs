using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberOne, numberTwo;
            float sumOne, answer, answerOne, sumTwo;
            
            bool statement;
            int n = 0;
             
        
            Console.WriteLine("enter three digit number");
            numberOne = Console.ReadLine();




            int[] digitsOne = numberOne.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();







            Console.WriteLine("enter three digit number");
            numberTwo = Console.ReadLine();

            int[] digitsTwo = numberTwo.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();


            sumOne = (digitsOne[0] + digitsTwo[0]);
            sumTwo = (digitsOne[1] + digitsTwo[1]);
            answer = digitsOne[n];
            answerOne = digitsTwo[n];


            for ( n = 0; n < digitsOne.Length; n++) ;

            if (sumTwo == sumOne) Console.WriteLine(true);

            else Console.Write(false);
            










        }
    }
}
