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
            #region draw start screen
            string title = "Snake On a Train";

            Console.CursorLeft = Console.BufferWidth / 2 - title.Length / 1;
            Console.Write(title);

            Console.WriteLine($"Player One Control:\n"+
                              "Up:W\n" + 
                              "Down:S\n" + 
                              "Left:A\n" + 
                              "Right:D");
            string player2 = "Up: upper arrow\n" + "Down: down arrow\n" + "Left: left arrow\n" + "Right: right arrow";
            var player2controltitle = "Player Two Control:";
            var cursorLeft = Console.BufferWidth - player2controltitle.Length;
            Console.CursorTop = 1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Player Two Control:\n");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Up: upper arrow");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Down: down arrow");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Left: left arrow");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Right: right arrow");




            // some things you may want to use
            // Console.CursorTop, Console.ForegroundColor...
            Console.ReadKey();
            Console.Clear();

            #endregion

            SetupPlayArea();

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
            
            public static readonly Vector2 Up = new Vector2(0, 1);
            public static readonly Vector2 Down = new Vector2(0, -1);
            public static readonly Vector2 Left = new Vector2(-1, 0);
            public static readonly Vector2 Right = new Vector2(1, 0);


        }
    }

    public class Player
    {
        public Vector2 Position;
        //
        public Vector2 Directing;

        
    }
}