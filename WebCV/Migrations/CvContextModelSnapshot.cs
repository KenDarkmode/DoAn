﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebCV.Models;

#nullable disable

namespace WebCV.Migrations
{
    [DbContext(typeof(CvContext))]
    partial class CvContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CategoryId")
                        .HasName("PK__Category__19093A2B40231617");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CompanyID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CopmpanyName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Country")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Hide")
                        .HasColumnType("int");

                    b.Property<string>("Hotline")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Information")
                        .HasColumnType("ntext");

                    b.Property<string>("Link")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("CompanyId")
                        .HasName("PK__Company__2D971C4CA95AF372");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "Link" }, "Link4");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.Cv", b =>
                {
                    b.Property<int>("CvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CvID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CvId"));

                    b.Property<string>("File")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Hide")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int")
                        .HasColumnName("TemplateID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("CvId")
                        .HasName("PK__CV__4FB514990A468CEE");

                    b.HasIndex("TemplateId");

                    b.HasIndex("UserId");

                    b.ToTable("CV", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.Evaluate", b =>
                {
                    b.Property<int>("EvaluateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EvaluateId"));

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Hide")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Profession")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EvaluateId");

                    b.ToTable("Evaluates");
                });

            modelBuilder.Entity("WebCV.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("CompanyID");

                    b.Property<DateTime?>("EndDay")
                        .HasColumnType("datetime");

                    b.Property<int?>("ExperienceYear")
                        .HasColumnType("int");

                    b.Property<string>("Jd")
                        .HasColumnType("ntext")
                        .HasColumnName("JD");

                    b.Property<string>("JobName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("LevelId")
                        .HasColumnType("int")
                        .HasColumnName("LevelID");

                    b.Property<string>("Link")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("RecruitmentCount")
                        .HasColumnType("int");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDay")
                        .HasColumnType("datetime");

                    b.HasKey("JobId")
                        .HasName("PK__Job__056690E2B1B8B79B");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("LevelId");

                    b.HasIndex(new[] { "Link" }, "Link5");

                    b.ToTable("Job", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.Level", b =>
                {
                    b.Property<int>("LevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LevelID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LevelId"));

                    b.Property<string>("LevelName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("LevelId")
                        .HasName("PK__Level__09F03C067D00BA19");

                    b.ToTable("Level", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("NotificationID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"));

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.Property<int?>("Hide")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("SendAt")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("NotificationId")
                        .HasName("PK__Notifica__20CF2E320AE36A93");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "Link" }, "Link1");

                    b.ToTable("Notification", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.Recruitment", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<int>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    b.Property<string>("FileCv")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("FileCV");

                    b.Property<DateTime?>("SendAt")
                        .HasColumnType("datetime");

                    b.HasKey("UserId", "JobId")
                        .HasName("PK__Recruitm__27DEA5A211C07C9B");

                    b.HasIndex("JobId");

                    b.ToTable("Recruitment", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SkillID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"));

                    b.Property<int>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    b.Property<string>("SkillName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("SkillId")
                        .HasName("PK__Skill__DFA091E726076B0D");

                    b.HasIndex("JobId");

                    b.ToTable("Skill", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.Slider", b =>
                {
                    b.Property<int>("SlideID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SlideID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Hide")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SlideID");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("WebCV.Models.Template", b =>
                {
                    b.Property<int>("TemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TemplateID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TemplateId"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("File")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("Hide")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Link")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UploadedBy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TemplateId")
                        .HasName("PK__Template__F87ADD0732FD63B8");

                    b.HasIndex(new[] { "Link" }, "Link3");

                    b.ToTable("Template", (string)null);
                });

            modelBuilder.Entity("WebCV.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("ntext");

                    b.Property<string>("Avatar")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex(new[] { "Link" }, "Link2");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("WebCV.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("WebCV.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebCV.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("WebCV.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebCV.Models.Company", b =>
                {
                    b.HasOne("WebCV.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebCV.Models.Cv", b =>
                {
                    b.HasOne("WebCV.Models.Template", "Template")
                        .WithMany("Cvs")
                        .HasForeignKey("TemplateId")
                        .IsRequired()
                        .HasConstraintName("FK__CV__TemplateID__4BAC3F29");

                    b.HasOne("WebCV.Models.User", "User")
                        .WithMany("Cvs")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__CV__UserID__48CFD27E");

                    b.Navigation("Template");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebCV.Models.Job", b =>
                {
                    b.HasOne("WebCV.Models.Category", "Category")
                        .WithMany("Jobs")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK__Job__CategoryID__4F7CD00D");

                    b.HasOne("WebCV.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .IsRequired()
                        .HasConstraintName("FK__Job__CompanyID__4E88ABD4");

                    b.HasOne("WebCV.Models.Level", "Level")
                        .WithMany("Jobs")
                        .HasForeignKey("LevelId")
                        .IsRequired()
                        .HasConstraintName("FK__Job__LevelID__5070F446");

                    b.Navigation("Category");

                    b.Navigation("Company");

                    b.Navigation("Level");
                });

            modelBuilder.Entity("WebCV.Models.Notification", b =>
                {
                    b.HasOne("WebCV.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Notificat__UserI__4AB81AF0");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebCV.Models.Recruitment", b =>
                {
                    b.HasOne("WebCV.Models.Job", "Job")
                        .WithMany("Recruitments")
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK__Recruitme__JobID__4CA06362");

                    b.HasOne("WebCV.Models.User", "User")
                        .WithMany("Recruitments")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Recruitme__UserI__49C3F6B7");

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebCV.Models.Skill", b =>
                {
                    b.HasOne("WebCV.Models.Job", "Job")
                        .WithMany("Skills")
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK__Skill__JobID__4D94879B");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("WebCV.Models.Category", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("WebCV.Models.Company", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("WebCV.Models.Job", b =>
                {
                    b.Navigation("Recruitments");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("WebCV.Models.Level", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("WebCV.Models.Template", b =>
                {
                    b.Navigation("Cvs");
                });

            modelBuilder.Entity("WebCV.Models.User", b =>
                {
                    b.Navigation("Cvs");

                    b.Navigation("Notifications");

                    b.Navigation("Recruitments");
                });
#pragma warning restore 612, 618
        }
    }
}
