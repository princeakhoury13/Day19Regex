namespace Day19Regex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Patterns pattern = new Patterns();

            Console.WriteLine("Enter your Password (Min 8 Characters) ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if(val)
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password!");
            }
        }
    }
}