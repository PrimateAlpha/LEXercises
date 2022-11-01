namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personalregister");


            Console.Write("Medarbetarens förnamn? ");
            string firstName = Console.ReadLine();

            Console.Write("Medarbetarens Efternamn? ");
            string lastName = Console.ReadLine();

            Console.Write("Employers salary? ");
            string salary = Console.ReadLine();


            DisplayResult(firstName, lastName, salary);


            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(string firstName, string lastName, string salary)
        {
            Console.WriteLine("Medarbetarens uppgifter: ");
            Console.Write(String.Format("{0} {1} {2}",
                firstName,
                lastName + ",",
                "Lön: " + salary + " SEK/månad"));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine("Results: ");
            Console.Write(message);

        }
    }
}