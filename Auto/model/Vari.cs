using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
   public class Vari
    {
        int id;
        string varinnimi;

        public int Id { get => id; set => id = value; }
        public string Varinnimi { get => varinnimi; set => varinnimi = value; }
    }
}
