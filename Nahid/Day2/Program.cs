using System;
using System.Linq;
using System.Threading.Tasks;


class Student
{
    public string Name { get; set; }
    public int Roll { get; set; }
    public double Marks { get; set; }

    
    public double GetGPA()
    {
        // উদাহরণ সূত্র: GPA = Marks / 20
        return Math.Round(Marks / 20, 2);
    }
}


public record EmployeeRecord(string Name, string Department, double Salary);

class Program
{
   
    static async Task LoadDataAsync()
    {
        Console.WriteLine("Loading...");
        await Task.Delay(2000); 
        Console.WriteLine("Loaded!");
    }

   
    static void ShowTypeInfo(object data)
    {
        switch (data)
        {
            case int n:
                Console.WriteLine($"Integer value: {n}");
                break;
            case string s:
                Console.WriteLine($"String text: {s}");
                break;
            case double d:
                Console.WriteLine($"Double number: {d}");
                break;
            case Student st:
                Console.WriteLine($"Student: {st.Name}, GPA: {st.GetGPA()}");
                break;
            case EmployeeRecord er:
                Console.WriteLine($"Employee: {er.Name}, Dept: {er.Department}, Salary: {er.Salary}");
                break;
            default:
                Console.WriteLine("Unknown type");
                break;
        }
    }

    static async Task Main(string[] args)
    {
      
        var s1 = new Student { Name = "Rahim", Roll = 1, Marks = 85 };
        Console.WriteLine($"Student: {s1.Name}, GPA: {s1.GetGPA()}");

    
        var evenNumbers = Enumerable.Range(1, 100).Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers (1–100):");
        Console.WriteLine(string.Join(", ", evenNumbers));

        
        await LoadDataAsync();

       
        var emp = new EmployeeRecord("Karim", "IT", 55000);
        Console.WriteLine($"Employee Record: {emp}");

        
        Console.WriteLine("\nPattern Matching Demo:");
        ShowTypeInfo(42);
        ShowTypeInfo("Hello");
        ShowTypeInfo(3.14);
        ShowTypeInfo(s1);
        ShowTypeInfo(emp);
    }
}
