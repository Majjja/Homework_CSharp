using System;

namespace Homework_Class_05
{
    //Task 7
    #region
    public class Dog
    {
        public string Name;
        public string Race;
        public string Color;

        public void Eat()
        {
            Console.WriteLine($"{Name} is now eating!");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is now playing!");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"{Name} is now chasing it's tail.");
        }
    }
    #endregion

    //Task 8
    #region
    public class Human
    {
        public string FirstName;
        public string LastName;
        private int Age;
        public DateTime DateOfBirth;


        DateTime Today = DateTime.Now;
        public void GetAge(DateTime DateOfBirth)
        {
            if (Today.Month < DateOfBirth.Month)
                Age = Today.Year - DateOfBirth.Year - 1;
            else
                Age = Today.Year - DateOfBirth.Year;
        }

        public void GetPersonStats()
        {
            GetAge(DateOfBirth);
            Console.WriteLine($"Hello {FirstName} {LastName}, you are {Age} years old");
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //* Print individual characters of the string in reverse order. *Example: we love c# *Expected Output : #c evol ew

            string someString = "We love C#";
            char[] reverseString = someString.ToCharArray();
            Array.Reverse(reverseString);
            string join = "";
            foreach (var item in reverseString)
            {
                join += item;
            }
            Console.WriteLine(join);


            //Task 2
            //Count the total number of words in a string entered by the user. * 
            //Example: user enters "I love C#" * Expected output: "I love c#" contains 3 words.

            Console.WriteLine("Enter some words:\n*Note: Type space between every word");
            string userInput = Console.ReadLine().Trim();
            string[] enteredWords = userInput.Split(' ');
            int count = 0;
            foreach (var word in enteredWords)
            {
                count++;
            }
            Console.WriteLine(count);


            //Task 3
            //* Find maximum occurring character in a string* Example: "We want this situation with covid-19 to ends!" * 
            //Expected Output: The highest frequency of character 't' appears number of times : 6

            string covid = "We want this situation with covid-19 to ends!";
            string[] deleteSpaces = covid.ToLower().Split(' ');
            string joined = "";
            foreach (var item in deleteSpaces)
            {
                joined += item.Trim();
            }

            char[] characters = joined.ToCharArray();

            int[] arrOfOccurrence = new int[characters.Length];
            int index = 0;
            int counter = 0;
            while (counter < arrOfOccurrence.Length)
            {
                arrOfOccurrence[index] = 0;
                counter++;
            }

            for (int i = 0; i < characters.Length; i++)
            {
                int occurence = 1;
                for (int j = i + 1; j < characters.Length; j++)
                {
                    if (characters[i] == characters[j])
                        occurence++;
                }
                arrOfOccurrence[i] = occurence;
            }
            int max = 0;
            foreach (var item in arrOfOccurrence)
            {
                if (max < item)
                    max = item;
            }
            int indexOfMax = Array.IndexOf(arrOfOccurrence, max);
            Console.WriteLine($"The highest frequency of character '{characters[indexOfMax]}' appears number of times : {max}");


            //Task 4
            //"The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!"
            //* Print the whole text after "," in the console. *Bonus - Try to do that without counting the characters till "," by yourself :)

            //one way
            string ourGroup = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";
            int character = ourGroup.IndexOf(',');
            string ourGroupSubs = ourGroup.Substring(character + 2);
            Console.WriteLine(ourGroupSubs);

            //another way
            string[] partOfString = ourGroup.Split(", ");
            Console.WriteLine(partOfString[1]);


            //Task 5
            //* Display the Day properties(year, month, day, hour, minute, second) from the today's date. *Expected Output : *year = 2020
            //* month = 3
            //* day = 26
            //* hour = 23
            //* minute = 12
            //* second = 22

            DateTime today = DateTime.Now;
            int year = today.Year;
            int month = today.Month;
            int day = today.Day;
            int hour = today.Hour;
            int minute = today.Minute;
            int second = today.Second;
            Console.WriteLine($"year = {year}\nmonth = {month}\nday = {day}\nhour = {hour}\nminute = {minute}\nsecond = {second}");


            //Task 6
            //* Find the leap years between 2008 and 2020. * Expected output: *2008 is a leap year.
            //* 2012 is a leap year. * 2016 is a leap year. * 2020 is a leap year.
            //* Hint - make some researches of DateTime methods, you will find interesting ones that might help you;)

            for (var leapYear = 2008; leapYear <= 2020; leapYear++)
            {
                if (DateTime.IsLeapYear(leapYear))
                    Console.WriteLine($"{leapYear} is a leap year.");
            }


            //Task 7
            //Create a class Dog
            //Add properties: Name, race, color
            //The dog needs to have:
            //Eat method that returns message: The dog is now eating
            //Play method returning a message : The dog is now playing
            //ChaseTail method that returns a message: Dog is now chasing its tail.
            //The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.

            var usersDoggy = new Dog();
            Console.WriteLine("Please enter name of a dog:");
            usersDoggy.Name = Console.ReadLine();
            Console.WriteLine("Please enter race of a dog:");
            usersDoggy.Race = Console.ReadLine();

            Console.WriteLine("Please enter color of a dog:");
            usersDoggy.Color = Console.ReadLine();

            Console.WriteLine($@"Please choose ""1"", ""2"" or ""3"" to see what is {usersDoggy.Name} doing:");
            int input;
            bool parsedInput = int.TryParse(Console.ReadLine(), out input);
            if (parsedInput)
            {
                switch (input)
                {
                    case 1:
                        usersDoggy.Eat();
                        break;
                    case 2:
                        usersDoggy.Play();
                        break;
                    case 3:
                        usersDoggy.ChaseTail();
                        break;
                    default:
                        Console.WriteLine("Sorry, You didn't enter the right number.");
                        break;
                }
            }
            else
                Console.WriteLine("Sorry, You didn't enter the right input.");


            //Task 8
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonStats that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information
            //Call the GetPersonStats method and print the result in the console after the object is created

            var user = new Human();
            Console.WriteLine("Please enter your name:");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Please enter your date of birth:");
            user.DateOfBirth = DateTime.Parse(Console.ReadLine());
            user.GetPersonStats();
        }
    }
}
