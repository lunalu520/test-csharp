namespace zhumaliyeva_csharp.Tasks
{
    public static class Task2NameCheck
    {
        public static void Run()
        {
            string? name;

            do
            {
                Console.WriteLine("Enter a name.");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("You did not enter a name.");
                }

            } while (string.IsNullOrWhiteSpace(name));

            if (name == "John")
                Console.WriteLine("Hello, John");
            else
                Console.WriteLine("There is no such name.");
        }


    }
}
