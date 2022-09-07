using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class BasicPrograms
    {
        public void CheckVowelConsonant()
        {
            Console.WriteLine("C# Program to Check Whether an Alphabet is Vowel or Consonant");
            Console.WriteLine("Enter Alphabate in small case");
            char a = char.Parse(Console.ReadLine());

            switch (a)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Alphabate is vowel");
                    break;
                default:
                    Console.WriteLine("Alphabate is Consonant");
                    break;
           }
        }      
        public void NumberCheckPN()
            {
                Console.WriteLine("Enter Numbers");
                int Number = int.Parse(Console.ReadLine());
                if (Number == 0)
                {
                    Console.WriteLine("zero is zero");
                }
                else if (Number > 0)
                {
                    Console.WriteLine("{0} is Positive", Number);
                }
                else { Console.WriteLine("{0} is Negative", Number); }
            }


        internal void MaxOfThreeNum()
        {
            Console.WriteLine("Enter First Numbers");
            int FNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Numbers");
            int SNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Numbers");
            int TNumber = int.Parse(Console.ReadLine());
            if (FNumber > SNumber)
            {
                if (FNumber > TNumber)
                {
                    Console.WriteLine("{0} is maximum", FNumber);
                }
                else
                {
                    Console.WriteLine("{0} is maximum", TNumber);
                }
            }
            else if (SNumber > TNumber)
            {
                Console.WriteLine("{0} is maximum", SNumber);
            }
            else { Console.WriteLine("{0} is maximum", TNumber); }
        }

        public void CheckMaxNumberTernary()
            {
                Console.WriteLine("C# Program to Find the Largest Among Three Numbers");
                Console.WriteLine("Enter value of first Number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value of second Number");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value of third Number");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Maximum form  is {0} ", a > b ? (a > c ? a : c) : (b > c ? b : c));
            }
        
        public void AlphabetsLowerCase()
        {

            char Alphabet = 'a';

            Console.WriteLine("Alphabets in small case");
            for (int i = 1; i <= 26; i++)
            {
                Console.Write(" "+Alphabet++);
              
            }
        }
    }
}
   

