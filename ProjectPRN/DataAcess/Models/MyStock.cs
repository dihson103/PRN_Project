using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAcessLayer.Models;

public partial class MyStock : DbContext
{
    private static MyStock instance = null;
    public static MyStock Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new MyStock();
            }
            return instance;
        }
    }
    private MyStock()
    {
    }

    public MyStock(DbContextOptions<MyStock> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    private string GetConnectionString()
    {
        string connectionString;
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        connectionString = config["ConnectionStrings:MyProductDB"];
        return connectionString;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Account__3213E83F144A8078");

            entity.ToTable("Account");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Sex).HasColumnName("sex");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Class__3213E83F72FE57EC");

            entity.ToTable("Class");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.IdTeacher)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idTeacher");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.NumberSlot).HasColumnName("numberSlot");

            entity.HasOne(d => d.IdTeacherNavigation).WithMany(p => p.Classes)
                .HasForeignKey(d => d.IdTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Class__idTeacher__38996AB5");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => new { e.IdStudent, e.IdClass }).HasName("PK__Grade__84C2EF2F26738723");

            entity.ToTable("Grade");

            entity.Property(e => e.IdStudent)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idStudent");
            entity.Property(e => e.IdClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idClass");
            entity.Property(e => e.Mark1).HasColumnName("mark1");
            entity.Property(e => e.Mark2).HasColumnName("mark2");
            entity.Property(e => e.Mark3).HasColumnName("mark3");

            entity.HasOne(d => d.IdClassNavigation).WithMany(p => p.Grades)
                .HasForeignKey(d => d.IdClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grade__idClass__3C69FB99");

            entity.HasOne(d => d.IdStudentNavigation).WithMany(p => p.Grades)
                .HasForeignKey(d => d.IdStudent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grade__idStudent__3B75D760");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => new { e.IdStudent, e.IdClass, e.Date, e.Slot }).HasName("PK__Schedule__98781CDCCF8E56DF");

            entity.ToTable("Schedule");

            entity.Property(e => e.IdStudent)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idStudent");
            entity.Property(e => e.IdClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idClass");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Slot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("slot");
            entity.Property(e => e.IsAttended).HasColumnName("isAttended");

            entity.HasOne(d => d.IdClassNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.IdClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Schedule__idClas__403A8C7D");

            entity.HasOne(d => d.IdStudentNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.IdStudent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Schedule__idStud__3F466844");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
