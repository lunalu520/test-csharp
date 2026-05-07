namespace zhumaliyeva_csharp.Tasks
{
    public static class Task4BracketSequenceAnswers
    {
        public static void Run()
        {
            Console.WriteLine("\nPress any key to move to the sequence question.");
            Console.ReadKey();
            Console.WriteLine("Can this sequence be considered correct: [((())()(())]] ?");
            Console.WriteLine("Press any key to know the answer.");
            Console.ReadKey();
            Console.WriteLine("No, the given bracket sequence is not correct because the closing brackets do not properly match the opening ones.");
            Console.WriteLine("Press any key to know what needs to be changed in it to make it correct.");
            Console.ReadKey();
            Console.WriteLine("The last closing bracket is ], but it should be a round bracket ) to balance the sequence.");
            Console.WriteLine("Press any key to see the correct version.");
            Console.ReadKey();
            Console.WriteLine("The corrected version is [((())()(()))] .");
        }
    }
}
