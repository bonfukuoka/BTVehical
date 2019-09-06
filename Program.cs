using System;

namespace OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1, "Family Car", "0 -> 200km", "4 wheel", "4 seats", "Toyota", "2018");
            Car car2 = new Car(2,"Sport", "0 -> 400km", "4 wheel", "2 seats", "Subaru", "2019");
            Bike bike1 = new Bike(1,"Mountain bike", "0 -> 50km", "2 wheel", "1 seats", "Fujisan", "2018");
            Bike bike2 = new Bike(2,"Normal bike", "0 -> 30km", "2 wheel", "2 seats", "Asama", "2016");
            System.Collections.Generic.List<Car> listCar = new System.Collections.Generic.List<Car>();
            System.Collections.Generic.List<Bike> listBike = new System.Collections.Generic.List<Bike>();
            listCar.Add(car1);
            listCar.Add(car2);
            listBike.Add(bike1);
            listBike.Add(bike2);

            Console.Write("Enter the number :");
            int num = Int32.Parse(Console.ReadLine());
            switch (num){
                case 1:
                    Console.WriteLine("Enter Type  Bike :");
                    string type = Console.ReadLine();
                    Console.WriteLine("Enter Speed  Bike :");
                    string speed = Console.ReadLine();
                    Console.WriteLine("Enter Wheel  Bike :");
                    string wheel = Console.ReadLine();
                    Console.WriteLine("Enter Make  Bike :");
                    string make = Console.ReadLine();
                    Console.WriteLine("Enter Model  Bike :");
                    string model = Console.ReadLine();
                    Console.WriteLine("Enter Year  Bike :");
                    string year = Console.ReadLine();
                    int id = listBike.Count + 1;
                    Bike bike = new Bike(id, type, speed, wheel, make, model, year);
                    listBike.Add(bike);

                    Console.WriteLine("Show list Bike :");
                    for (int i = 0; i < listBike.Count; i++)
                    {
                        Console.WriteLine(listBike[i].toString());
                    }
                    break;
                case 2:
                    Console.WriteLine("Show list Bike :");
                    for(int i = 0; i < listBike.Count; i++)
                    {
                        Console.WriteLine(listBike[i].toString());
                    }
                    break;
                case 3: 
                    Console.WriteLine("Enter Type  Car :");
                    type = Console.ReadLine();
                    Console.WriteLine("Enter Speed  Car :");
                    speed = Console.ReadLine();
                    Console.WriteLine("Enter Wheel  Car :");
                    wheel = Console.ReadLine();
                    Console.WriteLine("Enter Make  Car :");
                    make = Console.ReadLine();
                    Console.WriteLine("Enter Model  Car :");
                    model = Console.ReadLine();
                    Console.WriteLine("Enter Year  Car :");
                    year = Console.ReadLine();
                    id = listCar.Count + 1;
                    Car car = new Car(id, type, speed, wheel, make, model, year);
                    listCar.Add(car);

                    for (int i = 0; i < listCar.Count; i++)
                    {
                        Console.WriteLine(listCar[i].toString());
                    }
                    break;
                case 4: Console.WriteLine("Show list Car :");
                    for (int i = 0; i < listCar.Count; i++)
                    {
                        Console.WriteLine(listCar[i].toString());
                    }
                    break;
                case 5: Console.WriteLine("Exit");
                    break;
            }
            Console.ReadKey();
        }
    }
}
