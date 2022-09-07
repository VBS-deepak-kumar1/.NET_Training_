using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Invalid_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invalid Cast Exception");
            int i = 123;
            string s = "I am feeling Lucky";
            object obj = s;//Object consist string
            try
            {
                i = (int)obj;
                Console.WriteLine("This writeline is at the end of try block.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catching the {0} exception triggers finally blocks",ex.GetType());
                throw;
            }
            finally
            {
                Console.WriteLine("executing the finally bloks..!!");
                Console.WriteLine("i={0} ",i);
            }
        }
    }
}
