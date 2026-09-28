namespace MarchandageEchoppeObscure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Prix de l'artefact : ");
            int prixArtefact = int.Parse(Console.ReadLine());

            Console.Write("En possesion d'un sceau des Ombres ? : ");
            char sceauOmbres = char.ToLower(Console.ReadLine()[0]);

            Console.Write("Membre de la Guilde des Marchands ? : ");
            char membreGuilde = char.ToLower(Console.ReadLine()[0]);

            int prixFinal;

            if (sceauOmbres == "oui" || prixArtefact >= 100)
            {
                prixFinal = prixArtefact * 0.85;
                Console.WriteLine($"Il y a une reduction de 15% pour l'achat de l'artefact.");
            }
            else if (sceauOmbres == "oui" || prixArtefact < 100)
            {
                prixFinal = prixArtefact * 0.9;
                Console.WriteLine($"Il y a une reduction de 10% pour l'achat de l'artefact.");
            }
            else
            {
                Console.WriteLine($"Il n'y a pas de reduction pour l'achat de l'artefact.");
            }
            if (membreGuilde == "oui")
            {
                prixFinal = prixFinal * 0.8;
                Console.WriteLine($"Il y a une reduction de 20% pour l'achat de l'artefact.");
            }

            Console.WriteLine($"Prix final : {prixFinal}");
        }
    }
}
