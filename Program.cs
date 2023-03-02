namespace Day19Regex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Patterns pattern = new Patterns();

            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if(val)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name!");
            }
        }
    }
}