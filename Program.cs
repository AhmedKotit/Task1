using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Parsmall= 25 ;
            int parlarge = 35;
            double taxrate = 0.06;
            Console.WriteLine("number of smalle carbets = ");
            int smallecarbets= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number of large carbets = ");
            int largecarbets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            int cost= smallecarbets * 25 + largecarbets * 35;
            Console.WriteLine($"Cost = {cost :c} ");
            double  tax = cost * taxrate;
            Console.WriteLine($"Tax = {tax :c} ");
           double  Total = cost + tax;
            Console.WriteLine($"Total Cost = {Total :c} ");







        }
    }
}
