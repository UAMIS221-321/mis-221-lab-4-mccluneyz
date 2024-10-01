
using System.Formats.Asn1;
using System.Globalization;

DisplayMenu();
string userChoice = GetUserChoice();

while (userChoice != "4")
{
    RouteEm(userChoice);
    DisplayMenu();
    userChoice = GetUserChoice();
}

static void DisplayMenu()
{
    System.Console.WriteLine(@"Which type of pizza would you like
    1. Plain
    2. Cheese 
    3. Pepperoni
    4. Exit");
}
static string GetUserChoice()
{
    string userChoice = Console.ReadLine();
    return userChoice;
}

static void RouteEm(string userChoice)
{
    if (userChoice == "1")
    {
        PlainPizza();
    }
    if (userChoice == "2")
    {
        CheesePizza();
    }
    if (userChoice == "3")
    {
        PepperoniPizza();
    }
    if (userChoice == "4")
    {
        Exit();

    }
    else
    {
        System.Console.WriteLine("Invalid choice");
        
    }
}

static void PlainPizza()
{

    Random random = new Random();
    int numberRows = random.Next(8, 13);

    for (int i = 1; i < numberRows ; i++)
    {

        for (int j = 0; j <= i - 1; j++)
        {

            Console.Write(" *");
        }
        System.Console.WriteLine();
    }
}

static void CheesePizza()
{

    Random random = new Random();
    int numberRows = random.Next(8, 13);
    for (int i = 1; i <= numberRows; i++)
    {
        for (int j = 0; j <= i - 1; j++)
        {
            if (i == numberRows)
            {
                Console.Write(" *");
            }
            else
            {
                if (j == 0)
                {
                    Console.Write(" *");
                }
                else if (j == i - 1)
                {
                    Console.Write(" *");
                }
                else
                {
                    Console.Write(" #");
                }
            }


        }
        System.Console.WriteLine();
    }
}


static void PepperoniPizza()
{

    Random random = new Random();
    int numberRows = random.Next(8, 13);
    Random number = new Random();
    int ranNumber = number.Next(1, 11);
    for (int i = 1; i <= numberRows; i++)
    {
        ranNumber = number.Next(1, 11);

        for (int j = 0; j <= i - 1; j++)
        {
             
            if (i == numberRows )
            {
                Console.Write(" *");
            }
            else
            {
                if (j == 0)
                {
                    Console.Write(" *");
                }
                else if (j == i -1) 
                {
                    Console.Write(" *");
                }
                else
                {
                    Console.Write(" #");
                }
                if (j == ranNumber -1)
                {
                    
                    Console.Write(" []");
                }
                // else
                // {
                //     Console.Write(" #");
                // }
            }

        }
        System.Console.WriteLine();
    }
}


static void Exit()
{
    Console.Clear();
    DisplayMenu();
}


