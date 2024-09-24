using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class DVD : Media
    {
        private float Duree;

        // Constructeur
        public DVD(float duree)
        {
            Duree = duree;
        }

        // Méthode de polymorphisme
        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Duree : "+Duree);
        }
    }
}
