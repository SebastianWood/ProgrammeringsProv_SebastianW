using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsProv_SebastianW
{
    class Program
    {
        static void Main(string[] args)
        {
            kunder antal = new kunder(); //reglerar ett nytt antal av kunder.

            Random generator = new Random(); //en random generator som gör att man kan använda den slumpmässigt inom koden. 
            

           

            Console.WriteLine("Här får du se några böcker nedan med dess namn och kategory!");

            Bocker bok = new Bocker();

            Console.WriteLine(bok.name); //implementerar så att bok kan skrivas som ett namn nedan. 

            bok.name = "Robert";

            Console.WriteLine("BokNamn: " + bok.name + ".");

            Bocker kategory = new Bocker();

            kategory.name = "Komedy"; //tar kategory från klassen Bocker och nämner den till komedy. 

            Console.WriteLine("Kategory: " + kategory.name + "."); //printar ut namn på kategory

            Console.ReadLine();


            Console.WriteLine("Nu skulle vi vilja låta dig att döpa en bok! Skriv ett bok namn nu!");

            string namnBok = Console.ReadLine(); //kan skriva in namn på boken.

            Console.WriteLine("Hur mycket kostar den här boken?");

            int pris = int.Parse(Console.ReadLine()); //kan skriva in pris på boken

            Console.WriteLine("Namnet på boken är" + pris + " och priset på den blev " +pris+ "!" );

            Console.ReadLine();

            int money = generator.Next(1000); //randomiserar från 0 till 1000

            kunder kund1 = new kunder(); //skriver ut kund1 från kunder klassen

            Console.WriteLine(kund1.name); //gör så att name kan få ett namn 

            kund1.name = "Robert";

            kunder plånbok = new kunder();

            Console.WriteLine(plånbok.pengar);

            plånbok.pengar = money;


            Console.WriteLine("Den första kunden heter " + kund1.name + " och har" + plånbok.pengar + " kr i sin plånbok");

            Console.ReadLine();


        }


        public void PrintInfo() //hann inte med det ;(
        {




        }


    }
}
