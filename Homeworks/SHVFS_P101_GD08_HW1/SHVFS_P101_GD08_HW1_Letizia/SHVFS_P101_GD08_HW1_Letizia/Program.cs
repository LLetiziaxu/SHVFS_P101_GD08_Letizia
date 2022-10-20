// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



namespace SHVFS_P101_GD08_Letizia
{
    public class program
    {
        public static void Main(string[] args)
        {
            String degree1;
            Console.WriteLine("Hi, this is calculator which could convert Fahrenheit to Celsius. Please type your Fahrenheit degree here:");
            degree1 = Console.ReadLine();
            Console.Clear();

            var celsius1 = Convert.ToInt32(degree1);
            Console.WriteLine($"So the Celsius of your Fahrenheit is... \n{5 * (celsius1 - 32) / 9}!!!");
            Console.ReadLine();
        }
    }
}