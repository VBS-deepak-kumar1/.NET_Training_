using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.SystemException;


namespace Demo_UserDefined_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Define Exception");
            Temperature temp = new Temperature();
            try
            {
                temp.Showtemp();
            }
            catch(TempIsZeroException e)
            {
                Console.WriteLine("Temperature is Zero exception:{0}",e.Message);
                //throw;
            }
            Console.ReadKey();

        }
    }
}
