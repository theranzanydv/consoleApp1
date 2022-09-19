using ConsoleApp1;

Console.WriteLine("Welcome to .NET with C#");
string? input = Console.ReadLine();

Console.WriteLine("The number of times you want to repeat the name");
string? times = Console.ReadLine();
Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~");

int intTimes = Convert.ToInt32(times);
// intTimes = intTimes * 10;

for (int i = 0; i < intTimes; i++)
{
    Console.WriteLine("Hello " + input);
}

Student student = new Student();
student.Name = "Ranjan";
student.Age = 23;
student.Id = 1;

Console.WriteLine(student.Id);
Console.WriteLine(student.Name);
Console.WriteLine(student.Age);

Console.ReadKey();