//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace SHVFS_P101_GD08_Letizia
{
    public class programe
    {

      
        public static void Main(string[] args)
        {
            int time = 0;
            string name;
            string[] words = new string[] {"Apple","Peach","Lemon","Melon"};  
            Random random = new Random();
            int i=random.Next(words.Length);
            Console.Clear();
            Console.WriteLine($"Hello, Welocome to the game, may I have your name");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Oh hello {name} Come and play the guessing game!");
            string typing="";
            while(typing != words[i])
            {
                Console.WriteLine($"Please guess a word from list: 'Apple','Peach','Lemon',Melon'");
                typing = Convert.ToString(Console.ReadLine());
                //if (typing != words[i])
                //{
                //    Console.WriteLine($"Unfortunately, you are wrong. Please try again.");
                //}
                //Console.WriteLine($"Congrats, You are write.");
                Console.Clear();
                time++;
            }
            Console.WriteLine($"Thanks you have try {time} times");
            Console.ReadLine();



                    



        }
    }
}