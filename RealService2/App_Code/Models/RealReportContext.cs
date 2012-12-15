using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RealService2.Models.Mapping;

namespace RealService2.Models
{
    public class RealReportContext : DbContext
    {
        static RealReportContext()
        {
            Database.SetInitializer<RealReportContext>(null);
        }

		public RealReportContext()
			: base("Name=RealReportContext")
		{
		}

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<OutsideInterest> OutsideInterests { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<RealType> RealTypes { get; set; }
        public DbSet<Wish> Wishes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AgencyMap());
            modelBuilder.Configurations.Add(new AgentMap());
            modelBuilder.Configurations.Add(new AgreementMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new InterestMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new OutsideInterestMap());
            modelBuilder.Configurations.Add(new PriceMap());
            modelBuilder.Configurations.Add(new PropertyMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new RealTypeMap());
            modelBuilder.Configurations.Add(new WishMap());
        }
    }
}
