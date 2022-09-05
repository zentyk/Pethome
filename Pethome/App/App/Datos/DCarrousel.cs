using Pethome.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pethome.Datos
{
    public class DCarrousel
    {
        public async Task<List<CarruselList>> adoption()
        {
            var lista = new List<CarruselList>()
            {
                new CarruselList
                {
                  Name = "Marley",
                  Image = "dogs.png",
                  Age = "un año",
                  Location = "Mexico"
                },

                 new CarruselList
                 {
                     Name = "Odie",
                     Image = "dogs.png",
                     Age = "un año",
                     Location = "Mexico"
                 },

                  new CarruselList
                  {
                      Name = "Snoopy",
                      Image = "dogs.png",
                      Age = "un año",
                      Location = "Mexico"
                  },

                   new CarruselList
                   {
                       Name = "Balto",
                       Image = "dogs.png",
                       Age = "un año",
                       Location = "Mexico"
                   },

                    new CarruselList
                    {
                        Name = "Golfo",
                        Image = "dogs.png",
                        Age = "un año",
                        Location = "Mexico"
                    },

                     new CarruselList
                     {
                         Name = "Milo",
                         Image = "dogs.png",
                         Age = "un año",
                         Location = "Mexico"
                     },



            };
            return lista;

        }

    }

}

