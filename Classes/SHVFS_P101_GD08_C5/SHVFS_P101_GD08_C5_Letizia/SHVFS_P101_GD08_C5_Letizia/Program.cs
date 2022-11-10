//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace SHVFS_P101_GD08_C05_Letizia
{
    public class program
    {
        public static void Main(string[] args)
        {
            //PrintHello();
            // the arguement type is abcde
            //PrintHelloName("abcde");
            //var expArray = new[] { 23, 345, 22, 20, 1, 99, 9999, 2, 3 };
            //var maxEXP = GetMaxEXP(expArray);

            //Console.WriteLine($"Our max exp is: {maxEXP}");

            //var smileyface = ReturnSmileyFace();
            //Console.WriteLine(smileyface);

            //// out modifier MUST be set before ANYTHING is returned
            //string input;
            //int radius;
            //double myCircumference;
            //double myArea;

            //do
            //{
            //    Console.WriteLine("Please enter a radius");
            //    input = Console.ReadLine();
            //} while (!int.TryParse(input, out radius) || !TryCircle(radius, out myCircumference, out myArea));

            //Console.WriteLine($"Your circle has a raidus of {radius}, a circumference of {myCircumference}, and an area of {myArea}");
            //Console.ReadLine();

            // With ref modifier we tell the compiler WE WILL set them
            //string input;
            //int radius;
            //double myCircumference = 0;
            //double myArea = 0;

            //do
            //{
            //    Console.WriteLine("Please enter a radius");
            //    input = Console.ReadLine();
            //} while (!int.TryParse(input, out radius) || !TryCircleRef(radius, ref myCircumference, ref myArea));

            //Console.WriteLine($"Your circle has a raidus of {radius}, a circumference of {myCircumference}, and an area of {myArea}");
            //Console.ReadLine();

            //string input;
            //int radius;
            //double myCircumference = 0;
            //double myArea = 0;

            //do
            //{
            //    Console.WriteLine("Please enter a radius");
            //    input = Console.ReadLine();
            //} while (!int.TryParse(input, out radius) || !TryCircleOops(radius, myCircumference, myArea));

            //Console.WriteLine($"Your circle has a raidus of {radius}, a circumference of {myCircumference}, and an area of {myArea}");
            //Console.ReadLine();

            // let's talk a little about scope...Local and global varialbles

            //Scope: Anything INSIDE the Main method can see and use i
            //Nothing outside the Main method can see or use
            //int i;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Classes and objects
            // Classes sorta like templates, and they are used/reusedd to create OBJECTS
            //we use the new keyword to create an instance of a class
            // this runs the classes' constructor -- which is public
            // It create a version of it in memory -- an instance -- assigning it the cariable name

            var pikachu1 = new Pokemon(20);
            var pikachu2 = pikachu1;
            pikachu2.HP = 99999;
            Console.WriteLine($"pikachu1 HP: {pikachu1.HP} | pickachu2's HP: {pikachu2.HP}");

            var pokemonData1 = new PokemonData(48);
            var pokemonData2 = pokemonData1;
            pokemonData2.EXP = 47893478;
            Console.WriteLine($"pokemonData1 EXP: {pokemonData1.EXP} | pokemonData2 EXP: {pokemonData2.EXP}");
            Console.WriteLine($"Oh! Statics! {Pokemon.BaseType}");

            Console.ReadLine();
        }

        //public static void WheresI()
        //{
        //    Console.WriteLine(i);
        //}

        ////break
        ////terminates the closest enclosing loop

        //var input = "";
        //// this while(true) is very very dangerous
        //while (true)
        //{
        //    Console.Clear();
        //    Console.WriteLine("Type 'y' to quit");
        //    input = Console.ReadLine();

        //    if (input == "y")
        //    {
        //        break;
        //    }
        //    // this line won't appear when type y
        //    Console.WriteLine("Did not exit the loop...");
        //}
        //Console.WriteLine("Quiting...");
        //Console.ReadLine();

        //continue
        //proceeds to the next iteration of the loop

        //for (var i = 0; i < 10; i++)
        //{
        //    if (i == 4)
        //    {
        //        continue; // if use break. the loop end at 3, use continue will end until 9
        //    }
        //    Console.WriteLine(i);

        //}
        //Console.ReadLine();

        //}
        //public static void PrintHello()
        //{
        //    Console.WriteLine("Hello!");
        //}
        ////the boolean/bool type
        // methods/functions are blocks of code that DO THINGS that we can reuse
        //we've already been using them...Writeline, Readline, Clear, etc.
        // They can have input -- parameters in the definition/arguement that are passed -- and outputs --return

        // this method has no parameters in its Signature and returns nothing (void)

        // methods can have as many parameters as we want to define
        // usually more than a few, is a sign that you metho is doing too much..
        // Methods can only return ONE value.
        // This method has No parameter in its Signature and returns NOTHING (void)

        //this method has ONE parameter, a string called 'name', in its SIGNATURE and returns NOTHING (void)
        public static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello,{name}");
        }

        //this method has ONE parameter in its signature and returns an int
        public static int GetMaxEXP(int[] intArray)
        {
            var maximum = intArray[0];

            for (var i = 0; i < intArray.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                if (intArray[i] > maximum)
                {
                    maximum = intArray[i];
                }
            }
            return maximum;
        }

        //This method has NO parameters and returns a strings
        public static string ReturnSmileyFace()
        {
            Console.WriteLine("Returning a smiley face...");
            return ":)";
        }

        // out/ref modifiers
        // out modifier Must be set before ANYTHING is returned
        public static bool TryCircle(int radius, out double circumference, out double area)
        {
            circumference = 0;
            area = 0;

            if (radius == 0)
            {
                Console.WriteLine("you need to enter a raius for a circle, silly billy!");
                return false;

            }

            circumference = Math.PI * radius * 2;
            area = Math.PI * Math.Pow(radius, 2);
            return true;
        }

        // with the ref modifier we tell the compiler that WE WILL set it LATER
        public static bool TryCircleRef(int radius, ref double circumference, ref double area)
        {
            circumference = 0;
            area = 0;

            if (radius == 0)
            {
                Console.WriteLine("you need to enter a raius for a circle, silly billy!");
                return false;

            }

            circumference = Math.PI * radius * 2;
            area = Math.PI * Math.Pow(radius, 2);
            return true;
        }

        public static bool TryCircleOops(int radius, double circumference, double area)
        {

            if (radius == 0)
            {
                Console.WriteLine("you need to enter a raius for a circle, silly billy!");
                return false;

            }

            circumference = Math.PI * radius * 2;
            area = Math.PI * Math.Pow(radius, 2);
            return true;
        }


        }
    public class Pokemon
    {
        public static string BaseType = "Pokemon";
        private static string baseType = "Pokemon";
        // Non-static public field
        // it is public,so other classes can see/access it
        // Since it's non-static, it is accessed on instances of the class
        public int HP;

        // the constructor is a special method used to create a c=version/object/instance
        // the constructor name and class name MUST MATCH
        // it runs once, when the object is created (the 'new' keyword is used)
        // there are No return types with constructors
        // we can use them to assign fields/properties

        public Pokemon(int hp)
        {
            HP = hp;
        }
    }

    public struct PokemonData
    {
        public int EXP;
        public PokemonData(int exp)
        {
            EXP = exp;
        }
    }
}
