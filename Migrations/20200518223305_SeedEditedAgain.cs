using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SDMS.Migrations
{
    public partial class SeedEditedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("2012d256-2218-4899-87fb-194f7ddb304d"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("34b4f556-43cb-4f4e-8e02-ca377368e68b"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("6ba90822-dcf5-4d48-a532-bdcf7376e7ff"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("91c86171-2a22-4da8-84fe-be29271ca353"));

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"), new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"), new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"), new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("07af7773-9ead-4ab9-ac56-7a56929716aa") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("53f1918b-a53c-470a-b547-2137d40fc632"));

            migrationBuilder.DeleteData(
                table: "CurrentCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("2f03324b-1152-4573-bac3-65c2e7adda41"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("3ca2f92d-76eb-41c7-a86a-4b67e109d83e"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("624623e9-4534-47d3-8301-c805d969f00a"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("70b4c6c7-c1fa-410d-8b8a-82e8d186ab74"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("9275a2d1-61b5-4aab-a79b-6b8f8cae428d"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("939e6bf9-e0b5-4799-a699-9973d57f860d"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("a6d4f569-09fc-4c25-bdc3-40d7f72cdfe7"));

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb"), new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("07af7773-9ead-4ab9-ac56-7a56929716aa"), new Guid("10680bf9-a009-46d6-9cdd-4684a7eafef8") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393"), new Guid("855416e2-8654-44df-ab29-0fef69914426") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf"), new Guid("855416e2-8654-44df-ab29-0fef69914426") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new Guid("6fcbb37f-b951-4bec-a4f9-144ea24ca14e") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new Guid("6fcbb37f-b951-4bec-a4f9-144ea24ca14e") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb"), new Guid("36e8b3e3-6e85-4a58-99ad-96152aed2997") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("07af7773-9ead-4ab9-ac56-7a56929716aa"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("10680bf9-a009-46d6-9cdd-4684a7eafef8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("36e8b3e3-6e85-4a58-99ad-96152aed2997"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6fcbb37f-b951-4bec-a4f9-144ea24ca14e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("855416e2-8654-44df-ab29-0fef69914426"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("91c86171-2a22-4da8-84fe-be29271ca353"), "admin1@sdms.az", new byte[] { 118, 154, 146, 167, 110, 72, 79, 210, 194, 40, 188, 53, 92, 240, 58, 113, 238, 249, 88, 81, 104, 52, 117, 142, 73, 119, 219, 182, 94, 84, 206, 42 }, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), 11, 6, "Calculus II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb"), 6, 5, "Probability and Statistics", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("53f1918b-a53c-470a-b547-2137d40fc632"), 11, 5, "System Engineering Conseption", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("07af7773-9ead-4ab9-ac56-7a56929716aa"), 6, 6, "Introduction to Programming", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393"), 13, 4, "Physics II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), "System Engineering", new DateTime(2020, 5, 11, 22, 0, 38, 61, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"), "Information Technologies", new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a"), "N/A", "ANAR001", "since 2017 teaching here. Test data LOL", "anar@sdms.az", 0, "Anar Kazimov", new byte[] { 13, 163, 157, 63, 215, 56, 253, 36, 173, 144, 123, 128, 215, 160, 65, 146, 66, 160, 85, 207, 141, 30, 123, 20, 133, 166, 142, 100, 95, 123, 123, 212 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("36e8b3e3-6e85-4a58-99ad-96152aed2997"), "N/A", "KONU001", "Cuuute teacher. doesn't know eng.", "konul@sdms.az", 1, "Konul Jabbarova", new byte[] { 225, 95, 75, 32, 223, 30, 43, 41, 130, 26, 86, 69, 237, 49, 122, 22, 200, 149, 87, 68, 150, 95, 141, 191, 60, 121, 48, 214, 99, 239, 101, 71 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("10680bf9-a009-46d6-9cdd-4684a7eafef8"), "N/A", "ULVI001", "Meeh, not bad", "ulviyye@sdms.az", 1, "Ulviyye Memmedova", new byte[] { 168, 14, 103, 199, 215, 42, 209, 248, 3, 160, 5, 252, 245, 60, 173, 182, 25, 218, 195, 84, 47, 209, 215, 43, 123, 101, 136, 37, 83, 85, 162, 6 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("855416e2-8654-44df-ab29-0fef69914426"), "N/A", "CEYH001", "Veery Cuuute teacher. doesn't know eng.", "ceyhun@sdms.az", 0, "Ceyhun Naziyev", new byte[] { 195, 139, 238, 24, 37, 33, 11, 141, 87, 96, 116, 187, 225, 223, 196, 114, 171, 140, 193, 4, 160, 103, 124, 221, 126, 213, 181, 35, 99, 184, 54, 125 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("6fcbb37f-b951-4bec-a4f9-144ea24ca14e"), "N/A", "ELED001", "Reis.", "eleddin@sdms.az", 0, "Eleddin Memmedli", new byte[] { 47, 241, 100, 169, 13, 197, 122, 59, 242, 8, 3, 103, 181, 141, 173, 216, 176, 2, 209, 17, 102, 231, 236, 184, 248, 180, 21, 168, 107, 69, 177, 248 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("07af7773-9ead-4ab9-ac56-7a56929716aa") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"), new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"), new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), 11, 6, "Calculus I", new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf"), 13, 4, "Physics I", new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393"), "N/A", null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8"), "ALVA001", "BA Programs", "alvan@sdms.az", 0, "Alvan Rahimli", new byte[] { 220, 121, 31, 195, 66, 161, 196, 242, 197, 217, 20, 142, 19, 132, 185, 44, 89, 244, 177, 222, 235, 28, 62, 173, 121, 184, 91, 151, 77, 250, 162, 156 }, 1, "student", new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398"), "SAMI001", "BA Programs", "samir@sdms.az", 0, "Samir Hasanov", new byte[] { 26, 138, 154, 79, 225, 90, 179, 124, 122, 92, 74, 150, 215, 163, 128, 13, 221, 243, 126, 213, 98, 60, 251, 224, 44, 198, 158, 237, 77, 194, 220, 152 }, 1, "student", new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb"), new Guid("36e8b3e3-6e85-4a58-99ad-96152aed2997") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("07af7773-9ead-4ab9-ac56-7a56929716aa"), new Guid("10680bf9-a009-46d6-9cdd-4684a7eafef8") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393"), new Guid("855416e2-8654-44df-ab29-0fef69914426") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new Guid("6fcbb37f-b951-4bec-a4f9-144ea24ca14e") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("6ba90822-dcf5-4d48-a532-bdcf7376e7ff"), new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new DateTime(2021, 3, 26, 22, 0, 38, 80, DateTimeKind.Local).AddTicks(3360), new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("34b4f556-43cb-4f4e-8e02-ca377368e68b"), new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new DateTime(2021, 3, 11, 22, 0, 38, 80, DateTimeKind.Local).AddTicks(2358), new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("2012d256-2218-4899-87fb-194f7ddb304d"), new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new DateTime(2021, 3, 11, 22, 0, 38, 80, DateTimeKind.Local).AddTicks(3299), new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"), new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"), new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf") });

            migrationBuilder.InsertData(
                table: "CurrentCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8"), new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("624623e9-4534-47d3-8301-c805d969f00a"), new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("3ca2f92d-76eb-41c7-a86a-4b67e109d83e"), new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("939e6bf9-e0b5-4799-a699-9973d57f860d"), new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("2f03324b-1152-4573-bac3-65c2e7adda41"), new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("70b4c6c7-c1fa-410d-8b8a-82e8d186ab74"), new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("a6d4f569-09fc-4c25-bdc3-40d7f72cdfe7"), new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("9275a2d1-61b5-4aab-a79b-6b8f8cae428d"), new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398"), new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8"), new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb"), new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8"), new Guid("36e8b3e3-6e85-4a58-99ad-96152aed2997") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"), new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398"), new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf"), new Guid("855416e2-8654-44df-ab29-0fef69914426") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new Guid("6fcbb37f-b951-4bec-a4f9-144ea24ca14e") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"), new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a") });
        }
    }
}
