namespace _04.VowelSum
{
    internal class VowelSum
    {
        static void Main(string[] args)
        {
            int countOfChar = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 1; i <= countOfChar; i++)
            {
                char currentSymbol = char.Parse(Console.ReadLine());

                switch (currentSymbol)
                {
                    case 'a':
                        result += 1;
                        break;
                    case 'e':
                        result += 2;
                        break;
                    case 'i':
                        result += 3;
                        break;
                    case 'o':
                        result += 4;
                        break;
                    case 'u':
                        result += 5;
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}