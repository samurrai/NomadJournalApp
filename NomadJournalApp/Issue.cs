using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadJournalApp
{
    public class Issue : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PageAmount { get; set; }
        public bool IsDelievered { get; set; }
    }
}
