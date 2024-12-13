namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("Please Enter Number");
            //    int num = int.Parse(Console.ReadLine());

            //if ((num % 3 == 0) && (num % 4 == 0))
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            #endregion

            #region Q2. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("Please Enter Number");
            //int num = int.Parse(Console.ReadLine());

            //if (num > 0)
            //    Console.WriteLine("Positive");
            //else if (num < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Zero");

            #endregion

            #region  Q3. Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Third number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int max = Math.Max(num1 , Math.Max( num2,num3));

            //int min = Math.Min(num1 , Math.Min( num2 , num3));

            //Console.WriteLine($"Max Element = {max}");
            //Console.WriteLine($"Min Element = {min}");

            #endregion

            #region Q4. Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Please enter integer: ");

            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");

            #endregion

            #region Q5. Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //  Console.WriteLine("Enter one character");

            //  char letter = char.Parse(Console.ReadLine());

            //switch(letter)
            //{
            //      case 'a':
            //      case 'e':
            //      case 'i':
            //      case 'o':
            //      case 'u':
            //      case 'A':
            //      case 'E':
            //      case 'I':
            //      case 'O':
            //      case 'U':
            //          Console.WriteLine("Vowel");
            //          break;
            //      default:
            //          Console.WriteLine("Constant");
            //          break;
            //}


            #endregion

            #region Q7. Write a program that allows the user to insert an integer then print a multiplication table up to 12.


            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());

            //for (int i=1; i <=12; i++)
            //{
            //    Console.Write($"{num * i}");
            //}


            #endregion

            #region Q9. Write a program that takes two integers then prints the power.

            //Console.Write("enter number ");
            //int num = int.Parse(Console.ReadLine());

            //Console.Write("enter Power ");
            //int pow = int.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Pow(num, pow));

            #endregion


            #region Q10. Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Enter marks of five subjects: ");

            //int total = 0;
            //int[] marks = new int[5];
            //for(int i =0; i < 5; i++)
            //{
            //    marks[i] = int.Parse(Console.ReadLine());
            //    total += marks[i];
            //}


            //int avrg = total / marks.Length;
            //int percentage = total / marks.Length; // (total/500) *100 =? total/5 


            //Console.WriteLine($"Total= {total}");
            //Console.WriteLine($"Average= {avrg}");
            //Console.WriteLine($"Percentage= {percentage}");

            #endregion


            #region Q11. Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter Month: ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month 28 or 29");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //}


            #endregion


            #region Q17. Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.Write("Enter X1: ");
            //int X1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter X2: ");
            //int X2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter X3: ");
            //int X3 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Y1: ");
            //int Y1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Y2: ");
            //int Y2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Y3: ");
            //int Y3 = int.Parse(Console.ReadLine());

            //if ((Y3 - Y2)* (X2 - X1) == (Y2 - Y1)* (X3 - X2))
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");


            #endregion


            #region Q18. Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 

            //Console.Write("Please enter the time taken for the task: ");

            //float time = float.Parse(Console.ReadLine());

            //if ((time >= 2) && (time <= 3))
            //    Console.WriteLine("they are considered highly efficient.");
            //else if ((time >= 3) && (time <= 4))
            //    Console.WriteLine("they are instructed to increase their speed.");
            //else if ((time >= 4) && (time <= 5))
            //    Console.WriteLine("they are provided with training to enhance their speed.");
            //else if (time > 5)
            //    Console.WriteLine("they are required to leave the company.");

            #endregion


            #region Q21. Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int a = 10;
            //int b = 0;

            //b = a; // b will be = value of a (10)
            //a = 20; // modified a value but it will not affect b value

            //Console.WriteLine($"a ={a} and b = {b}");

            #endregion


            #region Q22. Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //String one = "One"; // one will store the address of word "One" in the stack that references to it in the heap
            //String two; // create pointer in stack that will references to string in heap with initial size 4 bytes

            //two = one; // two will be reference to the same value of one in the heap;

            //Console.WriteLine($"one refers to {one} and two refers to {two}");



            #endregion


            #region Q23. Which of the following statements is correct about the C#.NET code snippet given below?

            // Answer is b => A value 1 will be assigned to d.

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d); // 1


            // tracing:
            // Convert.ToInt32(!(false));
            // Convert.ToInt32(true);
            // 0 => false
            // 1 => true
            // since !(false) = true => d=1 after converting




            #endregion



            #region Q24. Which of the following is the correct output for the C# code given below?

            // Answer is d : 6 1
            //Console.WriteLine(13 / 2 + " " + 13 % 2);


            // tracing:
            // since 13/2 = 6.5 and cause 13 and 2 are int the output will be int too => 6
            //  13%2 = 1 




            #endregion


            #region Q25. What will be the output of the C# code given below?


            // Answer is d : 7 7


            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            // tracing:
            // (1 <= 0) => false
            // !(false) = true
            // ++num [prefix] = 2
            // since z++ is postfix => 2 + 5 = 7
            // z++ [postfix] = 6
            // since ++z [prefix] and z = 6 it will be 7
            // 7  7 


            #endregion


        }
    }
}
