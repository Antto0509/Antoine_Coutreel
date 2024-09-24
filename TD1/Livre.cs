using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class Livre : Media
    {
        private string Auteur;

        // Constructeur
        public Livre(string auteur)
        {
            Auteur = auteur;
        }

        // Méthode de polymorphisme
        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Auteur : " + Auteur);
        }
    }
}
