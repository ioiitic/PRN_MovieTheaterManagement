using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ObjectLibrary.ObjectLibrary
{
    public partial class PRN_PRJContext : DbContext
    {
        public PRN_PRJContext()
        {
        }

        public PRN_PRJContext(DbContextOptions<PRN_PRJContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genre{ get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Showtime> Showtimes { get; set; }
        public virtual DbSet<Theater> Theaters { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=PRN_PRJ;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genre");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TheaterId).HasColumnName("TheaterID");
            });

            modelBuilder.Entity<Showtime>(entity =>
            {
                entity.ToTable("Showtime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Theater>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BuyTime)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NovieId).HasColumnName("NovieID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.SeatId).HasColumnName("SeatID");

                entity.Property(e => e.ShowtimeId).HasColumnName("ShowtimeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
