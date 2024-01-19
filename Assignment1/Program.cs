// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

using System.Data;


while (true)
{
    String userResponse = "";
    Console.WriteLine("Welcome to Amazing Ticket Systems 1.0");
    Console.WriteLine("Type A,B or C:");
    userResponse = Console.ReadLine();
    if (userResponse == "A" || userResponse == "B" || userResponse == "C")
    {
        string price = "";

        if (userResponse == "A")
        {
            price = "$33";
        }
        else if (userResponse == "B")
        {
            price = "$40";
        }
        else if (userResponse == "C")
        {
            price = "$60";
        }
        
        Console.WriteLine($"You have selected {userResponse}, your total is {price}");
        break;
    }
    else
    {
        Console.WriteLine("I'm sorry, that's not a valid ticket.");
    } 
}