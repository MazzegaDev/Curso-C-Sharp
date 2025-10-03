

public class Employee
{
    public int ID { get; private set; }
    public string Name { get; set; }

    public double Salary { get; private set; }

    public Employee(int id, string name, double salary)
    {
        ID = id;
        Name = name;
        Salary = salary;
    }

    public void IncreaseSalary(double percentage) {
        Salary += Salary * percentage / 100.0;
    }
}
