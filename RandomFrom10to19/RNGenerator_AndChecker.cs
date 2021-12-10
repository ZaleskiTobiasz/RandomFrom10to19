using System;
using System.Collections.Generic;

namespace RandomFrom10to19
{
    public class RNGenerator_AndChecker
    {
        List<byte> numbers = new List<byte>();
        public Random rng = new Random();
        int index = 0;
        bool isDone = false;
        public RNGenerator_AndChecker()
        {
            for (int i = 0; i < 3; i++)
            {
                numbers.Add((byte)rng.Next(10, 20));
                Console.WriteLine(numbers[i]);
                index = i;
            }
            if (numbers[0] % 3 == 0 && numbers[1] % 3 == 0 && numbers[2] % 3 == 0)
            {
                Console.WriteLine("Ostatnie 3 liczby podzielne przez trzy, ilość wylosowanych liczb = " + (index + 1));
                isDone = true;
            }
        }

        public void ContinueWork()
        {
            while (true)
            {
                if (numbers[index - 2] % 3 == 0 && numbers[index - 1] % 3 == 0 && numbers[index] % 3 == 0)
                {
                    Console.WriteLine("Ostatnie 3 liczby podzielne przez trzy, ilość wylosowanych liczb = " + (index + 1));
                    break;
                }
                else
                {
                    GenerateAnotherNumber();
                }
            }

        }
        public bool isItDoneAfterFstIteration()
        {
            return isDone;
        }
        public void GenerateAnotherNumber()
        {
            numbers.Add((byte)rng.Next(10, 20));
            index++;
            Console.WriteLine(numbers[index]);
        }

    }
}
