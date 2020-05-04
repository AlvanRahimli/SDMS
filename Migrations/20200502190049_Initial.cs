using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SDMS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<byte[]>(nullable: false),
                    RegistrtationStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CardNumber = table.Column<string>(nullable: false),
                    Password = table.Column<byte[]>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    CVPath = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    RegisterStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CardNumber = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<byte[]>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    RegisterStatus = table.Column<int>(nullable: false),
                    SpecialityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Credit = table.Column<int>(nullable: false),
                    AbsenceLimit = table.Column<int>(nullable: false),
                    SyllabusPath = table.Column<string>(nullable: true),
                    RequiredById = table.Column<Guid>(nullable: true),
                    TeacherId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Courses_RequiredById",
                        column: x => x.RequiredById,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Absences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StudentId = table.Column<Guid>(nullable: false),
                    CourseId = table.Column<Guid>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Absences_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Absences_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSpecialities",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(nullable: false),
                    SpecialityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSpecialities", x => new { x.SpecialityId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_CourseSpecialities_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSpecialities_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentCourseStudents",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(nullable: false),
                    StudentId = table.Column<Guid>(nullable: false),
                    CourseTeacherId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentCourseStudents", x => new { x.CourseId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_CurrentCourseStudents_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentCourseStudents_Teachers_CourseTeacherId",
                        column: x => x.CourseTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentCourseStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ScoreOver100 = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    StudentId = table.Column<Guid>(nullable: false),
                    CourseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scores_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scores_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TakenCourseStudents",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(nullable: false),
                    StudentId = table.Column<Guid>(nullable: false),
                    CourseTeacherId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakenCourseStudents", x => new { x.CourseId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_TakenCourseStudents_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TakenCourseStudents_Teachers_CourseTeacherId",
                        column: x => x.CourseTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TakenCourseStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCourses",
                columns: table => new
                {
                    TeacherId = table.Column<Guid>(nullable: false),
                    CourseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCourses", x => new { x.CourseId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_TeacherCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherCourses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Absences_CourseId",
                table: "Absences",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_StudentId",
                table: "Absences",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_RequiredById",
                table: "Courses",
                column: "RequiredById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSpecialities_CourseId",
                table: "CourseSpecialities",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentCourseStudents_CourseTeacherId",
                table: "CurrentCourseStudents",
                column: "CourseTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentCourseStudents_StudentId",
                table: "CurrentCourseStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_CourseId",
                table: "Scores",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_StudentId",
                table: "Scores",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SpecialityId",
                table: "Students",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_TakenCourseStudents_CourseTeacherId",
                table: "TakenCourseStudents",
                column: "CourseTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TakenCourseStudents_StudentId",
                table: "TakenCourseStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourses_TeacherId",
                table: "TeacherCourses",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absences");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CourseSpecialities");

            migrationBuilder.DropTable(
                name: "CurrentCourseStudents");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "TakenCourseStudents");

            migrationBuilder.DropTable(
                name: "TeacherCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
