using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exception_Handling
{
    internal class Program : System.Exception
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 2, 3, 6 };

            try
            {
                //Displaying it 
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine(arr[9]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(" An Exception Has occured : {0},{1}", e.Message, e.StackTrace);
                
                // throw;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An Exception has occured :{0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Blocks runs irrespective of Exception..!!");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0}", arr[i]);
                }
            }
            Console.ReadKey();
        }

    }
}
 






