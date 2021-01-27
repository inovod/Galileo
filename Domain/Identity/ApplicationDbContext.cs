using Domain.Identity.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Domain.Identity
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRoles,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
           base(options)
        {

        }

        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserToken> UserToken { get; set; }

        public virtual DbSet<GalLogTransactions> GalLogTransactions { get; set; }
        public virtual DbSet<GalLogTransactionsErr> GalLogTransactionsErr { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_UserInfo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.DateInsert).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(200);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_Id")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RefresToken)
                    .IsRequired()
                    .HasColumnName("Refres_Token")
                    .HasMaxLength(200);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_Id")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<GalLogTransactions>(entity =>
            {
                entity.HasKey(e => e.Idtr)
                    .HasName("PK_GAL_LOG_TRANSACTIONS");

                entity.Property(e => e.Idtr).HasColumnName("IDTR");

                entity.Property(e => e.Dinserted)
                    .HasColumnName("DINSERTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idapp).HasColumnName("IDAPP");

                entity.Property(e => e.Idstatuscode).HasColumnName("IDSTATUSCODE");

                entity.Property(e => e.Ioper).HasColumnName("IOPER");

                entity.Property(e => e.Voper).HasColumnName("VOPER");
            });

            modelBuilder.Entity<GalLogTransactionsErr>(entity =>
            {
                entity.HasKey(e => e.Iderror);

                entity.Property(e => e.Iderror).HasColumnName("IDERROR");

                entity.Property(e => e.Dinserted)
                    .HasColumnName("DINSERTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idkey).HasColumnName("IDKEY");

                entity.Property(e => e.Idtr).HasColumnName("IDTR");

                entity.Property(e => e.Ierror)
                    .HasColumnName("IERROR")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Verror).HasColumnName("VERROR");

                entity.Property(e => e.Verrorshort)
                    .HasColumnName("VERRORSHORT")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=DESKTOP-6AL824Q;initial catalog=metafase;user id=sa;password=Smilycode123_;MultipleActiveResultSets=True;");
            //}

        }
    }
}
