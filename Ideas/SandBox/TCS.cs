using System;
using System.Reflection.Metadata.Ecma335;
using SandBox;

public class TCS : IGovtRules
{
    private int empID;
    private string empName;
    private string dept;
    private string desg;
    private double basicSalary;
    private static int empIDStart = 10000000;
    private double employeePf;
    private double employerPf;
    private double pensionFund;
    private int casualLeave;
    private int sickLeave;
    private int privilageLeave;
    private DateTime DOJ;
    private float serviceCompleted;


    public TCS(string desg, double basicSalary, string empName, DateTime DOJ)
    {
        empIDStart++;
        this.desg = desg;
        this.basicSalary = basicSalary;
        this.empName = empName;
        this.empID = empIDStart;
        this.DOJ = DOJ;
        DateTime zeroTime = new DateTime(1, 1, 1);
        TimeSpan temp = (DateTime.Now - DOJ);
        serviceCompleted = (zeroTime + temp).Year - 1;
        Console.WriteLine("Details are: - ");
        Console.WriteLine(LeaveDetails());
        Console.WriteLine(EmployeePF(basicSalary));
        Console.WriteLine(gratuityAmount(serviceCompleted, basicSalary));

    }
    public string LeaveDetails()
    {
        casualLeave = 1;
        sickLeave = 12;
        privilageLeave = 10;

        return "Leaves set successfully";
    }

    public double EmployeePF(double basicSalary)
    {
        double totalPf = 0;
        totalPf = 20.33 * basicSalary;
        pensionFund = 0.367 * basicSalary;
        return totalPf;
    }

    public double gratuityAmount(float serviceCompleted, double basicSalary)
    {
        double gratuity = 0.0;
        if (serviceCompleted > 20)
        {
            gratuity = basicSalary * 3;
        }
        else if (serviceCompleted > 10)
        {
            gratuity = basicSalary * 2;
        }
        else if (serviceCompleted > 5)
        {
            gratuity = basicSalary;
        }
        return gratuity;
    }
}
