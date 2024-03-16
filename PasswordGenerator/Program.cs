namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lengtePassword = 0;

            Console.WriteLine("*****************************\nWelkom bij Password Generator\n*****************************");

            while(true)

            {
                Console.WriteLine("Hoelang moet je wachtwoord zijn? (min: 8 tekens / max: 20 tekens)");
                lengtePassword = int.Parse(Console.ReadLine());

                if (lengtePassword >= 8 && lengtePassword <= 20)
                {
                    Console.Write("Wachtwoord: ");
                    for (int i = 0; i < lengtePassword; i++)
                    {
                        char randomPassword = Convert.ToChar(random.Next(33, 123));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(randomPassword);
                        
                    }
                    Console.WriteLine( );
                    break;
                }
                else
                {
                    Console.WriteLine("Ongeldige lengte, probeer opnieuw.");
                   
                }
                
            }
            Console.ForegroundColor= ConsoleColor.White;    
            

        }
    }
}