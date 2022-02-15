using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm kontrollib, kas kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagrammi kasutada
            // kui kasutaja on noore, kui 13, siis ta on Instagrammi kasutamiseks liiga noor.

            Console.WriteLine("Palun, sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());


            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrammi kasutada");
            }
            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kasutajat luua");
            }
            else
            {
                Console.WriteLine("Oled 13 ja saad Instagrami kontot luua");
            }
            Console.WriteLine("Kena päeva");
        }
    }
}
