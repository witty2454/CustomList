using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            //example.AddCars();
            example.RemoveCars();
            Console.ReadKey();

            List<int> list = new List<int>();
            list.Add(4);
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }

        }
    }
}
