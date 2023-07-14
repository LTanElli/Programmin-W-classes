using System;
using System.Collections.Generic;
using System.IO;

abstract class Vehicle
{
    public string _make;
    public string _model;
    public int _year;
    public bool _isSold;

    public Vehicle(string make, string model, int year)
    {
        _make = make;
        _model = model;
        _year = year;
        _isSold = false;
    }

    public abstract void Display();
    public abstract void Sold();
    public abstract void Reset();
    public abstract void Save(StreamWriter writer);
    public abstract void Load(string[] data);
}

class Coupe : Vehicle
{
    public int _numberOfSeats;

    public Coupe(string make, string model, int year) : base(make, model, year)
    {

    }

    public override void Display()
    {
        Console.WriteLine("Make: " + _make);
        Console.WriteLine("Model: " + _model);
        Console.WriteLine("Year: " + _year);
        Console.WriteLine("Number of Seats: " + _numberOfSeats);
        Console.WriteLine("Is Sold: " + _isSold);
    }

    public override void Sold()
    {
        _isSold = true;
    }

    public override void Reset()
    {
        _isSold = false;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Coupe,{_make},{_model},{_year},{_isSold},{_numberOfSeats}");
    }

    public override void Load(string[] data)
    {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[4]);
        _numberOfSeats = int.Parse(data[5]);
    }
}

class Sedan : Vehicle
{
    public bool _isHybrid;

    public Sedan(string make, string model, int year) : base(make, model, year)
    {

    }

    public override void Display()
    {
        Console.WriteLine("Make: " + _make);
        Console.WriteLine("Model: " + _model);
        Console.WriteLine("Year: " + _year);
        Console.WriteLine("Is Hybrid: " + _isHybrid);
        Console.WriteLine("Is Sold: " + _isSold);
    }

    public override void Sold()
    {
        _isSold = true;
    }

    public override void Reset()
    {
        _isSold = false;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Sedan,{_make},{_model},{_year},{_isSold},{_isHybrid}");
    }

    public override void Load(string[] data)
    {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[4]);
        _isHybrid = bool.Parse(data[5]);
    }
}

class SUV : Vehicle
{
    public int _cargoCapacity;

    public SUV(string make, string model, int year) : base(make, model, year)
    {

    }

    public override void Display()
    {
        Console.WriteLine("Make: " + _make);
        Console.WriteLine("Model: " + _model);
        Console.WriteLine("Year: " + _year);
        Console.WriteLine("Cargo Capacity: " + _cargoCapacity);
        Console.WriteLine("Is Sold: " + _isSold);
    }

    public override void Sold()
    {
        _isSold = true;
    }

    public override void Reset()
    {
        _isSold = false;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"SUV,{_make},{_model},{_year},{_isSold},{_cargoCapacity}");
    }

    public override void Load(string[] data)
    {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[4]);
        _cargoCapacity = int.Parse(data[5]);
    }
}

class Truck : Vehicle
{
    public int _hasTrailer;

    public Truck(string make, string model, int year) : base(make, model, year)
    {

    }

    public override void Display()
    {
        Console.WriteLine("Make: " + _make);
        Console.WriteLine("Model: " + _model);
        Console.WriteLine("Year: " + _year);
        Console.WriteLine("Has Trailer: " + _hasTrailer);
        Console.WriteLine("Is Sold: " + _isSold);
    }

    public override void Sold()
    {
        _isSold = true;
    }

    public override void Reset()
    {
        _isSold = false;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Truck,{_make},{_model},{_year},{_isSold},{_hasTrailer}");
    }

    public override void Load(string[] data)
    {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[4]);
        _hasTrailer = int.Parse(data[5]);
    }
}

class Motorcycle : Vehicle
{
    public int _engineCapacity;

    public Motorcycle(string make, string model, int year) : base(make, model, year)
    {

    }

    public override void Display()
    {
        Console.WriteLine("Make: " + _make);
        Console.WriteLine("Model: " + _model);
        Console.WriteLine("Year: " + _year);
        Console.WriteLine("Engine Capacity: " + _engineCapacity);
        Console.WriteLine("Is Sold: " + _isSold);
    }

    public override void Sold()
    {
        _isSold = true;
    }

