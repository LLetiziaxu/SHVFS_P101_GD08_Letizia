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
            var object1 = new Gameobject("aa", new Position(0, 0, 0));
            var object2 = new Gameobject("bb", new Position(1, 5, 9));
            var object3 = new Gameobject("cc", new Position(2, 4, 6));
            var object4 = new Gameobject("dd", new Position(4, 8, 7));
            var object5 = new Gameobject("ee", new Position(0, 0, 0));




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
    
    }

    public class Gameobject
    {
        public string name;
        public Position position;

        public Gameobject(string name, Position position)
        {
            this.name = name;
            this.position = position;
        }

        public bool compare(Gameobject game)
        {
            if(position.x == game.position.x && position.y == game.position.y && position.z == game.position.z)
            {
                return true;
            }
            return false;
        }

    }




}