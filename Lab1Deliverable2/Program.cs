using System;

namespace Lab1Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldIn = "";                          //tracking old input in higher scope to use as while loop check
            do
            {
                Console.WriteLine("What do you wish to say to the bot?");
                string inText = Console.ReadLine().ToLower();  //setting as lower for ease of matching
                if (inText.Equals(oldIn))                      //compare to old text so other cases are skipped if same
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
                }                                               //no check for 'bye' necessary, since it exits the loop
                oldIn = inText;                                 //set old here so that loop can catch 'bye' escape
            } while (oldIn != "bye");
            Console.WriteLine("Good bye!");                     //only way out of loop is 'bye'. this is 'bye' response
        }
    }
}