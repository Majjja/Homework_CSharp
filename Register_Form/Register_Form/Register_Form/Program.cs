using System;

namespace Register_Form
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter: \"1\" - for register or" +
              "\n\"2\" - for login in the system!");

            string[] arrayOfEmails = new string[] { "admin@admindomain.com", "hello@yahoo.com", "hello@world.com" };
            string[] arrayOfPass = new string[] { "Ad#mi8$s@!", "HelloYahoo^!7", "HelloWorld$@!12" };

            int regLogInInput;
            bool parsedInput = int.TryParse(Console.ReadLine(), out regLogInInput);

            if (parsedInput && regLogInInput == 1 || regLogInInput == 2)
            {
                if (regLogInInput == 1)
                {
                    Console.WriteLine("Please enter your email:");
                    var userEmail = Console.ReadLine();

                    int isRegistered = Array.IndexOf(arrayOfEmails, userEmail);

                    if (isRegistered >= 0)
                    {
                        Console.WriteLine("You are allready registered, press \"2\" for login:");
                        regLogInInput = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(userEmail) &&
                               userEmail[0] >= (char)97 && userEmail[0] <= (char)122 &&
                               userEmail[userEmail.Length - 1] >= (char)97 &&
                               userEmail[userEmail.Length - 1] <= (char)122 &&
                               userEmail.Contains('@') &&
                               userEmail.Contains('.') &&
                               userEmail.Length < 30)
                        {
                            Array.Resize(ref arrayOfEmails, arrayOfEmails.Length + 1);
                            arrayOfEmails[arrayOfEmails.Length - 1] = userEmail;
                            Console.WriteLine("Please enter your password:");

                        }
                        else Console.WriteLine("Sorry, you didn't enter valid email");

                        var userPass = Console.ReadLine();

                        var number = 0;
                        var uppers = 0;
                        var symbols = 0;
                        var lowers = 0;
                        var punctation = 0;

                        if (!String.IsNullOrEmpty(userPass) &&
                     userPass.Length >= 10)
                        {
                            foreach (var ch in userPass)
                            {
                                if (Char.IsNumber(ch)) number++;
                                if (Char.IsLower(ch)) lowers++;
                                if (Char.IsUpper(ch)) uppers++;
                                if (Char.IsPunctuation(ch)) punctation++;
                                if (Char.IsSymbol(ch)) symbols++;
                            }
                            if (number > 0 && uppers > 0 && symbols > 0 && lowers > 0 && punctation > 0)
                            {
                                Array.Resize(ref arrayOfPass, arrayOfPass.Length + 1);
                                arrayOfPass[arrayOfPass.Length - 1] = userPass;
                                Console.WriteLine("Go on and login, press \"2\"");
                                regLogInInput = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                                Console.WriteLine("Sorry, your password should contain combination of small/big letters, " +
                                    "numbers and at least two special characters like (%, #, !, ^, &)");
                        }
                        else
                            Console.WriteLine("Sorry, your password should contain at least 10 characters");       
                    }
                }
                if (regLogInInput == 2)
                {
                    int count = 0;

                    while (true)
                    {
                        if (count == 3)
                        {
                            Console.WriteLine("Sorry. You are blocked for the next 24h, because you cross the limit of inputs.");
                            break;
                        }

                        Console.WriteLine("Enter your email - to login,\nor \"exit\" - to terminate the program:");
                        string userEmail = Console.ReadLine();

                        if (userEmail.ToLower() == "exit")
                            break;

                        Console.WriteLine("Enter your password:");
                        string userPass = Console.ReadLine();

                        int emailIndex = Array.IndexOf(arrayOfEmails, userEmail);
                        int passIndex = Array.IndexOf(arrayOfPass, userPass);

                        if (emailIndex > 0 && emailIndex == passIndex && passIndex > 0)
                        {
                            Console.WriteLine($"Welcome to the system!!!\nEnter \"1\" - to see the list of users:");

                            int user;
                            bool userParsed = int.TryParse(Console.ReadLine(), out user);
                            if (userParsed && user == 1)
                            {
                                int count2 = 0;
                                Console.WriteLine("List of users:");
                                foreach (var email in arrayOfEmails)
                                {
                                    count2++;
                                    Console.WriteLine($"{count2}. {email}");
                                }
                            }
                            else
                                Console.WriteLine("Wrong input. Sorry.");

                            while (true)
                            {
                                Console.WriteLine("Enter \"logout\" - to logout from the system:");
                                string userLogout = Console.ReadLine();
                                if (userLogout.ToLower() == "logout")
                                {
                                    break;
                                }
                                else
                                    Console.WriteLine("Wrong input.");
                            }
                        }
                        else if (emailIndex == 0 && passIndex == 0)
                        {
                            Console.WriteLine("Please enter:\n\"1\" - List of all users" +
                                                 "\n\"2\" - Delete user");
                            int admin;
                            bool adminParsedInt = int.TryParse(Console.ReadLine(), out admin);

                            if (adminParsedInt && admin == 1 || admin == 2)
                            {
                                if (admin == 1)
                                {
                                    int count1 = 0;
                                    Console.WriteLine("List of users:");
                                    foreach (var email in arrayOfEmails)
                                    {
                                        count1++;
                                        Console.WriteLine($"{count1}. {email}");
                                    }
                                }
                                else if (admin == 2)
                                {
                                    Console.WriteLine("Enter an email which you want to be deleted:");
                                    string deleteEmail = Console.ReadLine();
                                    int deleteEmailIndex = Array.IndexOf(arrayOfEmails, deleteEmail);
                                    if (deleteEmailIndex > 0)
                                    {
                                        int count3 = 0;
                                        Console.WriteLine("List of users:");
                                        foreach (var email in arrayOfEmails)
                                        {
                                            if (email == deleteEmail)
                                            {
                                                continue;
                                            }
                                            count3++;
                                            Console.WriteLine($"{count3}. {email}");
                                        }
                                    }
                                    else if (deleteEmailIndex == -1)
                                    {
                                        Console.WriteLine("There is no such user.");
                                    }
                                    else
                                        Console.WriteLine("This email can't be removed.");
                                }
                                while (true)
                                {
                                    Console.WriteLine("Enter \"logout\" - to logout from the system:");
                                    string userLogout = Console.ReadLine();
                                    if (userLogout.ToLower() == "logout")
                                    {
                                        break;
                                    }
                                    else
                                        Console.WriteLine("Wrong input.");
                                }
                            }
                            else
                                Console.WriteLine("Wrong input.");
                        }
                        else
                        {
                            count++;
                            Console.WriteLine("Wrong email or password.");
                        }
                    }
                }
            }
            else
                Console.WriteLine("Error occured.");
        }
    }
}
