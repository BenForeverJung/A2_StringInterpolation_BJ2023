using System.Runtime.Intrinsics.X86;

namespace A2_StringInterpolation_BJ2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            Console.WriteLine("Section one - Using today's date:");
            Console.WriteLine();
            
            //1.january 22, 2019(right aligned in a 40 character field)
            Console.WriteLine($"1.{now,40:MMMM dd, yyyy}");
            Console.WriteLine();
            
            //2.2019.01.22
            Console.WriteLine($"2.{now:yyyy.MM.dd}");
            Console.WriteLine();

            //3.day 22 of january, 2019
            Console.WriteLine($"3.{now:'Day' dd 'of' MMMM, yyyy}");
            Console.WriteLine();

            //4.year: 2019, month: 01, day: 22
            Console.WriteLine($"4.{now:'Year:' yyyy, 'Month:' MM, 'Day:' dd}");
            Console.WriteLine();

            //5.tuesday(10 spaces total, right aligned)
            Console.WriteLine($"5.{now,10:dddd}");
            Console.WriteLine();

            //6.     11:01 pm tuesday(10 spaces total for each including the day - of - week, both right - aligned)
            Console.WriteLine($"6.{now,10:hh:mm tt}");
            Console.WriteLine();

            //7.h:11, m: 01, s: 27
            Console.WriteLine($"7.{now:'h:'hh,'m:'mm,'s:'ss}");
            Console.WriteLine();

            //8.2019.01.22.11.01.27
            Console.WriteLine($"8.{now:yyyy.MM.dd.hh.mm.ss}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();
            Console.WriteLine("Section two - Using var pi = Math.PI;");
            Console.WriteLine();

            //if you have pi(3.1415) -use var pi = math.pi;
            var pi = Math.PI;

            //1.output as currency
            Console.WriteLine($"{pi:C2}");
            Console.WriteLine();


            //2.output as right - aligned(10 spaces), number with 3 decimal places
            Console.WriteLine($"{pi,10:N3}");
            Console.WriteLine();






        }
    }
}