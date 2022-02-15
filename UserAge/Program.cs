using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"oled sündinud aastal {yearOfBirth}

            Console.WriteLine("Palun sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int yearOfBirth = 2022 - userAge;

            Console.WriteLine($"Oled sündinud {yearOfBirth} aastal.");


        }
    }
}
