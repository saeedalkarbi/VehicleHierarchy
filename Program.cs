

public class Vehicle
{
    public string Brand;
    public int Year;

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Vehicle Information");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Year/Model: {Year}");
    }

    public void Start()
    {
        Console.WriteLine($"The vehicle from {Brand} model {Year} is starting.");
        Console.WriteLine("--------------------");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors;

    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public void DisplayCarInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        Console.WriteLine("--------------------");
    }
}

public class Bus : Vehicle
{
    public int Capacity;

    public Bus(string brand, int year, int capacity)
        : base(brand, year)
    {
        Capacity = capacity;
    }

    public void DisplayBusInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine("--------------------");
    }
}

public class Motorcycle : Vehicle
{
    public bool HasCarrier;

    public Motorcycle(string brand, int year, bool hasCarrier)
        : base(brand, year)
    {
        HasCarrier = hasCarrier;
    }

    public void DisplayMotorcycleInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Has Carrier: {HasCarrier}");
        Console.WriteLine("--------------------");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("ToyotaPrius", 2011, 4); ;
        Bus bus = new Bus("ToyotaNoah", 2009, 11);
        Motorcycle motorcycle = new Motorcycle("Botian", 2008, false);

        car.DisplayCarInfo();
        car.Start();

        bus.DisplayBusInfo();
        bus.Start();

        motorcycle.DisplayMotorcycleInfo();
        motorcycle.Start();
    }
}