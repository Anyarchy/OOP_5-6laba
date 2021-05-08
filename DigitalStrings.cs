using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_5laba
{
    class DigitalStrings : Strings
    {
        public DigitalStrings(int number)
        {
            string num = number.ToString();
            char[] temp = new char[num.Length + 1];
            for (int i = 0; i < num.Length; i++)
            {
                temp[i] = num[i]; 
            }
            temp[num.Length] = '\0';
            array = temp;
        }

        public void Remover(char element)
        {
            int t = 0;
            for (int i = 0; i <= Length(); i++)
            {
                if (array[i] != element)
                {
                    t++;
                }
            }
            char[] temp = new char[t + 1];
            temp[t] = '\0';
            t = 0;
            for (int i = 0; i < Length(); i++)
            {
                if (array[i] != element)
                {
                    temp[t] = array[i];
                    t++;
                }
            }

            array = temp;
        }

        public char[] Array
        {
            get => array;
        }
    }

}
