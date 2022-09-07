namespace BasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BasicPrograms basicPrograms = new BasicPrograms();
          
            Console.WriteLine("Practice Program!!!");
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1.Check for vowel");
            Console.WriteLine("2.Check for +ve -ve zero");
            Console.WriteLine("3.Largest among 3");
            Console.WriteLine("4.Max of 3");
            Console.WriteLine("5.Print A-Z");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    basicPrograms.CheckVowelConsonant();
                    break;
                case 2:
                    basicPrograms.NumberCheckPN();
                    break;
                case 3:
                    basicPrograms.MaxOfThreeNum();
                    break;
                case 4:

                    basicPrograms.CheckMaxNumberTernary();
                    break;
                case 5:
                    basicPrograms.AlphabetsLowerCase();
                    break;
                default:
                    Console.WriteLine("enter correct choice");
                    break;
            }

        }
    }
}