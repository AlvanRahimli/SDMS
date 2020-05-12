using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SDMS.Migrations
{
    public partial class SeedEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("1367a3d7-9b94-4ba7-8c6f-17439c008816"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("4ba1de6a-04cc-4732-b33f-1b42eff53ca2"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("508b399f-9c55-4d8f-9bf4-dcab6ad4fda9"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("5a4d0620-6e7a-4b28-b0b6-80d6ccfcda31"));

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("52d3f9cf-2b66-415b-a4a6-cf6a676d1d47") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("b30764dd-6ea0-4997-9d7f-4baeb8d03040") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("e3d25582-8773-43b5-9d82-d7629755c426") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("aaab1fb6-a7b0-403f-af6b-67bdd95c4e4f"), new Guid("52d3f9cf-2b66-415b-a4a6-cf6a676d1d47") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("aaab1fb6-a7b0-403f-af6b-67bdd95c4e4f"), new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("aaab1fb6-a7b0-403f-af6b-67bdd95c4e4f"), new Guid("e3d25582-8773-43b5-9d82-d7629755c426") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4d7fbd4d-fb6c-4ef8-9476-000f0fd32ef2"));

            migrationBuilder.DeleteData(
                table: "CurrentCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("022740e6-7938-4555-804e-04c262cc9ae1"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("530af600-1fc1-4ab0-abe2-a3f3b1c7d225"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("8eac3e33-f2ca-4aeb-9758-7635a4a7667a"));

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new Guid("fea749dd-5009-4676-8759-90949a81badc") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new Guid("fea749dd-5009-4676-8759-90949a81badc") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15"), new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new Guid("675bacbf-5071-4751-8bf1-908bb8cae04e") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new Guid("675bacbf-5071-4751-8bf1-908bb8cae04e") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("52d3f9cf-2b66-415b-a4a6-cf6a676d1d47"), new Guid("0000d8e1-f639-4885-b787-d0f87e5ba7fa") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("b30764dd-6ea0-4997-9d7f-4baeb8d03040"), new Guid("b38c9773-30b7-4a23-81a6-1de2b83dab1d") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15"), new Guid("6b0df89e-6a17-42b0-8979-4e0918acf421") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("e3d25582-8773-43b5-9d82-d7629755c426"), new Guid("0000d8e1-f639-4885-b787-d0f87e5ba7fa") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("52d3f9cf-2b66-415b-a4a6-cf6a676d1d47"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b30764dd-6ea0-4997-9d7f-4baeb8d03040"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("aaab1fb6-a7b0-403f-af6b-67bdd95c4e4f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fea749dd-5009-4676-8759-90949a81badc"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("0000d8e1-f639-4885-b787-d0f87e5ba7fa"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("675bacbf-5071-4751-8bf1-908bb8cae04e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6b0df89e-6a17-42b0-8979-4e0918acf421"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b38c9773-30b7-4a23-81a6-1de2b83dab1d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e3d25582-8773-43b5-9d82-d7629755c426"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("5a4d0620-6e7a-4b28-b0b6-80d6ccfcda31"), "admin1@sdms.az", new byte[] { 118, 154, 146, 167, 110, 72, 79, 210, 194, 40, 188, 53, 92, 240, 58, 113, 238, 249, 88, 81, 104, 52, 117, 142, 73, 119, 219, 182, 94, 84, 206, 42 }, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), 11, 6, "Calculus II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15"), 6, 5, "Probability and Statistics", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("4d7fbd4d-fb6c-4ef8-9476-000f0fd32ef2"), 11, 5, "System Engineering Conseption", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("b30764dd-6ea0-4997-9d7f-4baeb8d03040"), 6, 6, "Introduction to Programming", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("e3d25582-8773-43b5-9d82-d7629755c426"), 13, 4, "Physics II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), "System Engineering", new DateTime(2020, 5, 2, 23, 5, 9, 136, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("aaab1fb6-a7b0-403f-af6b-67bdd95c4e4f"), "Information Technologies", new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d"), "N/A", "ANAR001", "since 2017 teaching here. Test data LOL", "anar@sdms.az", 0, "Anar Kazimov", new byte[] { 13, 163, 157, 63, 215, 56, 253, 36, 173, 144, 123, 128, 215, 160, 65, 146, 66, 160, 85, 207, 141, 30, 123, 20, 133, 166, 142, 100, 95, 123, 123, 212 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("6b0df89e-6a17-42b0-8979-4e0918acf421"), "N/A", "KONU001", "Cuuute teacher. doesn't know eng.", "konul@sdms.az", 1, "Konul Jabbarova", new byte[] { 225, 95, 75, 32, 223, 30, 43, 41, 130, 26, 86, 69, 237, 49, 122, 22, 200, 149, 87, 68, 150, 95, 141, 191, 60, 121, 48, 214, 99, 239, 101, 71 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("b38c9773-30b7-4a23-81a6-1de2b83dab1d"), "N/A", "ULVI001", "Meeh, not bad", "ulviyye@sdms.az", 1, "Ulviyye Memmedova", new byte[] { 168, 14, 103, 199, 215, 42, 209, 248, 3, 160, 5, 252, 245, 60, 173, 182, 25, 218, 195, 84, 47, 209, 215, 43, 123, 101, 136, 37, 83, 85, 162, 6 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("0000d8e1-f639-4885-b787-d0f87e5ba7fa"), "N/A", "CEYH001", "Veery Cuuute teacher. doesn't know eng.", "ceyhun@sdms.az", 0, "Ceyhun Naziyev", new byte[] { 195, 139, 238, 24, 37, 33, 11, 141, 87, 96, 116, 187, 225, 223, 196, 114, 171, 140, 193, 4, 160, 103, 124, 221, 126, 213, 181, 35, 99, 184, 54, 125 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("675bacbf-5071-4751-8bf1-908bb8cae04e"), "N/A", "ELED001", "Reis.", "eleddin@sdms.az", 0, "Eleddin Memmedli", new byte[] { 47, 241, 100, 169, 13, 197, 122, 59, 242, 8, 3, 103, 181, 141, 173, 216, 176, 2, 209, 17, 102, 231, 236, 184, 248, 180, 21, 168, 107, 69, 177, 248 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("b30764dd-6ea0-4997-9d7f-4baeb8d03040") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("e3d25582-8773-43b5-9d82-d7629755c426") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("aaab1fb6-a7b0-403f-af6b-67bdd95c4e4f"), new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("aaab1fb6-a7b0-403f-af6b-67bdd95c4e4f"), new Guid("e3d25582-8773-43b5-9d82-d7629755c426") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), 11, 6, "Calculus I", new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("52d3f9cf-2b66-415b-a4a6-cf6a676d1d47"), 13, 4, "Physics I", new Guid("e3d25582-8773-43b5-9d82-d7629755c426"), "N/A", null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc"), "ALVA001", "BA Programs", "alvan@sdms.az", 0, "Alvan Rahimli", new byte[] { 220, 121, 31, 195, 66, 161, 196, 242, 197, 217, 20, 142, 19, 132, 185, 44, 89, 244, 177, 222, 235, 28, 62, 173, 121, 184, 91, 151, 77, 250, 162, 156 }, 1, "student", new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("fea749dd-5009-4676-8759-90949a81badc"), "SAMI001", "BA Programs", "samir@sdms.az", 0, "Samir Hasanov", new byte[] { 26, 138, 154, 79, 225, 90, 179, 124, 122, 92, 74, 150, 215, 163, 128, 13, 221, 243, 126, 213, 98, 60, 251, 224, 44, 198, 158, 237, 77, 194, 220, 152 }, 1, "student", new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15"), new Guid("6b0df89e-6a17-42b0-8979-4e0918acf421") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("b30764dd-6ea0-4997-9d7f-4baeb8d03040"), new Guid("b38c9773-30b7-4a23-81a6-1de2b83dab1d") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("e3d25582-8773-43b5-9d82-d7629755c426"), new Guid("0000d8e1-f639-4885-b787-d0f87e5ba7fa") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new Guid("675bacbf-5071-4751-8bf1-908bb8cae04e") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("1367a3d7-9b94-4ba7-8c6f-17439c008816"), new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new DateTime(2021, 3, 17, 23, 5, 9, 156, DateTimeKind.Local).AddTicks(1536), new Guid("fea749dd-5009-4676-8759-90949a81badc") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("508b399f-9c55-4d8f-9bf4-dcab6ad4fda9"), new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new DateTime(2021, 3, 2, 23, 5, 9, 156, DateTimeKind.Local).AddTicks(1471), new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("4ba1de6a-04cc-4732-b33f-1b42eff53ca2"), new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new DateTime(2021, 3, 2, 23, 5, 9, 156, DateTimeKind.Local).AddTicks(517), new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("2c09f481-83b1-4c48-b6f8-08fb248e3ef8"), new Guid("52d3f9cf-2b66-415b-a4a6-cf6a676d1d47") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("aaab1fb6-a7b0-403f-af6b-67bdd95c4e4f"), new Guid("52d3f9cf-2b66-415b-a4a6-cf6a676d1d47") });

            migrationBuilder.InsertData(
                table: "CurrentCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc"), new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("022740e6-7938-4555-804e-04c262cc9ae1"), new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new DateTime(2020, 2, 2, 23, 5, 9, 156, DateTimeKind.Local).AddTicks(4421), 93, new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("530af600-1fc1-4ab0-abe2-a3f3b1c7d225"), new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new DateTime(2020, 3, 2, 23, 5, 9, 156, DateTimeKind.Local).AddTicks(5613), 85, new Guid("fea749dd-5009-4676-8759-90949a81badc") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("8eac3e33-f2ca-4aeb-9758-7635a4a7667a"), new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new DateTime(2020, 2, 14, 23, 5, 9, 156, DateTimeKind.Local).AddTicks(5676), 100, new Guid("fea749dd-5009-4676-8759-90949a81badc") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new Guid("fea749dd-5009-4676-8759-90949a81badc"), new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc"), new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("b860427d-493e-4472-ac3e-9abf9fab9e15"), new Guid("22b7e4a5-91cf-4b43-9d43-b986e6eceafc"), new Guid("6b0df89e-6a17-42b0-8979-4e0918acf421") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("28729ea4-1932-45cd-aa3b-cc0ae3a5dc19"), new Guid("fea749dd-5009-4676-8759-90949a81badc"), new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new Guid("675bacbf-5071-4751-8bf1-908bb8cae04e") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("25e7075d-e83b-4b90-977d-93ead5e1d20b"), new Guid("ae585a08-dff3-4228-bc52-ebd1e57d452d") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("52d3f9cf-2b66-415b-a4a6-cf6a676d1d47"), new Guid("0000d8e1-f639-4885-b787-d0f87e5ba7fa") });
        }
    }
}
