using System.Diagnostics.Contracts;
using System.Globalization;
using Aula101.Entities;
using Aula101.Entities.Enums;




Console.Write("Enter department's name: ");
string depName = Console.ReadLine();

Console.WriteLine("Enter worker data:");

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Departament dept = new Departament(depName);

Worker worker = new Worker(name, level, baseSalary, dept);

Console.Write("How many contracts to this worker? ");
int manyContracts = int.Parse(Console.ReadLine());

for (int i = 1; i <= manyContracts; i++)
{
    Console.WriteLine($"Enter #{i} contract Data:");

    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Durantion (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valueperhour, hours);
    worker.AddContract(contract);
}

Console.WriteLine();

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();

int month =int.Parse(monthAndYear.Substring(0, 2));

int year = int.Parse(monthAndYear.Substring(3));

Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: "+ worker.Departament.Name);
Console.WriteLine("Income for "+ monthAndYear + ": "+ worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
