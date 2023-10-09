using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PatientFeedback.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingModelAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2aac1a7d-b331-4f0a-b45c-4d7733c26708"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("40c67ccb-faec-471c-aff0-8d6f9f124c33"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("7c6f4459-6165-42cd-8694-7bc740795474"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("9d2a381f-ead5-4de2-b6a1-faf83996dc46"));

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
                table: "AppointmentFeedbacks",
                keyColumn: "Id",
                keyValue: new Guid("9858a67b-02f6-4f1a-9f28-39ddae2367f9"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("1b3e3f11-fee1-4dc0-ae61-5cf964ec3b1d"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("9ac4728d-b4b6-454c-8cf4-13cbe1b657c6"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("a826ba92-a322-4b47-96e5-ec37e6a1e2ea"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("c0fb9d23-c54b-403d-8688-7ee4bfeb6a4d"));

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

            migrationBuilder.AddColumn<string>(
                name: "QuestionName",
                table: "FeedbackQuestions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FamilyName", "GivenName" },
                values: new object[] { new Guid("23efd273-bcfe-443f-ad1a-b625e612dff1"), "Careful", "Adam" });

            migrationBuilder.InsertData(
                table: "FeedbackQuestions",
                columns: new[] { "Id", "QuestionName", "QuestionType", "Text" },
                values: new object[,]
                {
                    { new Guid("2dc8dbe5-5c94-49a7-a49a-d23cc63b9494"), "DiagnosisReflection", 2, "We appreciate the feedback, one last question: how do you feel about being diagnosed with {key=diagnosis}?" },
                    { new Guid("6f3b8e33-3f09-46f2-b121-49b5aa881dad"), "DoctorRecommendRating", 1, "Hi {key=patient_first_name}, on a scale of 1-10, would you recommend Dr {key=doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend" },
                    { new Guid("fad52f3e-8681-4f5b-b8c3-e2cbf93d6c69"), "HelpfulDiagnosisExplanation", 0, "Thank you. You were diagnosed with {key=diagnosis}. Did Dr {key=doctor_last_name} explain how to manage this diagnosis in a way you could understand?" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Active", "BirthDate", "FamilyName", "Gender", "GivenName" },
                values: new object[] { new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"), true, new DateTime(1998, 10, 8, 4, 6, 32, 373, DateTimeKind.Utc).AddTicks(8150), "Tenderson", "Male", "Tendo" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressType", "PatientId", "StreetAddress" },
                values: new object[] { new Guid("dba2dee6-fc5c-42f7-8c4e-7262b807393b"), "home", new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"), "2222 Home Street" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentType", "DoctorId", "End", "PatientId", "Start", "Status" },
                values: new object[] { new Guid("d3af5d90-3c97-4870-9e29-b037bf630d76"), "Endocrinologist visit", new Guid("23efd273-bcfe-443f-ad1a-b625e612dff1"), new DateTime(2023, 10, 8, 6, 6, 32, 373, DateTimeKind.Utc).AddTicks(8240), new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"), new DateTime(2023, 10, 8, 4, 6, 32, 373, DateTimeKind.Utc).AddTicks(8240), "finished" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "ContactSystem", "ContactType", "PatientId", "Value" },
                values: new object[,]
                {
                    { new Guid("2a758473-4b8e-4bdd-94af-d7eb337d1aa7"), 1, 1, new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"), "tendo@tendoco.com" },
                    { new Guid("5eea83a8-3120-4122-a216-a84447c824f1"), 0, 0, new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"), "555-555-2021" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbacks",
                columns: new[] { "Id", "AppointmentId", "SubmittedDate" },
                values: new object[] { new Guid("0bc3b7fb-c5e9-4016-9d26-51ad552b1685"), new Guid("d3af5d90-3c97-4870-9e29-b037bf630d76"), null });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "AppointmentId", "LastUpdated", "Status" },
                values: new object[] { new Guid("08fb0cb9-b60e-4540-a34a-207a2f202a77"), new Guid("d3af5d90-3c97-4870-9e29-b037bf630d76"), new DateTime(2023, 10, 8, 4, 6, 32, 373, DateTimeKind.Utc).AddTicks(8370), "Final" });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbackQuestions",
                columns: new[] { "Id", "AppointmentFeedbackId", "FeedbackAnswerId", "FeedbackQuestionId", "Order" },
                values: new object[,]
                {
                    { new Guid("61b6e832-243b-4ef4-a017-8d5562f55ee3"), new Guid("0bc3b7fb-c5e9-4016-9d26-51ad552b1685"), null, new Guid("2dc8dbe5-5c94-49a7-a49a-d23cc63b9494"), 3 },
                    { new Guid("6e197cc9-e121-4374-89ce-a8372b3d148a"), new Guid("0bc3b7fb-c5e9-4016-9d26-51ad552b1685"), null, new Guid("fad52f3e-8681-4f5b-b8c3-e2cbf93d6c69"), 2 },
                    { new Guid("b43d87ed-9523-41f5-926a-9ba159514928"), new Guid("0bc3b7fb-c5e9-4016-9d26-51ad552b1685"), null, new Guid("6f3b8e33-3f09-46f2-b121-49b5aa881dad"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Codings",
                columns: new[] { "Id", "Code", "DiagnosisId", "Name", "System" },
                values: new object[] { new Guid("babef60f-0ea9-40db-b237-b3247ac4172d"), "E10-E14.9", new Guid("08fb0cb9-b60e-4540-a34a-207a2f202a77"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("dba2dee6-fc5c-42f7-8c4e-7262b807393b"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("61b6e832-243b-4ef4-a017-8d5562f55ee3"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("6e197cc9-e121-4374-89ce-a8372b3d148a"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("b43d87ed-9523-41f5-926a-9ba159514928"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("babef60f-0ea9-40db-b237-b3247ac4172d"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("2a758473-4b8e-4bdd-94af-d7eb337d1aa7"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("5eea83a8-3120-4122-a216-a84447c824f1"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbacks",
                keyColumn: "Id",
                keyValue: new Guid("0bc3b7fb-c5e9-4016-9d26-51ad552b1685"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("08fb0cb9-b60e-4540-a34a-207a2f202a77"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2dc8dbe5-5c94-49a7-a49a-d23cc63b9494"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("6f3b8e33-3f09-46f2-b121-49b5aa881dad"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fad52f3e-8681-4f5b-b8c3-e2cbf93d6c69"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d3af5d90-3c97-4870-9e29-b037bf630d76"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("23efd273-bcfe-443f-ad1a-b625e612dff1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"));

            migrationBuilder.DropColumn(
                name: "QuestionName",
                table: "FeedbackQuestions");

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
        }
    }
}
