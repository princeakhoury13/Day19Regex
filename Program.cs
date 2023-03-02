namespace Day19Regex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Patterns pattern = new Patterns();

            Console.WriteLine("Enter your Phone number (should start with our country code): ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if(val)
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number!");
            }
        }
    }
}