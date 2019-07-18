using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WilesJacksonBugTracker.Repository.Domain
{
    public partial class BugContext : DbContext
    {
        public BugContext()
        {
        }

        public BugContext(DbContextOptions<BugContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BugPriorities> BugPriorities { get; set; }
        public virtual DbSet<BugStatuses> BugStatuses { get; set; }
        public virtual DbSet<Bugs> Bugs { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<ProjectAccesses> ProjectAccesses { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Testers> Testers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Bug;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Bugs>(entity =>
            {
                entity.HasIndex(e => e.BugPriorityId);

                entity.HasIndex(e => e.BugStatusId);

                entity.HasIndex(e => e.ProjectId);

                entity.HasOne(d => d.BugPriority)
                    .WithMany(p => p.Bugs)
                    .HasForeignKey(d => d.BugPriorityId);

                entity.HasOne(d => d.BugStatus)
                    .WithMany(p => p.Bugs)
                    .HasForeignKey(d => d.BugStatusId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Bugs)
                    .HasForeignKey(d => d.ProjectId);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasIndex(e => e.TesterId);

                entity.HasOne(d => d.Tester)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.TesterId);
            });

            modelBuilder.Entity<ProjectAccesses>(entity =>
            {
                entity.HasIndex(e => e.ProjectId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectAccesses)
                    .HasForeignKey(d => d.ProjectId);
            });

            modelBuilder.Entity<Testers>(entity =>
            {
                entity.HasIndex(e => e.ProjectId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Testers)
                    .HasForeignKey(d => d.ProjectId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.ProjectId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ProjectId);
            });
        }
    }
}
