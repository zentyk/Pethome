using MvvmHelpers;
using Pethome.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pethome.Datos
{
    public class DCarrousel
    {
        public ObservableRangeCollection<Grouping<string, PethGroup>> Groups { get; set; }

        public DCarrousel()
        {
            Groups = new ObservableRangeCollection<Grouping<string, PethGroup>>();

            var groups = new List<CarruselList>();
            groups.Add(new CarruselList
            {
                Name = "Marley",
                Image = "dogs.png",
                Age = "un año",
                Location = "Mexico"
            });
            groups.Add(new CarruselList
            {
                Name = "Marley",
                Image = "dogs.png",
                Age = "un año",
                Location = "Mexico"
            });
            groups.Add(new CarruselList
            {
                Name = "Marley",
                Image = "dogs.png",
                Age = "un año",
                Location = "Mexico"
            });
            groups.Add(new CarruselList
            {
                Name = "Marley",
                Image = "dogs.png",
                Age = "un año",
                Location = "Mexico"
            });
            groups.Add(new CarruselList
            {
                Name = "Marley",
                Image = "dogs.png",
                Age = "un año",
                Location = "Mexico"
            });
            groups.Add(new CarruselList
            {
                Name = "Marley",
                Image = "dogs.png",
                Age = "un año",
                Location = "Mexico"
            });
          
        }
    }
}

