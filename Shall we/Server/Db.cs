using Microsoft.EntityFrameworkCore;
using Shall_we.Shared;

namespace Shallwe.Server
{
    public class Db : DbContext
{
    public Db(DbContextOptions<Db> opcije) : base(opcije)
    {

    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Osoba>().HasKey(x => x.Id);
            modelBuilder.Entity<Osoba>()
                .HasIndex(x => x.Phone)
                .IsUnique();

            modelBuilder.Entity<Profesor>().HasData(new[]
            {
                new Profesor{ Id = 1, Name = "Tarik", LastName = "Durovic",
            Phone ="223311", Mail ="Tarik@taksa.com" },
                new Profesor{ Id = 2, Name = "Zijad", LastName = "Hadzija",
            Phone ="223423", Mail ="Zice@zicu.com" }
            });
            modelBuilder.Entity<Polaznik>().HasData(new[]
            {
                new Polaznik{ Id = 4, Name ="Dzone", LastName= "Pepa",
                Mail = "Dzone@Dz.com", Phone ="22334"},
                new Polaznik{ Id = 3, Name ="Miki", LastName= "Mile",
                Mail = "Miki@Mile.com", Phone ="222312"}
            });

           

        }
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Profesor> Profesori { get; set;}
        public DbSet<Polaznik> Polaznici { get; set; }

}
}
