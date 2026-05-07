using System;
using zhumaliyeva_csharp.Tasks;

namespace zhumaliyeva_csharp
{

    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Task1NumberCheck.Run();

            Console.WriteLine("\nTask 2");
            Task2NameCheck.Run();

            Console.WriteLine("\nTask 3");
            Task3ArrayCheck.Run();

            Task4BracketSequenceAnswers.Run();
        }

    }

}
