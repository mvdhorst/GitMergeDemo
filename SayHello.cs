using System;

public class SayHello
{
    private string message = "Hello, World.\n";

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
	}

}
