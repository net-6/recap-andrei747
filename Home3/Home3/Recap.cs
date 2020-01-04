using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Home3
{
    enum Image
    {
        Landscape,
        Portrait
    }
    public class Recap
    {

        //Conditionals
        /// <summary>
        /// Write a program and ask the user to enter a number. 
        /// The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. 
        /// Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        /*public void Problem1()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if(num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid"); 
            }

        }
        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public void Problem2()
        {
            Console.WriteLine("Type first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The maximum number is: " + Math.Max(num1, num2));

        }
        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait. Use an enum for in which to group the landscape and portrait orientations
        /// </summary>
        public void Problem3()
        {
            Console.WriteLine("Enter the width of the image");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth of the image");
            int num2 = int.Parse(Console.ReadLine());
            Image img1 = Image.Landscape;
            Image img2 = Image.Portrait;
            if(num1 <= 400 && num2 <= 400)
            {
                Console.WriteLine("The image is: " + img2);
            }
            else
            {
                Console.WriteLine("The image is :" + img1);
            }
        }
        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// penalty points. For every 5km/hr above the speed limit, 1 penalty point should be incurred and displayed on 
        /// the console. If the number of penalty points is above 12, the program should display License Suspended.
        /// </summary>
        public void Problem4()
        {
            Console.WriteLine("Enter the speed limit");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of car");
            int speedofCar = int.Parse(Console.ReadLine());
            int penaltypoints = 0;           
            if (speedofCar < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                
               for( int speedofCar1 = speedLimit; speedofCar1 < speedofCar; speedofCar1 = speedofCar1 + 5)
                    penaltypoints++;
                {

                    Console.WriteLine("You have:" + penaltypoints + " penalty points");
                    if(penaltypoints > 12)
                    {
                        Console.WriteLine("License Suspended");
                    }
                }
                                                                                                           
            }

        }*/
        //## Lists
        ///<pattern>
        /// 1) John, Mary and 3 others like your post
        /// 2) John and Mary like your post
        /// 3) John likes your post
        /// </pattern>
        ///  <summary>
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
        /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>
    }

    public class RecapProblem05
    {
        public void Problem5()
        {
            var names = new List<string>();

            while (true)
            {
                var name = TypeNames();
                if (!string.IsNullOrEmpty(name))
                {
                    names.Add(name);
                    Console.WriteLine(GetLikes(names));

                }

            }

        }

        private static string TypeNames()//create a method to type names
        {
            Console.WriteLine("Type a name");
            return Console.ReadLine();
        }
        private static string GetLikes(List<string> names)
        {

            if (names.Count > 2)
            {
                return names[0] + ", " + names[1] + " and " + Reducelist(names).Count + " others like your post";
            }
            if (names.Count == 2)
            {
                return names[0] + " and " + names[1] + " liked your post";
            }
            return names[0] + " liked your post";
        }
        private static List<string> Reducelist(List<string> names)
        {
            return names.GetRange(2, names.Count - 2);
        }

    }
    /// <summary>
    /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
    /// Display the reversed name on the console.
    /// </summary>
    public class RecapProblem06
    {
        public void Problem06()
        {
            Console.WriteLine("Please type your name");
            string s1 = Console.ReadLine();
            Array arr = s1.ToArray();
            Array.Reverse(arr);
            string s2 = arr.ToString();
            Console.WriteLine(s2);// i give up...i realy don't kow
            ///System.Char[]                      
        }

    }
    /// <summary>
    /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
    /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
    /// and display the result on the console.
    /// </summary>
    public class RecapProblem07
    {
        public void Problem07()
        {
            var n1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    int numbers = 0;
                    numbers = EnterNumbers();
                    var currentNumber = Array.IndexOf(n1, numbers);
                    if (currentNumber == -1)
                    {
                        n1[i] = numbers;
                        break;
                    }
                    Console.WriteLine("Stop! Please enter a different number");
                }
            }
            Array.Sort(n1);
            foreach (var num in n1)
            {
                Console.Write(num);
            }

        }

        private static int EnterNumbers()
        {
            Console.WriteLine("Enter 5 numbers");
            return int.Parse(Console.ReadLine());

        }

    }
    /// <summary>
    /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
    /// include duplicates. Display the unique numbers that the user has entered.
    /// </summary>
    public class RecapProblem08
    {
        public void Problem08()
        {
            var numberList = new List<int>();
            do//execute this first while is true
            {
                int rawNumber;
                Console.Write("Please enter the numbers: ");
                string input = Console.ReadLine();
                bool check = int.TryParse(input, out rawNumber);
                if (check == false && input == "quit")
                {

                    Console.WriteLine("List unique numbers:");
                    List<int> distinctList = numberList.Distinct().ToList();//separates the distinct numbers
                    foreach (var element in distinctList)
                        Console.WriteLine(element);
                    break;
                }

                if (check == false)//if you type letters
                    Console.WriteLine("To exit type quit or enter more numbers");

                else
                    numberList.Add(rawNumber);//add the numbers you type in a list

            } while (true);//

        }



    }

    /// <summary>
    /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
    /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
    /// the 3 smallest numbers in the list.
    /// </summary>
    /* public class RecapProblem09
     {
         public void Problem09()
         {
             var numbers = new List<int>();
             int rawNumber;
                 Console.WriteLine("Enter a list of numbers separated by commas");
                 var input = Console.ReadLine();
             string [] s1 =  input.Split(',');
             bool check = int.TryParse(input, out rawNumber);
             if(check == true)
             {
                 List<int> n1 = numbers.ToList();
                 n1.Add(s1);//nu stiu

             }

             if(string.IsNullOrEmpty(input) || n1.Count < 5)
             {
                 Console.WriteLine("Invalid");
             }


         }


     }*/
    //## Loops
    /// <summary>
    /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
    /// Display the result on the console.
    /// </summary>
    public class RecapProblem10
    {
        public void Problem10()
        {
            Console.WriteLine("Numbers divisible by 3: ");
            int number = 100;
            int div = 0;

            for (int i = 0; i < 100; i++)
            {

                if (i % 3 == 0)
                {
                    div = div + 1;

                }

            }
            Console.WriteLine(div);

        }
    }

    /// <summary>
    /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
    /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
    /// </summary>
    public class RecapProblem11
    {
        public void Problem11()
        {
            var numberList = new List<int>();

            do
            {

                string num = Console.ReadLine();
                int random = 0;
                if (num == "ok")
                {
                    int num2 = Convert.ToInt32(num[0]);
                    char[] ch = num.ToCharArray();


                    for (int i = 0; i < num.Length; i++)
                    {
                        random = num2 + num2;
                        Console.WriteLine(random);// stuck
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Type numbers");
                }



            } while (true);

        }


    }
    /// <summary>
    /// Write a program which takes a single number from the user,
    /// calculates the factorial and prints the value on the console.
    /// For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
    /// and display it as 5! = 120(result of 5 x 4 x 3 x 2 x 1).
    /// </summary>
    public class RecapProblem12
    {
        public void Problem12()
        {
            Console.WriteLine("Type a single number");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;

            }
            Console.WriteLine("{0}! = {1}", number, factorial);

        }

    }
    /// <summary>
    /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
    /// If the user guesses the number, display “You won". Otherwise, display “You lost".
    /// </summary>
    public class RecapProblem13
    {
        public void Problem13()
        {

            for (int i = 0; i < 4; i++)
            {

                int random = int.Parse(Console.ReadLine());

                Random rr = new Random();
                int guess = rr.Next(1, 10);
                if (random > guess)
                {

                    Console.WriteLine("You lost");
                }
                else if (random < guess)
                {
                    Console.WriteLine("You lost");
                }
                else
                {
                    Console.WriteLine("You win");
                }

            }

        }

    }
    /// <summary>
    /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
    /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
    /// display 8 on the console.
    /// </summary>
    public class RecapProblem14
    {
        public void Problem14()
        {
            var numbers = new int[100];
            
           for(int i = 0; i < numbers.Length; i++)
           {
               Console.WriteLine("Type a series of numbers");
                
                var str = Console.ReadLine();
                var num = str.Split(',');
                int num2 = Convert.ToInt32(num[0]); //input not in correct format
                //nu merge nu citeste n1, ramane zero...am incercat...aveam cu bool si fara convert
                //am dat parse, am incercat cu convert si se blocheaza, 
                //am incercat cu list<> ca la problem08 numai ca am pus .Max() si nici asa..a pai nu mai stiu
                if (str == "ok")
                {
                    numbers[i] = num2;
                    int[] arr = { numbers[i] };
                    Console.WriteLine(arr.Max());                    
                    break; 
                }
                                              
           }
                           
        }
       

    }
