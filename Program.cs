using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class A
    {
       public virtual  void show()
        {
            Console.WriteLine(" this is class A");
        }
    }

    class B :A
    {

        public override void show() 
        {
            Console.WriteLine("This is class B");
        }
    }
   
    public class Program
    {
        static void Main(string [] args)
        {
            A b = new B();  
            b.show();
           
        }
    }
}
