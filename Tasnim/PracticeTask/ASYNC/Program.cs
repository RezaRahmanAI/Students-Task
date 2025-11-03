// See https://aka.ms/new-console-template for more information


async Task DelayedMessage()
{
    Console.WriteLine("Loading....");
    await Task.Delay(2000);
    Console.WriteLine("Loaded.");
}

await DelayedMessage();