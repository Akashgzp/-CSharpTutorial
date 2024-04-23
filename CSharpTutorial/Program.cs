using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class ClassA
    {
       public virtual  void Show()
        {
            // method overriding signature - Name , Parameter , return type are same.
            // method overloading signature - Name same  ,  , return type same or diff , parameter type different and seqence
            // method body always occures in curlybraces line number 14 and 18

            Console.WriteLine(" this is class A");
        }
        public string Method1()
        {
            Console.WriteLine("Method1.... ClassA");
            return "Akash";
        }
    }
    

    class ClassB :ClassA
    {

        public override void Show() 
        {
            Console.WriteLine("This is class B");
        }
        public void Method1()
        {
            Console.WriteLine("Method1.... ClassB");
        }
    }
   
    public class Program
    {
        static void Main(string [] args)
        {

            ClassA a = new ClassB();
          //  ClassB b = new ClassB();
            a.Show();
            a.Method1();
           
        }
    }
}
