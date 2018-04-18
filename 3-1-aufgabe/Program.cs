using System;

namespace _3_1_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(ConvertDecimalToHexal(Convert.ToInt32(args[0])));
            // Console.WriteLine(ConvertHexalToDezimal(Convert.ToInt32(args[0])));
            // Console.WriteLine(ConvertToBaseFromDecimal(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));
            Console.WriteLine(ConvertToDecimalFromBase(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));
        }
        public static int ConvertDecimalToHexal(int dec)
        {
            //To Do - if input from 0 to 1023
            int value ;
            int modulo;
            int[] arr = new int[4];
            
            for (int i = 0; i <= dec.ToString().Length + 2; i++)
            {
                value = dec / 6;
                modulo = dec % 6;
                arr[i] = modulo;
                dec = value;
            } 
            Array.Reverse(arr);
            int newArr = Convert.ToInt32((string.Join("", arr)));
            return newArr;
        }

        public static int ConvertHexalToDezimal(int hexal)
        {
            /* 
                Berechnung im 10 dezimal 
                4*6^3 + 4*6^2 + 2*6^1 + 3*6^0 = 1023
            */

            int a = Math.Abs(hexal);
            int length = a.ToString().Length;
            int[] array = new int[length];

            // new array
            int [] arr = new int[length];
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                array[i] = a % 10;
                a /= 10;
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
            int newArr = Convert.ToInt32((string.Join("", arr)));
            return newArr;
        }
        public static int ConvertToDecimalFromBase(int fromBase, int number)
        {
            int a = Math.Abs(number);
            int length = a.ToString().Length;
            int[] array = new int[length];

            // new array
            int [] arr = new int[length];
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                array[i] = a % 10;
                a /= 10;
                arr[i] += array[i] * Convert.ToInt32(Math.Pow(fromBase, i));
            }
            for (int j = 0; j < arr.Length; j++)
            {
                sum += arr[j];
            }
            return sum;
        }

    }
}
