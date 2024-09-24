using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class Library
    {
        List<Media> ts = new List<Media>();

        public void AddMedia(Media media)
        {
            ts.Add(media);
        }

        public Media this[int numeroRef]
        {
            get
            {
                return ts.Find(media => media.NumeroRef == numeroRef);
            }
        }
    }
}
