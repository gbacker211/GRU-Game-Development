using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hyperion
{
    static class GameManager
    {
        /*=======================
         * Public Methods
         *=======================*/
        public static void ShowTitleScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(TextUtil.WordWrap("**** The Hyperion Project *** an XNA Xtreme 101 game by 3D Buzz. \n\n\n"
                , Console.WindowWidth));
            Console.WriteLine("\nNOTE You may type 'help' at any time to see a list of command");
            Console.WriteLine("\nPress a key to begin.");

            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
            Console.Clear();
        }

        public static void StartGame()
        {
            Player.GetCurrentRoom().Describe();
            TextBuffer.Display();
        }

        public static void EndGame(string endingText)
        {
            Program.quit = true;

            Console.Clear();

            Console.WriteLine(TextUtil.WordWrap(endingText, Console.WindowWidth));
            Console.WriteLine("\nYou may now close this window");
            Console.CursorVisible = false;

            while (true)
            {
                Console.ReadKey(true);
            }

        }

        public static void ApplyRules()
        {
            //Add rules here, based on game specifications

            #region Example Game Rules
            /// <summary
            ///  Here are some sample game rules, 
            ///  they take simple things like looking at items in the player/room inventory
            /// </summary



            //if (Player.GetInventoryItem("Anvil") != null)
            //{
            //    EndGame("Good Job, you picked up a heavy item");
            //}

            //if (Level.Rooms[1, 0].GetItem("Blue Ball") != null)
            //{
            //    EndGame("Good Job, you placed the blue ball in the blue room");
            //}
            #endregion


            if (Level.Rooms[0, 0].GetItem("Red Ball") != null &&
                Level.Rooms[1, 0].GetItem("Blue Ball") != null &&
                Level.Rooms[1, 1].GetItem("Yellow Ball") != null &&
                Level.Rooms[0, 1].GetItem("Green Ball") != null)
            {
                EndGame("Good Job! You win!");
            }

            if (Player.GetInventoryItem("Key") != null)
            {
                Level.Rooms[0, 0].AddExit(Direction.South); // red room
                Level.Rooms[0, 0].Description = "You have entered the red room.";


                Level.Rooms[0, 1].AddExit(Direction.North); //green room
                Level.Rooms[0, 1].Description = "You have entered the green room.";
            }
            if (Player.Moves > 10)
            {
                EndGame("You are old and slow. Game Over!");
            }

        }
    }
}
