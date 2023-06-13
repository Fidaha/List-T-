namespace ListChallenge;

class Program
{
    static void Main(string[] args)
    {
        System.Collections.Generic.List<string> liste = new List<string>();

        liste.Add("Première chaîne de caractères");
        liste.Add("Deuxième chaîne de caractères");
        liste.Add("Troisième chaîne de caractères");

        Console.WriteLine("Trois chaînes de caractères sont insérées:");

        foreach (string element in liste)
        {
            Console.WriteLine(element);
        }

        liste.RemoveAt(0);

        Console.WriteLine("\nLa première chaîne de caractères est supprimée avec RemoveAt:");

        foreach (string element in liste)
        {
            Console.WriteLine(element);
        }

        liste.Remove("Troisième chaîne de caractères");

        Console.WriteLine("\nLa troisième chaîne de caractères est supprimée avec Remove:");

        foreach (string element in liste)
        {
            Console.WriteLine(element);
        }

        liste[0] = "Deuxième chaîne de caractères modifiée";

        Console.WriteLine("\nLa deuxième chaîne de caractères est modifiée:");

        foreach (string element in liste)
        {
            Console.WriteLine(element);
        }

    }
}
