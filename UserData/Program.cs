using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasuataja vanust;
            //prog kuvab kasutaja vanust konsoolis;
            //"oled sündinud aastal{yearOfBirth}";


            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            //Console.WriteLine("oled " + userAge + " aastat vana.");

            //string interpolation

            Console.WriteLine($"oled {userAge} aastat vana.");
        }
    }
}
