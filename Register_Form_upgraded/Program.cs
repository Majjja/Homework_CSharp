using System;

namespace Register_Form_upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            Msg("Please enter: \"1\" - for register or" +
            "\n\"2\" - for login in the system!");

            string[] arrayOfEmails = new string[] { "admin@admindomain.com", "hello@yahoo.com", "hello@world.com" };
            string[] arrayOfPass = new string[] { "Ad#mi8$s@!", "HelloYahoo^!7", "HelloWorld$@!12" };

            int regLogInInput;
            bool parsedInput = int.TryParse(Console.ReadLine().Trim(), out regLogInInput);

            if (parsedInput && regLogInInput == 1 || regLogInInput == 2)
            {
                if (regLogInInput == 1)
                    RegisterForm(arrayOfEmails, arrayOfPass);

                if (regLogInInput == 2)
                    LoginForm(arrayOfEmails, arrayOfPass);
            }
            else
                Msg("Error occured.");
        }

        public static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void PrintTheUsers(string[] emails)
        {
            int num = 0;
            Msg("List of users:");
            foreach (var email in emails)
            {
                num++;
                Console.WriteLine($"{num}. {email}");
            }
        }

        public static void DeleteTheUsers(string[] emails)
        {
            string deleteEmail = Console.ReadLine().Trim();
            int deleteEmailIndex = Array.IndexOf(emails, deleteEmail);
            if (deleteEmailIndex > 0)
            {
                int num = 0;
                Msg("List of users:");
                foreach (var email in emails)
                {
                    if (email == deleteEmail)
                        continue;

                    num++;
                    Console.WriteLine($"{num}. {email}");
                }
            }
            else if (deleteEmailIndex == -1)
                Msg("There is no such user.");
            else
                Msg("This email can't be removed.");
        }

        public static void Logout()
        {
            while (true)
            {
                Msg("Enter \"logout\" - to logout from the system:");
                string userLogout = Console.ReadLine().Trim();
                if (userLogout.ToLower() == "logout")
                    break;
                else
                    Msg("Wrong input.");
            }
        }

        public static void LoginForm(string[] arrE, string[] arrPass)
        {
            int count = 0;
            while (true)
            {
                if (count == 3)
                {
                    Msg("Sorry. You are blocked for the next 24h, because you cross the limit of inputs.");
                    break;
                }
                Msg("Enter your email - to login,\nor \"exit\" - to terminate the program:");

                string userEmail = Console.ReadLine().Trim();

                if (userEmail.ToLower() == "exit")
                    break;

                Msg("Enter your password:");

                string userPass = Console.ReadLine().Trim();

                int emailIndex = Array.IndexOf(arrE, userEmail);
                int passIndex = Array.IndexOf(arrPass, userPass);

                if (emailIndex > 0 && emailIndex == passIndex && passIndex > 0)
                {
                    Msg($"Welcome to the system!!!\nEnter \"1\" - to see the list of users:");

                    int user;
                    bool userParsed = int.TryParse(Console.ReadLine().Trim(), out user);

                    if (userParsed && user == 1)
                        PrintTheUsers(arrE);
                    else
                        Msg("Wrong input. Sorry.");

                    Logout();
                }
                else if (emailIndex == 0 && passIndex == 0)
                {
                    Msg("Please enter:\n\"1\" - List of all users" +
                                         "\n\"2\" - Delete user");
                    int admin;
                    bool adminParsedInt = int.TryParse(Console.ReadLine().Trim(), out admin);

                    if (adminParsedInt && admin == 1 || admin == 2)
                    {
                        if (admin == 1)
                            PrintTheUsers(arrE);

                        else if (admin == 2)
                        {
                            Msg("Enter an email which you want to be deleted:");
                            DeleteTheUsers(arrE);
                        }
                        Logout();
                    }
                    else
                        Msg("Wrong input.");
                }
                else
                {
                    count++;
                    Msg("Wrong email or password.");
                }
            }
        }

        public static void RegisterForm(string[] arrE, string[] arrPass)
        {
            Msg("Please enter your email:");
            var userEmail = Console.ReadLine().Trim();
            int isRegistered = Array.IndexOf(arrE, userEmail);

            if (isRegistered >= 0)
            {
                Msg("You are allready registered");
                LoginForm(arrE, arrPass);
            }
            else
            {
                if (!String.IsNullOrEmpty(userEmail) && userEmail[0] >= (char)97 && 
                    userEmail[0] <= (char)122 && userEmail[userEmail.Length - 1] >= (char)97 &&
                    userEmail[userEmail.Length - 1] <= (char)122 && userEmail.Contains('@') &&
                    userEmail.Contains('.') && userEmail.Length < 30)
                {
                    Array.Resize(ref arrE, arrE.Length + 1);
                    arrE[arrE.Length - 1] = userEmail;
                    Msg("Please enter your password:");
                }
                else
                    Msg("Sorry, you didn't enter valid email");

                var userPass = Console.ReadLine().Trim();

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
                        Array.Resize(ref arrPass, arrPass.Length + 1);
                        arrPass[arrPass.Length - 1] = userPass;
                        LoginForm(arrE, arrPass);
                    }
                    else
                        Msg("Sorry, your password should contain combination of small/big letters, " +
                            "numbers and at least two special characters like (%, #, !, ^, &)");
                }
                else
                    Msg("Sorry, your password should contain at least 10 characters");
            }
        }
    }
}
