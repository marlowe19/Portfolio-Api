using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlowe.Antonius.Models
{
    public class Ervaring
    {
        public string Bedrijfsnaam { get; set; }
        public string Datum { get; set; }
        public IEnumerable<Project> Projecten { get; set; }
    }
}
