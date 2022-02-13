using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun, sisesta oma vanus: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int YearOfBirth = 2022 - userAge;
            Console.WriteLine($"Olete sündinud {YearOfBirth} aastal.");


            //programm küsib kasutaja vanust;
            // programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            
            //oled sündinud aatal {kasutajaSünniAasta}

        }
    }
}
