using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        /// <summary>
        /// The Template Method pattern allows an abstract to define the skeleton or outline of an algorithm,
        /// but leave the implementation of the individual steps in that algorithm up to the deriving classes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Your_name craft = new Your_name();
            craft.Make();     
            Console.ReadKey();
        }
    }
}