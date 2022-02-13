using System;

namespace DriveingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog küsib kasutaj vanust;
            //prog arvutab kasutaja vanuse;

            //kui kasutaja on noorem,kui 18, siis programm kuvab konsoolis;
            // -" Oled liiga noo, et juhi lube saada";

            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis;
            // - "oled piisavalt vana, et juhulube saada";

            // kui kasutaja on 18, siis programm kuvab konsoolis;
            // " Palju Õnne! Nüüd saad juhilube taotleda"

            Console.WriteLine("Palun, sisesta oma vanus: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhulube saada.");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhi lube saada");
            }
            else
            {
                Console.WriteLine("Palju Õnne! Nüüd saad juhilube taotleda.");
            }

            Console.WriteLine("Kena päeva!");
        }

    }
}
