// See https://aka.ms/new-console-template for more information

String username = "falken";
String password = "joshua";
int i = 0;

while (i < 4)
{
    Console.WriteLine("Enter your username;");
    string checkUserName = Console.ReadLine();
    Console.WriteLine("Enter your password:");
    string checkPassword = Console.ReadLine();
    if (username == checkUserName && password == checkPassword)
    {
        Console.WriteLine("Success: You have been authenticated!");
        break;
    }
    else
    {
        Console.WriteLine("Incorrect Password or Username, try again");
        Console.WriteLine($"{2-i} attempts left");
        i++;
    }
}