using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PatientFeedback.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalSeedDataV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5c59cdc8-a5ad-4adc-8ce4-d863b86f4f1e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("7cc8e5d6-0e31-4c5e-a04f-63f7d7a3446b"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a486b404-5c41-49e8-bdad-ffdd7e15b1d7"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("00f55ce7-6d82-49a2-af15-c37b4ad87e0d"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("0a027376-79d3-4fa1-bcab-3ff9f505807f"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("49299ed6-f461-4c9c-a4a6-f87413943361"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("4b713308-7424-4599-9855-4f16ba20bfbd"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("81627128-c7c7-48ff-aebe-d7f638f93274"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("bed8983b-346d-400b-9227-c9df519dcf00"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("c0062d96-2cbf-4f32-8f19-fe05bfa1cd42"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("e086f265-5a5f-4bd9-8cdb-dff0e5eb5a9d"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("e77121ba-00a0-4d76-8153-9eb79c01c5de"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("03f1e98d-abf1-4568-b3f7-6708897510ee"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("94ddb159-57b1-4e99-9324-eeaec2bc228d"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("b477a25c-e49e-4624-8a70-d60c02b814b5"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("01151a9c-5d70-4d5b-86c3-69a10296b3e5"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("0ac31000-3738-4e08-90de-a1c9435e0390"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("3d0281a2-f4f6-43fa-9a16-090139824314"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("45a8d5e3-7529-47f3-99df-0a21ed432e58"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("c89a8ebb-c6a8-4d32-8952-7c7de69e36bc"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("ed3f9c83-bd8d-4d69-8e32-789e279f5f83"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbacks",
                keyColumn: "Id",
                keyValue: new Guid("0b223c7c-4633-490e-a948-ec96de30df7c"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbacks",
                keyColumn: "Id",
                keyValue: new Guid("694cddf2-4484-403a-bc39-1b3c58f1ccc7"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbacks",
                keyColumn: "Id",
                keyValue: new Guid("6c266c17-0e94-456e-b99f-dd5b701dfa6b"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("d1566f14-ef91-4062-9daf-02561258aace"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("dbb58bba-b53f-4576-819b-34de9b963ad2"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("e4481ed3-f741-4656-bbdb-e207ef01b7ca"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("0ee8827c-60d8-4e2a-b705-7bd42e4b0d1b"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2a803f5c-1650-4bd3-9e25-25d1dbe74d33"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("3b1c4d85-5861-4b58-8a2e-9ad530f146aa"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("51fa092e-a1cb-47f1-82a4-19fa77065938"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("54871e72-8879-4575-a578-ed2db4140650"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("86c4db16-4943-4b67-9b64-676fef60c837"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("a3eeaa20-91f8-4267-a9ab-fbbb1ad7ef34"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("a4aaa835-0ced-4d34-94d0-d86a5579e35f"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("f63f1b26-ccd3-4cb3-9f26-4370e0889f14"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1db24bb3-2879-451d-9121-9a9e7b231d2d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8210fa30-8225-49b3-9c12-ed1e41e5aa10"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8a82a289-54b8-4c87-8294-685771900832"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("743d25f9-c461-4d2f-af06-8a1982921eca"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c968a944-2bbf-4d87-8dae-e1cdce063115"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ee8abb7d-dbbb-4b1c-ac13-274d9c87af7a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FamilyName", "GivenName" },
                values: new object[] { new Guid("0296f234-2103-4335-a88d-9afe08ddcf1c"), "Careful", "Adam" });

            migrationBuilder.InsertData(
                table: "FeedbackQuestions",
                columns: new[] { "Id", "QuestionName", "QuestionType", "Text" },
                values: new object[,]
                {
                    { new Guid("69bed495-4d57-4351-9928-36d5a4593baa"), "HelpfulDiagnosisExplanation", 0, "Thank you. You were diagnosed with {diagnosis}. Did Dr. {doctor_last_name} explain how to manage this diagnosis in a way you could understand?" },
                    { new Guid("bf858fd2-96ec-4de4-8b68-9ec60a5eb444"), "DoctorRecommendRating", 1, "Hi {patient_first_name}, on a scale of 1-10, would you recommend Dr. {doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend" },
                    { new Guid("cc5ce509-e9fc-4431-b3fc-cdecff341ebe"), "DiagnosisReflection", 2, "We appreciate the feedback, one last question: how do you feel about being diagnosed with {diagnosis}?" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Active", "BirthDate", "FamilyName", "Gender", "GivenName" },
                values: new object[] { new Guid("98ca4b72-dd7b-4bb1-9e25-4d13805dcd30"), true, new DateTime(1998, 10, 10, 5, 59, 52, 466, DateTimeKind.Utc).AddTicks(1850), "Tenderson", "Male", "Tendo" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressType", "PatientId", "StreetAddress" },
                values: new object[] { new Guid("cb047a9c-145a-4620-b585-33219d350d44"), "home", new Guid("98ca4b72-dd7b-4bb1-9e25-4d13805dcd30"), "2222 Home Street" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentType", "DoctorId", "End", "PatientId", "Start", "Status" },
                values: new object[,]
                {
                    { new Guid("d385736e-3aee-415b-99ca-497f9cc095c3"), "Endocrinologist visit", new Guid("0296f234-2103-4335-a88d-9afe08ddcf1c"), new DateTime(2023, 10, 10, 7, 59, 52, 466, DateTimeKind.Utc).AddTicks(1940), new Guid("98ca4b72-dd7b-4bb1-9e25-4d13805dcd30"), new DateTime(2023, 10, 10, 5, 59, 52, 466, DateTimeKind.Utc).AddTicks(1940), "finished" },
                    { new Guid("fa4b52bf-21c8-45d3-9527-f556dd0d5dab"), "Endocrinologist visit", new Guid("0296f234-2103-4335-a88d-9afe08ddcf1c"), new DateTime(2023, 10, 10, 7, 59, 52, 466, DateTimeKind.Utc).AddTicks(1950), new Guid("98ca4b72-dd7b-4bb1-9e25-4d13805dcd30"), new DateTime(2023, 10, 10, 5, 59, 52, 466, DateTimeKind.Utc).AddTicks(1950), "finished" },
                    { new Guid("fd85b9ce-94e8-4852-95ca-c2939e1ea15c"), "Endocrinologist visit", new Guid("0296f234-2103-4335-a88d-9afe08ddcf1c"), new DateTime(2023, 10, 10, 7, 59, 52, 466, DateTimeKind.Utc).AddTicks(1950), new Guid("98ca4b72-dd7b-4bb1-9e25-4d13805dcd30"), new DateTime(2023, 10, 10, 5, 59, 52, 466, DateTimeKind.Utc).AddTicks(1950), "finished" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "ContactSystem", "ContactType", "PatientId", "Value" },
                values: new object[,]
                {
                    { new Guid("00515cfa-c012-4d40-87b0-75727e34630f"), 1, 1, new Guid("98ca4b72-dd7b-4bb1-9e25-4d13805dcd30"), "tendo@tendoco.com" },
                    { new Guid("5c24df65-006e-4370-b2c4-d8240816fcea"), 0, 0, new Guid("98ca4b72-dd7b-4bb1-9e25-4d13805dcd30"), "555-555-2021" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbacks",
                columns: new[] { "Id", "AppointmentId", "SubmittedDate" },
                values: new object[,]
                {
                    { new Guid("50176c20-51b2-4a1c-93c9-58490260ee7c"), new Guid("fd85b9ce-94e8-4852-95ca-c2939e1ea15c"), null },
                    { new Guid("557c6414-9e81-42fa-9121-c7f8579f9ba4"), new Guid("fa4b52bf-21c8-45d3-9527-f556dd0d5dab"), null },
                    { new Guid("a648b400-4f7a-4a99-bbc7-5fe218d02768"), new Guid("d385736e-3aee-415b-99ca-497f9cc095c3"), null }
                });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "AppointmentId", "LastUpdated", "Status" },
                values: new object[,]
                {
                    { new Guid("122d69de-1406-42e9-95be-f9a7d1b60719"), new Guid("fd85b9ce-94e8-4852-95ca-c2939e1ea15c"), new DateTime(2023, 10, 10, 5, 59, 52, 466, DateTimeKind.Utc).AddTicks(2110), "Final" },
                    { new Guid("ae780c06-7554-4311-a0e5-6641a373fd44"), new Guid("d385736e-3aee-415b-99ca-497f9cc095c3"), new DateTime(2023, 10, 10, 5, 59, 52, 466, DateTimeKind.Utc).AddTicks(2110), "Final" },
                    { new Guid("e02a180c-d447-471d-ab0a-d93eb4e47c79"), new Guid("fa4b52bf-21c8-45d3-9527-f556dd0d5dab"), new DateTime(2023, 10, 10, 5, 59, 52, 466, DateTimeKind.Utc).AddTicks(2120), "Final" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbackQuestions",
                columns: new[] { "Id", "AppointmentFeedbackId", "FeedbackAnswerId", "FeedbackQuestionId", "Order" },
                values: new object[,]
                {
                    { new Guid("0540be5e-813e-4e39-81a0-5b8438e058e5"), new Guid("50176c20-51b2-4a1c-93c9-58490260ee7c"), null, new Guid("bf858fd2-96ec-4de4-8b68-9ec60a5eb444"), 1 },
                    { new Guid("0d7d6b95-7516-489e-a2e8-3ff680d9c6d5"), new Guid("557c6414-9e81-42fa-9121-c7f8579f9ba4"), null, new Guid("cc5ce509-e9fc-4431-b3fc-cdecff341ebe"), 1 },
                    { new Guid("187e153d-ce7c-4870-9a28-60d6476a3739"), new Guid("a648b400-4f7a-4a99-bbc7-5fe218d02768"), null, new Guid("bf858fd2-96ec-4de4-8b68-9ec60a5eb444"), 1 },
                    { new Guid("4046fe14-b22e-48e0-95cc-09b95dc73eaa"), new Guid("a648b400-4f7a-4a99-bbc7-5fe218d02768"), null, new Guid("cc5ce509-e9fc-4431-b3fc-cdecff341ebe"), 3 },
                    { new Guid("8072f4b7-9ea1-4b17-b3a7-5153bac1174d"), new Guid("557c6414-9e81-42fa-9121-c7f8579f9ba4"), null, new Guid("69bed495-4d57-4351-9928-36d5a4593baa"), 2 },
                    { new Guid("85636ca4-2982-4169-a06b-309328bf58eb"), new Guid("50176c20-51b2-4a1c-93c9-58490260ee7c"), null, new Guid("69bed495-4d57-4351-9928-36d5a4593baa"), 2 },
                    { new Guid("98eb6791-620d-47b1-9532-5aeb62e98ff4"), new Guid("557c6414-9e81-42fa-9121-c7f8579f9ba4"), null, new Guid("bf858fd2-96ec-4de4-8b68-9ec60a5eb444"), 3 },
                    { new Guid("b312d5a0-b7ee-4aa6-b540-ca82e935ae0e"), new Guid("a648b400-4f7a-4a99-bbc7-5fe218d02768"), null, new Guid("69bed495-4d57-4351-9928-36d5a4593baa"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Codings",
                columns: new[] { "Id", "Code", "DiagnosisId", "Name", "System" },
                values: new object[,]
                {
                    { new Guid("20aea0a0-2777-4f24-b97d-8d8d98ae9b38"), "E10-E14.9", new Guid("e02a180c-d447-471d-ab0a-d93eb4e47c79"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" },
                    { new Guid("3eb3eb6c-78d2-4030-a7ae-72350285a289"), "E10-E14.9", new Guid("ae780c06-7554-4311-a0e5-6641a373fd44"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" },
                    { new Guid("a56a8874-02dc-412b-bcbf-670ca70a4337"), "E10-E14.9", new Guid("122d69de-1406-42e9-95be-f9a7d1b60719"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cb047a9c-145a-4620-b585-33219d350d44"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("0540be5e-813e-4e39-81a0-5b8438e058e5"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("0d7d6b95-7516-489e-a2e8-3ff680d9c6d5"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("187e153d-ce7c-4870-9a28-60d6476a3739"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("4046fe14-b22e-48e0-95cc-09b95dc73eaa"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("8072f4b7-9ea1-4b17-b3a7-5153bac1174d"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("85636ca4-2982-4169-a06b-309328bf58eb"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("98eb6791-620d-47b1-9532-5aeb62e98ff4"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("b312d5a0-b7ee-4aa6-b540-ca82e935ae0e"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("20aea0a0-2777-4f24-b97d-8d8d98ae9b38"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("3eb3eb6c-78d2-4030-a7ae-72350285a289"));

            migrationBuilder.DeleteData(
                table: "Codings",
                keyColumn: "Id",
                keyValue: new Guid("a56a8874-02dc-412b-bcbf-670ca70a4337"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("00515cfa-c012-4d40-87b0-75727e34630f"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("5c24df65-006e-4370-b2c4-d8240816fcea"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbacks",
                keyColumn: "Id",
                keyValue: new Guid("50176c20-51b2-4a1c-93c9-58490260ee7c"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbacks",
                keyColumn: "Id",
                keyValue: new Guid("557c6414-9e81-42fa-9121-c7f8579f9ba4"));

            migrationBuilder.DeleteData(
                table: "AppointmentFeedbacks",
                keyColumn: "Id",
                keyValue: new Guid("a648b400-4f7a-4a99-bbc7-5fe218d02768"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("122d69de-1406-42e9-95be-f9a7d1b60719"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("ae780c06-7554-4311-a0e5-6641a373fd44"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: new Guid("e02a180c-d447-471d-ab0a-d93eb4e47c79"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("69bed495-4d57-4351-9928-36d5a4593baa"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("bf858fd2-96ec-4de4-8b68-9ec60a5eb444"));

            migrationBuilder.DeleteData(
                table: "FeedbackQuestions",
                keyColumn: "Id",
                keyValue: new Guid("cc5ce509-e9fc-4431-b3fc-cdecff341ebe"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d385736e-3aee-415b-99ca-497f9cc095c3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fa4b52bf-21c8-45d3-9527-f556dd0d5dab"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fd85b9ce-94e8-4852-95ca-c2939e1ea15c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0296f234-2103-4335-a88d-9afe08ddcf1c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("98ca4b72-dd7b-4bb1-9e25-4d13805dcd30"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FamilyName", "GivenName" },
                values: new object[,]
                {
                    { new Guid("743d25f9-c461-4d2f-af06-8a1982921eca"), "Careful", "Adam" },
                    { new Guid("c968a944-2bbf-4d87-8dae-e1cdce063115"), "Careful", "Adam" },
                    { new Guid("ee8abb7d-dbbb-4b1c-ac13-274d9c87af7a"), "Careful", "Adam" }
                });

            migrationBuilder.InsertData(
                table: "FeedbackQuestions",
                columns: new[] { "Id", "QuestionName", "QuestionType", "Text" },
                values: new object[,]
                {
                    { new Guid("0ee8827c-60d8-4e2a-b705-7bd42e4b0d1b"), "HelpfulDiagnosisExplanation", 0, "Thank you. You were diagnosed with {diagnosis}. Did Dr. {doctor_last_name} explain how to manage this diagnosis in a way you could understand?" },
                    { new Guid("2a803f5c-1650-4bd3-9e25-25d1dbe74d33"), "DiagnosisReflection", 2, "We appreciate the feedback, one last question: how do you feel about being diagnosed with {diagnosis}?" },
                    { new Guid("3b1c4d85-5861-4b58-8a2e-9ad530f146aa"), "DoctorRecommendRating", 1, "Hi {patient_first_name}, on a scale of 1-10, would you recommend Dr. {doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend" },
                    { new Guid("51fa092e-a1cb-47f1-82a4-19fa77065938"), "HelpfulDiagnosisExplanation", 0, "Thank you. You were diagnosed with {diagnosis}. Did Dr. {doctor_last_name} explain how to manage this diagnosis in a way you could understand?" },
                    { new Guid("54871e72-8879-4575-a578-ed2db4140650"), "DoctorRecommendRating", 1, "Hi {patient_first_name}, on a scale of 1-10, would you recommend Dr. {doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend" },
                    { new Guid("86c4db16-4943-4b67-9b64-676fef60c837"), "DoctorRecommendRating", 1, "Hi {patient_first_name}, on a scale of 1-10, would you recommend Dr. {doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend" },
                    { new Guid("a3eeaa20-91f8-4267-a9ab-fbbb1ad7ef34"), "DiagnosisReflection", 2, "We appreciate the feedback, one last question: how do you feel about being diagnosed with {diagnosis}?" },
                    { new Guid("a4aaa835-0ced-4d34-94d0-d86a5579e35f"), "DiagnosisReflection", 2, "We appreciate the feedback, one last question: how do you feel about being diagnosed with {diagnosis}?" },
                    { new Guid("f63f1b26-ccd3-4cb3-9f26-4370e0889f14"), "HelpfulDiagnosisExplanation", 0, "Thank you. You were diagnosed with {diagnosis}. Did Dr. {doctor_last_name} explain how to manage this diagnosis in a way you could understand?" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Active", "BirthDate", "FamilyName", "Gender", "GivenName" },
                values: new object[,]
                {
                    { new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"), true, new DateTime(1998, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(7160), "Tenderson", "Male", "Tendo" },
                    { new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"), true, new DateTime(1998, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6950), "Tenderson", "Male", "Tendo" },
                    { new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"), true, new DateTime(1998, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6740), "Tenderson", "Male", "Tendo" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressType", "PatientId", "StreetAddress" },
                values: new object[,]
                {
                    { new Guid("5c59cdc8-a5ad-4adc-8ce4-d863b86f4f1e"), "home", new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"), "2222 Home Street" },
                    { new Guid("7cc8e5d6-0e31-4c5e-a04f-63f7d7a3446b"), "home", new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"), "2222 Home Street" },
                    { new Guid("a486b404-5c41-49e8-bdad-ffdd7e15b1d7"), "home", new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"), "2222 Home Street" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentType", "DoctorId", "End", "PatientId", "Start", "Status" },
                values: new object[,]
                {
                    { new Guid("1db24bb3-2879-451d-9121-9a9e7b231d2d"), "Endocrinologist visit", new Guid("743d25f9-c461-4d2f-af06-8a1982921eca"), new DateTime(2023, 10, 10, 7, 53, 54, 531, DateTimeKind.Utc).AddTicks(6990), new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"), new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6990), "finished" },
                    { new Guid("8210fa30-8225-49b3-9c12-ed1e41e5aa10"), "Endocrinologist visit", new Guid("c968a944-2bbf-4d87-8dae-e1cdce063115"), new DateTime(2023, 10, 10, 7, 53, 54, 531, DateTimeKind.Utc).AddTicks(6810), new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"), new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6810), "finished" },
                    { new Guid("8a82a289-54b8-4c87-8294-685771900832"), "Endocrinologist visit", new Guid("ee8abb7d-dbbb-4b1c-ac13-274d9c87af7a"), new DateTime(2023, 10, 10, 7, 53, 54, 531, DateTimeKind.Utc).AddTicks(7190), new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"), new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(7190), "finished" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "ContactSystem", "ContactType", "PatientId", "Value" },
                values: new object[,]
                {
                    { new Guid("01151a9c-5d70-4d5b-86c3-69a10296b3e5"), 1, 1, new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"), "tendo@tendoco.com" },
                    { new Guid("0ac31000-3738-4e08-90de-a1c9435e0390"), 0, 0, new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"), "555-555-2021" },
                    { new Guid("3d0281a2-f4f6-43fa-9a16-090139824314"), 1, 1, new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"), "tendo@tendoco.com" },
                    { new Guid("45a8d5e3-7529-47f3-99df-0a21ed432e58"), 1, 1, new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"), "tendo@tendoco.com" },
                    { new Guid("c89a8ebb-c6a8-4d32-8952-7c7de69e36bc"), 0, 0, new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"), "555-555-2021" },
                    { new Guid("ed3f9c83-bd8d-4d69-8e32-789e279f5f83"), 0, 0, new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"), "555-555-2021" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbacks",
                columns: new[] { "Id", "AppointmentId", "SubmittedDate" },
                values: new object[,]
                {
                    { new Guid("0b223c7c-4633-490e-a948-ec96de30df7c"), new Guid("8210fa30-8225-49b3-9c12-ed1e41e5aa10"), null },
                    { new Guid("694cddf2-4484-403a-bc39-1b3c58f1ccc7"), new Guid("1db24bb3-2879-451d-9121-9a9e7b231d2d"), null },
                    { new Guid("6c266c17-0e94-456e-b99f-dd5b701dfa6b"), new Guid("8a82a289-54b8-4c87-8294-685771900832"), null }
                });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "AppointmentId", "LastUpdated", "Status" },
                values: new object[,]
                {
                    { new Guid("d1566f14-ef91-4062-9daf-02561258aace"), new Guid("8a82a289-54b8-4c87-8294-685771900832"), new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(7240), "Final" },
                    { new Guid("dbb58bba-b53f-4576-819b-34de9b963ad2"), new Guid("8210fa30-8225-49b3-9c12-ed1e41e5aa10"), new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6890), "Final" },
                    { new Guid("e4481ed3-f741-4656-bbdb-e207ef01b7ca"), new Guid("1db24bb3-2879-451d-9121-9a9e7b231d2d"), new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(7110), "Final" }
                });

            migrationBuilder.InsertData(
                table: "AppointmentFeedbackQuestions",
                columns: new[] { "Id", "AppointmentFeedbackId", "FeedbackAnswerId", "FeedbackQuestionId", "Order" },
                values: new object[,]
                {
                    { new Guid("00f55ce7-6d82-49a2-af15-c37b4ad87e0d"), new Guid("694cddf2-4484-403a-bc39-1b3c58f1ccc7"), null, new Guid("f63f1b26-ccd3-4cb3-9f26-4370e0889f14"), 2 },
                    { new Guid("0a027376-79d3-4fa1-bcab-3ff9f505807f"), new Guid("0b223c7c-4633-490e-a948-ec96de30df7c"), null, new Guid("86c4db16-4943-4b67-9b64-676fef60c837"), 1 },
                    { new Guid("49299ed6-f461-4c9c-a4a6-f87413943361"), new Guid("0b223c7c-4633-490e-a948-ec96de30df7c"), null, new Guid("51fa092e-a1cb-47f1-82a4-19fa77065938"), 2 },
                    { new Guid("4b713308-7424-4599-9855-4f16ba20bfbd"), new Guid("694cddf2-4484-403a-bc39-1b3c58f1ccc7"), null, new Guid("3b1c4d85-5861-4b58-8a2e-9ad530f146aa"), 1 },
                    { new Guid("81627128-c7c7-48ff-aebe-d7f638f93274"), new Guid("6c266c17-0e94-456e-b99f-dd5b701dfa6b"), null, new Guid("54871e72-8879-4575-a578-ed2db4140650"), 1 },
                    { new Guid("bed8983b-346d-400b-9227-c9df519dcf00"), new Guid("6c266c17-0e94-456e-b99f-dd5b701dfa6b"), null, new Guid("0ee8827c-60d8-4e2a-b705-7bd42e4b0d1b"), 2 },
                    { new Guid("c0062d96-2cbf-4f32-8f19-fe05bfa1cd42"), new Guid("0b223c7c-4633-490e-a948-ec96de30df7c"), null, new Guid("a4aaa835-0ced-4d34-94d0-d86a5579e35f"), 3 },
                    { new Guid("e086f265-5a5f-4bd9-8cdb-dff0e5eb5a9d"), new Guid("694cddf2-4484-403a-bc39-1b3c58f1ccc7"), null, new Guid("2a803f5c-1650-4bd3-9e25-25d1dbe74d33"), 3 },
                    { new Guid("e77121ba-00a0-4d76-8153-9eb79c01c5de"), new Guid("6c266c17-0e94-456e-b99f-dd5b701dfa6b"), null, new Guid("a3eeaa20-91f8-4267-a9ab-fbbb1ad7ef34"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Codings",
                columns: new[] { "Id", "Code", "DiagnosisId", "Name", "System" },
                values: new object[,]
                {
                    { new Guid("03f1e98d-abf1-4568-b3f7-6708897510ee"), "E10-E14.9", new Guid("dbb58bba-b53f-4576-819b-34de9b963ad2"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" },
                    { new Guid("94ddb159-57b1-4e99-9324-eeaec2bc228d"), "E10-E14.9", new Guid("e4481ed3-f741-4656-bbdb-e207ef01b7ca"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" },
                    { new Guid("b477a25c-e49e-4624-8a70-d60c02b814b5"), "E10-E14.9", new Guid("d1566f14-ef91-4062-9daf-02561258aace"), "Diabetes without complications", "http://hl7.org/fhir/sid/icd-10" }
                });
        }
    }
}
