using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hyperion;
using System.Windows.Forms;


namespace Hyperion
{
    class Program
    {
        public static bool quit = false;

        static void Main(string[] args)
        {
            /*
             * TODO: Need to wire up items on the windows application to game items
             */


            //Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Interface());
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
