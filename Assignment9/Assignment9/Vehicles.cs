namespace Assignment9
{
    //Base Class Vehicles
    public abstract class Vehicles
    {
        public string CategoryName { get; set; }
        public Models Models { get; set; }
        public abstract void GetInfo(string name);
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Category: {CategoryName}");
            Console.WriteLine($"Model: {Models}");
        }
    }
    
    interface IDescription
    {
        void PrintDescription();
    }
}
