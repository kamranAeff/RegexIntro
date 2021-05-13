using RegularPractice.ConsoleApp.AppCode.Extension;
using System;
using System.Text.RegularExpressions;

namespace RegularPractice.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Şifrə: ");
        l2:
            string pwd = Console.ReadLine();

            if (!pwd.IsPassword())
            {
                Console.Write("Düzgün formatda deyil,yenidən daxil edin:");
                goto l2;
            }

            Console.WriteLine($"Sizin şifrəniz, {pwd}");

            return;

            Console.Write("Adınız: ");
            l1: 
            string name = Console.ReadLine();

            if (!name.IsName())
            {
                Console.Write("Düzgün formatda deyil,yenidən daxil edin:");
                goto l1;
            }

            Console.WriteLine($"Salam, {name}");

            return;
            string phone = "555-455-12-13";

            if (phone.IsPhone())
            {
                Console.WriteLine($"{phone} uygun formatdadir");
            }
            else
            {
                Console.WriteLine($"{phone} uygun formatda deyil");
            }

            phone = "055-455-12-13";

            if (phone.IsPhone())
            {
                Console.WriteLine($"{phone} uygun formatdadir");
            }
            else
            {
                Console.WriteLine($"{phone} uygun formatda deyil");
            }

            phone = "+99455-455-12-13";

            if (phone.IsPhone())
            {
                Console.WriteLine($"{phone} uygun formatdadir");
            }
            else
            {
                Console.WriteLine($"{phone} uygun formatda deyil");
            }


            string email = "555-455-1-13";
            Console.WriteLine("##########################");
            email = "test";
            bool state = email.IsEmail();

            Console.WriteLine(state);

            email = "test@mail.ru";
            state = Extension.IsEmail(email);
            Console.WriteLine(state);

            email = "test@mail";
            state = email.IsEmail();
            Console.WriteLine(state);
        }

       
    }
}
