using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter
{
    public class FromBaseTen
    {
        int outputBase;
        int intput;
        FromBaseTen(int outputBase,int intput)
        {
            this.intput = intput;
            this.outputBase = outputBase;
            convertDecToAny(outputBase, intput);
        }

        static String convertDecToAny(int outputBase, int intput)
        {
            String result = "";
            while (intput != 0)
            {
                int value = intput % outputBase;
                intput /= outputBase;
                if (value <= 9)
                    result = value.ToString() + result;
                else
                    result = (char)(value + 55) + result;//ASCII
            }
            return result;
        }
        }
}
