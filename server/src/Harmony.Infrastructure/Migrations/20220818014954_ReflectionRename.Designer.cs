﻿// <auto-generated />
using System;
using Harmony.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Harmony.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220818014954_ReflectionRename")]
    partial class ReflectionRename
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ActivityReflectionEntry", b =>
                {
                    b.Property<string>("ActivitiesId")
                        .HasColumnType("text");

                    b.Property<string>("ReflectionsId")
                        .HasColumnType("text");

                    b.HasKey("ActivitiesId", "ReflectionsId");

                    b.HasIndex("ReflectionsId");

                    b.ToTable("ActivityReflectionEntry");
                });

            modelBuilder.Entity("FeelingReflectionEntry", b =>
                {
                    b.Property<string>("FeelingsId")
                        .HasColumnType("text");

                    b.Property<string>("ReflectionsId")
                        .HasColumnType("text");

                    b.HasKey("FeelingsId", "ReflectionsId");

                    b.HasIndex("ReflectionsId");

                    b.ToTable("FeelingReflectionEntry");
                });

            modelBuilder.Entity("Harmony.Domain.Entities.Activity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("00000000-0000-0000-0000-000000000000");

                    b.Property<Instant>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(NodaTime.Instant.FromUnixTimeTicks(0L));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Instant>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(NodaTime.Instant.FromUnixTimeTicks(0L));

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = "ed7f68b5-deec-49ed-88a3-f3c1cfff0a39",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Being With Family",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "37a5e59e-460f-4591-9a5b-6f8b824528a2",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Friends",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "b8b4a4b3-fd26-4984-b189-71d84808e310",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Going on a Date",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "ca3b44b0-8ae3-4077-a39c-5d781a915f10",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Being with Friends",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "6cbbd09d-723f-4b67-9827-9e16218476b6",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Exercising",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "5ee06913-23ac-4e03-94de-e52db08fa155",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Sports",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "2f806854-cacd-455f-821f-9610bb351385",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Relaxing",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "ed9403f8-4774-445a-b5fb-048c2909973e",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Watching Movies",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "a0dfde6a-fe59-4b02-a18c-7e55cf958be8",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Reading",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "8f53575f-c8ef-48f6-b1b8-d1a6b7c4d03d",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Gaming",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "6deeb318-ee5b-47e6-b2a9-f3531864eb6a",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Cleaning",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "99a3bc29-1692-4d45-bc66-efd1374d7710",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Shopping",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "ffdb0d10-0793-411f-bc68-96eb5d4fa331",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Eating Healthy",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        });
                });

            modelBuilder.Entity("Harmony.Domain.Entities.Feeling", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("00000000-0000-0000-0000-000000000000");

                    b.Property<Instant>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(NodaTime.Instant.FromUnixTimeTicks(0L));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Instant>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(NodaTime.Instant.FromUnixTimeTicks(0L));

                    b.HasKey("Id");

                    b.ToTable("Feelings");

                    b.HasData(
                        new
                        {
                            Id = "d5fa2510-a448-45b4-bd2b-a8db9dab8e64",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Happy",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "fe995b5a-96a1-4caa-986d-8474d830795a",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Blessed",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "b6a729f6-47ec-4cff-83fb-487df556229d",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Good",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "4582e565-8b4d-4524-96d5-e66e7126941a",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Confused",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "b720b75e-b0c7-4d1d-975b-1d5f4c310c00",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Bored",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "e7ddd299-26ea-4b90-afb3-ba969e2f8817",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Awkward",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "a1ee71dc-c95f-498e-a95f-fa9032d72e87",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Angry",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "0e209ce8-7dd2-4c76-a4e1-e2ca432286f7",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Anxious",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "43f04171-111b-493e-86de-6bde784fac2c",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Down",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "3fc58222-76d1-4151-8723-2b572f69b527",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Stressed",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        });
                });

            modelBuilder.Entity("Harmony.Domain.Entities.Mood", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("00000000-0000-0000-0000-000000000000");

                    b.Property<Instant>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(NodaTime.Instant.FromUnixTimeTicks(0L));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Instant>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(NodaTime.Instant.FromUnixTimeTicks(0L));

                    b.HasKey("Id");

                    b.ToTable("Moods");

                    b.HasData(
                        new
                        {
                            Id = "1999caa5-0e76-40ee-a98f-679cd5b6f7e7",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Terrible",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "000d7d7b-fcc2-4b15-bfa8-73b75a70cdaf",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Bad",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "9f7db83e-427c-4d58-9c9f-58c8bfbc80bd",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Okay",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "7312d931-b262-483c-ad36-548d93c5d701",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Good",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = "5a7455c4-f555-4252-9aa2-7ba1f03c1977",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Awesome",
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        });
                });

            modelBuilder.Entity("Harmony.Domain.Entities.ReflectionEntry", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("00000000-0000-0000-0000-000000000000");

                    b.Property<Instant>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(NodaTime.Instant.FromUnixTimeTicks(0L));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MoodId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Instant>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(NodaTime.Instant.FromUnixTimeTicks(0L));

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MoodId");

                    b.HasIndex("UserId");

                    b.ToTable("Reflections");
                });

            modelBuilder.Entity("Harmony.Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ActivityReflectionEntry", b =>
                {
                    b.HasOne("Harmony.Domain.Entities.Activity", null)
                        .WithMany()
                        .HasForeignKey("ActivitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Harmony.Domain.Entities.ReflectionEntry", null)
                        .WithMany()
                        .HasForeignKey("ReflectionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FeelingReflectionEntry", b =>
                {
                    b.HasOne("Harmony.Domain.Entities.Feeling", null)
                        .WithMany()
                        .HasForeignKey("FeelingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Harmony.Domain.Entities.ReflectionEntry", null)
                        .WithMany()
                        .HasForeignKey("ReflectionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Harmony.Domain.Entities.ReflectionEntry", b =>
                {
                    b.HasOne("Harmony.Domain.Entities.Mood", "Mood")
                        .WithMany("Reflections")
                        .HasForeignKey("MoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Harmony.Domain.Entities.User", "User")
                        .WithMany("Reflections")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mood");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Harmony.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Harmony.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Harmony.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Harmony.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Harmony.Domain.Entities.Mood", b =>
                {
                    b.Navigation("Reflections");
                });

            modelBuilder.Entity("Harmony.Domain.Entities.User", b =>
                {
                    b.Navigation("Reflections");
                });
#pragma warning restore 612, 618
        }
    }
}