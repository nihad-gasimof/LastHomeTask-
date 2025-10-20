using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask21._10._2025
{
    internal class User
    {
        private static int _idCounter = 0;
        private int _id=0;
        public int Id
        {
            get { return _id; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id minimum 1 olmalidir");
                }
                
                _id = value;
            }
        }
        public int Age;

        public string FullName;
        public string Email;
        private string _Password;
        public static User[] users = [];
        public string Password
        {
            get { return _Password; }
            set
            {
               
                _Password = value;

            }
        }




        public User(string fullname,string email,string password,int age)
        {
            _idCounter++;
            Id = _idCounter;
            FullName = fullname;
            Email = email;
            Password = password;
            Age = age;

            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = this;

        }
        public void GetInfo()
        {
            Console.WriteLine($"Id:{_id},Fullname: {FullName}, Email: {Email}, Password: {Password}");
        }
        public static bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                Console.WriteLine("Password minimum 8 simvol olmalidir");
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Password en az 1 boyuk herf olmalidir");
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Passwordda en az 1 reqem olmalidir");
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                Console.WriteLine("Passwordda en az 1 kicik herf olmalidir");
                return false;
            }
            return true;
        }
        public static void AddUser()
        {
        restartfullname:
            Console.WriteLine("Userin Fullnameni daxil edin");
            string fullname=Console.ReadLine();
            if (string.IsNullOrEmpty(fullname)) {
                Console.WriteLine("Fullname bos ola bilmez");
                goto restartfullname;

            }
            else if (fullname.Any(char.IsDigit)) 
            {
                Console.WriteLine("Zehmet olmasa reqemden istifade etmeyin");
                goto restartfullname;
            }
        restartemail:
            Console.WriteLine("Userin Emailini daxil edin");
            string email = Console.ReadLine();
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("Email bos ola bilmez");
                goto restartemail;
            }
           
        restart:
            Console.WriteLine("Userin Passwordunu daxil edin");
            string password = Console.ReadLine();
            string password1="";
            bool securityPassword= PasswordChecker(password);
            if (securityPassword)
            {
               password1=password;
            }
            else
            {
                goto restart;
            }
        restartage:
            Console.WriteLine("Userin Age-ni daxil edin");
            int age=Convert.ToInt32(Console.ReadLine());
            if (age<0)
            {
                Console.WriteLine("Yas Menfi Deyer ala bilmez");
                goto restartage;    
            }
            User newUser = new User(fullname, email,password1, age);
            Console.WriteLine("User Elave olundu");
            
        }
        public static void ShowAllUsers()
        {
            foreach(User user in users)
            {
                user.GetInfo();
            }
        }
        public static void GetInfoById()
        {
            Console.WriteLine("Id ni daxil edin");
            int id=Convert.ToInt32(Console.ReadLine());
            foreach(User user in users)
            {
                if (user.Id==id)
                {
                    user.GetInfo();
                }
            }
        }



    }
}
