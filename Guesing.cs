using System;
using Loader;

namespace Game
{
    class Guess
    {
        public static void Game(int num,int random,int att)
        {
            if(num == random)
            {
                Win(att);
            }else if(num < random)
            {
                Console.WriteLine("Higher!");
                int newAtt = ++att;
                Loader.State.OnStep(random,newAtt);
            }else if(num > random)
            {
                Console.WriteLine("Lower!");
                int newAtt = ++att;
                Loader.State.OnStep(random,newAtt);
            }
        }
        public static void Try(int num,int attemp)
        {
            Console.Write("Gues The Number: ");
            int guessed = Convert.ToInt16(Console.ReadLine());
            Game(guessed,num,attemp);
            
        }

        public static void Win(int attempt)
        {
            Console.WriteLine($"You Win and you only have {attempt} attempts!");
        }
    }
}