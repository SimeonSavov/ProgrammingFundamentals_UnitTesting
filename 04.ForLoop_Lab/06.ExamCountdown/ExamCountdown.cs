namespace _06.ExamCountdown
{
    internal class ExamCountdown
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            for (int i = day; i > 0; i--)
            {
                Console.WriteLine($"{i} days before the exam");
            }

            Console.WriteLine("The exam has come");
        }
    }
}