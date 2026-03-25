namespace Tp_Manipulation_dates;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateActuelle = DateTime.Now;
        Console.WriteLine("Date par défaut : " + dateActuelle);
        Console.WriteLine("Date formatée : " + dateActuelle.ToString("dd/MM/yyyy"));
        Console.WriteLine("Appuyez sur une touche pour continuer...");
        Console.ReadKey();
    }
}
