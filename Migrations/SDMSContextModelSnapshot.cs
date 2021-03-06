﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SDMS.Data;

namespace SDMS.Migrations
{
    [DbContext(typeof(SDMSContext))]
    partial class SDMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("SDMS.Models.Absence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Absences");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fa8ab822-633c-474d-b909-326e20b9e880"),
                            CourseId = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"),
                            DateTime = new DateTime(2021, 3, 19, 2, 36, 41, 400, DateTimeKind.Local).AddTicks(9271),
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6")
                        },
                        new
                        {
                            Id = new Guid("91962704-7b0a-48f1-8a9a-1bdc76546308"),
                            CourseId = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"),
                            DateTime = new DateTime(2021, 3, 19, 2, 36, 41, 401, DateTimeKind.Local).AddTicks(316),
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6")
                        },
                        new
                        {
                            Id = new Guid("ab6cacbe-2ecc-49e4-ab7d-5b1533f9ed29"),
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            DateTime = new DateTime(2021, 4, 3, 2, 36, 41, 401, DateTimeKind.Local).AddTicks(392),
                            StudentId = new Guid("97442fa4-1e9d-402c-a142-714207918954")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("RegistrtationStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00ada62b-706d-42c7-906a-ede4eb09e5d8"),
                            Email = "admin1@sdms.az",
                            Password = new byte[] { 118, 154, 146, 167, 110, 72, 79, 210, 194, 40, 188, 53, 92, 240, 58, 113, 238, 249, 88, 81, 104, 52, 117, 142, 73, 119, 219, 182, 94, 84, 206, 42 },
                            RegistrtationStatus = 1
                        });
                });

            modelBuilder.Entity("SDMS.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AbsenceLimit")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Credit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RequiredById")
                        .HasColumnType("TEXT");

                    b.Property<string>("SyllabusPath")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RequiredById");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"),
                            AbsenceLimit = 11,
                            Credit = 6,
                            Name = "Calculus I",
                            RequiredById = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            AbsenceLimit = 11,
                            Credit = 6,
                            Name = "Calculus II",
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb"),
                            AbsenceLimit = 6,
                            Credit = 5,
                            Name = "Probability and Statistics",
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("e43ef20d-4a11-4be2-82c7-e3231ea3805e"),
                            AbsenceLimit = 11,
                            Credit = 5,
                            Name = "System Engineering Conseption",
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("8d8e56d5-5e88-483b-afe9-eb78e4d26ffc"),
                            AbsenceLimit = 6,
                            Credit = 6,
                            Name = "Introduction to Programming",
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31"),
                            AbsenceLimit = 13,
                            Credit = 4,
                            Name = "Physics I",
                            RequiredById = new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f"),
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f"),
                            AbsenceLimit = 13,
                            Credit = 4,
                            Name = "Physics II",
                            SyllabusPath = "N/A"
                        });
                });

            modelBuilder.Entity("SDMS.Models.CourseSpeciality", b =>
                {
                    b.Property<Guid>("SpecialityId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.HasKey("SpecialityId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseSpecialities");

                    b.HasData(
                        new
                        {
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"),
                            CourseId = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f")
                        },
                        new
                        {
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"),
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef")
                        },
                        new
                        {
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"),
                            CourseId = new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb")
                        },
                        new
                        {
                            SpecialityId = new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"),
                            CourseId = new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb")
                        },
                        new
                        {
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"),
                            CourseId = new Guid("8d8e56d5-5e88-483b-afe9-eb78e4d26ffc")
                        },
                        new
                        {
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"),
                            CourseId = new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31")
                        },
                        new
                        {
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"),
                            CourseId = new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f")
                        },
                        new
                        {
                            SpecialityId = new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"),
                            CourseId = new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31")
                        },
                        new
                        {
                            SpecialityId = new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"),
                            CourseId = new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f")
                        });
                });

            modelBuilder.Entity("SDMS.Models.CurrentCourseStudent", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseTeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("CourseTeacherId");

                    b.HasIndex("StudentId");

                    b.ToTable("CurrentCourseStudents");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6"),
                            CourseTeacherId = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f")
                        },
                        new
                        {
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            StudentId = new Guid("f5f5f499-5b0d-43d5-8b3b-aaa82479164f"),
                            CourseTeacherId = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f")
                        },
                        new
                        {
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            StudentId = new Guid("13f8b918-6640-40c0-aaba-9cf0b603e9ba"),
                            CourseTeacherId = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f")
                        },
                        new
                        {
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            StudentId = new Guid("3cdc02da-bd41-4195-996e-edf7cdae6251"),
                            CourseTeacherId = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f")
                        },
                        new
                        {
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            StudentId = new Guid("91b0793e-6008-4c6f-86bc-d18ae60acf0a"),
                            CourseTeacherId = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("ScoreOver100")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Scores");

                    b.HasData(
                        new
                        {
                            Id = new Guid("79228bf8-b9d3-4945-b562-c2dcfcca4791"),
                            CourseId = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"),
                            Date = new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6")
                        },
                        new
                        {
                            Id = new Guid("3cd857c8-b6b3-4688-aa30-746478292ead"),
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            Date = new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6")
                        },
                        new
                        {
                            Id = new Guid("782f0d63-5b1a-49b5-828b-6444f938e43b"),
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            Date = new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6")
                        },
                        new
                        {
                            Id = new Guid("3e2c44c4-c86c-413d-8ade-a7e5cf83f7d7"),
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            Date = new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6")
                        },
                        new
                        {
                            Id = new Guid("32bd8b64-e7d0-4e59-a567-6b6e0c0dc4f3"),
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            Date = new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6")
                        },
                        new
                        {
                            Id = new Guid("f7eb3f68-ad64-470d-94a9-b883dc0c1c1c"),
                            CourseId = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"),
                            Date = new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 85,
                            StudentId = new Guid("97442fa4-1e9d-402c-a142-714207918954")
                        },
                        new
                        {
                            Id = new Guid("0957c7cf-4d96-4295-9f3c-07ec743e723b"),
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            Date = new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 100,
                            StudentId = new Guid("97442fa4-1e9d-402c-a142-714207918954")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Speciality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"),
                            Name = "System Engineering",
                            StartDate = new DateTime(2020, 5, 19, 2, 36, 41, 377, DateTimeKind.Local).AddTicks(7542)
                        },
                        new
                        {
                            Id = new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"),
                            Name = "Information Technologies",
                            StartDate = new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SDMS.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("RegisterStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SpecialityId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4afac2d3-a157-4283-9070-f85473d387c6"),
                            CardNumber = "ALVA001",
                            Details = "BA Programs",
                            Email = "alvan@sdms.az",
                            Gender = 0,
                            Name = "Alvan Rahimli",
                            Password = new byte[] { 220, 121, 31, 195, 66, 161, 196, 242, 197, 217, 20, 142, 19, 132, 185, 44, 89, 244, 177, 222, 235, 28, 62, 173, 121, 184, 91, 151, 77, 250, 162, 156 },
                            RegisterStatus = 1,
                            Role = "student",
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70")
                        },
                        new
                        {
                            Id = new Guid("97442fa4-1e9d-402c-a142-714207918954"),
                            CardNumber = "SAMI001",
                            Details = "BA Programs",
                            Email = "samir@sdms.az",
                            Gender = 0,
                            Name = "Samir Hasanov",
                            Password = new byte[] { 26, 138, 154, 79, 225, 90, 179, 124, 122, 92, 74, 150, 215, 163, 128, 13, 221, 243, 126, 213, 98, 60, 251, 224, 44, 198, 158, 237, 77, 194, 220, 152 },
                            RegisterStatus = 1,
                            Role = "student",
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70")
                        },
                        new
                        {
                            Id = new Guid("f5f5f499-5b0d-43d5-8b3b-aaa82479164f"),
                            CardNumber = "SABI001",
                            Details = "BA Programs",
                            Email = "sabina@sdms.az",
                            Gender = 1,
                            Name = "Sabina Shukurova",
                            Password = new byte[] { 64, 60, 242, 176, 168, 165, 59, 225, 28, 96, 220, 59, 88, 20, 200, 254, 242, 254, 224, 122, 96, 205, 214, 111, 223, 197, 134, 72, 42, 65, 50, 29 },
                            RegisterStatus = 1,
                            Role = "student",
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70")
                        },
                        new
                        {
                            Id = new Guid("3cdc02da-bd41-4195-996e-edf7cdae6251"),
                            CardNumber = "RUFA001",
                            Details = "BA Programs",
                            Email = "rufat@sdms.az",
                            Gender = 0,
                            Name = "Rufat Karimli",
                            Password = new byte[] { 161, 252, 240, 162, 131, 171, 70, 11, 112, 249, 144, 65, 134, 118, 238, 149, 171, 235, 227, 94, 84, 115, 204, 124, 28, 96, 12, 54, 65, 133, 107, 5 },
                            RegisterStatus = 1,
                            Role = "student",
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70")
                        },
                        new
                        {
                            Id = new Guid("13f8b918-6640-40c0-aaba-9cf0b603e9ba"),
                            CardNumber = "SAHI001",
                            Details = "BA Programs",
                            Email = "sahin@sdms.az",
                            Gender = 0,
                            Name = "Sahin Mahmudov",
                            Password = new byte[] { 199, 137, 16, 213, 61, 243, 79, 113, 37, 18, 22, 88, 243, 139, 235, 21, 230, 159, 5, 19, 153, 241, 226, 4, 56, 233, 252, 118, 40, 40, 110, 131 },
                            RegisterStatus = 1,
                            Role = "student",
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70")
                        },
                        new
                        {
                            Id = new Guid("91b0793e-6008-4c6f-86bc-d18ae60acf0a"),
                            CardNumber = "NIGA001",
                            Details = "BA Programs",
                            Email = "nigar@sdms.az",
                            Gender = 1,
                            Name = "Nigar Alakbarli",
                            Password = new byte[] { 130, 234, 54, 43, 116, 212, 243, 80, 87, 177, 62, 1, 50, 127, 163, 81, 248, 135, 4, 69, 154, 227, 87, 111, 102, 130, 62, 237, 236, 136, 202, 180 },
                            RegisterStatus = 1,
                            Role = "student",
                            SpecialityId = new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70")
                        });
                });

            modelBuilder.Entity("SDMS.Models.TakenCourseStudent", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseTeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("CourseTeacherId");

                    b.HasIndex("StudentId");

                    b.ToTable("TakenCourseStudents");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"),
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6"),
                            CourseTeacherId = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f")
                        },
                        new
                        {
                            CourseId = new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb"),
                            StudentId = new Guid("4afac2d3-a157-4283-9070-f85473d387c6"),
                            CourseTeacherId = new Guid("2a3b65e0-45fe-4850-90a1-bc03da111eac")
                        },
                        new
                        {
                            CourseId = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"),
                            StudentId = new Guid("97442fa4-1e9d-402c-a142-714207918954"),
                            CourseTeacherId = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CVPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("RegisterStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f"),
                            CVPath = "N/A",
                            CardNumber = "ANAR001",
                            Details = "since 2017 teaching here. Test data LOL",
                            Email = "anar@sdms.az",
                            Gender = 0,
                            Name = "Anar Kazimov",
                            Password = new byte[] { 13, 163, 157, 63, 215, 56, 253, 36, 173, 144, 123, 128, 215, 160, 65, 146, 66, 160, 85, 207, 141, 30, 123, 20, 133, 166, 142, 100, 95, 123, 123, 212 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        },
                        new
                        {
                            Id = new Guid("2a3b65e0-45fe-4850-90a1-bc03da111eac"),
                            CVPath = "N/A",
                            CardNumber = "KONU001",
                            Details = "Cuuute teacher. doesn't know eng.",
                            Email = "konul@sdms.az",
                            Gender = 1,
                            Name = "Konul Jabbarova",
                            Password = new byte[] { 225, 95, 75, 32, 223, 30, 43, 41, 130, 26, 86, 69, 237, 49, 122, 22, 200, 149, 87, 68, 150, 95, 141, 191, 60, 121, 48, 214, 99, 239, 101, 71 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        },
                        new
                        {
                            Id = new Guid("89417dad-17ef-4082-8fd2-14c3e736afd5"),
                            CVPath = "N/A",
                            CardNumber = "ULVI001",
                            Details = "Meeh, not bad",
                            Email = "ulviyye@sdms.az",
                            Gender = 1,
                            Name = "Ulviyye Memmedova",
                            Password = new byte[] { 168, 14, 103, 199, 215, 42, 209, 248, 3, 160, 5, 252, 245, 60, 173, 182, 25, 218, 195, 84, 47, 209, 215, 43, 123, 101, 136, 37, 83, 85, 162, 6 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        },
                        new
                        {
                            Id = new Guid("12677341-d31e-4ee0-b817-99dbb30490e9"),
                            CVPath = "N/A",
                            CardNumber = "CEYH001",
                            Details = "Veery Cuuute teacher. doesn't know eng.",
                            Email = "ceyhun@sdms.az",
                            Gender = 0,
                            Name = "Ceyhun Naziyev",
                            Password = new byte[] { 195, 139, 238, 24, 37, 33, 11, 141, 87, 96, 116, 187, 225, 223, 196, 114, 171, 140, 193, 4, 160, 103, 124, 221, 126, 213, 181, 35, 99, 184, 54, 125 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        },
                        new
                        {
                            Id = new Guid("0b4bc885-bdbf-4c18-9b14-cc3d55cf2fcd"),
                            CVPath = "N/A",
                            CardNumber = "ELED001",
                            Details = "Reis.",
                            Email = "eleddin@sdms.az",
                            Gender = 0,
                            Name = "Eleddin Memmedli",
                            Password = new byte[] { 47, 241, 100, 169, 13, 197, 122, 59, 242, 8, 3, 103, 181, 141, 173, 216, 176, 2, 209, 17, 102, 231, 236, 184, 248, 180, 21, 168, 107, 69, 177, 248 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        });
                });

            modelBuilder.Entity("SDMS.Models.TeacherCourse", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherCourses");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"),
                            TeacherId = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f")
                        },
                        new
                        {
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            TeacherId = new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f")
                        },
                        new
                        {
                            CourseId = new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb"),
                            TeacherId = new Guid("2a3b65e0-45fe-4850-90a1-bc03da111eac")
                        },
                        new
                        {
                            CourseId = new Guid("8d8e56d5-5e88-483b-afe9-eb78e4d26ffc"),
                            TeacherId = new Guid("89417dad-17ef-4082-8fd2-14c3e736afd5")
                        },
                        new
                        {
                            CourseId = new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31"),
                            TeacherId = new Guid("12677341-d31e-4ee0-b817-99dbb30490e9")
                        },
                        new
                        {
                            CourseId = new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f"),
                            TeacherId = new Guid("12677341-d31e-4ee0-b817-99dbb30490e9")
                        },
                        new
                        {
                            CourseId = new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"),
                            TeacherId = new Guid("0b4bc885-bdbf-4c18-9b14-cc3d55cf2fcd")
                        },
                        new
                        {
                            CourseId = new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"),
                            TeacherId = new Guid("0b4bc885-bdbf-4c18-9b14-cc3d55cf2fcd")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Absence", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SDMS.Models.Course", b =>
                {
                    b.HasOne("SDMS.Models.Course", "RequiredBy")
                        .WithMany("Prerequisites")
                        .HasForeignKey("RequiredById");

                    b.HasOne("SDMS.Models.Teacher", null)
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("SDMS.Models.CourseSpeciality", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany("CourseSpecialities")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Speciality", "Speciality")
                        .WithMany("CourseSpecialities")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SDMS.Models.CurrentCourseStudent", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany("CurrentCourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SDMS.Models.Teacher", "CourseTeacher")
                        .WithMany()
                        .HasForeignKey("CourseTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Student", "Student")
                        .WithMany("CurrentCourseStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SDMS.Models.Score", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SDMS.Models.Student", b =>
                {
                    b.HasOne("SDMS.Models.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SDMS.Models.TakenCourseStudent", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany("TakenCourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SDMS.Models.Teacher", "CourseTeacher")
                        .WithMany()
                        .HasForeignKey("CourseTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Student", "Student")
                        .WithMany("TakenCourseStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SDMS.Models.TeacherCourse", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany("TeacherCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Teacher", "Teacher")
                        .WithMany("TeacherCourses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
