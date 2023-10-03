using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace arrays
{
    class printOuts
    {
        public static void printHTML()
        {
            Console.WriteLine("<!DOCTYPE html>");
            Console.WriteLine("<html>");
            Console.WriteLine("<body>");
            Console.WriteLine("<h1>Välkomna!</h1>");
            Console.WriteLine("<p>Kurs om C#</p>");
            Console.WriteLine("<p>Kurs om Databaser</p>");
            Console.WriteLine("</body>");
            Console.WriteLine("</html>");
        }

        public static int addera(int a, int b)
        {
            return a + b;
            }

        public static double addera(double c, double d) 
        {
            return c + d;
        }

        public static int Multiplicera(int a, int b) 
        {
            return a * b;
        }

        public static float WithRaise(float inlön, float nylön)
        {
            
            nylön = inlön + (inlön * 0.05F);
            return nylön;
        }

        public static string PlayerWelcome(string name) 
        {
            
            return $"Välkommen {name}!";

        }

        public static void PlayerStat(int xp, int level)
        {
            
            Console.WriteLine($"" +
                $"XP: {xp} \n" +
                $"Level: {level} \n");
                
                
        }

        public static string NameList(string[] names) 
        {
            
            return string.Concat(names);
        }
    }
}