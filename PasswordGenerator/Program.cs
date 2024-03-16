namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lengtePassword = 0;

            Console.WriteLine("*****************************\nWelcome to Password Generator\n*****************************");

            while(true)

            {
                Console.WriteLine("how long should your password be? (min: 8 characters / max: 20 characters)");
                lengtePassword = int.Parse(Console.ReadLine());

                if (lengtePassword >= 8 && lengtePassword <= 20)
                {
                    Console.Write("Password: ");
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
                    Console.WriteLine("Invalid length, please try again.");
                   
                }
                
            }
            Console.ForegroundColor= ConsoleColor.White;    
            

        }
    }
}