    public override void Reset()
    {
        _isSold = false;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Motorcycle,{_make},{_model},{_year},{_isSold},{_engineCapacity}");
    }

    public override void Load(string[] data)
    {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[4]);
        _engineCapacity = int.Parse(data[5]);
    }
}

class Crossover : Vehicle
{
    public bool _isAllWheelDrive;

    public Crossover(string make, string model, int year) : base(make, model, year)
    {

    }

    public override void Display()
    {
        Console.WriteLine("Make: " + _make);
        Console.WriteLine("Model: " + _model);
        Console.WriteLine("Year: " + _year);
        Console.WriteLine("Is All-Wheel Drive: " + _isAllWheelDrive);
        Console.WriteLine("Is Sold: " + _isSold);
    }

    public override void Sold()
    {
        _isSold = true;
    }

    public override void Reset()
    {
        _isSold = false;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Crossover,{_make},{_model},{_year},{_isSold},{_isAllWheelDrive}");
    }

    public override void Load(string[] data)
    {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[4]);
        _isAllWheelDrive = bool.Parse(data[5]);
    }
}

class Van : Vehicle
{
    public int _passengerCapacity;

    public Van(string make, string model, int year) : base(make, model, year)
    {

    }

    public override void Display()
    {
        Console.WriteLine("Make: " + _make);
        Console.WriteLine("Model: " + _model);
        Console.WriteLine("Year: " + _year);
        Console.WriteLine("Passenger Capacity: " + _passengerCapacity);
        Console.WriteLine("Is Sold: " + _isSold);
    }

    public override void Sold()
    {
        _isSold = true;
    }

    public override void Reset()
    {
        _isSold = false;
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Van,{_make},{_model},{_year},{_isSold},{_passengerCapacity}");
    }

    public override void Load(string[] data)
    {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[4]);
        _passengerCapacity = int.Parse(data[5]);
    }
}

class Program
{
    static List<Vehicle> vehicles = new List<Vehicle>();

    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("===== Vehicle Inventory =====");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. Sell Vehicle");
            Console.WriteLine("3. Show Vehicle Inventory");
            Console.WriteLine("4. Save Current Inventory");
            Console.WriteLine("5. Exit Inventory");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddVehicle();
                    break;
                case "2":
                    SellVehicle();
                    break;
                case "3":
                    ShowVehicleInventory();
                    break;
                case "4":
                    SaveVehicleInventory();
                    Console.WriteLine("Vehicles saved successfully.");
                    break;
                case "5":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void AddVehicle()
    {
        Console.Clear();
        Console.WriteLine("=== Add Vehicle ===");
        Console.Write("Enter the make: ");
        string make = Console.ReadLine();
        Console.Write("Enter the model: ");
        string model = Console.ReadLine();
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Select the type of vehicle:");
        Console.WriteLine("1. Coupe");
        Console.WriteLine("2. Sedan");
        Console.WriteLine("3. SUV");
        Console.WriteLine("4. Truck");
        Console.WriteLine("5. Motorcycle");
        Console.WriteLine("6. Crossover");
        Console.WriteLine("7. Van");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter the number of seats: ");
                int numberOfSeats = int.Parse(Console.ReadLine());

                Coupe coupe = new Coupe(make, model, year);
                coupe._numberOfSeats = numberOfSeats;

                vehicles.Add(coupe);
                Console.WriteLine("Coupe added successfully.");
                break;

            case "2":
                Console.Write("Is it a hybrid? (true/false): ");
                bool isHybrid = bool.Parse(Console.ReadLine());

                Sedan sedan = new Sedan(make, model, year);
                sedan._isHybrid = isHybrid;

                vehicles.Add(sedan);
                Console.WriteLine("Sedan added successfully.");
                break;

            case "3":
                Console.Write("Enter the passenger capacity: ");
                int cargoCapacity = int.Parse(Console.ReadLine());

                SUV suv = new SUV(make, model, year);
                suv._cargoCapacity = cargoCapacity;

                vehicles.Add(suv);
                Console.WriteLine("SUV added successfully.");
                break;

            case "4":
                Console.Write("Is it 2 or 4 doors?: ");
                int hasTrailer = int.Parse(Console.ReadLine());

                Truck truck = new Truck(make, model, year);
                truck._hasTrailer = hasTrailer;

                vehicles.Add(truck);
                Console.WriteLine("Truck added successfully.");
                break;

            case "5":
                Console.Write("Enter the engine capacity (50 to 1500): ");
                int engineCapacity = int.Parse(Console.ReadLine());

                Motorcycle motorcycle = new Motorcycle(make, model, year);
                motorcycle._engineCapacity = engineCapacity;

                vehicles.Add(motorcycle);
                Console.WriteLine("Motorcycle added successfully.");
                break;

            case "6":
                Console.Write("Is it all-wheel drive? (true/false): ");
                bool isAllWheelDrive = bool.Parse(Console.ReadLine());

                Crossover crossover = new Crossover(make, model, year);
                crossover._isAllWheelDrive = isAllWheelDrive;

                vehicles.Add(crossover);
                Console.WriteLine("Crossover added successfully.");
                break;

            case "7":
                Console.Write("Enter the passenger capacity: ");
                int passengerCapacity = int.Parse(Console.ReadLine());

                Van van = new Van(make, model, year);
                van._passengerCapacity = passengerCapacity;

                vehicles.Add(van);
                Console.WriteLine("Van added successfully.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void SellVehicle()
    {
        Console.Clear();
        Console.WriteLine("=== Sell Vehicle ===");
        Console.Write("Enter the make: ");
        string make = Console.ReadLine();
        Console.Write("Enter the model: ");
        string model = Console.ReadLine();

        Vehicle vehicle = vehicles.Find(v => v._make == make && v._model == model);
        if (vehicle != null)
        {
            vehicle._isSold = true;
            Console.WriteLine("Vehicle marked as sold.");
        }
        else
        {
            Console.WriteLine("Vehicle not found.");
        }
    }

    static void ShowVehicleInventory()
    {
        Console.Clear();
        Console.WriteLine("=== Vehicle Inventory ===");
        foreach (var vehicle in vehicles)
        {
            vehicle.Display();
            Console.WriteLine();
        }
    }

    static void SaveVehicleInventory()
    {
        Console.Clear();
        Console.WriteLine("=== Save Vehicle Inventory ===");
        Console.Write("Enter the file path to save the inventory: ");
        string filePath = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Save(writer);
            }
        }
        Console.WriteLine("Inventory Saved Successfully.");
    }

