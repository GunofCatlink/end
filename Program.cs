using System;

// Интерфейс для транспортного средства
interface IVehicle
{
    void Drive();
}

// Классы, представляющие различные типы транспортных средств
class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Автомобиль едет по дороге.");
    }
}

class Bicycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Велосипед движется по велосипедной дорожке.");
    }
}

// Интерфейс для фабричного метода
interface IVehicleFactory
{
    IVehicle CreateVehicle();
}

// Реализация фабричного метода для создания автомобилей
class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Car();
    }
}

// Реализация фабричного метода для создания велосипедов
class BicycleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Bicycle();
    }
}

class Program
{
    static void Main()
    {
        // Использование фабричных методов для создания транспортных средств
        IVehicleFactory carFactory = new CarFactory();
        IVehicle car = carFactory.CreateVehicle();
        car.Drive();

        IVehicleFactory bicycleFactory = new BicycleFactory();
        IVehicle bicycle = bicycleFactory.CreateVehicle();
        bicycle.Drive();
    }
}