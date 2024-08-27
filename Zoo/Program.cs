using System;
using System.Collections.Generic;
using ZooManagement;

class Program
{
    static void Main(string[] args)
    {
        IZooOperationen zoo = new Zoo();
        zoo.TierHinzufügen(new Säugetier("Elefant", 10, "Grau"));
        zoo.TierHinzufügen(new Vogel("Papagei", 2, 0.3));
        zoo.TierHinzufügen(new Hund("Rex", 4));
        zoo.TierHinzufügen(new Katze("Mimi", 3));

        zoo.AlleTiereAnzeigen();

        zoo.TierEntfernen(new Katze("Mimi", 3));

        zoo.AlleTiereAnzeigen();

        foreach (var anzahl in zoo.GetTierAnzahl())
        {
            Console.WriteLine($"Tiereanzahl: {anzahl}");
        }

        var hund = new Hund("REX", 11);
        Console.WriteLine($"{hund.Name} ist alt? {hund.IsAlt()}");


        TierBehandeln(hund);


        static void TierBehandeln(Tier tier)
        {
            switch (tier)
            {
                case Hund hund:
                    hund.LautGeben(); break;
                case Katze katze:
                    katze.LautGeben(); break;

                default:
                    Console.WriteLine("Unbekanntes Tier");
                    break;
            }

        }
    }
}
