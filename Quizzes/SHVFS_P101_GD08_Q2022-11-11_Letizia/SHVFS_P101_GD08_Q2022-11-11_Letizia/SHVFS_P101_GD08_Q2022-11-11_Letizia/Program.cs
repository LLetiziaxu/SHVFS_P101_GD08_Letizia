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
            var obm = new Gameobject[5];
            obm[0] = new Gameobject("aa", new Position(10, 10, 0));
            obm[1] = new Gameobject("bb", new Position(10, 0, 0));
            obm[2] = new Gameobject("cc", new Position(0, 10, 10));
            obm[3] = new Gameobject("dd", new Position(10, 0, 10));
            obm[4] = new Gameobject("ee", new Position(10, 10, 0));

            for (var i = 0; i < obm.Length; i++)
            {
                for (var j = 0; j < obm.Length; j++)
                {
                    if (i != j && obm[i].compare(obm[j]))
                    {
                        Console.WriteLine($"{obm[i].name} and {obm[j].name} have the save position.");
                    }
                }
            }





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