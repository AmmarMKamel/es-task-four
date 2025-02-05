namespace TaskFourSearchTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsVowels("Hello"));
            Console.WriteLine(ContainsVowels("Rhythm"));
        }

        static bool ContainsVowels(string str)
        {
            string lowerCaseStr = str.ToLower();
            string vowels = "aeiou";

            foreach (var character in lowerCaseStr)
            {
                if (vowels.Contains(character))
                    return true;
            }

            throw new Exception($"{str} doesn't contain vowels");
        }
    }
}
