using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class Media
    {
        public string Titres;
        public int NumeroRef;
        public int NbExemplairesDispos;
        public List<string> Emprunts;

        // Constructeur
        public Media(string titres, int numeroRef, int nbExemplairesDispos)
        {
            Titres = titres;
            NumeroRef = numeroRef;
            NbExemplairesDispos = nbExemplairesDispos;
            Emprunts = new List<string>();
        }

        // Méthode de polymorphisme
        public virtual void AfficherInfos()
        {
            Console.WriteLine("Titres : " + Titres + "\n"
                + "Numero de reference : " + NumeroRef + "\n"
                + "Numbre d'exemplaire disponibles : " + NbExemplairesDispos
                );
        }

        // Ajouter un Média
        public void AjouterMedia(int nbExemplaires)
        {
            NbExemplairesDispos += nbExemplaires;
        }

        // Retirer un Média
        public void RetirerMedia(int nbExemplaires)
        {
            if (NbExemplairesDispos < nbExemplaires)
            {
                throw new Exception("Nombre d'exemplaires disponibles insuffisant");
            }

            NbExemplairesDispos -= nbExemplaires;
        }

        // Emprunter un Média
        public void EmprunterMedia(string utilisateur)
        {
            if (NbExemplairesDispos == 0)
            {
                throw new Exception("Aucun exemplaire disponible pour l'emprunt");
            }

            NbExemplairesDispos--;
            Emprunts.Add(utilisateur);
        }

        // Retourner un Média
        public void RetournerMedia(string utilisateur)
        {
            NbExemplairesDispos++;
            Emprunts.Remove(utilisateur);
        }

        // Rechercher un Média par Titre ou Auteur
        public static List<Media> RechercherMedia(string critere)
        {
            List<Media> resultats = new List<Media>();
            // Effectuer la recherche en fonction du critère
            // ...
            return resultats;
        }

        
    }
}
