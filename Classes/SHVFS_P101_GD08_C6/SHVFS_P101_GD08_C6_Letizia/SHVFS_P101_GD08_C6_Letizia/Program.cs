// See https://aka.ms/new-console-template for more information
using Microsoft.Win32.SafeHandles;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;


namespace SHVFS_P101_GD08_C05_Letizia
{
    internal class program
    {
        public static void Main(string[] args)
        {
            //PrintAThing("Something funnt things");
            //Console.ReadLine();

            //var pokemon1 = new Pokemon();
            //pokemon1.EXP = 900;
            //var pokemon2 = new Pokemon(100);
            //var pokemon3 = new Pokemon() { EXP = 9000 };

            //Console.WriteLine($"P1:{pokemon1.EXP} | P2: {pokemon2.EXP} | P3: {pokemon3.EXP}");
            //Console.ReadLine();

            var pikachu1 = new Pikachu(0, 100, "CutiePatootie", "Devil");
            pikachu1.HP = 0;
            pikachu1.PrintDetails();
            pikachu1.DeclareForBattle();
            Console.ReadLine();
        }

       
        //Overloads, access modifiers, overrides/virtual methods, inheritance, lists, dictionaries, recursion, try/catch (error handling)
        //Methods/constructors can be overloaded, if the signatures are different
        // Overloads

        //    public static void PrintAThing(string stringThing)
        //    {
        //        Console.WriteLine($"The thing is: {stringThing}");
        //    }

        //    public static void PrintAThing(int anotherthing)
        //    {
        //        Console.WriteLine($"This thing is: {anotherthing}");
        //    }

        //    public static void PrintAThing(string stringthing, string anotherStringThing)
        //    {
        //        Console.WriteLine($"The thing is: {stringthing}, and the other thing is {anotherStringThing}");


        //        var pokemon1 = new Pokemon(0, 100, "Cutiepatootie", "Devil");
        //        Console.WriteLine($"Pokemon1! | EXP: {pokemon1.EXP} | HP: {pokemon1.EXP} | Name: {pokemon1.NAME} | Secret Name >:) : {pokemon1.GetSecretName()}");

    }



    public class Pokemon
    {
        public int EXP;
        public int HP;
        public string NAME;
        protected string SecretName;
        public Pokemon() { }
        public Pokemon(int exp, int hp, string name, string secretName)
        {
            Console.WriteLine($"Inovaking Pokemon Constructor");
            EXP = exp;
            HP = hp;
            NAME = name;
            SecretName = secretName;
        }
        public string GetSecretName()
        {
            return SecretName;
        }

        //Overrides/virtual methods
        public virtual void DeclareForBattle()
        {
            Console.WriteLine("I Am reay for battle!");
        }
    }

    //inheritance
    // OO/Polymorphism
    // Pokemon is the base class of Pikachu, so pikachu gets all his members
    // We Invoke the POKEMON CONSTRUCTOR with this base keyword

    public class Pikachu: Pokemon
    {
        public Pikachu(int exp, int hp, string name, string secretName): base(exp, hp, name, secretName)
        {
            Console.WriteLine($"Inovaking Pikachu Constructor");
        }

        public override void DeclareForBattle()
        {
            Console.WriteLine("I am Pikachu");
            base.DeclareForBattle();
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Pokemon1! | EXP:{EXP} | HP: {HP} | Name: {NAME} | Secret Name >:) : {SecretName}");
        }
    }

}