    static void LoadVehicleInventory()
    {
        Console.Clear();
        Console.WriteLine("=== Load Vehicle Inventory ===");
        Console.Write("Enter the file path to load the inventory: ");
        string filePath = Console.ReadLine();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                string vehicleType = data[0];

                Vehicle vehicle;
                switch (vehicleType)
                {
                    case "Coupe":
                        vehicle = new Coupe(data[1], data[2], int.Parse(data[3]));
                        ((Coupe)vehicle)._numberOfSeats = int.Parse(data[5]);
                        break;

                    case "Sedan":
                        vehicle = new Sedan(data[1], data[2], int.Parse(data[3]));
                        ((Sedan)vehicle)._isHybrid = bool.Parse(data[5]);
                        break;

                    case "SUV":
                        vehicle = new SUV(data[1], data[2], int.Parse(data[3]));
                        ((SUV)vehicle)._cargoCapacity = int.Parse(data[5]);
                        break;

                    case "Truck":
                        vehicle = new Truck(data[1], data[2], int.Parse(data[3]));
                        ((Truck)vehicle)._hasTrailer = int.Parse(data[5]);
                        break;

                    case "Motorcycle":
                        vehicle = new Motorcycle(data[1], data[2], int.Parse(data[3]));
                        ((Motorcycle)vehicle)._engineCapacity = int.Parse(data[5]);
                        break;

                    case "Crossover":
                        vehicle = new Crossover(data[1], data[2], int.Parse(data[3]));
                        ((Crossover)vehicle)._isAllWheelDrive = bool.Parse(data[5]);
                        break;

                    case "Van":
                        vehicle = new Van(data[1], data[2], int.Parse(data[3]));
                        ((Van)vehicle)._passengerCapacity = int.Parse(data[5]);
                        break;

                    default:
                        Console.WriteLine("Invalid vehicle type.");
                        continue;
                }

                vehicle._isSold = bool.Parse(data[4]);
                vehicles.Add(vehicle);
            }
        }

        Console.WriteLine("Inventory loaded successfully.");
    }
}
