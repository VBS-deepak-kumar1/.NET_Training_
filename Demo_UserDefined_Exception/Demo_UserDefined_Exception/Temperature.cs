using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.SystemException;

namespace Demo_UserDefined_Exception
{
    public class TempIsZeroException:Exception
    {
        public TempIsZeroException(string message):base (message)
        {

        }
    }

    class Temperature
    {
        int temperature = 0;
        public void Showtemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature Found"));
            }
            else
            {
                Console.WriteLine("Temperature :{0}", temperature);
            }
        }
    }
}
