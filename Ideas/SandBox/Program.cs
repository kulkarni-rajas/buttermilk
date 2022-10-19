// See https://aka.ms/new-console-template for more information
using SandBox;
Console.WriteLine("Welcome to Employee Management System");
Console.WriteLine("Press 1 for TCS");
Console.WriteLine("Press 2 for Wells Fargo");

string input = Console.ReadLine();
int option  = Convert.ToInt32(input);

if(option == 1)
{
    Console.WriteLine("Enter Employee Name, designation, basic salary, DOJ");
    string name = Console.ReadLine();
    string desig = Console.ReadLine();
    string basicSalary = Console.ReadLine();
    string DOJ = Console.ReadLine();
    double BasicSalary = Convert.ToDouble(basicSalary);
    DateTime Doj = DateTime.Parse(DOJ);
    TCS obj = new TCS(desig,BasicSalary,name,Doj);
}