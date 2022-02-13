using System;

namespace InstagamAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // program küsib kasutaja vanust;
            //program kontrollib kas kasutaja on vanem kui 13 a või 13 a vana;
            //kui kasutaja on 13 aastat vana või vanem siis ta võib instagram'i kasutada;
            //kui kasutaja on noorem kui 13 siis ta on liiga noor;

            Console.WriteLine("Palun sisesta oma vanud:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagam'i kontot luua.");
            }
            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et instagram'i kontot luua.");
            }
            else
            {
                Console.WriteLine("Oledki 13, nüüd saa endale Instagam'i kontot luua.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
