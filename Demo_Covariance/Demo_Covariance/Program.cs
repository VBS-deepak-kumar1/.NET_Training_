using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Covariance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Covariance and Contravariance");
            Console.WriteLine("Array data type supports Covariance");
            object[] objArray = new string[10];
            //here we are assigning a string array to an object array variable.
            objArray[0] = "10";
            Console.WriteLine(objArray[0]);
            Console.ReadKey();
        }
    }
}
