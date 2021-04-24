using saga.Domain.Entities;
using saga.Domain.Interfaces;
using System.Data.Entity;

namespace saga.Dal
{
    public class SagaContext : DbContext, IUnitOfWork
    {
        public DbSet<User> Cast { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieGender> MovieGender { get; set; }
        public DbSet<MovieRating> MovieRating { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Wishlist> Wishlist { get; set; }

        public void Save()
        {
            base.SaveChanges();
        }

    }
}
