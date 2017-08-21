using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marlowe.Antonius.Models;

namespace Marlowe.Antonius
{
    public class Cv
    {
        public PersoonlijkeGegevens PersoonlijkeGegevens { get; set; }
        public Werkervaring Werkervaring { get; set; }

        public IEnumerable<Opleiding> Opleidingen { get; set; }
    }
}
