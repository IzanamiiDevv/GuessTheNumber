using System;
using Game;

namespace Loader
{
    class State
    {
        public static void OnLoad()
        {
            //Run Once
            Random random = new Random();
            OnStep(random.Next(0,101),0);
        }
        public static void OnStep(int number,int attempt)
        {
            //Run Per Recursion
            Console.WriteLine("Guess The Number!");
            Game.Guess.Try(number,attempt);
        }
    }
}