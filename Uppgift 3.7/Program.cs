using System;
namespace Uppgift3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal.");
            string helaTal = Console.ReadLine();
            int plusIndex = helaTal.IndexOf("+");
            int minusIndex = helaTal.IndexOf("-");
            int multiplikationIndex = helaTal.IndexOf("*");
            int divisionIndex = helaTal.IndexOf("/");

            if (helaTal.Contains("+"))
            {
                string tal1PlusString = helaTal[..plusIndex];
                double tal1Plus = double.Parse(tal1PlusString);
                string tal2PlusString = helaTal[(plusIndex + 1)..];
                double tal2Plus = double.Parse(tal2PlusString);
                double summa = tal1Plus + tal2Plus;
                Console.WriteLine(tal1Plus + " + " + tal2Plus + " = " + summa);
            }
            else if (helaTal.Contains("-"))
            {
                string tal1MinusString = helaTal[..minusIndex];
                double tal1Minus = double.Parse(tal1MinusString);
                string tal2MinusString = helaTal[(minusIndex + 1)..];
                double tal2Minus = double.Parse(tal2MinusString);
                double differens = tal1Minus - tal2Minus;
                Console.WriteLine(tal1Minus + " - " + tal2Minus + " = " + differens);
            }
            else if (helaTal.Contains("*"))
            {
                string tal1MultiplikationString = helaTal[..multiplikationIndex];
                double tal1Multiplikation = double.Parse(tal1MultiplikationString);
                string tal2MultiplikationString = helaTal[(multiplikationIndex + 1)..];
                double tal2Multiplikation = double.Parse(tal2MultiplikationString);
                double produkt = tal1Multiplikation * tal2Multiplikation;
                Console.WriteLine(tal1Multiplikation + " * " + tal2Multiplikation + " = " + produkt);
            }
            else if (helaTal.Contains("/"))
            {
                string tal1DivisionString = helaTal[..divisionIndex];
                double tal1Division = double.Parse(tal1DivisionString);
                string tal2DivisionString = helaTal[(divisionIndex + 1)..];
                double tal2Division = double.Parse(tal2DivisionString);
                double kvot = tal1Division / tal2Division;
                Console.WriteLine(tal1Division + " / " + tal2Division + " = " + kvot);
            }
            else
            {
                Console.WriteLine("Vänligen skriv om ditt tal.");
            }
            Console.ReadKey();
        }
    }
}