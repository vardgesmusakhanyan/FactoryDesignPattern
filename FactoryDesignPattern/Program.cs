using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{

    interface CarFactory
    {
        Car CreateCar(string brand);
    }

    public class ConcreteCarFactory : CarFactory
    {
        public Car CreateCar(string brand)
        {
            switch (brand) {
                case "Mercedes":
                return new Mercedes();
                case "BMW":
                    return new BMW();
                default:
                    throw new ArgumentException("invalid brand",brand);
            }
        }
    }



    public class Car { }

    public class Mercedes : Car { }
    public class BMW : Car { }


    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            CarFactory factory = new ConcreteCarFactory();

            Car car = factory.CreateCar(x);

            Console.WriteLine(car.GetType());

            Console.ReadLine();
        }
    }
}
