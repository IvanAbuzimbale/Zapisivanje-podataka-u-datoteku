using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.IO;

namespace Test_08032021_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši ime: ");
            var ime = Console.ReadLine();
            Console.WriteLine("Upiši prezime: ");
            var prezime = Console.ReadLine();
            Console.WriteLine("Upiši godinu rođenja: ");
            var god_rod = Console.ReadLine();
            Console.WriteLine("Upiši svoj e-mail: ");
            string email = Console.ReadLine();
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
         RegexOptions.CultureInvariant | RegexOptions.Singleline);
            bool valjanostmaila = regex.IsMatch(email);
            if (!valjanostmaila)
            {
                Console.WriteLine($"Mail nije točan");
            }
            string sve = ime + ", " + prezime + ", " + god_rod + ", " + email;
            File.WriteAllText("C:/Users/ivanm/Documents/testNiOP/MočilacIvanSystemNiOP.csv", sve);
            Console.ReadKey();
        }
    }
}
