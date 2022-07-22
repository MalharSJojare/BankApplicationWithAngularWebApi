using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BankWebAPI.AngularBank
{
    public partial class AngularBankContext : DbContext
    {
        public AngularBankContext()
        {
        }

        public AngularBankContext(DbContextOptions<AngularBankContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAccount> TblAccounts { get; set; }
        public virtual DbSet<TblAdmin> TblAdmins { get; set; }
        public virtual DbSet<TblBank> TblBanks { get; set; }
        public virtual DbSet<TblTransaction> TblTransactions { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLSERVER2019G3;Database=AngularBank;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__TblAccou__349DA5A63D0E8837");

                entity.ToTable("TblAccount");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TblAccounts)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblAccoun__BankI__4E88ABD4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblAccounts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblAccoun__UserI__4D94879B");
            });

            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__TblAdmin__719FE488040F4D20");

                entity.ToTable("TblAdmin");

                entity.Property(e => e.Area)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TblAdmins)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblAdmin__BankId__5165187F");
            });

            modelBuilder.Entity<TblBank>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("PK__TblBank__AA08CB1303E65ADC");

                entity.ToTable("TblBank");

                entity.Property(e => e.Area)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__TblTrans__55433A6B23289C73");

                entity.ToTable("TblTransaction");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TblTransactions)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblTransa__Accou__5535A963");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TblTransactions)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TblTransa__BankI__5441852A");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__TblUser__1788CC4CD6960D44");

                entity.ToTable("TblUser");

                entity.Property(e => e.Area)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
