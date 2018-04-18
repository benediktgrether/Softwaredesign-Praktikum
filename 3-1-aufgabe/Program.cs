using System;

namespace _3_1_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(toHexal(Convert.ToInt32(args[0])));
            // int value = Convert.ToInt32(args[0]);
            
            // if (0 <= value && value <= 1023 ){
                // toHexal(value);
            // }else{
            //     Console.WriteLine("Please make a input from 0 to 1023");
            // }
        }
        public static int toHexal(int value)
        {

            int newvalue ;
            int rest;
            int[] arr = new int[value.ToString().Length + 1];
            
            for (int i = 0; i <= value.ToString().Length + 1; i++)
            {
                newvalue = value / 6;
                rest = value % 6;
                arr[i] = rest;
                Console.WriteLine(newvalue + " mod " + rest );
                Console.WriteLine("array test " + arr[i]);
                value = newvalue;
            } 
            Array.Reverse(arr);
            // return arrayrest;
            Console.WriteLine("Debugger " + string.Join("", arr));
            return value;
        }
    }
}
