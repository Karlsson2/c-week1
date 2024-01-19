while (true)
{ 
    Console.WriteLine("Welcome to Amazing Ticket Systems 2.0");
    Console.WriteLine("Type A,B or C:");
    String userResponse = Console.ReadLine();
    if (userResponse == "A" || userResponse == "B" || userResponse == "C")
    {
        string price ;

        if (userResponse == "A")
        {
            price = "$33";
            Console.WriteLine($"You have selected {userResponse}, your total is {price}");
            break;
        }
        else if (userResponse == "B")
        {
            price = "$40";
            Console.WriteLine($"You have selected {userResponse}, your total is {price}");
            break;
           
        }
        else if (userResponse == "C")
        {
            price = "$60";
            while (true)
            {
                Console.WriteLine("Would you like our special VIP package with that? +$20");
                Console.WriteLine("Type yes or no:");
                String userResponseYn = Console.ReadLine();
                if (userResponseYn== "yes")
                {
                    Console.WriteLine("You have selected C+VIP, your total is $80");
                    break;
                }
                else
                {
                    Console.WriteLine($"You have selected {userResponse}, your total is {price}");
                    break; 
                }

            }
            break;
        }
        

    }
    else
    {
        Console.WriteLine("I'm sorry, that's not a valid ticket.");
    } 
}