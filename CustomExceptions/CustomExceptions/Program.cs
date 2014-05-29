using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int> {2,4,5,8,10};
            try
            {
                foreach (var i in input)
                {
                    if(i%2 !=0)
                        throw new OddNumberException(i);
                }
            }
            catch (OddNumberException exception)
            {
                Console.Write(string.Format("An odd Number was found in the sequence {0}",exception.OddNumber));
                Console.ReadKey();
            }
        }
    }
}