////## Strings
    /// <summary>
    /// Write a program and ask the user to enter a few numbers separated by a hyphen(minus). Work out 
    /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
    /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
    /// </summary>
    public class RecapProblem15
    {
        public void Problem15()
        {
            //luata de pe net
            Console.WriteLine("Type a few numbers separated by hypens");
            var num = Console.ReadLine();
            var numArray = num.Split('-');
            int values = Convert.ToInt32(numArray[0]);//nu inteleg
            bool check = true;
            for(var i = 0; i < numArray.Length; i++)
            {
                if(Convert.ToInt32(numArray[i]) + i  !=values && Convert.ToInt32(numArray[i]) - i !=values)//nu inteleg
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }


    }
    /// <summary>
    /// Write a program and ask the user to enter a few numbers separated by a hyphen(minus). If the user simply 
    /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
    /// any duplicates. If so, display "Duplicate" on the console.
    /// </summary>
   /* public class RecapProblem16
    {
        public void Problem16()
        {
            var numbers = new List<int>();
            Console.WriteLine("Write some numbers");
            var str = Console.ReadLine();
            var num = str.Split('-');
            int values = Convert.ToInt32(num[0]);//input not in correct format// nu mai inteleg nimic
            for (int i = 0; i < num.Length; i++)
            {
                if (string.IsNullOrEmpty(str))
                {
                    Environment.Exit(values);
                }
                else
                {
                    List<int> numberList = numbers.Distinct().ToList();
                    if (!numbers.Distinct())//cannot be applied to operand of type List<int> for numberList...nu mai stiu
                    {
                        Console.WriteLine("Duplicates");
                    }
                }

                numbers.Add(values);

            }

        }

    }*/

    /// <summary>
    /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
    /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
    /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
    /// </summary>
    public class RecapProblem17
    {
        public void Problem17()
        {
            Console.WriteLine("Write a time value");
            string date = Console.ReadLine();
            string date0 = Console.ReadLine();
            int date1 = Convert.ToInt32(date[0]);
            int date2 = Convert.ToInt32(date0[0]);
            int datehour = 23;
            int datemin = 59;
            if (date1 <= datehour && date2 <= datemin)
            {
                Console.WriteLine($" UTC time {date:HH:mm} = UTC time {date0:HH:mm}" + "Ok");
            }
            else
            {
                Console.WriteLine("Invalid time");///doesn't work...i don't know..in progress
            }
            
        }

    }

    /// <summary>
    /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
    /// create a variable name with PascalCase convention. For example, if the user types: 
    /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
    /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
    /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
    /// </summary>
    public class RecapProblem18
    {
        public void Problem18()
        {
            Console.WriteLine("Write some words");
            string str1 = Console.ReadLine();
            var str2 = str1.TrimEnd().ToLower();
            Console.WriteLine(str2.Replace(" ",string.Empty));
            if(str2 == string.Empty)
            {
                Console.WriteLine("error");
            }

        }
    }
    /// <summary>
    /// Write a program and ask the user to enter an English word. Count the number of vowels 
    /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
    /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
    /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
    /// </summary>
    public class RecapProblem19
    {
        public void Problem19()
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Enter a Sentence");
            string sentence = Console.ReadLine().ToLower();

            int total = sentence.Count(c => vowels.Contains(c));
            Console.WriteLine("Your total number of vowels is: {0}", total);
            

        }


    }

}






















