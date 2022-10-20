#region Structure of a program

//namespace
//contain classes
//like a dictionary made for us, or by us, and pprovide and tools we can use
//note the syntax
//keywords/reserved words namespace, followed bt the name of our namespace, opening and closing curly braces
//words that we ARE NOT ALLOWED to use

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SHVFS_P101_GD08_Letizia
{
    // class
    //contain variables -- fields and parameters -- to store data, and methods to do things (function)
    //Note the syntas
    //public -> access modifier
    public class program
    {
        //Technically methods are in object oriented programming (C#)... but they are basically use interchangeably
        //methods contains statements that do things
        //the main method is entry point for out program/console app
        //Note the syntax, keywords/access modifiers, static, reture type (void), arguments/parameters (string[]args)
        public static void Main(string[] args)
        {
            //type
            //int
            //4 bytes, counting/whole number
            //we canuse explict types or implict var
            //int myFirstNumber = 5;
            //var mySecondNumber = 8;

            //Console.WriteLine($"My first number is: {myFirstNumber}");
            //Console.WriteLine($"My Second number is: {mySecondNumber}");
            //Console.ReadLine();

            //float myfirstnumber = 14.847568928098f;
            //var mysecondnumber = 324.849309847647f;
            //var mythirdthing = 6.0976746999;

            //double myfirstrealdouble = 344.970497854;

            //Console.WriteLine($"My first float is: {myfirstnumber},and my first double's:{myfirstrealdouble}");
            //Console.ReadLine();

            //char myfirstChar = 'A';
            //Console.WriteLine($"my First Char is: {myfirstChar}");
            //Console.ReadLine();

            //typecast/typecasting
            //ASCII-> American Standard Code for Information Interchange
            //int MyfirstNumberchar = 'A';
            //char myfirstcharnumber = (char)65;
            //Console.WriteLine($"My first number char is: {MyfirstNumberchar}, and my first char number is {myfirstcharnumber}");
            //Console.ReadLine();

            //statements
            //everthing we've written inside our main method, has been statsments
            //statements  can assign variables, write to the console, read from the console, and MUCH MORE
            //Statements always end in the semi-colons: ';'
            //use intellisense if you have compiler ERRORS

            //string
            //string together a bunch of characters (char)
            //string myfirststring = "Hello";
            //myfirststring = myfirststring + "characters!";
            //Console.WriteLine($"{myfirststring} has\n {myfirststring.Length} characters");
            //Console.ReadLine();

            //working with user input
            //type can be declared all on the same line, and use commas if they're the same type
            //Readlin waits for the user to type something, and hit enter
            //CLear -> Clears the console


            //string name, age; int idealAge = 21;
            //Console.Clear();
            //Console.WriteLine("Hi! What's your name?");
            //name = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Annnd what's your age?");
            //age = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine($"Oh, hello {name}, nice to know you're {age} years old. Too bad you're not {idealAge}!");
            //Console.ReadLine();

            // Mathematical operators
            // + addition
            // - substraction
            // * multiplication
            // / division
            // % modulus
            // = assignment/logical operator
            //var number1 = 15;
            //var number2 = 9;
            //int total1;
            //float total2;
            //total1 = number1 + number2;
            //Console.WriteLine($"Addition: {total1}");
            //total1 = number1 - number2;
            //Console.WriteLine($"Substraction: {total1}");
            //total1 = number1 * number2;
            //Console.WriteLine($"Multiplcation: {total1}");
            //total1 = number1 / number2;
            //Console.WriteLine($"Division 1: {total1}");
            //total2 = number1 / (float)number2;
            //Console.WriteLine($"Division 2: {total2}");
            //total1 = number1 % number2;
            //Console.WriteLine($"Modulus: {total1}");
            //total1 = (number1 + number2) * 2;
            //Console.WriteLine($"Mathsss: {total1}");
            //Console.ReadLine();

            //Converting String input to numbers!
            //String number1;
            //string number2;
            //Console.WriteLine("Hi I'm Mr. Calculator! Please enter a number ^_^");
            //number1 = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Oh boy, that was Great! Please enter a second number so I can CALLLCULLLLLAAAATE! \nI'm gonna add them together!");
            //number2 = Console.ReadLine();
            //Console.Clear();
            //var num1converted = Convert.ToInt32(number1);
            //var num2converted = Convert.ToInt32(number2);
            //Console.WriteLine($"Oh wow! Those were great numbers! I've added them up, and the sum is... \n{num1converted + num2converted}!!!");
            //Console.ReadLine();

            //HW
            //finish this if you haven't
            //create a calculator for converting Fahrenheit to celsius

            //String degree1;
            //Console.WriteLine("Hi, this is calculator which could convert Fahrenheit to Celsius. Please type your Fahrenheit degree here:");
            //degree1 = Console.ReadLine();
            //Console.Clear();

            //var celsius1 = Convert.ToInt32(degree1);
            //Console.WriteLine($"So the Celsius of your Fahrenheit is... \n{5*(celsius1-32)/9}!!!");
            //Console.ReadLine();

            // The boolean/bool type
            // Relational operators
            // >
            // <
            // >=
            // <=
            // ==
            // !=
            // var is syntactic sugar, the compiler can infer the type is int.

            //var firstNumber = 20;
            //var secondNumber = 30;

            //// bools can be true or false
            //// implicitly typed var
            //var evaluation = firstNumber > secondNumber;
            //// explicity typed bool
            //bool altevaluation = firstNumber > secondNumber;

            //Console.WriteLine($"evaluation is: {evaluation}, as int it's {Convert.ToInt32(evaluation)}");
            //Console.ReadLine();

            //int numberToGuess = 80;
            //int guess;
            //Console.WriteLine("what number am I thinking of");
            //guess = Convert.ToInt32(Console.ReadLine());

            //if (guess < numberToGuess) 
            //{
            //    Console.WriteLine("You guess was too low.");
            //}
            //if (guess > numberToGuess) 
            //{
            //    Console.WriteLine("You guess was too high.");
            //}
            //if (guess == numberToGuess) 
            //{
            //    Console.WriteLine("You got it.");
            //}
            //Console.ReadLine();

            // Logical operators
            // && and
            // || or (this is called a pipe)

            var rand = new Random();
            var randombool1 = Convert.ToBoolean(rand.Next(2));
            var randombool2 = Convert.ToBoolean(rand.Next(2));
            var randombool3 = Convert.ToBoolean(rand.Next(2));
            bool answer;

            Console.Clear();
            Console.WriteLine("Answer with true for TRUE, or False for FALSE");
            Console.WriteLine("A is {0}, B is {1}, C is {2}", randombool1, randombool2, randombool3);
            //Console.WriteLine("A is" + randombool1 + "B is" + randombool2 + "C is" + randombool3);
            //Console.WriteLine($"A is {randombool1}, B is {randombool2}, C is {randombool3}");

            Console.WriteLine("What is A && B?");
            answer = Convert.ToBoolean(Console.ReadLine());

            if (answer == (randombool1 && randombool2))
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("incorrect!");
            }

            Console.WriteLine("what is A || C?");
            answer = Convert.ToBoolean(Console.ReadLine());

            if (answer == (randombool1 || randombool3))
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("incorrect!");
            }


            Console.WriteLine("what is A && B && C?");
            answer = Convert.ToBoolean(Console.ReadLine());

            if (answer == (randombool1 && randombool2 && randombool3))
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("incorrect!");
            }

        }
    }
}

#endregion