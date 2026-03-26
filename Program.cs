using System;

class Program
{
    static void Main()
    {
        //Partie 1
        DateTime dateActuelle = DateTime.Now;

        Console.WriteLine("Date actuelle (format par défaut) : " + dateActuelle);
        Console.WriteLine("Date actuelle (format personnalisé) : " + dateActuelle.ToString("dd/MM/yyyy"));

        //Partie 2
        DateTime datePerso = new DateTime(2025, 1, 1);

        Console.WriteLine("Date personnalisée : " + datePerso);
        Console.WriteLine("Format personnalisé : " + datePerso.ToString("dd/MM/yyyy"));

        //Partie 3
        Console.WriteLine("ToShortDateString : " + datePerso.ToShortDateString());
        Console.WriteLine("ToLongDateString : " + datePerso.ToLongDateString());
        Console.WriteLine("Format dd/MM/yyyy : " + datePerso.ToString("dd/MM/yyyy"));
        Console.WriteLine("Format yyyy-MM-dd : " + datePerso.ToString("yyyy-MM-dd"));

        //Partie 4
        DateTime plus10Jours = datePerso.AddDays(10);
        DateTime plus2Mois = datePerso.AddMonths(2);
        DateTime plus1An = datePerso.AddYears(1);

        Console.WriteLine("Date +10 jours : " + plus10Jours.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date +2 mois : " + plus2Mois.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date +1 an : " + plus1An.ToString("dd/MM/yyyy"));

        //Partie 5
        DateTime moins5Jours = datePerso.AddDays(-5);
        DateTime moins1Mois = datePerso.AddMonths(-1);

        Console.WriteLine("Date -5 jours : " + moins5Jours.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date -1 mois : " + moins1Mois.ToString("dd/MM/yyyy"));

        //Partie 6
        Console.WriteLine("Entrez une date (format JJ/MM/AAAA) : ");
        string saisie = Console.ReadLine();

        DateTime dateUtilisateur;

        if (DateTime.TryParse(saisie, out dateUtilisateur))
        {
            if (dateUtilisateur.Date < DateTime.Now.Date)
            {
                Console.WriteLine("La date est passée");
            }
            else if (dateUtilisateur.Date == DateTime.Now.Date)
            {
                Console.WriteLine("La date est aujourd'hui");
            }
            else
            {
                Console.WriteLine("La date est dans le futur");
            }
        }
        else
        {
            Console.WriteLine("Date invalide");
        }

        // Partie 7
        Console.WriteLine("Entrez la première date : ");
        string date1Texte = Console.ReadLine();

        Console.WriteLine("Entrez la deuxième date : ");
        string date2Texte = Console.ReadLine();

        DateTime date1, date2;

        if (DateTime.TryParse(date1Texte, out date1) && DateTime.TryParse(date2Texte, out date2))
        {
            TimeSpan difference = date2 - date1;
            Console.WriteLine("Différence en jours : " + difference.TotalDays);
        }
        else
        {
            Console.WriteLine("Une des dates est invalide");
        }
        
        Console.WriteLine("Entrez une date : ");
        string texteDate = Console.ReadLine();

        DateTime resultat;

        if (DateTime.TryParse(texteDate, out resultat))
        {
            Console.WriteLine("Date valide : " + resultat.ToString("dd/MM/yyyy"));
        }
        else
        {
            Console.WriteLine("Date invalide");
        }

         //Partie 8
        Console.WriteLine("Entrez une date (JJ/MM/AAAA) : ");
        string saisie2 = Console.ReadLine();

        DateTime date;

        if (DateTime.TryParse(saisie, out date))
        {
            Console.WriteLine("Date valide : " + date.ToString("dd/MM/yyyy"));
        }
        else
        {
            Console.WriteLine("Date invalide");
        }

        //Partie 9
        DateTime dateDebut = DateTime.Now;
        int duree = 5;
        DateTime dateFin = dateDebut.AddDays(duree);
        Console.WriteLine("Date de début : " + dateDebut.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date de fin : " + dateFin.ToString("dd/MM/yyyy"));
    }
}