int students = int.Parse(Console.ReadLine());

double sumOfGrades = 0;

for (int i = 0; i < students; i++)
{
    double grade = double.Parse(Console.ReadLine());

    sumOfGrades += grade;
}

double result = sumOfGrades / students;

Console.WriteLine($"{result:f2}");
