using System;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary {  get; set; }

    public virtual decimal CalculateAnnualSalary()
    {
        return(Salary * 12);
    }
}

class FullTimeEmployee : Employee
{
    public decimal Bonus {  get; set; }

    public override decimal CalculateAnnualSalary()
    {
        return (Salary * 12) + Bonus;
    }
}

class PartTimeEmployee : Employee
{
    public decimal HourlyRate {  get; set; }
    public decimal HoursWorkedInAWeek { get; set; }

    public override decimal CalculateAnnualSalary()
    {
        return HourlyRate * HoursWorkedInAWeek * 12;
    }
}