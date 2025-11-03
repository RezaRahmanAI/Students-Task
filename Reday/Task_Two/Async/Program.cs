
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting Rice Cooker...");
        await Task.Delay(3000); // Simulate time taken to cook rice
        Console.WriteLine("Rice is ready!");
    }
}