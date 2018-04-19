using System;

namespace _3_1_aufgabe
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Convert from Decimal to Hexal: " + ConvertDecimalToHexal(Convert.ToInt32(args[0])));
            Console.WriteLine("Convert from Hexal to Dezimal: " + ConvertHexalToDezimal(Convert.ToInt32(args[0])));
            Console.WriteLine("Convert to Base from Decimal: " + ConvertToBaseFromDecimal(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));
            Console.WriteLine("Convert to Decimal from Base: " + ConvertToDecimalFromBase(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));
            Console.WriteLine("Convert Number to Base from Base: " + ConvertNumberToBaseFromBase(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2])));
        }
        public static int ConvertDecimalToHexal(int dec)
        {
            int value ;
            int modulo;
            int[] arr = new int[4];
            
            if (0 <= dec && dec <= 1023){
                for (int i = 0; i <= dec.ToString().Length + 2; i++)
                {
                    value = dec / 6;
                    modulo = dec % 6;
                    arr[i] = modulo;
                    dec = value;
                } 
            }
            Array.Reverse(arr);
            int sum = Convert.ToInt32((string.Join("", arr)));
            return sum;
        }

        public static int ConvertHexalToDezimal(int hexal)
        {

            int length = hexal.ToString().Length;
            int[] array = new int[length];
            int [] arr = new int[length];
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                array[i] = hexal % 10;
                hexal /= 10;
                arr[i] += array[i] * Convert.ToInt32(Math.Pow(6, i));
            }
            for (int j = 0; j < arr.Length; j++)
            {
                sum += arr[j];
            }
            return sum;
        }

        public static int ConvertToBaseFromDecimal(int toBase, int dec)
        {
            int value;
            int modulo;
            int[] arr = new int[4];
            
            for (int i = 0; i <= dec.ToString().Length + 2; i++)
            {
                value = dec / toBase;
                modulo = dec % toBase;
                arr[i] = modulo;
                dec = value;
            } 
            Array.Reverse(arr);
            int sum = Convert.ToInt32((string.Join("", arr)));
            return sum;
        }
        public static int ConvertToDecimalFromBase(int fromBase, int number)
        {
            int length = number.ToString().Length;
            int[] array = new int[length];
            int [] arr = new int[length];
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

            if(2 <= fromBase && fromBase <= 10 && 2 <= toBase && toBase <= 10){   
                int dec = ConvertToDecimalFromBase(fromBase, number);
                int value = ConvertToBaseFromDecimal(toBase, dec);
                return value;
            }
            return -1;
        }

    }
}
