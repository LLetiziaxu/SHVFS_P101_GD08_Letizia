//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Numerics;

namespace SHCFS_P101_GD08_Letizia
{
    internal class Program
    {
        // casing
        // camelCase
        // UpperCamelCase
        // etc.
        // _camelCase
        // CAMEL_CASE

        // we need to track score
        // we need chars to represent players
        public static void Main(string[] args)
        {

        }
        public struct Vector2
        {
            // this is "small" inconsistency/code style
            // Mathematics libraries usually use camel instead of UpperCamel
            public int x;
            public int y;
            public Vector2(int x, int y)
            { 
                // the keyword "this" means this ohect when an instance is instantiated using the keyword "new"
                this.x = x; 
                this.y = y; 
            }
        }
    }

    public class Player
    {
        public Vector2 Position;
        //
        public Vector2 Directing;
    }
}