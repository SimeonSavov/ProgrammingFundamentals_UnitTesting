namespace _06.NumberProcessor
{
    internal class NumberProcessor
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Inc")
                {
                    num++;
                }
                else if (command == "Dec")
                {
                    num--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(num);
        }
    }
}