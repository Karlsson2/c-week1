// See https://aka.ms/new-console-template for more information

while (true)
{ 
    Console.WriteLine("Welcome to Amazing Ticket Systems 2.0");
    Console.WriteLine("Enter your email:");
    String email = Console.ReadLine();
    bool discount = false;
    double discountValue = 0.2;
    if (email.EndsWith("@yrgo.se") || email.EndsWith("@w3c.org"))
    {
        discount = true;
        Console.Write("A 20% discount will be applied at checkout!");
    }
    Console.WriteLine("Type A,B or C:");
    String userResponse = Console.ReadLine();
    if (userResponse == "A" || userResponse == "B" || userResponse == "C")
    {
        double price ;

        if (userResponse == "A")
        {
            if (discount == true)
            {
                price = 33 - (33 * discountValue);
                Console.WriteLine($"You have selected {userResponse}, your total is ${price:F2}");
                break;
            }
            else
            {
                price = 33;
                Console.WriteLine($"You have selected {userResponse}, your total is ${price:F2}");
                break;
            }
        }
        else if (userResponse == "B")
        {
            if (discount == true)
            {
                price = 40 -( 40 * discountValue);
                Console.WriteLine($"You have selected {userResponse}, your total is ${price:F2}");
                break;
            }
            else
            {
                price = 40;
                Console.WriteLine($"You have selected {userResponse}, your total is ${price:F2}");
                break;
            }
           
        }
        else if (userResponse == "C")
        {
            if (discount == true)
            {
                price = 60 - (60 * discountValue);
            }
            else
            {
                price = 60;
            }
            while (true)
            {
                Console.WriteLine("Would you like our special VIP package with that? +$20");
                Console.WriteLine("Type yes or no:");
                String userResponseYn = Console.ReadLine();
                if (userResponseYn== "yes")
                {
                    if (discount == true)
                    {
                        price = 80 - (80 * discountValue);
                    }
                    Console.WriteLine($"You have selected C+VIP, your total is {(price + 20):F2}");
                    break;
                }
                else
                {
                    Console.WriteLine($"You have selected {userResponse}, your total is ${price:F2}");
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