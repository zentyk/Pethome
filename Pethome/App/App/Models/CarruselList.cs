using System;
using System.Collections.Generic;
using System.Text;

namespace Pethome.Models
{
    public class CarruselList
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public bool Bookmarked { get; set; }
    }

    public class PethGroup
    {
        public PethGroup(List<CarruselList> group)
        {
            Groups = group;
        }
        public List<CarruselList> Groups { get; set; }
    }
}
