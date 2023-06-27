using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1) გავაკეთოთ სამკუთხედის კლასი, რომელსაც ექნება ორი მეთოდი Area და Perimeter.
//2) გადავტვირტოთ ოპერატორები: ტოლობა, უტოლობა.
//3) გადავტვირტოთ ოპერატორები: მეტობა, ნაკლებობა (ფართობებით გაირკვეს რომელი უფრო დიდია).
//4) გადავტვირტოთ მიმატება(მიმატებისას წარმოიშვას ორი სამკუთხედის ჯამური ფართობის მქონე მართკუთხა სამკუთხედი).
//5) კონსტრუქტორში ჩავდოთ სამკუთხედის ტოლობის შემოწმება
//6) გავუკეთოთ Explicit დაკასტვა double-დან სამკუთხედზე, რა დროსაც უნდა შეიქნას double ცვლადის მნიშველობის ტოლგვერდა სამკუთხედი.
//7) ინიციალიზაცია განხორციელდეს კონსოლიდან.

namespace Task2
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c ) 
        {
            A = a;
            B = b;
            C = c;
            Validate(this);
        }

        public Triangle() 
        { 
            while (true)
            {
                Console.Write("sheiyvanet pirveli gverdis sigrdze: ");
                A = double.Parse(Console.ReadLine());
                Console.Write("sheiyvanet meore gverdis sigrdze: ");
                B = double.Parse(Console.ReadLine());
                Console.Write("sheiyvanet mesame gverdis sigrdze: ");
                C = double.Parse(Console.ReadLine());
                if (Validate(this)) break; 
            }
        }

        public double Perimeter()
        {
            double perimeter = A + B + C;
            return perimeter;
        }

        public double Area()
        {
            double p2 = Perimeter() / 2;
            double area = Math.Sqrt(p2 * (p2 - A) * (p2 - C) * (p2 - B));
            return area;
        }

        public static bool operator ==(Triangle tr1 , Triangle tr2)
        {
            if (tr1.Area() == tr2.Area())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Triangle tr1, Triangle tr2)
        {
            if (tr1.Area() != tr2.Area())
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Triangle tr1, Triangle tr2)
        {
            if (tr1.Area() > tr2.Area())
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Triangle tr1, Triangle tr2)
        {
            if (tr1.Area() < tr2.Area())
            {
                return true;
            }
            return false;
        }

        public static Triangle operator +(Triangle tr1, Triangle tr2)
        {
            //mokled verafriT amovxseni, marto fartobiT ver vpoulob gverdebs.
            double S = tr1.Area() + tr2.Area();
            //result.A = S*2 / result.B;
            double a = S/6;
            double b = S/7;
            double c = S/8;
            Triangle result = new Triangle(a,b,c);
            return result;
        }

        public static explicit operator Triangle(double a)
        {
            Triangle result = new Triangle(a, a, a);
            return result;
        }

        public override string ToString()
        {
            return $"x = {A}, y = {B}, z = {C}"; 
        }

        public static bool Validate(Triangle tr)
        {
            if (tr.A + tr.B <= tr.C || tr.A + tr.C <= tr.B || tr.B + tr.C <= tr.A)
            {
                Console.WriteLine("ori gverdis sigrdzeebis jami ar unda iyos mesameze naklebi!");
                return false;
            }
            else { return true; }
        }
    }
}
