// See https://aka.ms/new-console-template for more information
using PRG_assignment;
using System;

void displayMenu()
{
    Console.WriteLine("Menu \n============= 1. List all customer \n2. List all current orders \n3. Register a new customer \n" +
        "4. Create an order \n5. Display order details of customer \n6. Modify order details");
}
void getOrders()
{
    using (StreamReader sr = new StreamReader("orders.csv"))
    {
        string? s = sr.ReadLine(); 
        
        while ((s = sr.ReadLine()) != null)
        {
            string[] order = s.Split(',');
            //Create flavour and add them to a list
            if (order[9] != null)
            {
                if (order[10] != null)
                {

                }
            }

            if (order[4] == "Waffle")
            {
                
                Waffle waffle = new Waffle(order[4], order[5], order[7]);
            }
        }
    }

}

while (true)
{
    int option = -1;
    displayMenu();
    Console.Write("Enter your option: ");
    try
    {
        option = Convert.ToInt32(Console.ReadLine());
        if (option < 1 || option > 3)
        {
            throw new ArgumentOutOfRangeException("Option must be 1, 2, or 3");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid option. Please choose an integer. \n");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Please choose from the list. \n");
    }
    if (option == 2)
    {

    }
}