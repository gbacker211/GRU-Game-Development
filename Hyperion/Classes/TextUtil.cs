using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperion
{
    static class TextUtil
    {
        public static string ExtractCommand(string line)
        {
            int index = line.IndexOf(' ');
            if (index == -1) //if single command like 'help' just return that 
                return line;
            else // otherwise if there is a space, return the command up until the space
                return line.Substring(0, index);

        }

        public static string ExtractArguments(string line)
        {
            int index = line.IndexOf(' ');
            if (index == -1)  // no arguments
                return string.Empty;
            else //we have arguments so extract 
                return line.Substring(index + 1, line.Length - index - 1);
        } 

        public static string WordWrap(string text, int bufferWidth)
        {
            string result = string.Empty;
            string[] lines = text.Split('\n');

            foreach (string line in lines)
            {
                int lineLength = 0;
                string[] words = line.Split(' ');

                foreach (String word in words)
                {
                    if (word.Length + lineLength >= bufferWidth - 1)
                    {
                        result += "\n";
                        lineLength = 0;
                    }
                    result += word + " ";
                    lineLength += word.Length + 1;
                }
                result += "\n";

            }

          

            return result;

        }
    }
}
