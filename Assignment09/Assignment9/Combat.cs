namespace Assignment9
{
    public class Combat : Vehicles, IDescription
    {
        public bool Shoots { get; set; }
        public string Details { get; set; }
        public override void GetInfo(string name)
        {
            CategoryName = name;
        }
        public void PrintDescription()
        {
            Console.WriteLine("Combat vehicles are used for wars.");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Shoots: {Shoots}");
        }
    }
}
