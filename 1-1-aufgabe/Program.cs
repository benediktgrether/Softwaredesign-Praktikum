using System;

namespace _1_1_aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = Convert.ToDouble(args[1]);
            
            switch(args[0])
            {
                case "w":
                    Console.WriteLine(getCubeInfo(length));
                    break;
                case "k":
                    Console.WriteLine(getSphereInfo(length));
                    break;
                case "o":
                    Console.WriteLine(getOctahedronInfo(length));
                    break;
                
                default:
                    Console.WriteLine("Please make an input between W, K, O");
                    break;
            }           
        }
        // Cube
        public static double getCubeSurface(double length){
            return Math.Round(6 * (length * length), 2);
        }
        public static double getCubeVolume(double length){
            return Math.Round(length * length * length, 2);
        }
        public static string getCubeInfo(double length){
            return "Kubus: A = " + getCubeSurface(length) + " | V = " + getCubeVolume(length);
        }

        // Sphere
        public static double getSphereSurface(double length){
            return Math.Round(Math.PI * ( length * length), 2);
        }
        public static double getSphereVolume(double length){
            return Math.Round(Math.PI * ( length * length * length) / 6 , 2);
        }
        public static string getSphereInfo(double length){
            return "Kugel: A = " +  getSphereSurface(length) + " | V = " + getSphereVolume(length);
        }
        
        // Octahedron
        public static double getOctahedronSurface(double length){
            return Math.Round(2 *( Math.Sqrt(3)) * length * length, 2);
        }
        public static double getOctahedronVolume(double length){
            return Math.Round(Math.Sqrt(2) * length * length * length / 3 , 2);
        }
        public static string getOctahedronInfo(double length){
            return "Oktaeder: A = " +getOctahedronSurface(length) + " | V = " + getOctahedronVolume(length);
        }
    }

}
