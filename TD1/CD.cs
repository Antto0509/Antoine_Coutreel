using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class CD : Media
    {
        private string Artiste;
        
        // Constructeur
        public CD(string artiste)
        {
            Artiste = artiste;
        }

        // Méthode de polymorphisme
        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Artiste : "+Artiste);
        }
    }
}
