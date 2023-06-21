namespace Assignment9
{
    public class Personal : Vehicles, IDescription
    {
        public string Color { get; set; }
        public int SeatAmount { get; set; }
        public override void GetInfo(string name)
        {
            CategoryName = name;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Amount of seats: {SeatAmount}");
        }
        public void PrintDescription()
        {
            Console.WriteLine("Personal vehicles are used for family or personal use.");
        }
    }
}