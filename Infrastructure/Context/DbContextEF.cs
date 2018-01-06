namespace Infrastructure.Context
{
    using Domain.Entities;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class DbContextEF : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'DbContextEF' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Infrastructure.Context.DbContextEF' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'DbContextEF'  en el archivo de configuración de la aplicación.
        public DbContextEF()
            : base("name=DbContextEF")
        {
            ///Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbContextEF, Migrations.Configuration>("DbContextEF"));
        }

       public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using Fluent API here
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }

}