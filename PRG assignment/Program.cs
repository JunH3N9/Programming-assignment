// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
using PRG_assignment;
using System;
using System.Collections.Generic;

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
            List<Flavour> flavourlist = new List<Flavour>();
            for(int i = 8; i < 11; i++)
            {
                if (order[i] != " ")
                {
                    if (order[i] == "Durian" || order[i] == "Ube" || order[i] == "Sea Salt")
                    {
                        Flavour flavour = new Flavour(order[i], true, Convert.ToInt32(order[5]));
                        flavourlist.Add(flavour);

                    }
                    else
                    {
                        Flavour flavour = new Flavour(order[i], false, Convert.ToInt32(order[5]));
                        flavourlist.Add(flavour);
                    }
                }
            }
            List<Topping> toppingsList = new List<Topping>();
            for (int i = 11; i < 14; i++)
            {
                Topping topping = new Topping(order[i]);
                toppingsList.Add(topping);
            }

            if (order[4] == "Waffle")
            {
                Waffle waffle = new Waffle(order[4], Convert.ToInt32(order[5]), flavourlist, toppingsList, order[7]);
            }
            else if (order[4] == "Cone")
            {
                if (order[6] == "FALSE")
                {
                    Cone cone = new Cone(order[4], Convert.ToInt32(order[5]), flavourlist, toppingsList, false);
                }
                else
                {
                    Cone cone = new Cone(order[4], Convert.ToInt32(order[5]), flavourlist, toppingsList, true);
                }
            }
            else if (order[4] == "Cup")
            {

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