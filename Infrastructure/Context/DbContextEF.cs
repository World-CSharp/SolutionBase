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

        public  DbSet<User> User { get; set; }
        public  DbSet<Aproaches> Aproaches { get; set; }
        public  DbSet<DetailedApproaches> DetailedApproaches { get; set; }        
        public  DbSet<Label> Label { get; set; }
        public  DbSet<Organization> Organization { get; set; }
        public  DbSet<Project> Project { get; set; }
        public  DbSet<StateApproaches> StateApproaches { get; set; }
        public  DbSet<StateDetailApproaches> StateDetailApproaches { get; set; }
        public  DbSet<TypeSolution> TypeSolution { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using Fluent API here
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);

            //Configuración de las Entidades Exectuanto la Entidad EntityBase(Master)

            #region   StateApproaches

            //Configurando los Primary Key de la Entidad
            modelBuilder.Entity<StateApproaches>().HasKey<int>(p => p.Id);
            //Configurando las propiedades de las entidades(Campos de las columnas)
            //Configuración Table StateApproaches
            modelBuilder.Entity<StateApproaches>()
                .Property(x => x.Description)
                .HasMaxLength(50)//Se le indica de una longitud
                .IsRequired();//Sele indica de que es requerido

            #endregion StateApproaches


            #region    StateDetailApproaches

            //Configurando los Primary Key de la Entidad
            modelBuilder.Entity<StateDetailApproaches>().HasKey<int>(p => p.Id);
            //Configurando las propiedades de las entidades(Campos de las columnas)
            //Configuración Table StateDetailApproaches        
            modelBuilder.Entity<StateDetailApproaches>()
                .Property(x => x.Description)
                .HasMaxLength(50)
                .IsRequired();

            #endregion StateDetailApproaches


            #region    TypeSolution

            //Configurando los Primary Key de la Entidad
            modelBuilder.Entity<TypeSolution>().HasKey<int>(p => p.Id);

            //Configurando las propiedades de las entidades(Campos de las columnas)
            //Configuración Table TypeSolution        
            modelBuilder.Entity<TypeSolution>()
                .Property(x => x.Description)
                .HasMaxLength(50)
                .IsRequired();

            #endregion TypeSolution


            #region    Organization
            //Configurando los Primary Key de la Entidad
            modelBuilder.Entity<Organization>().HasKey<int>(p => p.Id);

            //Configurando las propiedades de las entidades(Campos de las columnas)
            //Configuración Table Organization        
            modelBuilder.Entity<Organization>()
                .Property(x => x.Description)
                .HasMaxLength(100)
                .IsRequired();                
            modelBuilder.Entity<Organization>()
                .Property(x => x.Slogan)
                .HasMaxLength(50)                
                .IsOptional();
            modelBuilder.Entity<Organization>()
                .Property(x => x.Logo)
                .IsOptional();
            modelBuilder.Entity<Organization>()
                .Property(x => x.Email)
                .HasMaxLength(100)                
                .IsOptional();
            modelBuilder.Entity<Organization>()
                .Property(x => x.PhoneNumber)
                .HasMaxLength(15)
                .IsOptional();
            modelBuilder.Entity<Organization>()
                .Property(x => x.Comment)
                .HasMaxLength(200)
                .IsOptional();
            modelBuilder.Entity<Organization>()
                .Property(x => x.RegisteredBy)
                .HasMaxLength(30)
                .IsRequired();
            modelBuilder.Entity<Organization>()
                .Property(x => x.RegisteredOn)
                .IsRequired();

            #endregion Organization


            #region    Label
            //Configurando los Primary Key de la Entidad
            modelBuilder.Entity<Label>().HasKey<int>(p => p.Id);

            //Configurando las propiedades de las entidades(Campos de las columnas)
            //Configuración Table Label        
            modelBuilder.Entity<Label>()
                .Property(x => x.Description)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Label>()
                .Property(x => x.Comment)
                .IsOptional()
                .HasMaxLength(100);
            modelBuilder.Entity<Label>()
                .Property(x => x.RegisteredBy)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Label>()
                .Property(x => x.RegisteredOn)
                .IsRequired();

            #endregion Label


            #region    Project
            //Configurando los Primary Key de la Entidad
            modelBuilder.Entity<Project>().HasKey<int>(p => p.Id);

            //Configurando los FK de la Tabla Project
            modelBuilder.Entity<Project>()
                .HasRequired(s => s.Organization)
                .WithMany(dt => dt.Project);

            //Configurando las propiedades de las entidades(Campos de las columnas)
            //Configuración Table Label  
            modelBuilder.Entity<Project>()
                .Property(x => x.Description)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Project>()
                .Property(x => x.Comment)
                .HasMaxLength(200)
                .IsOptional();

            modelBuilder.Entity<Project>()
                .Property(x => x.RegisteredBy)
                .HasMaxLength(30)
                .IsRequired();
            modelBuilder.Entity<Project>()
                .Property(x => x.RegisteredOn)
                .IsRequired();

            #endregion Project


            #region    Aproaches
            //Configurando los Primary Key de la Entidad
            modelBuilder.Entity<Aproaches>().HasKey<int>(p => p.Id);

            //Configurando los FK de la Tabla Aproaches
            modelBuilder.Entity<Aproaches>()
                .HasRequired(s => s.StateApproaches)
                .WithMany(dt => dt.Aproaches);

            modelBuilder.Entity<Aproaches>()
                .HasRequired(s => s.TypeSolution)
                .WithMany(dt => dt.Aproaches);

            //Configurando las propiedades de las entidades(Campos de las columnas)
            //Configuración Table Aproaches  

            modelBuilder.Entity<Aproaches>()
                .Property(x => x.IdUser)
                .IsRequired();
            modelBuilder.Entity<Aproaches>()
                .Property(x => x.Topic)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Aproaches>()
                .Property(x => x.Description)
                .IsRequired();
            modelBuilder.Entity<Aproaches>()
                .Property(x => x.Label)
                .IsOptional();
            modelBuilder.Entity<Aproaches>()
                .Property(x => x.Date)
                .IsRequired();
            modelBuilder.Entity<Aproaches>()
               .Property(x => x.RegisteredBy)
               .HasMaxLength(30)
               .IsRequired();
            modelBuilder.Entity<Aproaches>()
                .Property(x => x.RegisteredOn)
                .IsRequired();

            #endregion Aproaches


            #region    DetailedApproaches
            //Configurando los Primary Key de la Entidad
            modelBuilder.Entity<DetailedApproaches>().HasKey<int>(p => p.Id);

            //Configurando los FK de la Tabla DetailedApproaches
            modelBuilder.Entity<DetailedApproaches>()
                .HasRequired(s => s.StateDetailApproaches)
                .WithMany(dt => dt.DetailedApproaches);

            modelBuilder.Entity<DetailedApproaches>()
                .HasRequired(s => s.Aproaches)
                .WithMany(dt => dt.DetailedApproaches);
            //Configurando las propiedades de las entidades(Campos de las columnas)
            //Configuración Table Label 
            modelBuilder.Entity<DetailedApproaches>()
                .Property(x => x.UserId)
                .IsRequired();
            modelBuilder.Entity<DetailedApproaches>()
                .Property(x => x.Comment)
                .IsOptional()
                .HasMaxLength(2000);
            modelBuilder.Entity<DetailedApproaches>()
                .Property(x => x.PositivePoint)
                .IsOptional();
            modelBuilder.Entity<DetailedApproaches>()
                .Property(x => x.NegativePoint)
                .IsOptional();
            modelBuilder.Entity<DetailedApproaches>()
                .Property(x => x.RegisteredBy)
                .HasMaxLength(30)
                .IsRequired();
            modelBuilder.Entity<Aproaches>()
                .Property(x => x.RegisteredOn)
                .IsRequired();

            #endregion DetailedApproaches


        }
    }

}