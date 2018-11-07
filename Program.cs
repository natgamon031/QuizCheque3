using System;

namespace QuizCheque3
{
    class Program
    {
        static void Main(string[] args)
        // {
        // String name;
        // int age;
        // double height;

        // // Console.Write("Your number: ", out age);
        // name = Console.ReadLine();
        // int.TryParse(Console.ReadLine(), out age);
        // double.TryParse(Console.ReadLine(), out height);
        // double.TryParse(Console.ReadLine(), out height);

        // Console.WriteLine("You should write the following cheques");
        // Console.WriteLine("Enter amount #1: {0}", name);
        // Console.WriteLine("Enter amount #2: {0}", age);
        // Console.WriteLine("Enter amount #3: {0}", height);
        // Console.WriteLine("Enter amount #4: {0}", height);
        // }
         {
        const int SIZE = 4;

         String name;
        int age;
        double height;

        int[] scores = new int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.WriteLine("Enter amount # "+ i + 1);
            name = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out age);
            double.TryParse(Console.ReadLine(), out height);
            double.TryParse(Console.ReadLine(), out height);

        Console.WriteLine("for {0}", name);
        Console.WriteLine("for {0}", age);
        Console.WriteLine("for {0}", height);
        Console.WriteLine("for {0}", height);
        int maxIndex= 0;

        // for (int i = 0; i < SIZE; i++)
        {
            if (scores[i] > scores[maxIndex])
            {
                maxIndex = i;
            }
        }

        Console.WriteLine("score {1}", 
            scores[maxIndex]);
    }
    }
    }
}
