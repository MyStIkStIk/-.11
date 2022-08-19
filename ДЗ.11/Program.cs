using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ._11
{
    internal class Program
    {
        class CarCollection
        {
            List<Car> collection;
            public CarCollection()
            {
                collection = new List<Car>();
            }
            public CarCollection(string name, int year)
            {
                collection.Add(new Car(name, year));
            }
            public void AddCar(string name, int year)
            {
                collection.Add(new Car(name, year));
            }
            public int CountOfCars()
            {
                if(collection.Count == 0)
                    return 0;
                else
                    return collection.Count;
            }
            public List<Car> this[int index]
            {
                get
                {
                    if(index < collection.Count && index >= 0)
                    {
                        return this[index];
                    }
                    else
                    {
                        Console.WriteLine("Нет машины под таким номером");
                        return null;
                    }
                }
            }
        }
        class Car
        {
            public string name { get; }
            int year;
            public Car(string name, int year)
            {
                this.name = name;
                this.year = year;
            }
            public void ShowInfo()
            {
                Console.WriteLine(name);
                Console.WriteLine(year);
            }
        }
        static void Main(string[] args)
        {
            CarCollection cars = new CarCollection();
            Console.WriteLine(cars.CountOfCars());
            Console.WriteLine(cars[1]);
            cars.AddCar("Porshe", 2004);
            Console.WriteLine(cars.CountOfCars());
        }
    }
}
