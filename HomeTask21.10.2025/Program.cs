namespace HomeTask21._10._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User.AddUser();
            User.AddUser();
            User.AddUser();
                Console.Clear();

            while (true)
            {
                
            Console.WriteLine("Metodlardan birini secin");
                Console.WriteLine("1. Butun istifadecileri goster");
                Console.WriteLine("2. Id-ye gore melumat almaq");
                Console.WriteLine("3. Cixis");
                char choice = Convert.ToChar(Console.ReadLine());

                switch (choice)
            {
                case '1':
                   User.ShowAllUsers();
                    break;
                case '2':
                    User.GetInfoById();
                    break;
                case '3':
                    Console.WriteLine("Consoldan Cixirsiniz,Sag olun!"); ;
                    return;
                default:
                    Console.WriteLine("Duzgun secim edin");
                    break;
            }
                Console.WriteLine("\nDavama basmaq üçün Enter...");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
