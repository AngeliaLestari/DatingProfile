using Microsoft.Win32.SafeHandles;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Dating_Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam", 35, "Tulungagung", "Swiss");
            sam.SetHobbies(new string[] {"Tidur", "Makan Cabe", "Ngupil", "Berenang"});

            Console.WriteLine(sam.ViewProfile());

            Profile Mary = new Profile("Mary", 40, "Malang", "Belanda");
            Mary.SetHobbies(new string[] { "Molor", "Membaca", "Menyanyi", "Bersepeda" });
            Console.WriteLine(Mary.ViewProfile());

        }
                    
           


        
    }
}
