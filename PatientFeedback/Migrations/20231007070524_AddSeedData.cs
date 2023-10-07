using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PatientFeedback.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GivenName = table.Column<string>(type: "text", nullable: false),
                    FamilyName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GivenName = table.Column<string>(type: "text", nullable: false),
                    FamilyName = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StreetAddress = table.Column<string>(type: "text", nullable: false),
                    AddressType = table.Column<string>(type: "text", nullable: false),
                    PatientId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    AppointmentType = table.Column<string>(type: "text", nullable: false),
                    PatientId = table.Column<Guid>(type: "uuid", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactSystem = table.Column<int>(type: "integer", nullable: false),
                    ContactType = table.Column<int>(type: "integer", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: false),
                    PatientId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnoses_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Codings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    System = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DiagnosisId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Codings_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FamilyName", "GivenName" },
                values: new object[] { new Guid("d7152498-94cb-4a09-bd8d-0a133e61a015"), "Careful", "Adam" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Active", "BirthDate", "FamilyName", "Gender", "GivenName" },
                values: new object[] { new Guid("ab90917a-8668-4286-bf97-65cd56891a93"), true, new DateTime(1998, 10, 7, 7, 5, 23, 982, DateTimeKind.Utc).AddTicks(6100), "Tenderson", "Male", "Tendo" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressType", "PatientId", "StreetAddress" },
                values: new object[] { new Guid("5386c348-7c73-4186-9dc6-108bd586bbd8"), "home", new Guid("ab90917a-8668-4286-bf97-65cd56891a93"), "2222 Home Street" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentType", "DoctorId", "End", "PatientId", "Start", "Status" },
                values: new object[] { new Guid("f361cda8-15bf-462e-959b-759960f4fc78"), "Endocrinologist visit", new Guid("d7152498-94cb-4a09-bd8d-0a133e61a015"), new DateTime(2023, 10, 7, 9, 5, 23, 982, DateTimeKind.Utc).AddTicks(6270), new Guid("ab90917a-8668-4286-bf97-65cd56891a93"), new DateTime(2023, 10, 7, 7, 5, 23, 982, DateTimeKind.Utc).AddTicks(6260), "finished" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "ContactSystem", "ContactType", "PatientId", "Value" },
                values: new object[,]
                {
                    { new Guid("b0998557-7a85-44a8-ba5b-73b9c00950f7"), 1, 1, new Guid("ab90917a-8668-4286-bf97-65cd56891a93"), "tendo@tendoco.com" },
                    { new Guid("f0b6120e-aa97-45b8-bc6d-96e5c78cff05"), 0, 0, new Guid("ab90917a-8668-4286-bf97-65cd56891a93"), "555-555-2021" }
                });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "AppointmentId", "LastUpdated", "Status" },
                values: new object[] { new Guid("8238c523-aacd-436d-8129-4cf478c5d530"), new Guid("f361cda8-15bf-462e-959b-759960f4fc78"), new DateTime(2023, 10, 7, 7, 5, 23, 982, DateTimeKind.Utc).AddTicks(6300), "Final" });

            migrationBuilder.InsertData(
                table: "Codings",
                columns: new[] { "Id", "Code", "DiagnosisId", "Name", "System" },
                values: new object[] { new Guid("37cffebc-cde2-48b0-a9a5-115c62c115fb"), "E10-E14.9", new Guid("8238c523-aacd-436d-8129-4cf478c5d530"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PatientId",
                table: "Addresses",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Codings_DiagnosisId",
                table: "Codings",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PatientId",
                table: "Contacts",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_AppointmentId",
                table: "Diagnoses",
                column: "AppointmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Codings");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
