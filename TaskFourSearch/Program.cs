namespace TaskFourSearchOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            while (true)
            {
                Console.Write("Please enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (set.Contains(number))
                    throw new Exception($"A duplicated number ({number}) was entered!");

                set.Add(number);

                Display(set);
            }
        }

        static void Display(HashSet<int> set)
        {
            Console.Write("[ ");
            foreach (var number in set)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("]");
        }
    }
}
