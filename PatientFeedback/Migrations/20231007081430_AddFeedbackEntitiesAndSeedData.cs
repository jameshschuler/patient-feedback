using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PatientFeedback.Migrations
{
    /// <inheritdoc />
    public partial class AddFeedbackEntitiesAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5386c348-7c73-4186-9dc6-108bd586bbd8"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("37cffebc-cde2-48b0-a9a5-115c62c115fb"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("b0998557-7a85-44a8-ba5b-73b9c00950f7"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("f0b6120e-aa97-45b8-bc6d-96e5c78cff05"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("8238c523-aacd-436d-8129-4cf478c5d530"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f361cda8-15bf-462e-959b-759960f4fc78"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d7152498-94cb-4a09-bd8d-0a133e61a015"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ab90917a-8668-4286-bf97-65cd56891a93"));

            migrationBuilder.CreateTable(
                name: "AppointmentFeedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AppointmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentFeedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentFeedbacks_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackAnswers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackAnswers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    QuestionType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentFeedbackQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    AppointmentFeedbackId = table.Column<Guid>(type: "uuid", nullable: false),
                    FeedbackQuestionId = table.Column<Guid>(type: "uuid", nullable: false),
                    FeedbackAnswerId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentFeedbackQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentFeedbackQuestions_AppointmentFeedbacks_Appointme~",
                        column: x => x.AppointmentFeedbackId,
                        principalTable: "AppointmentFeedbacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentFeedbackQuestions_FeedbackAnswers_FeedbackAnswer~",
                        column: x => x.FeedbackAnswerId,
                        principalTable: "FeedbackAnswers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppointmentFeedbackQuestions_FeedbackQuestions_FeedbackQues~",
                        column: x => x.FeedbackQuestionId,
                        principalTable: "FeedbackQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FamilyName", "GivenName" },
                values: new object[] { new Guid("7bc1dbb0-0f8f-4594-92c7-2d7a49bc49f3"), "Careful", "Adam" });

            migrationBuilder.InsertData(
                table: "FeedbackQuestions",
                columns: new[] { "Id", "QuestionType", "Text" },
                values: new object[,]
                {
                    { new Guid("9ac4728d-b4b6-454c-8cf4-13cbe1b657c6"), 2, "We appreciate the feedback, one last question: how do you feel about being diagnosed with [diagnosis]?" },
                    { new Guid("a826ba92-a322-4b47-96e5-ec37e6a1e2ea"), 0, "Thank you. You were diagnosed with [diagnosis]. Did Dr [doctor_last_name] explain how to manage this diagnosis in a way you could understand?" },
                    { new Guid("c0fb9d23-c54b-403d-8688-7ee4bfeb6a4d"), 1, "Hi [patient_first_name], on a scale of 1-10, would you recommend Dr [doctor_last_name] to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Active", "BirthDate", "FamilyName", "Gender", "GivenName" },
                values: new object[] { new Guid("84e5cef0-2aed-4a9a-98bf-f00197713e73"), true, new DateTime(1998, 10, 7, 8, 14, 30, 97, DateTimeKind.Utc).AddTicks(4380), "Tenderson", "Male", "Tendo" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressType", "PatientId", "StreetAddress" },
                values: new object[] { new Guid("2aac1a7d-b331-4f0a-b45c-4d7733c26708"), "home", new Guid("84e5cef0-2aed-4a9a-98bf-f00197713e73"), "2222 Home Street" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentType", "DoctorId", "End", "PatientId", "Start", "Status" },
                values: new object[] { new Guid("64f1b5a0-1f6e-4e59-ae95-a94b34e5619c"), "Endocrinologist visit", new Guid("7bc1dbb0-0f8f-4594-92c7-2d7a49bc49f3"), new DateTime(2023, 10, 7, 10, 14, 30, 97, DateTimeKind.Utc).AddTicks(4460), new Guid("84e5cef0-2aed-4a9a-98bf-f00197713e73"), new DateTime(2023, 10, 7, 8, 14, 30, 97, DateTimeKind.Utc).AddTicks(4460), "finished" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "ContactSystem", "ContactType", "PatientId", "Value" },
                values: new object[,]
                {
                    { new Guid("3b831fab-e01c-43f3-9b18-d350ff4a79fe"), 1, 1, new Guid("84e5cef0-2aed-4a9a-98bf-f00197713e73"), "tendo@tendoco.com" },
                    { new Guid("439086b8-da4c-49cd-b1a9-3f8b96b297fc"), 0, 0, new Guid("84e5cef0-2aed-4a9a-98bf-f00197713e73"), "555-555-2021" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbacks",
                columns: new[] { "Id", "AppointmentId", "SubmittedDate" },
                values: new object[] { new Guid("9858a67b-02f6-4f1a-9f28-39ddae2367f9"), new Guid("64f1b5a0-1f6e-4e59-ae95-a94b34e5619c"), null });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "AppointmentId", "LastUpdated", "Status" },
                values: new object[] { new Guid("1b3e3f11-fee1-4dc0-ae61-5cf964ec3b1d"), new Guid("64f1b5a0-1f6e-4e59-ae95-a94b34e5619c"), new DateTime(2023, 10, 7, 8, 14, 30, 97, DateTimeKind.Utc).AddTicks(4540), "Final" });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbackQuestions",
                columns: new[] { "Id", "AppointmentFeedbackId", "FeedbackAnswerId", "FeedbackQuestionId", "Order" },
                values: new object[,]
                {
                    { new Guid("40c67ccb-faec-471c-aff0-8d6f9f124c33"), new Guid("9858a67b-02f6-4f1a-9f28-39ddae2367f9"), null, new Guid("a826ba92-a322-4b47-96e5-ec37e6a1e2ea"), 2 },
                    { new Guid("7c6f4459-6165-42cd-8694-7bc740795474"), new Guid("9858a67b-02f6-4f1a-9f28-39ddae2367f9"), null, new Guid("9ac4728d-b4b6-454c-8cf4-13cbe1b657c6"), 3 },
                    { new Guid("9d2a381f-ead5-4de2-b6a1-faf83996dc46"), new Guid("9858a67b-02f6-4f1a-9f28-39ddae2367f9"), null, new Guid("c0fb9d23-c54b-403d-8688-7ee4bfeb6a4d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Codings",
                columns: new[] { "Id", "Code", "DiagnosisId", "Name", "System" },
                values: new object[] { new Guid("fe388979-5dbc-4316-99ed-2bd4318588b6"), "E10-E14.9", new Guid("1b3e3f11-fee1-4dc0-ae61-5cf964ec3b1d"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentFeedbackQuestions_AppointmentFeedbackId",
                table: "AppointmentFeedbackQuestions",
                column: "AppointmentFeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentFeedbackQuestions_FeedbackAnswerId",
                table: "AppointmentFeedbackQuestions",
                column: "FeedbackAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentFeedbackQuestions_FeedbackQuestionId",
                table: "AppointmentFeedbackQuestions",
                column: "FeedbackQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentFeedbacks_AppointmentId",
                table: "AppointmentFeedbacks",
                column: "AppointmentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentFeedbackQuestions");

            migrationBuilder.DropTable(
                name: "AppointmentFeedbacks");

            migrationBuilder.DropTable(
                name: "FeedbackAnswers");

            migrationBuilder.DropTable(
                name: "FeedbackQuestions");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2aac1a7d-b331-4f0a-b45c-4d7733c26708"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("fe388979-5dbc-4316-99ed-2bd4318588b6"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("3b831fab-e01c-43f3-9b18-d350ff4a79fe"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("439086b8-da4c-49cd-b1a9-3f8b96b297fc"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("1b3e3f11-fee1-4dc0-ae61-5cf964ec3b1d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("64f1b5a0-1f6e-4e59-ae95-a94b34e5619c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7bc1dbb0-0f8f-4594-92c7-2d7a49bc49f3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("84e5cef0-2aed-4a9a-98bf-f00197713e73"));

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
        }
    }
}
