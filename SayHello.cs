using System;

public class SayHello
{
    private string message = "Hello, World.\n";

    // CTor  
    public SayHello(string message = "")
    {
        if (!string.IsNullOrEmpty(message))
            this.message = message;

        Console.WriteLine(message);
    }
}
