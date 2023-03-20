
using System;

namespace percobaan_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            bool isRunning = true;
            Console.WriteLine("=========================================");
            Console.WriteLine("==            kalkulator               ==");
            Console.WriteLine("=========================================");

            Console.WriteLine("masukan nilai a : ");
            double x = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("masukan nilai b : ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("                                         ");
                Console.WriteLine("=========================================");
                Console.WriteLine("==            pilih operasi            ==");
                Console.WriteLine("=========================================");
                Console.WriteLine("==                                     ==");
                Console.WriteLine("==           +  penjumlahan            ==");
                Console.WriteLine("==           -  pengurangan            ==");
                Console.WriteLine("==           *  perkalian              ==");
                Console.WriteLine("==           /  pembagian              ==");
                Console.WriteLine("==                                     ==");
                Console.WriteLine("=========================================");
                string z = Console.ReadLine();

                switch (z)
                {
                    case "+":
                        Console.WriteLine("=========================================");
                        Console.WriteLine("==        hasil dari penjummlahan      ==");
                        Console.WriteLine("=========================================");
                        x = (x + y);  //Store the result in x
                        Console.WriteLine(x);
                        break;
                    case "-":
                        Console.WriteLine("=========================================");
                        Console.WriteLine("==        hasil dari pengurangan       ==");
                        Console.WriteLine("=========================================");
                        x = (x - y);  //Store the result in x
                        Console.WriteLine(x);
                        break;
                    case "*":
                        Console.WriteLine("=========================================");
                        Console.WriteLine("==        hasil dari perkalian         ==");
                        Console.WriteLine("=========================================");
                        x = (x * y);  //Store the result in x
                        Console.WriteLine(x);
                        break;
                    case "/":
                        if (y == 0)
                        {
                            Console.WriteLine("nilai tidak valid");
                        }
                        else
                        {
                            Console.WriteLine("=========================================");
                            Console.WriteLine("==        hasil dari pembagian         ==");
                            Console.WriteLine("=========================================");
                            x = (x / y);
                            Console.WriteLine(x);
                        }
                        break;

                        Console.WriteLine("Apakah Anda ingin melakukan operasi matematika lagi? (y/n)");
                        string choice = Console.ReadLine();

                        if (choice.ToLower() == "n")
                        {
                            isRunning = false;
                        }
                }

                Console.WriteLine("\nTekan random key untuk berhenti");
                Console.ReadKey();
            }


        }
    }
}