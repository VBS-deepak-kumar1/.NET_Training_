using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_Single_Casting
{
     class Myprogram
    {
        public delegate void delmethod();//Declaration of delegate

        internal class Program 
        {
            public static void Display()
            {
                Console.WriteLine("Inside Display()");
            }
            public static void Show()
            {
                Console.WriteLine("Inside Show()");
            }
            public void Print()
            {
                Console.WriteLine("Inside Print()");
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Single Casting Delegate..");
                //Assigning static method Show() to delegate
                delmethod del1 = Program.Show;
                delmethod del2 = new delmethod(Program.Display);
                Program obj1 = new Program();
                //creating object of class for referring non-static method
                delmethod del3 = obj1.Print;
                del1();
                del2();
                del3();
                Console.ReadKey();

            }
        }
    }
}
