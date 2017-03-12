using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreEf
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Model1();
            var people = context.People.FirstOrDefault();
           
            Console.WriteLine(people.Id);
        }
    }
}
