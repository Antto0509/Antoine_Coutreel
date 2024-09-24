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

        // Constructeur
        public Media(string titres, int numeroRef, int nbExemplairesDispos)
        {
            Titres = titres;
            NumeroRef = numeroRef;
            NbExemplairesDispos = nbExemplairesDispos;
        }

        // Méthode de polymorphisme
        public virtual void AfficherInfos()
        {
            Console.WriteLine("Titres : " + Titres + "\n"
                + "Numero de reference : " + NumeroRef + "\n"
                + "Numbre d'exemplaire disponibles : " + NbExemplairesDispos
                );
        }

        // Surcharge de l'opérateur "+"
        public static Media operator +(Media media, int nbExemplaires)
        {
            media.NbExemplairesDispos += nbExemplaires;
            return media;
        }

        // Surcharge de l'opérateur "-"
        public static Media operator -(Media media, int nbExemplaires)
        {
            if (media.NbExemplairesDispos < nbExemplaires)
            {
                throw new Exception("Nombre d'exemplaires disponibles insuffisant");
            }

            media.NbExemplairesDispos -= nbExemplaires;
            return media;
        }
    }
}
