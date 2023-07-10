using System;

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

class Coupe:Vehicle
{

    public Coupe(string make, string model, int year):base(make, model, year) {

    }

    public override void Display() {

    }

    public override void Sold() {
        _isSold = true;
    }

    public override void Reset() {
        _isSold = false;
    }

    public override void Save(StreamWriter writer) {
        writer.WriteLine($"Coupe,{_make},{_model},{_year},{_isSold}");
    }

    public override void Load(string[] data) {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[3]);
    }
}

class Sedan:Vehicle
{
    public Sedan(string make, string model, int year):base(make, model, year) {
        
    }

    public override void Display() {

    }

    public override void Sold() {
        _isSold = true;
    }

    public override void Reset() {
        _isSold = false;
    }

    public override void Save(StreamWriter writer) {
    writer.WriteLine($"Sedan,{_make},{_model},{_year},{_isSold}");
    }

    public override void Load(string[] data) {

    }
}

class SUV:Vehicle
{
     public SUV(string make, string model, int year):base(make, model, year) {
        
    }

    public override void Display() {
        
    }

    public override void Sold() {
        _isSold = true;
    }

    public override void Reset() {
        _isSold = false;
    }

    public override void Save(StreamWriter writer) {
        writer.WriteLine($"SUV,{_make},{_model},{_year},{_isSold}");
    }

    public override void Load(string[] data) {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[3]);
    }
}

class Truck:Vehicle
{
     public Truck(string make, string model, int year):base(make, model, year) {
        
    }

    public override void Display() {

    }

    public override void Sold() {
        _isSold = true;
    }

    public override void Reset() {
        _isSold = false;
    }

    public override void Save(StreamWriter writer) {
        writer.WriteLine($"Truck,{_make},{_model},{_year},{_isSold}");
    }

    public override void Load(string[] data) {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[3]);
    }
}

class Motorcycle:Vehicle
{
     public Motorcycle(string make, string model, int year):base(make, model, year) {
        
    }

    public override void Display() {

    }

    public override void Sold() {
        _isSold = true;
    }

    public override void Reset() {
        _isSold = false;
    }

    public override void Save(StreamWriter writer) {
        writer.WriteLine($"Motorcycle,{_make},{_model},{_year},{_isSold}");
    }

    public override void Load(string[] data) {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[3]);
    }
}

class Crossover:Vehicle
{
     public Crossover(string make, string model, int year):base(make, model, year) {
        
    }

    public override void Display() {

    }

    public override void Sold() {
        _isSold = true;
    }

    public override void Reset() {
        _isSold = false;
    }

    public override void Save(StreamWriter writer) {
    writer.WriteLine($"Crossover,{_make},{_model},{_year},{_isSold}");
    }

    public override void Load(string[] data) {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[3]);
    }
}

class Van:Vehicle
{
     public Van(string make, string model, int year):base(make, model, year) {
        
    }

    public override void Display() {

    }

    public override void Sold() {
        _isSold = true;
    }

    public override void Reset() {
        _isSold = false;
    }

    public override void Save(StreamWriter writer) {
        writer.WriteLine($"Van,{_make},{_model},{_year},{_isSold}");
    }

    public override void Load(string[] data) {
        _make = data[1];
        _model = data[2];
        _year = int.Parse(data[3]);
        _isSold = bool.Parse(data[3]);
    }
}

class Program
{
    static List<Vehicle> vehicles = new List<Vehicle>();
    static void Main(string[] args)
    {
        // int price = 0? or would this be in each class?

        // LoadVehicles()

        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("===== Vehivle Inventory =====");
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
                    // AddVehicle();
                    break;
                case "2":
                    // SellVehicle();
                    break;
                case "3":
                    // ShowVehicle();
                    break;
                case "4":
                    // SaveVehicle();
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

    }

    static void SellVehicle()
    {

    }

    static void ShowVehicle()
    {

    }

    static void SaveVehicle()
    {

    }

    static void LoadVehicle()
    {

    }
}