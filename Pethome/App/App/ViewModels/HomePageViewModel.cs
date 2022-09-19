using MvvmHelpers;
using Pethome.Datos;
using Pethome.Models;
using Pethome.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pethome.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Grouping<string, PethGroup>> Groups { get; set; }

        public HomePageViewModel()
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

            var adopcion = new Grouping<string, PethGroup>("Adopcion", new[] {new PethGroup(groups.OrderBy(x => Guid.NewGuid()).ToList()) });
            var mascotasExtraviadas = new Grouping<string, PethGroup>("Mascotas extraviadas", new[] { new PethGroup(groups.OrderBy(x => Guid.NewGuid()).ToList()) });
            var veterianariasCerca = new Grouping<string, PethGroup>("Veterianarias cerca", new[] { new PethGroup(groups.OrderBy(x => Guid.NewGuid()).ToList()) });

            Groups.AddRange(new[] { adopcion, mascotasExtraviadas, veterianariasCerca});

        }
    }
}
