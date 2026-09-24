using System;

public class Vehicle
{
    public string Brand;
    public int Year;

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine("Vehicle Started");
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

    public void Drive()
    {
        Console.WriteLine("Car is driving");
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

    public void Honk()
    {
        Console.WriteLine("Bus is honking");
    }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(string brand, int year, bool hasSidecar)
        : base(brand, year)
    {
        HasSidecar = hasSidecar;
    }

    public void Rev()
    {
        Console.WriteLine("Motorcycle is revving");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("ToyotaPrius", 2011, 4);
        Bus bus = new Bus("ToyotaNoah", 2009, 11);
        Motorcycle motorcycle = new Motorcycle("Botian", 2008, false);

        car.Start();
        car.Drive();

        bus.Start();
        bus.Honk();

        motorcycle.Start();
        motorcycle.Rev();
    }
}