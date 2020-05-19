using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SDMS.Migrations
{
    public partial class SeedEditedAgain1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("19e39407-40f7-44f8-93b1-c6219ac63085"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("2752bd2c-05ce-4dfb-bba4-83e04426a3d3"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("c5ed90f9-5d73-44d1-996f-86754d8842dd"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a4a45e27-d986-438f-a3bc-a97c3ec5428c"));

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("5de8b989-da16-4892-bdc6-1aa733acc6d9"), new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("5de8b989-da16-4892-bdc6-1aa733acc6d9"), new Guid("824bb85d-f710-4edf-ba9f-3faef9dc70ba") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("5de8b989-da16-4892-bdc6-1aa733acc6d9"), new Guid("a158ea83-c2ed-4940-ae66-88e5008bd3bb") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("824bb85d-f710-4edf-ba9f-3faef9dc70ba") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("86a221df-dd80-4def-8462-da7b4e708977") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("a158ea83-c2ed-4940-ae66-88e5008bd3bb") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f9f27bec-bde9-41e0-9853-5bc56fa1299b"));

            migrationBuilder.DeleteData(
                table: "CurrentCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("0e9a2f13-f47e-4421-b7da-471e18808587"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("2ab52c55-0069-47c4-b447-08c40fb2e657"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("5504e630-4bdf-4c9f-a596-1b9a3f84e26c"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("6a9fefcb-db39-4022-a0b9-202428be0840"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("8185413b-ce8b-427e-85b9-22a37c531950"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("a1376352-e505-45e2-8eba-f91cc7d7cfe4"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("e9f98d66-9c31-4340-8ba5-04403bc51efb"));

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a"), new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("54e3aacc-d9c2-43bf-839d-6eebdab47519") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("675b7393-201d-477a-bc1a-2ade98986729") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("c858dcc4-0330-4820-a18b-49f0b17f2bf7") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("f5eddb87-d233-4951-b277-bc4adfed9a30") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new Guid("e92c249a-ad0a-4372-85c7-3aa86a809aaa") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a"), new Guid("82d6c411-a56e-4ad4-993b-505562c5c222") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("824bb85d-f710-4edf-ba9f-3faef9dc70ba"), new Guid("e35ac515-3d51-4b70-93ad-5ac347fa4a5a") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("86a221df-dd80-4def-8462-da7b4e708977"), new Guid("cfe81a9b-c667-410c-aae7-188a406c7fe4") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("c13c078e-fd3c-493b-93f3-443beca276e2") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("a158ea83-c2ed-4940-ae66-88e5008bd3bb"), new Guid("e35ac515-3d51-4b70-93ad-5ac347fa4a5a") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new Guid("c13c078e-fd3c-493b-93f3-443beca276e2") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("824bb85d-f710-4edf-ba9f-3faef9dc70ba"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("86a221df-dd80-4def-8462-da7b4e708977"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("5de8b989-da16-4892-bdc6-1aa733acc6d9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("54e3aacc-d9c2-43bf-839d-6eebdab47519"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("59f363ad-4326-4831-9fff-c34e457696c3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("675b7393-201d-477a-bc1a-2ade98986729"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c858dcc4-0330-4820-a18b-49f0b17f2bf7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e92c249a-ad0a-4372-85c7-3aa86a809aaa"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f5eddb87-d233-4951-b277-bc4adfed9a30"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("82d6c411-a56e-4ad4-993b-505562c5c222"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c13c078e-fd3c-493b-93f3-443beca276e2"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("cfe81a9b-c667-410c-aae7-188a406c7fe4"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e35ac515-3d51-4b70-93ad-5ac347fa4a5a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a158ea83-c2ed-4940-ae66-88e5008bd3bb"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Email", "Password", "RegistrtationStatus" },
                values: new object[] { new Guid("00ada62b-706d-42c7-906a-ede4eb09e5d8"), "admin1@sdms.az", new byte[] { 118, 154, 146, 167, 110, 72, 79, 210, 194, 40, 188, 53, 92, 240, 58, 113, 238, 249, 88, 81, 104, 52, 117, 142, 73, 119, 219, 182, 94, 84, 206, 42 }, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), 11, 6, "Calculus II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb"), 6, 5, "Probability and Statistics", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("e43ef20d-4a11-4be2-82c7-e3231ea3805e"), 11, 5, "System Engineering Conseption", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("8d8e56d5-5e88-483b-afe9-eb78e4d26ffc"), 6, 6, "Introduction to Programming", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f"), 13, 4, "Physics II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), "System Engineering", new DateTime(2020, 5, 19, 2, 36, 41, 377, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"), "Information Technologies", new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f"), "N/A", "ANAR001", "since 2017 teaching here. Test data LOL", "anar@sdms.az", 0, "Anar Kazimov", new byte[] { 13, 163, 157, 63, 215, 56, 253, 36, 173, 144, 123, 128, 215, 160, 65, 146, 66, 160, 85, 207, 141, 30, 123, 20, 133, 166, 142, 100, 95, 123, 123, 212 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("2a3b65e0-45fe-4850-90a1-bc03da111eac"), "N/A", "KONU001", "Cuuute teacher. doesn't know eng.", "konul@sdms.az", 1, "Konul Jabbarova", new byte[] { 225, 95, 75, 32, 223, 30, 43, 41, 130, 26, 86, 69, 237, 49, 122, 22, 200, 149, 87, 68, 150, 95, 141, 191, 60, 121, 48, 214, 99, 239, 101, 71 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("89417dad-17ef-4082-8fd2-14c3e736afd5"), "N/A", "ULVI001", "Meeh, not bad", "ulviyye@sdms.az", 1, "Ulviyye Memmedova", new byte[] { 168, 14, 103, 199, 215, 42, 209, 248, 3, 160, 5, 252, 245, 60, 173, 182, 25, 218, 195, 84, 47, 209, 215, 43, 123, 101, 136, 37, 83, 85, 162, 6 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("12677341-d31e-4ee0-b817-99dbb30490e9"), "N/A", "CEYH001", "Veery Cuuute teacher. doesn't know eng.", "ceyhun@sdms.az", 0, "Ceyhun Naziyev", new byte[] { 195, 139, 238, 24, 37, 33, 11, 141, 87, 96, 116, 187, 225, 223, 196, 114, 171, 140, 193, 4, 160, 103, 124, 221, 126, 213, 181, 35, 99, 184, 54, 125 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("0b4bc885-bdbf-4c18-9b14-cc3d55cf2fcd"), "N/A", "ELED001", "Reis.", "eleddin@sdms.az", 0, "Eleddin Memmedli", new byte[] { 47, 241, 100, 169, 13, 197, 122, 59, 242, 8, 3, 103, 181, 141, 173, 216, 176, 2, 209, 17, 102, 231, 236, 184, 248, 180, 21, 168, 107, 69, 177, 248 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("8d8e56d5-5e88-483b-afe9-eb78e4d26ffc") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"), new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"), new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), 11, 6, "Calculus I", new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31"), 13, 4, "Physics I", new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f"), "N/A", null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("91b0793e-6008-4c6f-86bc-d18ae60acf0a"), "NIGA001", "BA Programs", "nigar@sdms.az", 1, "Nigar Alakbarli", new byte[] { 130, 234, 54, 43, 116, 212, 243, 80, 87, 177, 62, 1, 50, 127, 163, 81, 248, 135, 4, 69, 154, 227, 87, 111, 102, 130, 62, 237, 236, 136, 202, 180 }, 1, "student", new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("13f8b918-6640-40c0-aaba-9cf0b603e9ba"), "SAHI001", "BA Programs", "sahin@sdms.az", 0, "Sahin Mahmudov", new byte[] { 199, 137, 16, 213, 61, 243, 79, 113, 37, 18, 22, 88, 243, 139, 235, 21, 230, 159, 5, 19, 153, 241, 226, 4, 56, 233, 252, 118, 40, 40, 110, 131 }, 1, "student", new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("3cdc02da-bd41-4195-996e-edf7cdae6251"), "RUFA001", "BA Programs", "rufat@sdms.az", 0, "Rufat Karimli", new byte[] { 161, 252, 240, 162, 131, 171, 70, 11, 112, 249, 144, 65, 134, 118, 238, 149, 171, 235, 227, 94, 84, 115, 204, 124, 28, 96, 12, 54, 65, 133, 107, 5 }, 1, "student", new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("f5f5f499-5b0d-43d5-8b3b-aaa82479164f"), "SABI001", "BA Programs", "sabina@sdms.az", 1, "Sabina Shukurova", new byte[] { 64, 60, 242, 176, 168, 165, 59, 225, 28, 96, 220, 59, 88, 20, 200, 254, 242, 254, 224, 122, 96, 205, 214, 111, 223, 197, 134, 72, 42, 65, 50, 29 }, 1, "student", new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("97442fa4-1e9d-402c-a142-714207918954"), "SAMI001", "BA Programs", "samir@sdms.az", 0, "Samir Hasanov", new byte[] { 26, 138, 154, 79, 225, 90, 179, 124, 122, 92, 74, 150, 215, 163, 128, 13, 221, 243, 126, 213, 98, 60, 251, 224, 44, 198, 158, 237, 77, 194, 220, 152 }, 1, "student", new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("4afac2d3-a157-4283-9070-f85473d387c6"), "ALVA001", "BA Programs", "alvan@sdms.az", 0, "Alvan Rahimli", new byte[] { 220, 121, 31, 195, 66, 161, 196, 242, 197, 217, 20, 142, 19, 132, 185, 44, 89, 244, 177, 222, 235, 28, 62, 173, 121, 184, 91, 151, 77, 250, 162, 156 }, 1, "student", new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb"), new Guid("2a3b65e0-45fe-4850-90a1-bc03da111eac") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("8d8e56d5-5e88-483b-afe9-eb78e4d26ffc"), new Guid("89417dad-17ef-4082-8fd2-14c3e736afd5") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f"), new Guid("12677341-d31e-4ee0-b817-99dbb30490e9") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("0b4bc885-bdbf-4c18-9b14-cc3d55cf2fcd") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("ab6cacbe-2ecc-49e4-ab7d-5b1533f9ed29"), new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new DateTime(2021, 4, 3, 2, 36, 41, 401, DateTimeKind.Local).AddTicks(392), new Guid("97442fa4-1e9d-402c-a142-714207918954") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("fa8ab822-633c-474d-b909-326e20b9e880"), new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new DateTime(2021, 3, 19, 2, 36, 41, 400, DateTimeKind.Local).AddTicks(9271), new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("91962704-7b0a-48f1-8a9a-1bdc76546308"), new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new DateTime(2021, 3, 19, 2, 36, 41, 401, DateTimeKind.Local).AddTicks(316), new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"), new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31") });

            migrationBuilder.InsertData(
                table: "CurrentCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("3cdc02da-bd41-4195-996e-edf7cdae6251"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.InsertData(
                table: "CurrentCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("f5f5f499-5b0d-43d5-8b3b-aaa82479164f"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.InsertData(
                table: "CurrentCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("13f8b918-6640-40c0-aaba-9cf0b603e9ba"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.InsertData(
                table: "CurrentCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("91b0793e-6008-4c6f-86bc-d18ae60acf0a"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.InsertData(
                table: "CurrentCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("4afac2d3-a157-4283-9070-f85473d387c6"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("3cd857c8-b6b3-4688-aa30-746478292ead"), new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("3e2c44c4-c86c-413d-8ade-a7e5cf83f7d7"), new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("32bd8b64-e7d0-4e59-a567-6b6e0c0dc4f3"), new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("f7eb3f68-ad64-470d-94a9-b883dc0c1c1c"), new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, new Guid("97442fa4-1e9d-402c-a142-714207918954") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("0957c7cf-4d96-4295-9f3c-07ec743e723b"), new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, new Guid("97442fa4-1e9d-402c-a142-714207918954") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("79228bf8-b9d3-4945-b562-c2dcfcca4791"), new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("782f0d63-5b1a-49b5-828b-6444f938e43b"), new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new Guid("4afac2d3-a157-4283-9070-f85473d387c6"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb"), new Guid("4afac2d3-a157-4283-9070-f85473d387c6"), new Guid("2a3b65e0-45fe-4850-90a1-bc03da111eac") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new Guid("97442fa4-1e9d-402c-a142-714207918954"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31"), new Guid("12677341-d31e-4ee0-b817-99dbb30490e9") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new Guid("0b4bc885-bdbf-4c18-9b14-cc3d55cf2fcd") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("91962704-7b0a-48f1-8a9a-1bdc76546308"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("ab6cacbe-2ecc-49e4-ab7d-5b1533f9ed29"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("fa8ab822-633c-474d-b909-326e20b9e880"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("00ada62b-706d-42c7-906a-ede4eb09e5d8"));

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"), new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"), new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"), new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("8d8e56d5-5e88-483b-afe9-eb78e4d26ffc") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"), new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e43ef20d-4a11-4be2-82c7-e3231ea3805e"));

            migrationBuilder.DeleteData(
                table: "CurrentCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("13f8b918-6640-40c0-aaba-9cf0b603e9ba") });

            migrationBuilder.DeleteData(
                table: "CurrentCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("3cdc02da-bd41-4195-996e-edf7cdae6251") });

            migrationBuilder.DeleteData(
                table: "CurrentCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.DeleteData(
                table: "CurrentCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("91b0793e-6008-4c6f-86bc-d18ae60acf0a") });

            migrationBuilder.DeleteData(
                table: "CurrentCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("f5f5f499-5b0d-43d5-8b3b-aaa82479164f") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("0957c7cf-4d96-4295-9f3c-07ec743e723b"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("32bd8b64-e7d0-4e59-a567-6b6e0c0dc4f3"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("3cd857c8-b6b3-4688-aa30-746478292ead"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("3e2c44c4-c86c-413d-8ade-a7e5cf83f7d7"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("782f0d63-5b1a-49b5-828b-6444f938e43b"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("79228bf8-b9d3-4945-b562-c2dcfcca4791"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("f7eb3f68-ad64-470d-94a9-b883dc0c1c1c"));

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb"), new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new Guid("4afac2d3-a157-4283-9070-f85473d387c6") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new Guid("97442fa4-1e9d-402c-a142-714207918954") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31"), new Guid("12677341-d31e-4ee0-b817-99dbb30490e9") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("8d8e56d5-5e88-483b-afe9-eb78e4d26ffc"), new Guid("89417dad-17ef-4082-8fd2-14c3e736afd5") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f"), new Guid("12677341-d31e-4ee0-b817-99dbb30490e9") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"), new Guid("0b4bc885-bdbf-4c18-9b14-cc3d55cf2fcd") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb"), new Guid("2a3b65e0-45fe-4850-90a1-bc03da111eac") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"), new Guid("0b4bc885-bdbf-4c18-9b14-cc3d55cf2fcd") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3e7eea7e-26a1-475b-bff4-8f0a11dc5e31"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8d8e56d5-5e88-483b-afe9-eb78e4d26ffc"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9a58c04e-7b58-48d0-9f28-a922a69983fb"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("bd0bd8d8-b524-48fd-916e-0b61aeb18d7f"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("0ea8a3a5-b366-4a4f-b0e8-9e5ad884f5dd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("13f8b918-6640-40c0-aaba-9cf0b603e9ba"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3cdc02da-bd41-4195-996e-edf7cdae6251"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4afac2d3-a157-4283-9070-f85473d387c6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("91b0793e-6008-4c6f-86bc-d18ae60acf0a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("97442fa4-1e9d-402c-a142-714207918954"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f5f5f499-5b0d-43d5-8b3b-aaa82479164f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("06f2583e-4088-4fc2-a371-c67e29d8812f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("0b4bc885-bdbf-4c18-9b14-cc3d55cf2fcd"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("12677341-d31e-4ee0-b817-99dbb30490e9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2a3b65e0-45fe-4850-90a1-bc03da111eac"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("89417dad-17ef-4082-8fd2-14c3e736afd5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("968395eb-fee2-45c1-a3a1-b100ed8f754f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("985582a9-4eb1-4d49-b9d8-1baca6c608ef"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("29317fe8-e38a-4e51-9e5c-d9e29b999b70"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Email", "Password", "RegistrtationStatus" },
                values: new object[] { new Guid("a4a45e27-d986-438f-a3bc-a97c3ec5428c"), "admin1@sdms.az", new byte[] { 118, 154, 146, 167, 110, 72, 79, 210, 194, 40, 188, 53, 92, 240, 58, 113, 238, 249, 88, 81, 104, 52, 117, 142, 73, 119, 219, 182, 94, 84, 206, 42 }, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), 11, 6, "Calculus II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a"), 6, 5, "Probability and Statistics", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("f9f27bec-bde9-41e0-9853-5bc56fa1299b"), 11, 5, "System Engineering Conseption", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("86a221df-dd80-4def-8462-da7b4e708977"), 6, 6, "Introduction to Programming", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("a158ea83-c2ed-4940-ae66-88e5008bd3bb"), 13, 4, "Physics II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), "System Engineering", new DateTime(2020, 5, 19, 2, 33, 3, 741, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("5de8b989-da16-4892-bdc6-1aa733acc6d9"), "Information Technologies", new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9"), "N/A", "ANAR001", "since 2017 teaching here. Test data LOL", "anar@sdms.az", 0, "Anar Kazimov", new byte[] { 13, 163, 157, 63, 215, 56, 253, 36, 173, 144, 123, 128, 215, 160, 65, 146, 66, 160, 85, 207, 141, 30, 123, 20, 133, 166, 142, 100, 95, 123, 123, 212 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("82d6c411-a56e-4ad4-993b-505562c5c222"), "N/A", "KONU001", "Cuuute teacher. doesn't know eng.", "konul@sdms.az", 1, "Konul Jabbarova", new byte[] { 225, 95, 75, 32, 223, 30, 43, 41, 130, 26, 86, 69, 237, 49, 122, 22, 200, 149, 87, 68, 150, 95, 141, 191, 60, 121, 48, 214, 99, 239, 101, 71 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("cfe81a9b-c667-410c-aae7-188a406c7fe4"), "N/A", "ULVI001", "Meeh, not bad", "ulviyye@sdms.az", 1, "Ulviyye Memmedova", new byte[] { 168, 14, 103, 199, 215, 42, 209, 248, 3, 160, 5, 252, 245, 60, 173, 182, 25, 218, 195, 84, 47, 209, 215, 43, 123, 101, 136, 37, 83, 85, 162, 6 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("e35ac515-3d51-4b70-93ad-5ac347fa4a5a"), "N/A", "CEYH001", "Veery Cuuute teacher. doesn't know eng.", "ceyhun@sdms.az", 0, "Ceyhun Naziyev", new byte[] { 195, 139, 238, 24, 37, 33, 11, 141, 87, 96, 116, 187, 225, 223, 196, 114, 171, 140, 193, 4, 160, 103, 124, 221, 126, 213, 181, 35, 99, 184, 54, 125 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("c13c078e-fd3c-493b-93f3-443beca276e2"), "N/A", "ELED001", "Reis.", "eleddin@sdms.az", 0, "Eleddin Memmedli", new byte[] { 47, 241, 100, 169, 13, 197, 122, 59, 242, 8, 3, 103, 181, 141, 173, 216, 176, 2, 209, 17, 102, 231, 236, 184, 248, 180, 21, 168, 107, 69, 177, 248 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("86a221df-dd80-4def-8462-da7b4e708977") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("a158ea83-c2ed-4940-ae66-88e5008bd3bb") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("5de8b989-da16-4892-bdc6-1aa733acc6d9"), new Guid("a158ea83-c2ed-4940-ae66-88e5008bd3bb") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("5de8b989-da16-4892-bdc6-1aa733acc6d9"), new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), 11, 6, "Calculus I", new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("824bb85d-f710-4edf-ba9f-3faef9dc70ba"), 13, 4, "Physics I", new Guid("a158ea83-c2ed-4940-ae66-88e5008bd3bb"), "N/A", null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("c858dcc4-0330-4820-a18b-49f0b17f2bf7"), "NIGA001", "BA Programs", "nigar@sdms.az", 1, "Nigar Alakbarli", new byte[] { 130, 234, 54, 43, 116, 212, 243, 80, 87, 177, 62, 1, 50, 127, 163, 81, 248, 135, 4, 69, 154, 227, 87, 111, 102, 130, 62, 237, 236, 136, 202, 180 }, 1, "student", new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("54e3aacc-d9c2-43bf-839d-6eebdab47519"), "SAHI001", "BA Programs", "sahin@sdms.az", 0, "Sahin Mahmudov", new byte[] { 199, 137, 16, 213, 61, 243, 79, 113, 37, 18, 22, 88, 243, 139, 235, 21, 230, 159, 5, 19, 153, 241, 226, 4, 56, 233, 252, 118, 40, 40, 110, 131 }, 1, "student", new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("675b7393-201d-477a-bc1a-2ade98986729"), "RUFA001", "BA Programs", "rufat@sdms.az", 0, "Rufat Karimli", new byte[] { 161, 252, 240, 162, 131, 171, 70, 11, 112, 249, 144, 65, 134, 118, 238, 149, 171, 235, 227, 94, 84, 115, 204, 124, 28, 96, 12, 54, 65, 133, 107, 5 }, 1, "student", new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("f5eddb87-d233-4951-b277-bc4adfed9a30"), "SABI001", "BA Programs", "sabina@sdms.az", 1, "Sabina Shukurova", new byte[] { 64, 60, 242, 176, 168, 165, 59, 225, 28, 96, 220, 59, 88, 20, 200, 254, 242, 254, 224, 122, 96, 205, 214, 111, 223, 197, 134, 72, 42, 65, 50, 29 }, 1, "student", new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("e92c249a-ad0a-4372-85c7-3aa86a809aaa"), "SAMI001", "BA Programs", "samir@sdms.az", 0, "Samir Hasanov", new byte[] { 26, 138, 154, 79, 225, 90, 179, 124, 122, 92, 74, 150, 215, 163, 128, 13, 221, 243, 126, 213, 98, 60, 251, 224, 44, 198, 158, 237, 77, 194, 220, 152 }, 1, "student", new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("59f363ad-4326-4831-9fff-c34e457696c3"), "ALVA001", "BA Programs", "alvan@sdms.az", 0, "Alvan Rahimli", new byte[] { 220, 121, 31, 195, 66, 161, 196, 242, 197, 217, 20, 142, 19, 132, 185, 44, 89, 244, 177, 222, 235, 28, 62, 173, 121, 184, 91, 151, 77, 250, 162, 156 }, 1, "student", new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a"), new Guid("82d6c411-a56e-4ad4-993b-505562c5c222") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("86a221df-dd80-4def-8462-da7b4e708977"), new Guid("cfe81a9b-c667-410c-aae7-188a406c7fe4") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("a158ea83-c2ed-4940-ae66-88e5008bd3bb"), new Guid("e35ac515-3d51-4b70-93ad-5ac347fa4a5a") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("c13c078e-fd3c-493b-93f3-443beca276e2") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("2752bd2c-05ce-4dfb-bba4-83e04426a3d3"), new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new DateTime(2021, 4, 3, 2, 33, 3, 764, DateTimeKind.Local).AddTicks(1788), new Guid("e92c249a-ad0a-4372-85c7-3aa86a809aaa") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("c5ed90f9-5d73-44d1-996f-86754d8842dd"), new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new DateTime(2021, 3, 19, 2, 33, 3, 764, DateTimeKind.Local).AddTicks(664), new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("19e39407-40f7-44f8-93b1-c6219ac63085"), new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new DateTime(2021, 3, 19, 2, 33, 3, 764, DateTimeKind.Local).AddTicks(1720), new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("f7082f52-082d-42b4-8538-c98f4bf2ab18"), new Guid("824bb85d-f710-4edf-ba9f-3faef9dc70ba") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("5de8b989-da16-4892-bdc6-1aa733acc6d9"), new Guid("824bb85d-f710-4edf-ba9f-3faef9dc70ba") });

            migrationBuilder.InsertData(
                table: "CurrentCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("59f363ad-4326-4831-9fff-c34e457696c3"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("5504e630-4bdf-4c9f-a596-1b9a3f84e26c"), new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, new Guid("e92c249a-ad0a-4372-85c7-3aa86a809aaa") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("a1376352-e505-45e2-8eba-f91cc7d7cfe4"), new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, new Guid("e92c249a-ad0a-4372-85c7-3aa86a809aaa") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("6a9fefcb-db39-4022-a0b9-202428be0840"), new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("0e9a2f13-f47e-4421-b7da-471e18808587"), new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new DateTime(2019, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("2ab52c55-0069-47c4-b447-08c40fb2e657"), new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new DateTime(2019, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("8185413b-ce8b-427e-85b9-22a37c531950"), new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("e9f98d66-9c31-4340-8ba5-04403bc51efb"), new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new DateTime(2019, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("59f363ad-4326-4831-9fff-c34e457696c3") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new Guid("59f363ad-4326-4831-9fff-c34e457696c3"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("77495424-0d7f-43f7-8d6c-b430b2927c1a"), new Guid("59f363ad-4326-4831-9fff-c34e457696c3"), new Guid("82d6c411-a56e-4ad4-993b-505562c5c222") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new Guid("e92c249a-ad0a-4372-85c7-3aa86a809aaa"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("f5eddb87-d233-4951-b277-bc4adfed9a30"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("675b7393-201d-477a-bc1a-2ade98986729"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("54e3aacc-d9c2-43bf-839d-6eebdab47519"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("9d8fcf3f-118c-4c2a-89d1-cd4176c19ad1"), new Guid("c858dcc4-0330-4820-a18b-49f0b17f2bf7"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("824bb85d-f710-4edf-ba9f-3faef9dc70ba"), new Guid("e35ac515-3d51-4b70-93ad-5ac347fa4a5a") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new Guid("c13c078e-fd3c-493b-93f3-443beca276e2") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("abf6b210-566c-4dcd-bc5e-7527599248cb"), new Guid("3c4ab952-8b79-4e58-8aaf-31a52a4435a9") });
        }
    }
}
