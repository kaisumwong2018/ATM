// See https://aka.ms/new-console-template for more information
using ATM;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

Dbcontext db = new Dbcontext();
bool menu = true;

Console.WriteLine("Maybank ATM");
Console.WriteLine();
Console.WriteLine("1.Login");
Console.WriteLine("2.Exit");
string option1 = Console.ReadLine()!;


switch (option1)
{
    case "1":

        Console.Clear();
        Console.WriteLine("Cardnumber");
        string cardnumber = Console.ReadLine()!;
        Console.WriteLine("Password");
        string password = Console.ReadLine()!;
        var finduser = db.Users.FirstOrDefault(x=>x.PIN == password && x.CardNumber == cardnumber);
        if(finduser == null)
        {
            Console.WriteLine("User Not Found!");
            Console.ReadKey();
        }

        else
        {
            var loginuser = db.Users.FirstOrDefault(x=>x.);
        }


        Console.Clear() ;
        Console.WriteLine("Welcome To Maybank");
        Console.WriteLine("1.Check Balance");
        Console.WriteLine("2.Deposit");
        Console.WriteLine("3.Withdraw");
        Console.WriteLine("4.Transfer");
        Console.WriteLine("5.Transaction History");
        Console.WriteLine("6.Account");
        Console.WriteLine("7.Exit");
        string option2 = Console.ReadLine()!;

        switch (option2)
        {
            case "1":




                break;
        }



        break;


        case "2":

        Environment.Exit(0);

        break;
}





