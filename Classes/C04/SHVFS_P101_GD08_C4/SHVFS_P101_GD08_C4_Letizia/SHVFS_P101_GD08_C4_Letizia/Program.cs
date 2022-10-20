// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace SHVFS_P101_GD08_C04_Letizia
{
    public class program
    {
        public static void Main(string[] args)
        {
            //Arithmetic operators continued... */+-%
            // +=
            // -=
            // *=
            // /=
            // %=
            // ++
            // --

            //var arithmeticoperatorPlusPlus = 5;

            //// these are just shortcuts, shorter ways of writing code that does the same thing
            //arithmeticoperatorPlusPlus++;

            ////// arithmeticoperatorMultiply = arithmeticoperatorMultiply * 10
            ////// arithmeticoperatorPlusPlus = arithmeticoperatorPlusPlus + 1
            ////Console.WriteLine(arithmeticoperatorPlusPlus);
            ////Console.ReadLine();

            ////for loop
            ////first we assign a value to our variable, andd declare one if it needs to be declared
            //// the assignment is run once, before we enter our loop
            //// Then there is an evaluation/check...
            //// Then, we inrecment/decrement our variable at the END of the loop

            //Console.WriteLine("This is BOFORE our FOR LOOP!");

            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("This is THE FIRST LINE in our FOR LOOP!");
            //    Console.WriteLine($"The value of i is:{i}");
            //}
            //Console.WriteLine("This is AFTER our FOR LOOP!");
            //Console.ReadLine();

            //while loop
            //var input = "";

            //// while(true) is technically fine and has its uses, but be very careful and use it sparingly
            //// it is very dangerous, and provides no means of escape/exciting the program. It's a quick hack to get something working
            //while (input == "quit")
            ////while (true) 
            //{
            //    Console.Clear();
            //    // \ can be use as an escape character. here let's use the literal ""
            //    Console.WriteLine($"Enter \"Quit\" to win the game!");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Congrats! you win");
            //Console.ReadLine();

            //do while loop
            //very similar to while
            //it is not tested/evaluated until the loop is run once

            int i=2;
            Console.WriteLine("enter 1 for options\n" +
                "      2 for quit\n" +
                "      3 for start game");
            do
            {
                Console.WriteLine("please make a selection!");
                i = Convert. ToInt32(Console.ReadLine());
            } while (i < 1 || i > 3);
            Console.WriteLine("excellent choice!");
            Console.ReadLine();

            //Nested for Loops
            // You might work with these for 2d arrays, girds, tiles...
            // outer loop

            //for(var i = 0; i < 7; i++)
            //{
            //    // inner loop
            //    for(var j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"i is: {i},and j is: {j}");
            //    }
            //}
            //Console.ReadLine();

            //Arrays
            // Arrays start at index ZERO
            // will learn more about this 'new' keyword 
            // Arrays hold STUFF, and we set it to a size of FIVE (it can hold five things)
            // This array holds ints!
            // And we set it to hold
            //var scores = new int[7];
            //scores[0] = 7;
            //scores[1] = 24;
            //scores[2] = 2;
            //scores[3] = 9;
            //scores[4] = 1;
            //scores[5] = 234532;
            //scores[6] = 99;

            //you can also sset values for the indices when you declare the array, in a few ways...
            //we are just making it quicker, easier, simpler to code/read/write/understand
            //var scores = new int[5] { 55, 3, 24, 29, 33 };
            //var scores = new int[] { 55, 3, 24, 29, 33 };
            var scores = new[] { 55, 3, 24, 29, 33 };

            ////this is bad
            //// it use MAGIC NUMBERS /HARDCORED/INFLEXIBLE/DANGEROUS e.g. "5"
            //for (var i = 0; i < scores.Length; i++)
            //{
            //    //Console.WriteLine(scores[i]);
            //    Console.WriteLine($"the length of score is: {scores.Length} | the index is {i} | the value is: {scores[i]}");
            //}
            //Console.ReadLine();


            //for (var i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"the length of score is: {scores.Length} | the index is {i} | the value is: {scores[i]}");
            //}
            //Console.ReadLine();

            // choose age calculater or number guessing or quit (back to the menu)
            // age calculator: type number of people, type their age, calculate the sum, calculate the average
            // number guessing: guessing between 1~99, higher or lower hint
            // 20min
        }
    }
}