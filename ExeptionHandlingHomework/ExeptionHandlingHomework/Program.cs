using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionHandlingHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework 1
            //List<string> list = new List<string>()
            //{
            //    "1", "2", "5a", "10b", "abc", "10", "50"
            //};
            //foreach(string item in list)
            //{
            //    try
            //    {
            //        int a = Convert.ToInt32(item);
            //        Console.WriteLine(a);
            //    }catch(Exception ex)
            //    {
            //        continue;
            //    }
            //}

            //Homework 2
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Number: ");
            //        string input = Console.ReadLine();
            //        if (input == "q")
            //        {
            //            break;
            //        }
            //        int number = Convert.ToInt32(input);
            //        Console.WriteLine("Your number : " + number);
            //    }catch (Exception ex)
            //    {
            //        Console.WriteLine("Wrong number.");
            //        continue;
            //    }
            //}

            //Homework 3
            Console.WriteLine("Password : ");
            string password = Console.ReadLine();

            try
            {
                CheckPassword(password);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        static void CheckPassword(string password)
        {
            string a = "ğ,Ğ,ç,Ç,ş,Ş,ü,Ü,ı,İ";
            foreach (var character in turkishCharacters)
            {
                if (turkishCharacters.IndexOf(character) > -1)
                {
                    throw new Exception("cannot contain Turkish characters");
                }
            }
            Console.WriteLine("Valid password");
        }
    }
}
