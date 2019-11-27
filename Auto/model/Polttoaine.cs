using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
   public class Polttoaine
    {
        int id;
        string polttoaineennimi;

        public int Id { get => id; set => id = value; }
        public string Polttoaineennimi { get => polttoaineennimi; set => polttoaineennimi = value; }
    }
}
