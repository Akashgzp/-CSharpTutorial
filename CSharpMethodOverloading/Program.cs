using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethodOverloading
{
    public class Cal
    {
        public  int add(int a, int b)
        {
            return a + b;
        }
        public  int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Cal a = new Cal();
            a.add(23, 45);
            a.add(34, 56, 67);
        }
    }
}
