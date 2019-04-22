namespace NomadJournalApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NomadJournalContext : DbContext
    {
        public NomadJournalContext()
            : base("name=NomadJournalContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Issue> Issues { get; set; }
    }
}