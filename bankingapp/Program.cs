using System.ComponentModel.Design;
using System.Xml.Serialization;

void buildbankingapp()
{
    int choice;
    int choice2;
    double depositAmount;
    double withdrawlamount; 
    double accountbalance = 1000.00; 
    Console.WriteLine("Please choose an option");
    Console.WriteLine("========================");
    Console.WriteLine("1 - deposit or withdraw funds");
    Console.WriteLine("2 - view current account information");
    Console.WriteLine("please choose an option (1-2)");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1 || choice == 2)
    {
        if (choice == 1)
        {
            Console.WriteLine("\nYou have chosen to manage funds.");
            Console.WriteLine("1 - Deposit");
            Console.WriteLine("2 - Withdraw");
            Console.Write("Please choose an option (1 or 2): ");
            choice2 = Convert.ToInt32(Console.ReadLine());


            if (choice2 == 1)
            {
                Console.WriteLine("You have chosen to deposit funds");
                Console.WriteLine("how much do you want to deposit");
                Console.WriteLine("enter amount including pence using a decimal point");


                depositAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"your original account balance was {accountbalance}");

                accountbalance += depositAmount;
                Console.WriteLine($"your new account balance is  {accountbalance}");

            }
            else
            {
                Console.WriteLine("You have chosen to withdrawl funds");
                Console.WriteLine("How much do you want to withdrawl");
                Console.WriteLine("Enter amount including pence using a decimal point"); 
                
                withdrawlamount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"your orignal account balance was {accountbalance}");

                accountbalance -= withdrawlamount;
                Console.WriteLine($"your new balance is {accountbalance}"); 
            }
        }
        if (choice == 2)
        {
            Console.WriteLine("You have chosen to view account information");
            Console.WriteLine($"Your current account balance is {accountbalance}");
            Console.WriteLine("Enter amount including pence using a decimal point"); 

        }
        else
        {
            Console.WriteLine("You have chosen to view information");
          

        }
    }
    else
    {
        Console.WriteLine("invalid choice, please choose 1 or 2");
    }
}

buildbankingapp(); 
