namespace Assignment9
{
    public class Public : Vehicles, IDescription
    {
        public int PassengerAmount { get; set; }
        public override void GetInfo(string name)
        {
            CategoryName = name;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Passenger amount: {PassengerAmount}");
        }
        public void PrintDescription()
        {
            Console.WriteLine("Public vehicles are used for public transport.");
        }
    }
}
