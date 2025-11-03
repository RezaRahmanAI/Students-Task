// See https://aka.ms/new-console-template for more information
class Student
{
    private string name;
    private string roll;
    private float marks;


    public void setStudentInfo(string name, string roll, float marks)
    {
        this.name = name;
        this.roll = roll;
        this.marks = marks;
    }

    public void getStudentInfo()
    {
        Console.WriteLine($"Name: {name}, Roll: {roll}, Marks: {marks}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new();
        Student s2 = new();

        s1.setStudentInfo("Tasnim", "221902285", 80.5f);

        s2.setStudentInfo("Shakir", "221902286", 90.0f);

        s1.getStudentInfo();
        s2.getStudentInfo();

    }
}
