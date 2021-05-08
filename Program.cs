using System;

namespace OOP_5laba
{
    class Program
    {
        public static void Printer(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            DigitalStrings DS = new DigitalStrings(80670850);
            Console.Write("Original string:\n ");
            Printer(DS.Array);
            Console.Write("length:");
            Console.WriteLine(DS.Length());
            DS.Remover('0');
            Console.Write("\nChanged string:\n ");
            Printer(DS.Array);
            Console.Write("length:");
            Console.WriteLine(DS.Length());
        }

    }
}
