using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperion
{
    static class  CommandProcessor
    {
        public static void ProcessCommand(string line)
        {
            //Store command and argument into variables, trime off any spaces before and after line
            //And make them lower case.
            string command = TextUtil.ExtractCommand(line.Trim()).Trim().ToLower();
            string arguments = TextUtil.ExtractArguments(line.Trim()).Trim().ToLower();

            if (Direction.IsValidDirection(command))
            {
                Player.Move(command);
            }
            else
            {
                switch (command)
                {
                    case "exit":
                        Program.quit = true;
                        return;
                    case "help":
                        ShowHelp();
                        break;
                    case "move":
                        Player.Move(arguments);
                        break;
                    case "look":
                        Player.GetCurrentRoom().Describe();
                        break;
                    case "pickup":
                        Player.PickupItem(arguments);
                        break;
                    case "drop":
                        Player.DropItem(arguments);
                        break;
                    case "inventory":
                        Player.DisplayInventory();
                        break;
                    case "whereami":
                        Player.GetCurrentRoom().ShowTitle();
                        break;
                    default:
                        TextBuffer.Add("Input not understood");
                        break;

                }
            }
            //----------End Switch----------//
            //Check rules after action
            GameManager.ApplyRules();
            TextBuffer.Display();



        }

        public static void ShowHelp()
        {
            TextBuffer.Add("Available Commands");
            TextBuffer.Add("------------------");
            TextBuffer.Add("help");
            TextBuffer.Add("exit");
            TextBuffer.Add("move [north, south, east, wast]");
            TextBuffer.Add("look");
            TextBuffer.Add("pickup [item name]");
            TextBuffer.Add("drop [item name]");
            TextBuffer.Add("inventory");
            TextBuffer.Add("whereami");
        }
    }
}
