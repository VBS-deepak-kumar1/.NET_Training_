using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_delegate_Multi_Casting
{
    public delegate void delmethod(int x, int y);//delegate declaration
    internal class Program
    {
        public void Add(int x,int y)
        {
            Console.WriteLine("you are in add method");
            Console.WriteLine(x+y);
        }
       public void Subtract(int x,int y) {
            Console.WriteLine("you are in subtract method");
            Console.WriteLine(x-y);
        }
    static void Main(string[] args)
        {
            Program obj1 = new Program();
            delmethod del = new delmethod(obj1.Add);
            //multicasting delegate is like this 
            del += new delmethod(obj1.Subtract);
          //  del(45, 25);
            Console.WriteLine("After removing the ref for Add()");
           del -= new delmethod(obj1.Add);
           del(20, 25);
            Console.ReadKey();


        }
    }
}
