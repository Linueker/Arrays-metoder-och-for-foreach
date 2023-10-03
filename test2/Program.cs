using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace arrays
{

    class Program

    {
        /*
         * Övningar i momenten Arrays, for-loopar, foreach-loopar och metoder.
         * Kurs: Programmering grund .NET C#
         * Utgivare: Linus Ekermo, student
         * Datum: 2023-10-03
         * Version: 1.0
         * 
         */
        static void Main()
        {
            bool isRunning = true;
            while (isRunning)
            {

                Console.WriteLine("======================================================== \n" +
                    "Ange nummer för ditt val och tryck enter: \n \n" +
                    "1. Sorterande av gitarrer i en sting-array \n" +
                    "2. Summernade av integers i en int-array \n" +
                    "3. Sorterar och sen radar upp element i en string-array med en foreach-loop \n" +
                    "4. Printar ut en text som lagrats i en metod \n" +
                    "5. Printar ut en overload-metod (addera) med retur int och double \n" +
                    "6. Tar in kontaktinfo i en string-array och visar skapat kontaktkort \n" +
                    "7. Listar Bok och Pris ur en 2D-array \n" +
                    "8. Metoder som skriver ut en spelares valda namn samt XP och Level \n" +
                    "9. Metod som lägger på 5% ökning på angiven lön \n" +
                    "10.Konkatinering av en array med namn via en separat metod \n" +
                    "11.for-loop som listar upp alla tal i nummer-variabeln \n" +
                    "12.Lista på alla nummer mellan 1 och angivet tal \n" +
                    "" +
                    "========================================================");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1: //Sorterande av gitarrer i en sting-array

                        string[] gitarrer = { "Les Paul", "SG", "Explorer", "DOT" };
                        Array.Sort(gitarrer);
                        Console.WriteLine($"Gitarrmodeller: {gitarrer[0]}, {gitarrer[1]}, {gitarrer[2]} och {gitarrer[3]} ");

                        Console.ReadLine();
                        break;

                    case 2: //Summernade av integers i en int-array

                        int[] numbers = { 12, 50, 72 };
                        int summa = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            summa += numbers[i];

                        }
                        Console.WriteLine("Summan av alla tal i din array är: " + summa);

                        Console.ReadLine();
                        break;

                    case 3: //Sorterar och sen radar upp element i en string-array med en foreach-loop

                        string[] kurser = { "C#", "Databaser", "Webbutveckling", "Clean code" };
                        Array.Sort(kurser);

                        Console.WriteLine("Kurser: ");
                        foreach (string i in kurser)
                        {
                            Console.WriteLine(i);
                        }

                        Console.ReadLine();
                        break;

                    case 4: //Printar ut en text som lagrats i en metod i calssen "printouts"

                        printOuts.printHTML();

                        Console.ReadLine();
                        break;

                    case 5: //Printar ut en overload-metod (addera) med retur int och double

                        int a = 2;
                        int b = 3;

                        Console.WriteLine($"{a} + {b} = " + printOuts.addera(a, b)+ "\n");

                        double c = 4.56;
                        double d = 3.56;

                        Console.WriteLine("4,56 + 3,56 = " + printOuts.addera(c, d) + "\n");

                        Console.WriteLine($"{a} * {b} = {printOuts.Multiplicera(a, b)}");

                        Console.ReadLine();
                        break;

                    case 6: //Tar in kontaktinfo i en string-array och visar skapat kontaktkort

                        string[] contactDetails = new string[5];

                        Console.WriteLine("Ange ditt förnamn: ");
                        contactDetails[0] = Console.ReadLine();
                        Console.WriteLine("Ange ditt Efternamn: ");
                        contactDetails[1] = Console.ReadLine();
                        Console.WriteLine("Ange din Adress: ");
                        contactDetails[2] = Console.ReadLine();
                        Console.WriteLine("Ange ditt Telefonnummer: ");
                        contactDetails[3] = Console.ReadLine();
                        Console.WriteLine("Ange din E-postadress: ");
                        contactDetails[4] = Console.ReadLine();

                        Console.WriteLine("\n" +
                            $"Dina kontaktuppgifter är: \n \n" +
                            $"Förnamn: {contactDetails[0]} \n" +
                            $"Efternamn: {contactDetails[1]} \n" +
                            $"Adress: {contactDetails[2]} \n" +
                            $"Telefonnummer: {contactDetails[3]} \n" +
                            $"E-postadress: {contactDetails[4]}");

                        Console.ReadLine();    
                        break;

                    case 7: //Listar Bok och Pris ur en 2D-array

                        string[,] bokRegister = { { "Then Name Of the Wind", "Att Föda Utan Rädsla" }, { "150kr", "200kr"} };

                        for (int i = 0; i < bokRegister.GetLength(1); i++)
                        {
                            Console.WriteLine("Bok: " + bokRegister[0, i] + ", Pris: " + bokRegister[1, i]);
                        }

                        Console.ReadLine();
                        break;

                    case 8: //Metoder som skriver ut valt spelarnamn samt XP och Level

                        Console.WriteLine("Ange namnet på din avatar: ");
                        string name = Console.ReadLine();

                        int xp = 900;
                        int level = 5;

                        Console.WriteLine(printOuts.PlayerWelcome(name));
                        printOuts.PlayerStat(xp, level);    
                      
                        Console.ReadLine();
                        break;

                    case 9: //Metod som lägger på 5% ökning på angiven lön

                        Console.WriteLine("Ange din lön: \n");
                        float inlön = float.Parse(Console.ReadLine());
                        float nylön = 0;

                        Console.WriteLine($"\n" +
                            $"Din löneökning är 5%! Din nya lön är: {printOuts.WithRaise(inlön, nylön)}");
                        
                        Console.ReadLine();
                        break;

                    case 10: //Konkatinering av en array med namn via en separat metod. Dvs listas alla namn i en förskriven lista upp

                        string[] names = { "Linus", "Bella", "Hedda", "Turid", "Albus" };

                        Console.WriteLine(" "+printOuts.NameList(names)+",");

                        Console.ReadLine();
                        break;

                    case 11: //for-loop som listar upp alla tal i nummer-variabeln

                        int number1 = 11;
                        int number2 = 100;

                        for (int i = 1;i<number1; i++)
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine();

                        for (int i = 2; i < number2; i+=2)
                        {
                            Console.WriteLine(i);
                        }

                        Console.ReadLine();
                        break;
                        
                    case 12: //Lista på alla nummer mellan 1 och angivet tal

                        Console.WriteLine("Ange ett valfritt heltal: ");
                        int heltal = int.Parse(Console.ReadLine());

                        if (heltal > 0)
                        {
                            Console.WriteLine("Här är alla tal mellan 1 och "+heltal);
                            for (int i = 1; i < heltal; i++)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Ange ett tal som är högre än 0");
                        }

                        Console.ReadLine();
                        break;

                    default: //programmet avslutas om man anger något annat än de alternativ som presenteras i början.

                        Console.WriteLine("Slut");
                        isRunning = false;
                        break;

                        
                }


            }


        }
}

}