using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_AgeLessThan
{
    class AgeException: Exception
    {
        public AgeException(String message):base(message)
      {
       // Console.WriteLine(message);
      }
    }
    class AgeCheck
    {
        int age;
       public AgeCheck(int age)
        {
            this.age = age;

        }
        public void ShowAge()
        {
            if (age < 20)
                throw new AgeException("Invalid age less than 20");
            else
                Console.WriteLine("Valid age {0} greater than 20",age);
        }
    }
      class Program
      { 
            static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age: ");
             int age = Convert.ToInt32(Console.ReadLine());
            AgeCheck abc = new AgeCheck(age);

        try
        {
                abc.ShowAge();
        }
        catch (AgeException a)
        {
            Console.WriteLine(a);
        }
            Console.ReadLine();
    }
    }
}
