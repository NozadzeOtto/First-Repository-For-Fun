using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Triangle(double x, double y, double z ) 
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Triangle() { }

        public void InputTriangle()
        {
            while (true)
            {
                Console.Write("sheiyvanet pirveli gverdis sigrdze: ");
                X = double.Parse(Console.ReadLine());
                Console.Write("sheiyvanet meore gverdis sigrdze: ");
                Y = double.Parse(Console.ReadLine());
                Console.Write("sheiyvanet mesame gverdis sigrdze: ");
                Z = double.Parse(Console.ReadLine());

                if (X + Y <= Z || X + Z <= Y || Y + Z <= X)
                {
                    Console.WriteLine("ori gverdis sigrdzeebis jami ar unda iyos mesameze naklebi!");
                    Console.WriteLine("sheiyvanet mnishvnelobebi tavidan.");
                }
                else { break; }
            }
        }

        public double Perimeter()
        {
            double perimeter = 0;
            perimeter = X + Y + Z;
            return perimeter;
        }

        public double Area()
        {
            double p2 = Perimeter() / 2;
            double area = Math.Sqrt(p2 * (p2 - X) * (p2 - Z) * (p2 - Y));
            return area;
        }

        public static explicit operator Triangle(double d)
        {
            Triangle result = new Triangle(d, d, d);
            return result;
        }

        public override string ToString()
        {
            return $"\nx = {X}, y = {Y}, z = {Z}"; 
        }
    }
}
