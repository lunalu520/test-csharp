namespace zhumaliyeva_csharp.Tasks
{
    public static class Task3ArrayCheck
    {
        public static void Run()
        {
            string? input;

            do
            {
                Console.WriteLine("Enter numbers separated by spaces.");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("You did not enter any numbers.");
                }

            } while (string.IsNullOrWhiteSpace(input));

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = Array.ConvertAll(parts, int.Parse);

            Console.WriteLine("Multiples of 3:");
            int count = 0;

            foreach (int num in numbers)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(num);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("There are no multiples of 3 among the entered numbers.");
            }
        }
    }
}
