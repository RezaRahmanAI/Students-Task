class EmployeeRecord
{
    public string? Name { get; set; }
    public string? Department { get; set; }
    public float Salary { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        List<EmployeeRecord> employees = new List<EmployeeRecord>();

        employees.Add(new EmployeeRecord { Name = "Alice", Department = "HR", Salary = 50000 });
        employees.Add(new EmployeeRecord { Name = "Bob", Department = "CEO", Salary = 500000 });

        foreach (var e in employees)
        {
            Console.WriteLine($"{e.Name} - {e.Department} - {e.Salary}");
        }
    }
}
