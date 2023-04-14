using CodeWars.Kata;
using System.Collections;
using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var testIp = "128.32.10.1";

            var final = IPConvert.FromInt32(12832101);
        }

        static void Ballerest()
        {
            Sphere ball = new Sphere(2, 50);
            Console.WriteLine(ball.GetMass());
            Console.WriteLine(ball.GetVolume());
            Console.WriteLine(ball.GetSurfaceArea());
            Console.WriteLine(ball.GetDensity());
        }
        static void BlockTest()
        {
            Block b = new Block(new int[] { 2, 2, 2 });
            Console.WriteLine(b.GetVolume());
            Console.WriteLine(b.GetSurfaceArea());
        }
        static void DivConTest()
        {
            var tester = new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 };
            Console.WriteLine(DivideConquer.DivCon(tester));
        }
    }

}