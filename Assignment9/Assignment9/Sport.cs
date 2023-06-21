namespace Assignment9
{
    public class Sport : Vehicles, IDescription
    {
        public int TopSpeed { get; set; }
        public int horsePower { get; set; }
        public override void GetInfo(string name)
        {
            CategoryName = name;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Horse power: {horsePower}");
            Console.WriteLine($"Top speen: {TopSpeed}");
        }
        public void PrintDescription()
        {
            Console.WriteLine("Sport vehicles are used for racing.");
        }
    }
}
