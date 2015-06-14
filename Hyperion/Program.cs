using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hyperion;

namespace Hyperion
{
    class Program
    {
        public static bool quit = false;

        static void Main(string[] args)
        {
            GameManager.ShowTitleScreen();
            Level.Initialize();
            GameManager.StartGame();


            //While quit is not true continue playing
            while (!quit)
            {
                CommandProcessor.ProcessCommand(Console.ReadLine());
            }
        }
    }
}
