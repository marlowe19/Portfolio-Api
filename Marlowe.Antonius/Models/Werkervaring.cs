using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlowe.Antonius.Models
{
    public class Werkervaring
    {
        public string Titel { get; set; }
        public IEnumerable<Ervaring> ErvaringsLijst { get; set; }
    }
}
