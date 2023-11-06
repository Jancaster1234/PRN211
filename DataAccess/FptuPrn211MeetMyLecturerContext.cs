using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using Microsoft.Extensions.Configuration;

namespace DataAccess;

public partial class FptuPrn211MeetMyLecturerContext : DbContext
{
    public FptuPrn211MeetMyLecturerContext()
    {
    }

    public FptuPrn211MeetMyLecturerContext(DbContextOptions<FptuPrn211MeetMyLecturerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActionRecord> ActionRecords { get; set; }

    public virtual DbSet<MeetingRequest> MeetingRequests { get; set; }

    public virtual DbSet<PasscodeRequest> PasscodeRequests { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<ScheduleRecord> ScheduleRecords { get; set; }

    public virtual DbSet<Slot> Slots { get; set; }

    public virtual DbSet<SlotRecord> SlotRecords { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<User> Users { get; set; }

    private string GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DBDefault"];
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(GetConnectionString());
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActionRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__action_r__3213E83F0B8DF502");

            entity.ToTable("action_record");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.ActionRecords)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_action_record_user");
        });

        modelBuilder.Entity<MeetingRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__meeting___3213E83F881BE147");

            entity.ToTable("meeting_request");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.ReviewedDate)
                .HasColumnType("datetime")
                .HasColumnName("reviewedDate");
            entity.Property(e => e.SlotId).HasColumnName("slotId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.TeacherId).HasColumnName("teacherId");

            entity.HasOne(d => d.Student).WithMany(p => p.MeetingRequestStudents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_meeting_request_user");

            entity.HasOne(d => d.Teacher).WithMany(p => p.MeetingRequestTeachers)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_meeting_request_user1");
        });

        modelBuilder.Entity<PasscodeRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__passcode__3213E83FBB605039");

            entity.ToTable("passcode_request");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("message");
            entity.Property(e => e.ReviewedDate)
                .HasColumnType("datetime")
                .HasColumnName("reviewedDate");
            entity.Property(e => e.SlotId).HasColumnName("slotId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StudentId).HasColumnName("studentId");

            entity.HasOne(d => d.Slot).WithMany(p => p.PasscodeRequests)
                .HasForeignKey(d => d.SlotId)
                .HasConstraintName("FK_passcode_request_slot");

            entity.HasOne(d => d.Student).WithMany(p => p.PasscodeRequests)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_passcode_request_user");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__role__3213E83F62DE213A");

            entity.ToTable("role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<ScheduleRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__schedule__3213E83F7E78403B");

            entity.ToTable("schedule_record");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClassName)
                .HasMaxLength(100)
                .HasColumnName("className");
            entity.Property(e => e.CourseName)
                .HasMaxLength(100)
                .HasColumnName("courseName");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.EndTime).HasColumnName("endTime");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("location");
            entity.Property(e => e.Room)
                .HasMaxLength(50)
                .HasColumnName("room");
            entity.Property(e => e.StartTime).HasColumnName("startTime");
            entity.Property(e => e.TeacherId).HasColumnName("teacherId");

            entity.HasOne(d => d.Teacher).WithMany(p => p.ScheduleRecords)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_schedule_record_user");
        });

        modelBuilder.Entity<Slot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__slot__3213E83F2426C106");

            entity.ToTable("slot");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.EndTime).HasColumnName("endTime");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Passcode)
                .HasMaxLength(50)
                .HasColumnName("passcode");
            entity.Property(e => e.StartTime).HasColumnName("startTime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StudentLimit).HasColumnName("studentLimit");
            entity.Property(e => e.SubjectId).HasColumnName("subjectId");
            entity.Property(e => e.TeacherId).HasColumnName("teacherId");

            entity.HasOne(d => d.Subject).WithMany(p => p.Slots)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_slot_subject");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Slots)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_slot_user");
        });

        modelBuilder.Entity<SlotRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__slot_rec__3213E83F18206D00");

            entity.ToTable("slot_record");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.SlotId).HasColumnName("slotId");
            entity.Property(e => e.StudentId).HasColumnName("studentId");

            entity.HasOne(d => d.Slot).WithMany(p => p.SlotRecords)
                .HasForeignKey(d => d.SlotId)
                .HasConstraintName("FK_slot_record_slot");

            entity.HasOne(d => d.Student).WithMany(p => p.SlotRecords)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_slot_record_user");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__subject__3213E83FAF5F2879");

            entity.ToTable("subject");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Major)
                .HasMaxLength(100)
                .HasColumnName("major");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user__3213E83FAE5F12BF");

            entity.ToTable("user");

            entity.HasIndex(e => e.Email, "UQ__user__AB6E61645F2D2621").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DayOfBirth)
                .HasColumnType("date")
                .HasColumnName("dayOfBirth");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.HideInfo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hideInfo");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.IsShowProfile).HasColumnName("isShowProfile");
            entity.Property(e => e.IsShowSchedule).HasColumnName("isShowSchedule");
            entity.Property(e => e.Major)
                .HasMaxLength(255)
                .HasColumnName("major");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.UserStatus)
                .HasMaxLength(50)
                .HasColumnName("userStatus");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Role)
                .HasConstraintName("FK_user_role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
