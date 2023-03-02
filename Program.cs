namespace Day19Regex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Patterns pattern = new Patterns();

            Console.WriteLine("Enter your Email Id: ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if(val)
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email Id!");
            }
        }
    }
}