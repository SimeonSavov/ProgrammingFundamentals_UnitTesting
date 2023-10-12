static void PrintNumberSign(int number)
{
  if (number == 0)
  {
     Console.WriteLine($"The number {number} is zero.");
  }
  else if (number > 0)
  {
     Console.WriteLine($"The number {number} is positive.");
  }
  else
  {
     Console.WriteLine($"The number {number} is negative.");
  }
}

int number = int.Parse(Console.ReadLine());

PrintNumberSign(number);
