using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadJournalApp
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int SubscriptionMonths { get; set; }
        public virtual ICollection<Issue> Issues { get; set; } = new List<Issue>();
    }
}
