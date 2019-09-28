namespace Arnez.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Arnez.Models.Fairy> Fairies { get; set; }
    }
}