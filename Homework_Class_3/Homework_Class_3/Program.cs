using System;

namespace Homework_Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise_01
            #region
            //Get an input number from the console​
            //Print all numbers from 1 to that number
            //Get another input number from the console​
            //Print all numbers from that number to 1​

            //Console.WriteLine("Enter number:");
            //int input1 = Convert.ToInt32(Console.ReadLine());
            //int num = 0;
            //while (num < input1)
            //{
            //    num++;
            //    Console.Write($"{num} ");
            //}
            //Console.WriteLine("\nEnter number again:");
            //int input2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = input2; i > 0; i--)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            //Exercise_02
            #region
            //Get an input number from the console​
            //Print all even numbers starting from 2​
            //Get another input number from the console​
            //Print all odd numbers starting from 1​​

            //Console.WriteLine("Enter number:");
            //int num1;
            //bool parsedNum1 = int.TryParse(Console.ReadLine(), out num1);
            //if(parsedNum1)
            //{
            //    if (num1 > 1)
            //    {
            //        Console.WriteLine("\nEven Numbers:");
            //        for (int i = 1; i <= num1; i++)
            //        {
            //            if (i % 2 == 0) Console.Write($"{i} ");
            //        }
            //    }
            //    else Console.WriteLine("Error. You should type number greater the 1.");
            //    Console.WriteLine("\n\nEnter number again:");
            //    int num2;
            //    bool parsedNum2 = int.TryParse(Console.ReadLine(), out num2);
            //    if (parsedNum2)
            //    {
            //        if (num2 > 0)
            //        {
            //            Console.WriteLine("\nOdd numbers:");
            //            int someNum = 0;
            //            while (someNum < num2)
            //            {
            //                someNum++;
            //                if (someNum % 2 != 0) Console.Write($"{someNum} ");
            //            }
            //        }
            //        else Console.WriteLine("Error. You should type number greater the 0.");
            //    }
            //    else Console.WriteLine("Error occurred. Try again.");
            //}
            //else Console.WriteLine("Error occurred. Try again.");
            #endregion

            //Exercise_03
            #region
            //Create an array with names​
            //Give an option to the user to enter a name from the keyboard​
            //After entering the name put it in the array​
            //Ask the user if they want to enter another name(Y / N)​
            //Do the same process over and over until the user enters N​
            //Print all the names after user enters N​

            //string[] names = new string[] { };
            //var index = 0;

            //Console.WriteLine("Please enter a name:");

            //while (true)
            //{
            //    string userName = Console.ReadLine();
            //    index++;
            //    Array.Resize(ref names, index + 1);
            //    names[index] = userName;

            //    Console.WriteLine("If you like to enter another name press \"Y\", otherwise press \"N\":");
            //    string userInput = Console.ReadLine();
            //    if (userInput.ToUpper() == "Y")
            //    {
            //        Console.WriteLine("Please enter a name:");
            //        continue;
            //    }
            //    else if (userInput.ToUpper() == "N")
            //    {
            //        Console.WriteLine("\nArray of Names:");
            //        foreach (var name in names)
            //        {
            //            Console.WriteLine(name);
            //        }
            //        break;
            //    }
            //}
            #endregion

            //Exercise_04
            #region
            //Create two variables and initialize them with a keyboard input
            //Write code that can test which number is larger
            //Write code that can test the numbers whether they are even or odd
            //Write the larger number from the two in the console
            //After that write if the number is even or odd

            //Console.WriteLine("Please enter number:");
            //int inputNum1, inputNum2;
            //bool userInput1 = int.TryParse(Console.ReadLine(), out inputNum1);
            //Console.WriteLine("Please enter number again:");
            //bool userInput2 = int.TryParse(Console.ReadLine(), out inputNum2);

            //var evenOdd = inputNum1 % 2 == 0 ? $"Number {inputNum1} is Even number" : $"Number {inputNum1} is Odd number";
            //var evenOdd2 = inputNum2 % 2 == 0 ? $"Number {inputNum2} is Even number" : $"Number {inputNum2} is Odd number";

            //if (userInput1 && userInput2)
            //{
            //    if (inputNum1 == inputNum2)
            //    {
            //        Console.WriteLine($"The numbers {inputNum1} and {inputNum2} are equal and \n{evenOdd}");
            //    }
            //    else if (inputNum1 > inputNum2)
            //    {
            //        Console.WriteLine($"Number {inputNum1} is larger then number {inputNum2} and \n{evenOdd}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Number {inputNum2} is larger then number {inputNum1} and \n{evenOdd2}");
            //    }
            //}
            //else Console.WriteLine("Error occurred. Try again.");
            #endregion

            //Exercise_05
            #region
            //Solve the following problem. On one tree there are 12 branches with n apples on them. One basket can hold m apples. 
            //If a user enters number of trees find out how many baskets does it take to collect all the apples from the trees?​
            //n = 8​
            //m = 5​
            //Result = ?​


            //int branchesOnTree = 12;
            //int applesOnBrach = 8;
            //int basketWithApples = 5;
            //Console.WriteLine("Enter number of trees to find out how many baskets does it take to collect all the apples from the trees:");
            //int numOfTrees;
            //bool apples = int.TryParse(Console.ReadLine(), out numOfTrees);

            //if (apples)
            //{
            //    int result = (numOfTrees * (branchesOnTree * applesOnBrach)) / basketWithApples;
            //    Console.WriteLine($"It takes {result} baskets!");
            //}
            //else
            //{
            //    Console.WriteLine($"You didn't enter a number. Try again.");
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
