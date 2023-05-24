using System;
using System.Collections.Generic;

//TestFlemming Kamil Kulpa



// Øvelse 3 - 22 = Klasser har to komponenter:
// Felter er intet andet end de variabler, vi allerede kender. Men når vi mener variabler, der tilhører en bestemt klasse, kalder vi dem felter i denne klasse.
// Metoder - metoder definerer hvilke operationer klassen udsætter for omverdenen og hvordan det kan bruges.


interface IElephant
{
    void CreateDelete(string choice);
}

class Animal
{

}

class AfricanElephant : Animal
{

    public void CreateDelete(string choice)
    {
        if (choice == "insert")
        {
            ElephantDatabase.CreateDelete(this, true);
        }
        else if (choice == "delete")
        {
            ElephantDatabase.CreateDelete(this, false);
        }
        else
        {
            Console.WriteLine("Ugyldigt valgr.");
        }
    }
}

class ElephantDatabase
{
    static List<AfricanElephant> africanElephants = new List<AfricanElephant>();

    public static void CreateDelete(AfricanElephant elephant, bool isInsert)
    {
        if (elephant is AfricanElephant)
        {
            if (isInsert)
            {
                africanElephants.Add(elephant);
                Console.WriteLine("Afrikansk elefant tilføjet til databasen.");
            }
            else
            {
                africanElephants.Remove(elephant);
                Console.WriteLine("indisk elefant fjernet fra databasen.");
            }
        }
        else
        {
            Console.WriteLine("Kun afrikanske elefanter kan gemmes i databasen.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vælg en mulighed::");
        Console.WriteLine("1. tilføje en afrikansk elefant");
        Console.WriteLine("2. Tilføj en indisk elefant");
        Console.WriteLine("3.Fjern den afrikanske elefant");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                AfricanElephant africanElephant = new AfricanElephant();
                africanElephant.CreateDelete("insert");
                break;

            case 2:
                Console.WriteLine("Kun afrikanske elefanter kan gemmes i databasen.");
                break;

            case 3:
                AfricanElephant africanElephantToDelete = new AfricanElephant();
                africanElephantToDelete.CreateDelete("delete");
                break;

            default:
                Console.WriteLine("Ugyldigt valg.");
                break;
        }
    }
}
