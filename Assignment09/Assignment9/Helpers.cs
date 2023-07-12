namespace Assignment9
{
    public static class Helpers
    {
        // Reads int in range input
        public static int ReadInt(int min, int max)
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result) || result < min || result > max)
            {
                Console.WriteLine($"Wrong number, input between {min} and {max}");
            }
            return result;
        }

        //Prints All Models and than Returns Model Enum With Given Number
        public static Models getModels()
        {
            int number = 0;
            Console.WriteLine("Choose model: ");
            foreach (Models i in Enum.GetValues(typeof(Models)))
            {
                Console.Write($"{number}.{i} ");
                number++;
            }
            Console.WriteLine();

            int modelNumber = ReadInt(0, 7);

            switch (modelNumber)
            {
                case 1: return Models.BMW;
                case 2: return Models.Honda;
                case 3: return Models.Ford;
                case 4: return Models.Honda;
                case 5: return Models.Lamborgini;
                case 6: return Models.Ferrari;
                case 7: return Models.Mercedes_Benz;
                default: return Models.Undefined;
            }
        }
        //Gets Any Emun And Prints All Of Its Value
        public static int PrintVehiclesCategories(Type enumType)
        {
            int number = 1;
            int categoryNumber;
            Console.WriteLine($"Enter the name of {enumType.Name} vehicle from the list below:");
            foreach (var i in Enum.GetValues(enumType))
            {
                Console.WriteLine($"{number}.{i} ");
                number++;
            }
            categoryNumber = ReadInt(0, number);
            return categoryNumber;
        }
    }
}
