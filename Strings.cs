using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_5laba
{
    class Strings
    {
        protected char[] array;
        public Strings()
        {
            char[] temp = new char[1];
            temp[0] = '\0';
            array = temp;
        }

        public Strings(char[] temp)
        {
            array = temp;
        }

        public int Length()
        {
            int length = 0;
            while (array[length] != 0)
            {
                length++;
            }
            return length;
        }

    }
}
