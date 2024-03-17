using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BusinessObjects.Models
{
    public partial class MovieTicketManagementContext : DbContext
    {
        public MovieTicketManagementContext()
        {
        }

        public MovieTicketManagementContext(DbContextOptions<MovieTicketManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeAccount> EmployeeAccounts { get; set; } = null!;
        public virtual DbSet<MemberAccount> MemberAccounts { get; set; } = null!;
        public virtual DbSet<Movie> Movies { get; set; } = null!;
        public virtual DbSet<MovieCategory> MovieCategories { get; set; } = null!;
        public virtual DbSet<MovieDetail> MovieDetails { get; set; } = null!;
        public virtual DbSet<MovieRoom> MovieRooms { get; set; } = null!;
        public virtual DbSet<MovieSchedule> MovieSchedules { get; set; } = null!;
        public virtual DbSet<MovieTicket> MovieTickets { get; set; } = null!;
        public virtual DbSet<MoviewScheduleDetail> MoviewScheduleDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("MyCnn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeAccount>(entity =>
            {
                entity.HasKey(e => e.EmpAccId)
                    .HasName("PK__employee__CBA316C5C735599B");

                entity.ToTable("employeeAccount");

                entity.Property(e => e.EmpAccId)
                    .ValueGeneratedNever()
                    .HasColumnName("empAccId");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("empName");

                entity.Property(e => e.EmpUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empUserName");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Role)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<MemberAccount>(entity =>
            {
                entity.HasKey(e => e.MemAccId)
                    .HasName("PK__memberAc__B7CEAB54A8AB45D2");

                entity.ToTable("memberAccount");

                entity.Property(e => e.MemAccId)
                    .ValueGeneratedNever()
                    .HasColumnName("memAccId");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.MemName)
                    .HasMaxLength(50)
                    .HasColumnName("memName");

                entity.Property(e => e.MemUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("memUserName");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movie");

                entity.Property(e => e.MovieId)
                    .ValueGeneratedNever()
                    .HasColumnName("movieId");

                entity.Property(e => e.CatId).HasColumnName("catID");

                entity.Property(e => e.MovieLength).HasColumnName("movieLength");

                entity.Property(e => e.MovieName)
                    .HasMaxLength(50)
                    .HasColumnName("movieName");

                entity.Property(e => e.MovieOpeningDay)
                    .HasColumnType("date")
                    .HasColumnName("movieOpeningDay");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__movie__catID__4BAC3F29");
            });

            modelBuilder.Entity<MovieCategory>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__movieCat__17B6DD26144853AA");

                entity.ToTable("movieCategory");

                entity.Property(e => e.CatId)
                    .ValueGeneratedNever()
                    .HasColumnName("catID");

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .HasColumnName("catName");
            });

            modelBuilder.Entity<MovieDetail>(entity =>
            {
                entity.ToTable("movieDetail");

                entity.Property(e => e.MovieDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("movieDetailId");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DirectorName)
                    .HasMaxLength(50)
                    .HasColumnName("directorName");

                entity.Property(e => e.ImagePoster)
                    .HasColumnType("image")
                    .HasColumnName("imagePoster");

                entity.Property(e => e.LimitAge).HasColumnName("limitAge");

                entity.Property(e => e.MovieDescription)
                    .HasMaxLength(500)
                    .HasColumnName("movieDescription");

                entity.Property(e => e.MovieId).HasColumnName("movieId");

                entity.Property(e => e.ReleasedYear).HasColumnName("releasedYear");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MovieDetails)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__movieDeta__movie__4E88ABD4");
            });

            modelBuilder.Entity<MovieRoom>(entity =>
            {
                entity.ToTable("movieRoom");

                entity.Property(e => e.MovieRoomId)
                    .ValueGeneratedNever()
                    .HasColumnName("movieRoomID");

                entity.Property(e => e.MovieRoomName)
                    .HasMaxLength(50)
                    .HasColumnName("movieRoomName");

                entity.Property(e => e.SitPlaceTotal).HasColumnName("sitPlaceTotal");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<MovieSchedule>(entity =>
            {
                entity.HasKey(e => e.MovieScheId)
                    .HasName("PK__movieSch__88E1949511E31CA1");

                entity.ToTable("movieSchedule");

                entity.Property(e => e.MovieScheId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("movieScheId");

                entity.Property(e => e.TimeSlot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timeSlot");
            });

            modelBuilder.Entity<MovieTicket>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK__movieTic__3333C6103C9A7AE8");

                entity.ToTable("movieTicket");

                entity.Property(e => e.TicketId)
                    .ValueGeneratedNever()
                    .HasColumnName("ticketId");

                entity.Property(e => e.MemAccId).HasColumnName("memAccId");

                entity.Property(e => e.MovSdid).HasColumnName("movSDId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SitDetail)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sitDetail");

                entity.Property(e => e.TicketDate)
                    .HasColumnType("date")
                    .HasColumnName("ticketDate");

                entity.Property(e => e.TotalTicketPrice)
                    .HasColumnType("money")
                    .HasColumnName("totalTicketPrice");

                entity.HasOne(d => d.MemAcc)
                    .WithMany(p => p.MovieTickets)
                    .HasForeignKey(d => d.MemAccId)
                    .HasConstraintName("FK__movieTick__memAc__5EBF139D");

                entity.HasOne(d => d.MovSd)
                    .WithMany(p => p.MovieTickets)
                    .HasForeignKey(d => d.MovSdid)
                    .HasConstraintName("FK__movieTick__movSD__5DCAEF64");
            });

            modelBuilder.Entity<MoviewScheduleDetail>(entity =>
            {
                entity.HasKey(e => e.MovSdid)
                    .HasName("PK__moviewSc__86D71C1CF12D553A");

                entity.ToTable("moviewScheduleDetail");

                entity.Property(e => e.MovSdid)
                    .ValueGeneratedNever()
                    .HasColumnName("movSDId");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.EmptySlot)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emptySlot");

                entity.Property(e => e.MovieId).HasColumnName("movieId");

                entity.Property(e => e.MovieRoomId).HasColumnName("movieRoomID");

                entity.Property(e => e.MovieScheId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("movieScheId");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MoviewScheduleDetails)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__moviewSch__movie__5AEE82B9");

                entity.HasOne(d => d.MovieRoom)
                    .WithMany(p => p.MoviewScheduleDetails)
                    .HasForeignKey(d => d.MovieRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__moviewSch__movie__59063A47");

                entity.HasOne(d => d.MovieSche)
                    .WithMany(p => p.MoviewScheduleDetails)
                    .HasForeignKey(d => d.MovieScheId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__moviewSch__movie__59FA5E80");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
