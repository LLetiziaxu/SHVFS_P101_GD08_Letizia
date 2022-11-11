//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace SHVFS_P101_GD08_Letizia
{
    public class Program
    {
        public static void Main()
        {
            var gameobject1 = new Position(11, 12, 13);
            var gameobject2 = new Position(11, 12, 13);


            
        }
    }

    public struct Position
    {
        public int x;
        public int y;
        public int z;
        public Position(int X,int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
       


        public string Gameobject()
        {
            return nameof(Gameobject);
        }

        
    }

    
      
}