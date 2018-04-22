using System;

namespace _3_1_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32(args[0]);
            int toBase = Convert.ToInt32(args[1]);
            int fromBase = Convert.ToInt32(args[2]);
            
            Console.WriteLine($"Convert number {value} from 10 - base to 6 - base = " + ConvertDecimalToHexal(value) );
            Console.WriteLine($"Convert number {value} from 6 - base to 10 - base = " + ConvertHexalToDezimal(value) );
            Console.WriteLine($"Convert number {value} from 10 - base to {toBase} - base = " + ConvertToBaseFromDecimal(toBase, value) );
            Console.WriteLine($"Convert number {value} from {fromBase} - base  to 10 - base = " + ConvertToDecimalFromBase(fromBase, value) );
            Console.WriteLine($"Convert number {value} from {fromBase} - base to {toBase} - base = " + ConvertNumberToBaseFromBase(value, toBase, fromBase) );
        }
        public static int ConvertDecimalToHexal(int dec)
        {
            return ConvertToBaseFromDecimal(6, dec);
        }

        public static int ConvertHexalToDezimal(int hexal)
        {
            return ConvertToDecimalFromBase(6, hexal);
        }

        public static int ConvertToBaseFromDecimal(int toBase, int dec)
        {
            int value;
            int modulo;
            int[] arr = new int[4];
            if (0 <= dec && dec <= 1023)
            {
                for (int i = 0; i <= dec.ToString().Length + 2; i++)
                {
                    value = dec / toBase;
                    modulo = dec % toBase;
                    arr[i] = modulo;
                    dec = value;
                }
            }
            Array.Reverse(arr);
            int sum = Convert.ToInt32((string.Join("", arr)));
            return sum;
        }
        public static int ConvertToDecimalFromBase(int fromBase, int number)
        {
            int length = number.ToString().Length;
            int[] array = new int[length];
            int[] arr = new int[length];
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                array[i] = number % 10;
                number /= 10;
                arr[i] += array[i] * Convert.ToInt32(Math.Pow(fromBase, i));
            }
            for (int j = 0; j < arr.Length; j++)
            {
                sum += arr[j];
            }
            return sum;
        }
        public static int ConvertNumberToBaseFromBase(int number, int toBase, int fromBase)
        {

            if (2 <= fromBase && fromBase <= 10 && 2 <= toBase && toBase <= 10)
            {
                int dec = ConvertToDecimalFromBase(fromBase, number);
                int value = ConvertToBaseFromDecimal(toBase, dec);
                return value;
            }
            return -1;
        }
    }
}
