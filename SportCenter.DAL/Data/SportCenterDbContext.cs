using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SportCenter.DAL.Entities;

namespace SportCenter.DAL.Data;

public partial class SportCenterDbContext : DbContext
{
    public SportCenterDbContext()
    {
    }

    public SportCenterDbContext(DbContextOptions<SportCenterDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Gym> Gyms { get; set; }

    public virtual DbSet<GymZone> GymZones { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<QRCode> QRCodes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Subscribtion> Subscribtions { get; set; }

    public virtual DbSet<SubscribtionPlan> SubscribtionPlans { get; set; }

    public virtual DbSet<SubscribtionZone> SubscribtionZones { get; set; }

    public virtual DbSet<TrainerPlan> TrainerPlans { get; set; }

    public virtual DbSet<TrainingSession> TrainingSessions { get; set; }

    public virtual DbSet<TrainingStatus> TrainingStatuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPlan> UserPlans { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-N27H27E\\MSSQLSERVER01;Database=GymAIS;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gym>(entity =>
        {
            entity.HasKey(e => e.GymId).HasName("PK__Gym__1A3A7C9693BEB528");
        });

        modelBuilder.Entity<GymZone>(entity =>
        {
            entity.HasKey(e => new { e.GymId, e.ZoneId }).HasName("PK__GymZones__5C3B1AED34D8BB0E");

            entity.HasOne(d => d.Gym).WithMany(p => p.GymZones).HasConstraintName("FK_GymZones_Gym");

            entity.HasOne(d => d.Zone).WithMany(p => p.GymZones).HasConstraintName("FK_GymZones_Zone");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payments__9B556A38FB667C11");

            entity.HasOne(d => d.SubscribtionPlan).WithMany(p => p.Payments).HasConstraintName("FK_Payments_SubPlan");

            entity.HasOne(d => d.User).WithMany(p => p.Payments).HasConstraintName("FK_Payments_User");
        });

        modelBuilder.Entity<QRCode>(entity =>
        {
            entity.HasKey(e => e.Token).HasName("PK__QRCodes__1EB4F81620E32A31");

            entity.Property(e => e.Token).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.QRCodes).HasConstraintName("FK_QRCodes_User");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE1A7A13DCB6");
        });

        modelBuilder.Entity<Subscribtion>(entity =>
        {
            entity.HasKey(e => e.SubscribtionId).HasName("PK__Subscrib__BAA6B3C4E70A8826");
        });

        modelBuilder.Entity<SubscribtionPlan>(entity =>
        {
            entity.HasKey(e => e.SubscribtionPlanId).HasName("PK__Subscrib__FB5F28C12F966311");

            entity.HasOne(d => d.Subscribtion).WithMany(p => p.SubscribtionPlans).HasConstraintName("FK_SubPlan_Sub");
        });

        modelBuilder.Entity<SubscribtionZone>(entity =>
        {
            entity.HasKey(e => e.SubscribtionZoneId).HasName("PK__Subscrib__975C2934E233E877");

            entity.HasOne(d => d.Subscribtion).WithMany(p => p.SubscribtionZones).HasConstraintName("FK_SubZ_Sub");

            entity.HasOne(d => d.Zone).WithMany(p => p.SubscribtionZones).HasConstraintName("FK_SubZ_Zone");
        });

        modelBuilder.Entity<TrainerPlan>(entity =>
        {
            entity.HasKey(e => e.TrainerPlanId).HasName("PK__TrainerP__541934ADAECA6585");

            entity.HasOne(d => d.Trainer).WithMany(p => p.TrainerPlans).HasConstraintName("FK_TrainerPlans_Trainer");
        });

        modelBuilder.Entity<TrainingSession>(entity =>
        {
            entity.HasKey(e => e.TrainingSessionId).HasName("PK__Training__63C998A052F33C91");

            entity.HasOne(d => d.Client).WithMany(p => p.TrainingSessionClients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingSession_Client");

            entity.HasOne(d => d.Status).WithMany(p => p.TrainingSessions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingSession_Status");

            entity.HasOne(d => d.Trainer).WithMany(p => p.TrainingSessionTrainers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingSession_Trainer");
        });

        modelBuilder.Entity<TrainingStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__Training__C8EE2063F784A580");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CEF23A0DF");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Roles");
        });

        modelBuilder.Entity<UserPlan>(entity =>
        {
            entity.HasKey(e => e.UserPlanId).HasName("PK__UserPlan__B2231FE1C10E58ED");

            entity.HasOne(d => d.SubscriptionPlan).WithMany(p => p.UserPlans).HasConstraintName("FK_UserPlans_SubPlan");

            entity.HasOne(d => d.User).WithMany(p => p.UserPlans).HasConstraintName("FK_UserPlans_User");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.ZoneId).HasName("PK__Zone__601667B5CC939F88");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
