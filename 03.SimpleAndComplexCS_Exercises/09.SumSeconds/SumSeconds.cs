namespace _09.SumSeconds
{
    internal class SumSeconds
    {
        static void Main(string[] args)
        {
            int athlete1Time = int.Parse(Console.ReadLine());
            int athlete2Time = int.Parse(Console.ReadLine());
            int athlete3Time = int.Parse(Console.ReadLine());

            int totalTime = athlete1Time + athlete2Time + athlete3Time;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}