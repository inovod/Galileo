using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.Identity.Model
{
    public partial class metafaseContext : DbContext
    {
        public metafaseContext()
        {
        }

        public metafaseContext(DbContextOptions<metafaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<GalLogTransactions> GalLogTransactions { get; set; }
        public virtual DbSet<GalLogTransactionsErr> GalLogTransactionsErr { get; set; }
        public virtual DbSet<OperationLog> OperationLog { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserToken> UserToken { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-6AL824Q;initial catalog=metafase;user id=sa;password=Smilycode123_;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
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

            modelBuilder.Entity<OperationLog>(entity =>
            {
                entity.HasKey(e => e.Idoper);

                entity.Property(e => e.Idoper)
                    .HasColumnName("IDOPER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200);
            });

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
        }
    }
}
