using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class Example
    {

        public Example()
        {

        }
        public void AddCars()
        {
            MyList<string> car = new MyList<string>();
            car.Add("ford");
            car.Add("chevy");
            car.Add("mini");
            Console.ReadKey();
        }
        public void RemoveCars()
        {
            MyList<string> car = new MyList<string>();
            car.Add("ford");
            car.Add("chevy");
            car.Add("lambo");
            car.Add("mini");
            car.Remove("chevy");
            Console.WriteLine($"You have {car.Count} cars!");
            Console.ReadKey();
        }
    }
}
