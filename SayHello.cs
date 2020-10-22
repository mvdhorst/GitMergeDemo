using System;
using System.Linq;

public class SayHello
{
    private string message = "Hello World.";

    // CTor  
    public SayHello(string message = "")
    {
        if (!string.IsNullOrEmpty(message))
            this.message = message;

		Greet();
        Console.WriteLine(message);
    }
	
	public void Greet()
	{
	  Console.WriteLine(message);
	  Console.WriteLine(message);
	  Console.WriteLine(message);
	}

}
// This is the comment
