using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature at the moment?");
            Console.WriteLine("Write value, please.");

            string temp = Console.ReadLine();

            int chosenTemp = 0;

            Int32.TryParse(temp, out chosenTemp);
            if (chosenTemp < 0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if ((chosenTemp >= 0) && (chosenTemp < 10))
            {
                Console.WriteLine("Zimno");
            }
            else if ((chosenTemp >= 10) && (chosenTemp < 20))
            {
                Console.WriteLine("Chłodno");
            }
            else if ((chosenTemp >= 20) && (chosenTemp < 30))
            {
                Console.WriteLine("W sam raz");
            }
            else if ((chosenTemp >= 30) && (chosenTemp < 40))
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            }
            else //(chosenTemp >= 40)
            {
                Console.WriteLine("A weź, wyprowadzam się na Alaskę");
            }
        }
    }

}
