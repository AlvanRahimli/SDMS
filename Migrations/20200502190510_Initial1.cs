using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SDMS.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("a70e7eeb-1b0b-4b1d-9621-8385f7d61153"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("b51279a1-bf90-409f-83aa-028e01a7f9f2"));

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: new Guid("beb9e04d-2609-4e26-a8af-7dc0222b628f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("bde17eaa-262d-4269-9dec-670f32e8abce"));

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("46e455b2-40de-4fac-b56e-69ffe4846685"), new Guid("59d13275-f16e-4525-a71e-c75e7afe3bac") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("46e455b2-40de-4fac-b56e-69ffe4846685"), new Guid("c8bc39cf-aa63-4854-a54f-978bc1d864f6") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("46e455b2-40de-4fac-b56e-69ffe4846685"), new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("3849542f-dc9c-4eb5-a27d-d9bd7ca4262d") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("59d13275-f16e-4525-a71e-c75e7afe3bac") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("c8bc39cf-aa63-4854-a54f-978bc1d864f6") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217") });

            migrationBuilder.DeleteData(
                table: "CourseSpecialities",
                keyColumns: new[] { "SpecialityId", "CourseId" },
                keyValues: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("daad583a-188b-45ee-8955-f958eb5629ea"));

            migrationBuilder.DeleteData(
                table: "CurrentCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343") });

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("079d49a5-3ecc-48e4-b220-b49ca2be358c"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("26567141-155a-45d9-a392-82b87a44a58a"));

            migrationBuilder.DeleteData(
                table: "Scores",
                keyColumn: "Id",
                keyValue: new Guid("47bef39b-c373-484e-809f-25286cf641c3"));

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new Guid("f4978b1f-c59f-4ac1-9bf4-20a28e82ea1d") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217"), new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343") });

            migrationBuilder.DeleteData(
                table: "TakenCourseStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new Guid("f4978b1f-c59f-4ac1-9bf4-20a28e82ea1d") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("3849542f-dc9c-4eb5-a27d-d9bd7ca4262d"), new Guid("946d7c30-d8fc-4a5d-970f-8eb84ad66233") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("59d13275-f16e-4525-a71e-c75e7afe3bac"), new Guid("b9739149-38c1-4dfa-914a-c18688784e0c") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new Guid("65be49c1-0b5c-4cce-a4fb-ce5d2a8206ba") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new Guid("a09df384-2dca-4dc3-850f-c064c46fabee") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("c8bc39cf-aa63-4854-a54f-978bc1d864f6"), new Guid("b9739149-38c1-4dfa-914a-c18688784e0c") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217"), new Guid("c988523e-be5f-4e81-929c-1341c54bbe32") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new Guid("65be49c1-0b5c-4cce-a4fb-ce5d2a8206ba") });

            migrationBuilder.DeleteData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new Guid("a09df384-2dca-4dc3-850f-c064c46fabee") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3849542f-dc9c-4eb5-a27d-d9bd7ca4262d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("59d13275-f16e-4525-a71e-c75e7afe3bac"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c8bc39cf-aa63-4854-a54f-978bc1d864f6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("46e455b2-40de-4fac-b56e-69ffe4846685"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f4978b1f-c59f-4ac1-9bf4-20a28e82ea1d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("65be49c1-0b5c-4cce-a4fb-ce5d2a8206ba"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("946d7c30-d8fc-4a5d-970f-8eb84ad66233"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a09df384-2dca-4dc3-850f-c064c46fabee"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b9739149-38c1-4dfa-914a-c18688784e0c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c988523e-be5f-4e81-929c-1341c54bbe32"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("bde17eaa-262d-4269-9dec-670f32e8abce"), "admin1@sdms.az", new byte[] { 118, 154, 146, 167, 110, 72, 79, 210, 194, 40, 188, 53, 92, 240, 58, 113, 238, 249, 88, 81, 104, 52, 117, 142, 73, 119, 219, 182, 94, 84, 206, 42 }, 1 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), 11, 6, "Calculus II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217"), 6, 5, "Probability and Statistics", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("daad583a-188b-45ee-8955-f958eb5629ea"), 11, 5, "System Engineering Conseption", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("3849542f-dc9c-4eb5-a27d-d9bd7ca4262d"), 6, 6, "Introduction to Programming", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("59d13275-f16e-4525-a71e-c75e7afe3bac"), 13, 4, "Physics I", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("c8bc39cf-aa63-4854-a54f-978bc1d864f6"), 13, 4, "Physics II", null, "N/A", null });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), "System Engineering", new DateTime(2020, 5, 2, 23, 0, 48, 526, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { new Guid("46e455b2-40de-4fac-b56e-69ffe4846685"), "Information Technologies", new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("a09df384-2dca-4dc3-850f-c064c46fabee"), "N/A", "ANAR001", "since 2017 teaching here. Test data LOL", "anar@sdms.az", 0, "Anar Kazimov", new byte[] { 13, 163, 157, 63, 215, 56, 253, 36, 173, 144, 123, 128, 215, 160, 65, 146, 66, 160, 85, 207, 141, 30, 123, 20, 133, 166, 142, 100, 95, 123, 123, 212 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("c988523e-be5f-4e81-929c-1341c54bbe32"), "N/A", "KONU001", "Cuuute teacher. doesn't know eng.", "konul@sdms.az", 1, "Konul Jabbarova", new byte[] { 225, 95, 75, 32, 223, 30, 43, 41, 130, 26, 86, 69, 237, 49, 122, 22, 200, 149, 87, 68, 150, 95, 141, 191, 60, 121, 48, 214, 99, 239, 101, 71 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("946d7c30-d8fc-4a5d-970f-8eb84ad66233"), "N/A", "ULVI001", "Meeh, not bad", "ulviyye@sdms.az", 1, "Ulviyye Memmedova", new byte[] { 168, 14, 103, 199, 215, 42, 209, 248, 3, 160, 5, 252, 245, 60, 173, 182, 25, 218, 195, 84, 47, 209, 215, 43, 123, 101, 136, 37, 83, 85, 162, 6 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("b9739149-38c1-4dfa-914a-c18688784e0c"), "N/A", "CEYH001", "Veery Cuuute teacher. doesn't know eng.", "ceyhun@sdms.az", 0, "Ceyhun Naziyev", new byte[] { 195, 139, 238, 24, 37, 33, 11, 141, 87, 96, 116, 187, 225, 223, 196, 114, 171, 140, 193, 4, 160, 103, 124, 221, 126, 213, 181, 35, 99, 184, 54, 125 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CVPath", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role" },
                values: new object[] { new Guid("65be49c1-0b5c-4cce-a4fb-ce5d2a8206ba"), "N/A", "ELED001", "Reis.", "eleddin@sdms.az", 0, "Eleddin Memmedli", new byte[] { 47, 241, 100, 169, 13, 197, 122, 59, 242, 8, 3, 103, 181, 141, 173, 216, 176, 2, 209, 17, 102, 231, 236, 184, 248, 180, 21, 168, 107, 69, 177, 248 }, 1, "teacher" });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("46e455b2-40de-4fac-b56e-69ffe4846685"), new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("3849542f-dc9c-4eb5-a27d-d9bd7ca4262d") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("59d13275-f16e-4525-a71e-c75e7afe3bac") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("c8bc39cf-aa63-4854-a54f-978bc1d864f6") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("46e455b2-40de-4fac-b56e-69ffe4846685"), new Guid("c8bc39cf-aa63-4854-a54f-978bc1d864f6") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("46e455b2-40de-4fac-b56e-69ffe4846685"), new Guid("59d13275-f16e-4525-a71e-c75e7afe3bac") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AbsenceLimit", "Credit", "Name", "RequiredById", "SyllabusPath", "TeacherId" },
                values: new object[] { new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), 11, 6, "Calculus I", new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), "N/A", null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("f4978b1f-c59f-4ac1-9bf4-20a28e82ea1d"), "SAMI001", "BA Programs", "samir@sdms.az", 0, "Samir Hasanov", new byte[] { 26, 138, 154, 79, 225, 90, 179, 124, 122, 92, 74, 150, 215, 163, 128, 13, 221, 243, 126, 213, 98, 60, 251, 224, 44, 198, 158, 237, 77, 194, 220, 152 }, 1, "student", new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d") });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CardNumber", "Details", "Email", "Gender", "Name", "Password", "RegisterStatus", "Role", "SpecialityId" },
                values: new object[] { new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343"), "ALVA001", "BA Programs", "alvan@sdms.az", 0, "Alvan Rahimli", new byte[] { 220, 121, 31, 195, 66, 161, 196, 242, 197, 217, 20, 142, 19, 132, 185, 44, 89, 244, 177, 222, 235, 28, 62, 173, 121, 184, 91, 151, 77, 250, 162, 156 }, 1, "student", new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new Guid("a09df384-2dca-4dc3-850f-c064c46fabee") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217"), new Guid("c988523e-be5f-4e81-929c-1341c54bbe32") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("3849542f-dc9c-4eb5-a27d-d9bd7ca4262d"), new Guid("946d7c30-d8fc-4a5d-970f-8eb84ad66233") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("59d13275-f16e-4525-a71e-c75e7afe3bac"), new Guid("b9739149-38c1-4dfa-914a-c18688784e0c") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("c8bc39cf-aa63-4854-a54f-978bc1d864f6"), new Guid("b9739149-38c1-4dfa-914a-c18688784e0c") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new Guid("65be49c1-0b5c-4cce-a4fb-ce5d2a8206ba") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("b51279a1-bf90-409f-83aa-028e01a7f9f2"), new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new DateTime(2021, 3, 2, 23, 0, 48, 546, DateTimeKind.Local).AddTicks(2215), new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("beb9e04d-2609-4e26-a8af-7dc0222b628f"), new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new DateTime(2021, 3, 2, 23, 0, 48, 546, DateTimeKind.Local).AddTicks(3136), new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343") });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "CourseId", "DateTime", "StudentId" },
                values: new object[] { new Guid("a70e7eeb-1b0b-4b1d-9621-8385f7d61153"), new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new DateTime(2021, 3, 17, 23, 0, 48, 546, DateTimeKind.Local).AddTicks(3217), new Guid("f4978b1f-c59f-4ac1-9bf4-20a28e82ea1d") });

            migrationBuilder.InsertData(
                table: "CourseSpecialities",
                columns: new[] { "SpecialityId", "CourseId" },
                values: new object[] { new Guid("64dddb31-a5a1-4b24-86d3-8b78164dfa2d"), new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60") });

            migrationBuilder.InsertData(
                table: "CurrentCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343"), new Guid("a09df384-2dca-4dc3-850f-c064c46fabee") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("47bef39b-c373-484e-809f-25286cf641c3"), new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new DateTime(2020, 2, 2, 23, 0, 48, 546, DateTimeKind.Local).AddTicks(6087), 93, new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("079d49a5-3ecc-48e4-b220-b49ca2be358c"), new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new DateTime(2020, 3, 2, 23, 0, 48, 546, DateTimeKind.Local).AddTicks(7286), 85, new Guid("f4978b1f-c59f-4ac1-9bf4-20a28e82ea1d") });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "CourseId", "Date", "ScoreOver100", "StudentId" },
                values: new object[] { new Guid("26567141-155a-45d9-a392-82b87a44a58a"), new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new DateTime(2020, 2, 14, 23, 0, 48, 546, DateTimeKind.Local).AddTicks(7347), 100, new Guid("f4978b1f-c59f-4ac1-9bf4-20a28e82ea1d") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343"), new Guid("a09df384-2dca-4dc3-850f-c064c46fabee") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("d31ec319-cc9b-4ec1-8591-dc9204c74217"), new Guid("995c68d3-ce71-4b3e-b8a3-3e5fe52c9343"), new Guid("c988523e-be5f-4e81-929c-1341c54bbe32") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new Guid("f4978b1f-c59f-4ac1-9bf4-20a28e82ea1d"), new Guid("a09df384-2dca-4dc3-850f-c064c46fabee") });

            migrationBuilder.InsertData(
                table: "TakenCourseStudents",
                columns: new[] { "CourseId", "StudentId", "CourseTeacherId" },
                values: new object[] { new Guid("7993eeda-454f-4abb-bd79-b014eeb50e9f"), new Guid("f4978b1f-c59f-4ac1-9bf4-20a28e82ea1d"), new Guid("a09df384-2dca-4dc3-850f-c064c46fabee") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new Guid("a09df384-2dca-4dc3-850f-c064c46fabee") });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId" },
                values: new object[] { new Guid("d8c0c776-f67a-49bd-a63e-38a0da29ab60"), new Guid("65be49c1-0b5c-4cce-a4fb-ce5d2a8206ba") });
        }
    }
}
