using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Write a C# Sharp program to find the sum of first 10 natural numbers
            //    *Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10
            #region
            int n = 0;
            int sum = 0;
            while (n < 10)
            {
                n++;
                var sum1 = n == 10 ? $"{n} = " : $"{n} + ";
                sum += n;
                Console.Write(sum1);
            }
            Console.Write(sum);
            Console.Write("\n");
            #endregion


            //2.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            //Console.WriteLine("Enter 10 numbers:");
            #region
            Console.WriteLine("Enter 10 numbers:");
            int[] arrOfNums = new int[10];
            int sumOfNums = 0;
            for (int i = 0; i < arrOfNums.Length; i++)
            {
                int number;
                bool parsed = int.TryParse(Console.ReadLine(), out number);
                if (parsed)
                {
                    arrOfNums[i] = number;
                }
                else
                {
                    Console.WriteLine("You entered an invalid number.");
                    break;
                }
            }
            foreach (var num in arrOfNums) sumOfNums += num;
            double avg = sumOfNums;
            Console.WriteLine($"The sum of numbers you entered is: {sumOfNums} and the average is {avg / arrOfNums.Length}");
            #endregion


            //3.Declare and init array of 10 integers by your choise. 
            //   Find maximum and minimum element in that array and their indexes.
            #region
            int[] arrOfNums2 = new int[] { 3, 33, 7, 100, 88, 8, 55, 1, 77, 12 };
            int max = arrOfNums2[0];
            int min = arrOfNums2[0];
            for (int i = 0; i < arrOfNums2.Length; i++)
            {
                if (max < arrOfNums2[i]) max = arrOfNums2[i];
                if (min > arrOfNums2[i]) min = arrOfNums2[i];
            }
            Console.WriteLine($"Maximum number is: {max}, index: {Array.IndexOf(arrOfNums2, max)}\n" +
                $"Minimum number is: {min}, index: {Array.IndexOf(arrOfNums2, min)}");
            #endregion


            //4.oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            //   Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays
            #region
            int[] oddEvenArray = new int[] { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            int[] clonedEven = new int[oddEvenArray.Length];
            int[] clonedOdd = new int[oddEvenArray.Length];

            Array.Copy(oddEvenArray, clonedEven, oddEvenArray.Length);
            Array.Copy(oddEvenArray, clonedOdd, oddEvenArray.Length);
            Console.WriteLine("Array with even numbers:");
            foreach (var even in clonedEven)
            {
                if (even % 2 == 0)
                    Console.Write($"{even} ");
            }
            Console.WriteLine("\n\nArray with odd numbers:");
            foreach (var odd in clonedOdd)
            {
                if (odd % 2 != 0)
                    Console.Write($"{odd} ");
            }
            #endregion


            //5.Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            //   the day with strings.Example: user enters 1, you should print Monday.
            #region
            string[] days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thirstday", "Friday", "Saturday", "Sunday" };
            int numOfDay;
            bool parsedNumOfDay = int.TryParse(Console.ReadLine(), out numOfDay);

            if (parsedNumOfDay)
            {
                numOfDay--;
                foreach (var day in days)
                {
                    if (numOfDay == Array.IndexOf(days, day))
                    {
                        Console.WriteLine(day);
                        break;
                    }
                    else if (numOfDay <= 0 || numOfDay >= 7)
                    {
                        Console.WriteLine("There is only 7 days in a week!");
                        break;
                    }
                }
            }
            else Console.WriteLine("Wrong input. Please try again.");
            #endregion

            //6.userNames = ["user1", "user2", "user3"]
            //   passwords = ["first", "second", "third"]
            //   Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //   Create a logic when user enters specific username to provide a correct password for that user, and when that
            //   happens you should print on the screen "You are logged in successfully".
            //   If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //   repeat the proccess from begining while he / she doesn't input correct username and password.


            //   Note: Every element in userNames corresponds with the element in passwords at same index.
            //   Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".
            #region
            //string[] userNames = new string[3] { "user1", "user2", "user3" };
            //string[] passwords = new string[3] { "first", "second", "third" };

            //CASE_1 
            //while (true)
            //{
            //    Console.WriteLine("Please enter your username:");
            //    string user = Console.ReadLine();
            //    Console.WriteLine("Please enter your password:");
            //    string usersPass = Console.ReadLine();
            //    foreach (var name in userNames)
            //    {
            //        foreach (var pass in passwords)
            //        {
            //            if (user == name && usersPass == pass)
            //            {
            //                if (Array.IndexOf(userNames, user) == Array.IndexOf(passwords, usersPass))
            //                {
            //                    Console.WriteLine("You are logged in successfully");
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Incorrect username or password");
            //                    break;
            //                }                        
            //            }
            //        }
            //    }
            //}


            //CASE_2 
            //while (true)
            //{
            //    Console.WriteLine("Please enter your username:");
            //    string user = Console.ReadLine();
            //    Console.WriteLine("Please enter your password:");
            //    string pass = Console.ReadLine();
            //    for (int i = 0; i < userNames.Length; i++)
            //    {
            //        for (int j = 0; j < passwords.Length; j++)
            //        {
            //            if (user == userNames[i] && pass == passwords[j])
            //            {
            //                if (Array.IndexOf(userNames, user) == Array.IndexOf(passwords, pass))
            //                {
            //                    Console.WriteLine("You are logged in successfully");
            //                    break;
            //                }
            //                if (Array.IndexOf(userNames, user) != Array.IndexOf(passwords, pass))
            //                {
            //                    Console.WriteLine("Incorrect username or password");
            //                }
            //            }
            //        }
            //    }
            //}


            //CASE_3
            //while (true)
            //{
            //    Console.WriteLine("Please enter your username:");
            //    string user = Console.ReadLine();
            //    Console.WriteLine("Please enter your password:");
            //    string usersPass = Console.ReadLine();
            //    int indexOfName = 0;
            //    int indexOfPass = 0;

            //    foreach (var name in userNames)
            //    {
            //        if (name == user)
            //        {
            //            indexOfName += Array.IndexOf(userNames, user);
            //        }
            //    }
            //    foreach (var pass in passwords)
            //    {
            //        if (pass == usersPass)
            //        {
            //            indexOfPass = Array.IndexOf(passwords, usersPass);
            //        }
            //    }
            //    if (indexOfName == indexOfPass)
            //    {
            //        Console.WriteLine("You are logged in successfully");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect username or password");
            //    }
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
