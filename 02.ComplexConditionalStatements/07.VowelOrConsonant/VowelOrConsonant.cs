namespace _07.VowelOrConsonant
{
    internal class VowelOrConsonant
    {
        static void Main(string[] args)
        {
            string character = Console.ReadLine();

            switch (character)
            {
                case "A":
                case "a":
                case "E":
                case "e":
                case "I":
                case "i":
                case "O":
                case "o":
                case "U":
                case "u":
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;

            }

        }
    }
}