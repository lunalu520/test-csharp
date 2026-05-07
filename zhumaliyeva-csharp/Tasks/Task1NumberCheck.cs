namespace zhumaliyeva_csharp.Tasks
{
    public static class Task1NumberCheck
    {
        public static void Run()
        {
            string? input;

            do
            {
                Console.WriteLine("Enter a number.");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("You did not enter a number.");
                }

            } while (string.IsNullOrWhiteSpace(input));

            int number = int.Parse(input);

            if (number > 7)
                Console.WriteLine("Hello");
            else
                Console.WriteLine("Your number is less than or equal to seven.");
        }



    }
}
