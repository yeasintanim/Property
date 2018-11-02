using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person();
            
            //aPerson.SetFirstName("Md.");

            Console.WriteLine(aPerson.FirstName);

            Console.ReadKey();
        }
    }
}
