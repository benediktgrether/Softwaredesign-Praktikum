using System;

namespace _1_1_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = "w";
            string k = "k";
            string o = "o";
            var eingabe = (args[0]);
            var Num = (args[1]); 
            double d = Convert.ToDouble(Num);
             if (w == eingabe){
                getCubeInfo(d);
            }else if( k == eingabe ){
                getSphereInfo(d);
            }else if( o == eingabe ){
                getSphereInfo(d);
            }else{
                Console.WriteLine("Wrong input");
            }            
        }
        // Cube
        public static double getCubeSurface(double durchmesser){
            double d = durchmesser;
            double a = Math.Round(6 * (d * d), 2);
            return a;
        }
        public static double getCubeVolume(double durchmesser){
            double d = durchmesser;
            double v = Math.Round(d * d * d, 2);
            return v;
        }
        public static void getCubeInfo(double durchmesser){
            double d = durchmesser;
            Console.WriteLine("Kubus: A=" + getCubeSurface(d) + " | V=" + getCubeVolume(d) );
        }

        // Sphere
        public static double getSphereSurface(double durchmesser){
            double d = durchmesser;
            double a = Math.Round(Math.PI * ( d * d), 2);
            return a;
        }
        public static double getSphereVolume(double durchmesser){
            double d = durchmesser;
            double v = Math.Round(Math.PI * ( d * d * d) / 6 , 2);
            return v;
        }
        public static void getSphereInfo(double durchmesser){
            double d = durchmesser;
            Console.WriteLine("Kugel: A=" + getSphereSurface(d) + " | V=" + getSphereVolume(d) );
        }
        
        // Octahedron
        public static double getOctahedronSurface(double durchmesser){
            double d = durchmesser;
            double a = Math.Round(2 *( Math.Sqrt(3)) * d * d, 2);
            return a;
        }
        public static double getOctahedronVolume(double durchmesser){
            double d = durchmesser;
            double v = Math.Round(Math.Sqrt(2) * d * d * d / 3 , 2);
            return v;
        }
        public static void getOctahedronInfo(double durchmesser){
            double d = durchmesser;
            Console.WriteLine("Oktaeder: A=" +getOctahedronSurface(d) + " | V=" + getOctahedronVolume(d) );
        }
    }

}
