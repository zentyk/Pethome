using Pethome.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pethome.Datos
{
    public class Dmusica
    {
        public async Task<List<Mmusica>> adoption()
        {
            var lista = new List<Mmusica>()
            {
                new Mmusica
                {
                  Name = "Marley",
                  Image = "dogs.png",
                  Age = "un año",
                  Location = "Mexico"
                },

                 new Mmusica
                 {
                     Name = "Odie",
                     Image = "dogs.png",
                     Age = "un año",
                     Location = "Mexico"
                 },

                  new Mmusica
                  {
                      Name = "Snoopy",
                      Image = "dogs.png",
                      Age = "un año",
                      Location = "Mexico"
                  },

                   new Mmusica
                   {
                       Name = "Balto",
                       Image = "dogs.png",
                       Age = "un año",
                       Location = "Mexico"
                   },

                    new Mmusica
                    {
                        Name = "Golfo",
                        Image = "dogs.png",
                        Age = "un año",
                        Location = "Mexico"
                    },

                     new Mmusica
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

