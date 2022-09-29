using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter
{
    public class ToBaseTen
    {
        string input;
        int inputBase;
        ToBaseTen(int inputBase, string input)
        {
            this.input = input;
            this.inputBase = inputBase;
            convertToDec(inputBase, input);
        }

        static int convertToDec(int inputBase, String input)
        {
            int output = 0, index = 0;
            int value = 0;
            input = input.ToUpper();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                char c = input[i];
                if (c >= '0' && c <= '9')
                    value = c - 48;//in ASCII char '0' is at index 48 so -48 give actual int value  
                else if (c >= 'A' && c <= 'F')
                    value = c - 55; //or just use String.valueOf(char) instead of -index(ASCII) 
                output += value * (int)Math.Pow(inputBase, index);
                index++;

            }
            return output;
        }
    }
}
