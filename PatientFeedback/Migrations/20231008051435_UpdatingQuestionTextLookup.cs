using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PatientFeedback.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingQuestionTextLookup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FamilyName", "GivenName" },
                values: new object[] { new Guid("0595a169-c30b-4643-b6ab-a0fb015dfccf"), "Careful", "Adam" });

            migrationBuilder.InsertData(
                table: "FeedbackQuestions",
                columns: new[] { "Id", "QuestionName", "QuestionType", "Text" },
                values: new object[,]
                {
                    { new Guid("2b48810a-3c83-4c85-96cd-5afa1c5f2c04"), "DoctorRecommendRating", 1, "Hi {patient_first_name}, on a scale of 1-10, would you recommend Dr {doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend" },
                    { new Guid("3c03fc88-71bf-40a1-b108-95a894ee3b2c"), "HelpfulDiagnosisExplanation", 0, "Thank you. You were diagnosed with {diagnosis}. Did Dr {doctor_last_name} explain how to manage this diagnosis in a way you could understand?" },
                    { new Guid("c0ba5f72-8efa-4ea3-9b31-48de48b5b94e"), "DiagnosisReflection", 2, "We appreciate the feedback, one last question: how do you feel about being diagnosed with {diagnosis}?" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Active", "BirthDate", "FamilyName", "Gender", "GivenName" },
                values: new object[] { new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"), true, new DateTime(1998, 10, 8, 5, 14, 34, 909, DateTimeKind.Utc).AddTicks(670), "Tenderson", "Male", "Tendo" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressType", "PatientId", "StreetAddress" },
                values: new object[] { new Guid("3a9d44ef-ef88-40c7-94d0-acbc8f7cf5c2"), "home", new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"), "2222 Home Street" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentType", "DoctorId", "End", "PatientId", "Start", "Status" },
                values: new object[] { new Guid("e739d74c-ee9a-418a-9b73-8ba33ade3dd8"), "Endocrinologist visit", new Guid("0595a169-c30b-4643-b6ab-a0fb015dfccf"), new DateTime(2023, 10, 8, 7, 14, 34, 909, DateTimeKind.Utc).AddTicks(770), new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"), new DateTime(2023, 10, 8, 5, 14, 34, 909, DateTimeKind.Utc).AddTicks(770), "finished" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "ContactSystem", "ContactType", "PatientId", "Value" },
                values: new object[,]
                {
                    { new Guid("0fc14ca8-c50c-43c0-8afc-6784a437f656"), 0, 0, new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"), "555-555-2021" },
                    { new Guid("8e944b7e-e1e8-47c3-841d-b2fc1c56ce89"), 1, 1, new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"), "tendo@tendoco.com" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbacks",
                columns: new[] { "Id", "AppointmentId", "SubmittedDate" },
                values: new object[] { new Guid("a345de57-4482-407f-98e8-1a809cf8f59f"), new Guid("e739d74c-ee9a-418a-9b73-8ba33ade3dd8"), null });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "AppointmentId", "LastUpdated", "Status" },
                values: new object[] { new Guid("9e398841-bb67-4764-932f-415be8789275"), new Guid("e739d74c-ee9a-418a-9b73-8ba33ade3dd8"), new DateTime(2023, 10, 8, 5, 14, 34, 909, DateTimeKind.Utc).AddTicks(910), "Final" });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbackQuestions",
                columns: new[] { "Id", "AppointmentFeedbackId", "FeedbackAnswerId", "FeedbackQuestionId", "Order" },
                values: new object[,]
                {
                    { new Guid("8cd18acd-b2c3-4ed6-9be8-5b12ddac9f4b"), new Guid("a345de57-4482-407f-98e8-1a809cf8f59f"), null, new Guid("c0ba5f72-8efa-4ea3-9b31-48de48b5b94e"), 3 },
                    { new Guid("94464071-897b-486c-b4ab-ad5298ea4707"), new Guid("a345de57-4482-407f-98e8-1a809cf8f59f"), null, new Guid("3c03fc88-71bf-40a1-b108-95a894ee3b2c"), 2 },
                    { new Guid("a0020c7f-9622-4378-aff4-1a8b70a14c18"), new Guid("a345de57-4482-407f-98e8-1a809cf8f59f"), null, new Guid("2b48810a-3c83-4c85-96cd-5afa1c5f2c04"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Codings",
                columns: new[] { "Id", "Code", "DiagnosisId", "Name", "System" },
                values: new object[] { new Guid("f6d0043c-0ac1-4bc3-9404-bbcde50deedc"), "E10-E14.9", new Guid("9e398841-bb67-4764-932f-415be8789275"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("3a9d44ef-ef88-40c7-94d0-acbc8f7cf5c2"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("8cd18acd-b2c3-4ed6-9be8-5b12ddac9f4b"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("94464071-897b-486c-b4ab-ad5298ea4707"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("a0020c7f-9622-4378-aff4-1a8b70a14c18"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("f6d0043c-0ac1-4bc3-9404-bbcde50deedc"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("0fc14ca8-c50c-43c0-8afc-6784a437f656"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("8e944b7e-e1e8-47c3-841d-b2fc1c56ce89"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbacks",
                keyColumn: "Id",
                keyValue: new Guid("a345de57-4482-407f-98e8-1a809cf8f59f"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("9e398841-bb67-4764-932f-415be8789275"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2b48810a-3c83-4c85-96cd-5afa1c5f2c04"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("3c03fc88-71bf-40a1-b108-95a894ee3b2c"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("c0ba5f72-8efa-4ea3-9b31-48de48b5b94e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e739d74c-ee9a-418a-9b73-8ba33ade3dd8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0595a169-c30b-4643-b6ab-a0fb015dfccf"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"));

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
    }
}
