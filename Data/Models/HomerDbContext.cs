using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Models
{
    public partial class HomerDbContext : DbContext
    {
        public HomerDbContext()
        {
        }

        public HomerDbContext(DbContextOptions<HomerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountTypes> AccountTypes { get; set; }
        public virtual DbSet<AmenityDetails> AmenityDetails { get; set; }
        public virtual DbSet<AmenityType> AmenityType { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DocumentTypes> DocumentTypes { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<FileTypes> FileTypes { get; set; }
        public virtual DbSet<Locality> Locality { get; set; }
        public virtual DbSet<PropertyAge> PropertyAge { get; set; }
        public virtual DbSet<PropertyDetails> PropertyDetails { get; set; }
        public virtual DbSet<PropertyDocuments> PropertyDocuments { get; set; }
        public virtual DbSet<PropertyImages> PropertyImages { get; set; }
        public virtual DbSet<PropertyTagsMapping> PropertyTagsMapping { get; set; }
        public virtual DbSet<PropertyTypes> PropertyTypes { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<UserAccounts> UserAccounts { get; set; }
        public virtual DbSet<UserProfileImages> UserProfileImages { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var con = System.Environment.GetEnvironmentVariable("ConnectionString");
                optionsBuilder.UseSqlServer(con);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountTypes>(entity =>
            {
                entity.HasKey(e => e.AccountTypeId)
                    .HasName("PK__AccountT__8F9585AFDCC20E5C");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AmenityDetails>(entity =>
            {
                entity.HasKey(e => e.AmenityDetailId)
                    .HasName("PK__AmenityD__87268049910E257B");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AmenityType>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DocumentTypes>(entity =>
            {
                entity.HasKey(e => e.DocumentTypeId)
                    .HasName("PK__Document__DBA390E1F7F331FB");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .HasName("PK__Document__1ABEEF0FBF2DCA07");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FileTypes>(entity =>
            {
                entity.HasKey(e => e.FileTypeId)
                    .HasName("PK__FileType__0896759E435AC07B");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Locality>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PropertyAge>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PropertyDetails>(entity =>
            {
                entity.HasKey(e => e.PropertyDetailId)
                    .HasName("PK__Property__78ECFF9D0BECA900");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PropertyDocuments>(entity =>
            {
                entity.HasKey(e => e.PropertyDocumentId)
                    .HasName("PK__Document__1ABEEF0F4373DE3F");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RemoteUrl)
                    .HasColumnName("RemoteURL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PropertyImages>(entity =>
            {
                entity.HasKey(e => e.PropertyImageId)
                    .HasName("PK__Property__3BCB5DE48D4B6E4F");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PropertyTagsMapping>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PropertyTypes>(entity =>
            {
                entity.HasKey(e => e.PropertyTypeId)
                    .HasName("PK__Property__BDE14DB4F76F24ED");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK__Tags__657CF9AC795824F4");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserAccounts>(entity =>
            {
                entity.HasKey(e => e.UserAccountId)
                    .HasName("PK__UserAcco__DA6C709AB9ABD83B");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserProfileImages>(entity =>
            {
                entity.HasKey(e => e.ProfileImageId)
                    .HasName("PK__UserProf__655C2E045B3CDDA8");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4CA89162D2");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
