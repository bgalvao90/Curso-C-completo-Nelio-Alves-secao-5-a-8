using Aula78;
using System.Collections.Generic;
using System.Globalization;




Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());


List<Employee> list = new List<Employee>();



for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i}");

    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    list.Add(new Employee(id, name, salary));

    Console.WriteLine("-------------------------------------");


}


Console.Write("Enter the employee id that will have salary increase : ");

int searchid = int.Parse(Console.ReadLine());

Employee employee = list.Find(x => x.Id == searchid);

if (employee != null)
{


    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    employee.increaseSalary(percentage);
}

else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updtated list of employees: ");
foreach (Employee emp in list)
{
    {
        Console.WriteLine(emp);
    }

}