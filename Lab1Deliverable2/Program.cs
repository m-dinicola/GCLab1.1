using System;

namespace Lab1Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldIn = "";
            do
            {
                Console.WriteLine("What do you wish to say to the bot?");
                string inText = Console.ReadLine().ToLower();
                if (inText.Equals(oldIn))
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                else if (inText.Equals("sup"))
                {
                    Console.WriteLine("I am good");
                }
                else if (inText.Equals("hello there"))
                {
                    Console.WriteLine("General Kenobi");
                }
                else if (inText.Equals("hello"))
                {
                    Console.WriteLine("Hi good to see you.");
                }
                oldIn = inText;
            } while (oldIn != "bye");
            Console.WriteLine("Good bye!");
        }
    }
}