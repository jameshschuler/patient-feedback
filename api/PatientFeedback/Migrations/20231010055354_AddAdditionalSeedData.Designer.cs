﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PatientFeedback;

#nullable disable

namespace PatientFeedback.Migrations
{
    [DbContext(typeof(PatientFeedbackContext))]
    [Migration("20231010055354_AddAdditionalSeedData")]
    partial class AddAdditionalSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PatientFeedback.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AddressType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a486b404-5c41-49e8-bdad-ffdd7e15b1d7"),
                            AddressType = "home",
                            PatientId = new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"),
                            StreetAddress = "2222 Home Street"
                        },
                        new
                        {
                            Id = new Guid("5c59cdc8-a5ad-4adc-8ce4-d863b86f4f1e"),
                            AddressType = "home",
                            PatientId = new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"),
                            StreetAddress = "2222 Home Street"
                        },
                        new
                        {
                            Id = new Guid("7cc8e5d6-0e31-4c5e-a04f-63f7d7a3446b"),
                            AddressType = "home",
                            PatientId = new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"),
                            StreetAddress = "2222 Home Street"
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AppointmentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8210fa30-8225-49b3-9c12-ed1e41e5aa10"),
                            AppointmentType = "Endocrinologist visit",
                            DoctorId = new Guid("c968a944-2bbf-4d87-8dae-e1cdce063115"),
                            End = new DateTime(2023, 10, 10, 7, 53, 54, 531, DateTimeKind.Utc).AddTicks(6810),
                            PatientId = new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"),
                            Start = new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6810),
                            Status = "finished"
                        },
                        new
                        {
                            Id = new Guid("1db24bb3-2879-451d-9121-9a9e7b231d2d"),
                            AppointmentType = "Endocrinologist visit",
                            DoctorId = new Guid("743d25f9-c461-4d2f-af06-8a1982921eca"),
                            End = new DateTime(2023, 10, 10, 7, 53, 54, 531, DateTimeKind.Utc).AddTicks(6990),
                            PatientId = new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"),
                            Start = new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6990),
                            Status = "finished"
                        },
                        new
                        {
                            Id = new Guid("8a82a289-54b8-4c87-8294-685771900832"),
                            AppointmentType = "Endocrinologist visit",
                            DoctorId = new Guid("ee8abb7d-dbbb-4b1c-ac13-274d9c87af7a"),
                            End = new DateTime(2023, 10, 10, 7, 53, 54, 531, DateTimeKind.Utc).AddTicks(7190),
                            PatientId = new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"),
                            Start = new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(7190),
                            Status = "finished"
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.AppointmentFeedback", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("SubmittedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.ToTable("AppointmentFeedbacks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b223c7c-4633-490e-a948-ec96de30df7c"),
                            AppointmentId = new Guid("8210fa30-8225-49b3-9c12-ed1e41e5aa10")
                        },
                        new
                        {
                            Id = new Guid("694cddf2-4484-403a-bc39-1b3c58f1ccc7"),
                            AppointmentId = new Guid("1db24bb3-2879-451d-9121-9a9e7b231d2d")
                        },
                        new
                        {
                            Id = new Guid("6c266c17-0e94-456e-b99f-dd5b701dfa6b"),
                            AppointmentId = new Guid("8a82a289-54b8-4c87-8294-685771900832")
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.AppointmentFeedbackQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AppointmentFeedbackId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("FeedbackAnswerId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("FeedbackQuestionId")
                        .HasColumnType("uuid");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentFeedbackId");

                    b.HasIndex("FeedbackAnswerId");

                    b.HasIndex("FeedbackQuestionId");

                    b.ToTable("AppointmentFeedbackQuestions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a027376-79d3-4fa1-bcab-3ff9f505807f"),
                            AppointmentFeedbackId = new Guid("0b223c7c-4633-490e-a948-ec96de30df7c"),
                            FeedbackQuestionId = new Guid("86c4db16-4943-4b67-9b64-676fef60c837"),
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("49299ed6-f461-4c9c-a4a6-f87413943361"),
                            AppointmentFeedbackId = new Guid("0b223c7c-4633-490e-a948-ec96de30df7c"),
                            FeedbackQuestionId = new Guid("51fa092e-a1cb-47f1-82a4-19fa77065938"),
                            Order = 2
                        },
                        new
                        {
                            Id = new Guid("c0062d96-2cbf-4f32-8f19-fe05bfa1cd42"),
                            AppointmentFeedbackId = new Guid("0b223c7c-4633-490e-a948-ec96de30df7c"),
                            FeedbackQuestionId = new Guid("a4aaa835-0ced-4d34-94d0-d86a5579e35f"),
                            Order = 3
                        },
                        new
                        {
                            Id = new Guid("4b713308-7424-4599-9855-4f16ba20bfbd"),
                            AppointmentFeedbackId = new Guid("694cddf2-4484-403a-bc39-1b3c58f1ccc7"),
                            FeedbackQuestionId = new Guid("3b1c4d85-5861-4b58-8a2e-9ad530f146aa"),
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("00f55ce7-6d82-49a2-af15-c37b4ad87e0d"),
                            AppointmentFeedbackId = new Guid("694cddf2-4484-403a-bc39-1b3c58f1ccc7"),
                            FeedbackQuestionId = new Guid("f63f1b26-ccd3-4cb3-9f26-4370e0889f14"),
                            Order = 2
                        },
                        new
                        {
                            Id = new Guid("e086f265-5a5f-4bd9-8cdb-dff0e5eb5a9d"),
                            AppointmentFeedbackId = new Guid("694cddf2-4484-403a-bc39-1b3c58f1ccc7"),
                            FeedbackQuestionId = new Guid("2a803f5c-1650-4bd3-9e25-25d1dbe74d33"),
                            Order = 3
                        },
                        new
                        {
                            Id = new Guid("81627128-c7c7-48ff-aebe-d7f638f93274"),
                            AppointmentFeedbackId = new Guid("6c266c17-0e94-456e-b99f-dd5b701dfa6b"),
                            FeedbackQuestionId = new Guid("54871e72-8879-4575-a578-ed2db4140650"),
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("bed8983b-346d-400b-9227-c9df519dcf00"),
                            AppointmentFeedbackId = new Guid("6c266c17-0e94-456e-b99f-dd5b701dfa6b"),
                            FeedbackQuestionId = new Guid("0ee8827c-60d8-4e2a-b705-7bd42e4b0d1b"),
                            Order = 2
                        },
                        new
                        {
                            Id = new Guid("e77121ba-00a0-4d76-8153-9eb79c01c5de"),
                            AppointmentFeedbackId = new Guid("6c266c17-0e94-456e-b99f-dd5b701dfa6b"),
                            FeedbackQuestionId = new Guid("a3eeaa20-91f8-4267-a9ab-fbbb1ad7ef34"),
                            Order = 3
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.Coding", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("DiagnosisId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("System")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DiagnosisId");

                    b.ToTable("Codings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("03f1e98d-abf1-4568-b3f7-6708897510ee"),
                            Code = "E10-E14.9",
                            DiagnosisId = new Guid("dbb58bba-b53f-4576-819b-34de9b963ad2"),
                            Name = "Diabetes without complications",
                            System = "http://hl7.org/fhir/sid/icd-10"
                        },
                        new
                        {
                            Id = new Guid("94ddb159-57b1-4e99-9324-eeaec2bc228d"),
                            Code = "E10-E14.9",
                            DiagnosisId = new Guid("e4481ed3-f741-4656-bbdb-e207ef01b7ca"),
                            Name = "Diabetes without complications",
                            System = "http://hl7.org/fhir/sid/icd-10"
                        },
                        new
                        {
                            Id = new Guid("b477a25c-e49e-4624-8a70-d60c02b814b5"),
                            Code = "E10-E14.9",
                            DiagnosisId = new Guid("d1566f14-ef91-4062-9daf-02561258aace"),
                            Name = "Diabetes without complications",
                            System = "http://hl7.org/fhir/sid/icd-10"
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("ContactSystem")
                        .HasColumnType("integer");

                    b.Property<int?>("ContactType")
                        .HasColumnType("integer");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("01151a9c-5d70-4d5b-86c3-69a10296b3e5"),
                            ContactSystem = 1,
                            ContactType = 1,
                            PatientId = new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"),
                            Value = "tendo@tendoco.com"
                        },
                        new
                        {
                            Id = new Guid("c89a8ebb-c6a8-4d32-8952-7c7de69e36bc"),
                            ContactSystem = 0,
                            ContactType = 0,
                            PatientId = new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"),
                            Value = "555-555-2021"
                        },
                        new
                        {
                            Id = new Guid("3d0281a2-f4f6-43fa-9a16-090139824314"),
                            ContactSystem = 1,
                            ContactType = 1,
                            PatientId = new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"),
                            Value = "tendo@tendoco.com"
                        },
                        new
                        {
                            Id = new Guid("0ac31000-3738-4e08-90de-a1c9435e0390"),
                            ContactSystem = 0,
                            ContactType = 0,
                            PatientId = new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"),
                            Value = "555-555-2021"
                        },
                        new
                        {
                            Id = new Guid("45a8d5e3-7529-47f3-99df-0a21ed432e58"),
                            ContactSystem = 1,
                            ContactType = 1,
                            PatientId = new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"),
                            Value = "tendo@tendoco.com"
                        },
                        new
                        {
                            Id = new Guid("ed3f9c83-bd8d-4d69-8e32-789e279f5f83"),
                            ContactSystem = 0,
                            ContactType = 0,
                            PatientId = new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"),
                            Value = "555-555-2021"
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.Diagnosis", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Diagnoses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dbb58bba-b53f-4576-819b-34de9b963ad2"),
                            AppointmentId = new Guid("8210fa30-8225-49b3-9c12-ed1e41e5aa10"),
                            LastUpdated = new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6890),
                            Status = "Final"
                        },
                        new
                        {
                            Id = new Guid("e4481ed3-f741-4656-bbdb-e207ef01b7ca"),
                            AppointmentId = new Guid("1db24bb3-2879-451d-9121-9a9e7b231d2d"),
                            LastUpdated = new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(7110),
                            Status = "Final"
                        },
                        new
                        {
                            Id = new Guid("d1566f14-ef91-4062-9daf-02561258aace"),
                            AppointmentId = new Guid("8a82a289-54b8-4c87-8294-685771900832"),
                            LastUpdated = new DateTime(2023, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(7240),
                            Status = "Final"
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GivenName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c968a944-2bbf-4d87-8dae-e1cdce063115"),
                            FamilyName = "Careful",
                            GivenName = "Adam"
                        },
                        new
                        {
                            Id = new Guid("743d25f9-c461-4d2f-af06-8a1982921eca"),
                            FamilyName = "Careful",
                            GivenName = "Adam"
                        },
                        new
                        {
                            Id = new Guid("ee8abb7d-dbbb-4b1c-ac13-274d9c87af7a"),
                            FamilyName = "Careful",
                            GivenName = "Adam"
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.FeedbackAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FeedbackAnswers");
                });

            modelBuilder.Entity("PatientFeedback.Entities.FeedbackQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("QuestionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QuestionType")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FeedbackQuestions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("86c4db16-4943-4b67-9b64-676fef60c837"),
                            QuestionName = "DoctorRecommendRating",
                            QuestionType = 1,
                            Text = "Hi {patient_first_name}, on a scale of 1-10, would you recommend Dr. {doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend"
                        },
                        new
                        {
                            Id = new Guid("51fa092e-a1cb-47f1-82a4-19fa77065938"),
                            QuestionName = "HelpfulDiagnosisExplanation",
                            QuestionType = 0,
                            Text = "Thank you. You were diagnosed with {diagnosis}. Did Dr. {doctor_last_name} explain how to manage this diagnosis in a way you could understand?"
                        },
                        new
                        {
                            Id = new Guid("a4aaa835-0ced-4d34-94d0-d86a5579e35f"),
                            QuestionName = "DiagnosisReflection",
                            QuestionType = 2,
                            Text = "We appreciate the feedback, one last question: how do you feel about being diagnosed with {diagnosis}?"
                        },
                        new
                        {
                            Id = new Guid("3b1c4d85-5861-4b58-8a2e-9ad530f146aa"),
                            QuestionName = "DoctorRecommendRating",
                            QuestionType = 1,
                            Text = "Hi {patient_first_name}, on a scale of 1-10, would you recommend Dr. {doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend"
                        },
                        new
                        {
                            Id = new Guid("f63f1b26-ccd3-4cb3-9f26-4370e0889f14"),
                            QuestionName = "HelpfulDiagnosisExplanation",
                            QuestionType = 0,
                            Text = "Thank you. You were diagnosed with {diagnosis}. Did Dr. {doctor_last_name} explain how to manage this diagnosis in a way you could understand?"
                        },
                        new
                        {
                            Id = new Guid("2a803f5c-1650-4bd3-9e25-25d1dbe74d33"),
                            QuestionName = "DiagnosisReflection",
                            QuestionType = 2,
                            Text = "We appreciate the feedback, one last question: how do you feel about being diagnosed with {diagnosis}?"
                        },
                        new
                        {
                            Id = new Guid("54871e72-8879-4575-a578-ed2db4140650"),
                            QuestionName = "DoctorRecommendRating",
                            QuestionType = 1,
                            Text = "Hi {patient_first_name}, on a scale of 1-10, would you recommend Dr. {doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend"
                        },
                        new
                        {
                            Id = new Guid("0ee8827c-60d8-4e2a-b705-7bd42e4b0d1b"),
                            QuestionName = "HelpfulDiagnosisExplanation",
                            QuestionType = 0,
                            Text = "Thank you. You were diagnosed with {diagnosis}. Did Dr. {doctor_last_name} explain how to manage this diagnosis in a way you could understand?"
                        },
                        new
                        {
                            Id = new Guid("a3eeaa20-91f8-4267-a9ab-fbbb1ad7ef34"),
                            QuestionName = "DiagnosisReflection",
                            QuestionType = 2,
                            Text = "We appreciate the feedback, one last question: how do you feel about being diagnosed with {diagnosis}?"
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GivenName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b5c37ee-393d-49a0-a391-ffdb4d044145"),
                            Active = true,
                            BirthDate = new DateTime(1998, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6740),
                            FamilyName = "Tenderson",
                            Gender = "Male",
                            GivenName = "Tendo"
                        },
                        new
                        {
                            Id = new Guid("2c7c83fa-5682-4575-b573-508307a9eb5d"),
                            Active = true,
                            BirthDate = new DateTime(1998, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(6950),
                            FamilyName = "Tenderson",
                            Gender = "Male",
                            GivenName = "Tendo"
                        },
                        new
                        {
                            Id = new Guid("0b0d70b4-9951-4f87-97e5-66365488dc5c"),
                            Active = true,
                            BirthDate = new DateTime(1998, 10, 10, 5, 53, 54, 531, DateTimeKind.Utc).AddTicks(7160),
                            FamilyName = "Tenderson",
                            Gender = "Male",
                            GivenName = "Tendo"
                        });
                });

            modelBuilder.Entity("PatientFeedback.Entities.Address", b =>
                {
                    b.HasOne("PatientFeedback.Entities.Patient", null)
                        .WithMany("Addresses")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientFeedback.Entities.Appointment", b =>
                {
                    b.HasOne("PatientFeedback.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientFeedback.Entities.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PatientFeedback.Entities.AppointmentFeedback", b =>
                {
                    b.HasOne("PatientFeedback.Entities.Appointment", "Appointment")
                        .WithOne("AppointmentFeedback")
                        .HasForeignKey("PatientFeedback.Entities.AppointmentFeedback", "AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("PatientFeedback.Entities.AppointmentFeedbackQuestion", b =>
                {
                    b.HasOne("PatientFeedback.Entities.AppointmentFeedback", "AppointmentFeedback")
                        .WithMany("AppointmentFeedbackQuestions")
                        .HasForeignKey("AppointmentFeedbackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientFeedback.Entities.FeedbackAnswer", "FeedbackAnswer")
                        .WithMany()
                        .HasForeignKey("FeedbackAnswerId");

                    b.HasOne("PatientFeedback.Entities.FeedbackQuestion", "FeedbackQuestion")
                        .WithMany()
                        .HasForeignKey("FeedbackQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppointmentFeedback");

                    b.Navigation("FeedbackAnswer");

                    b.Navigation("FeedbackQuestion");
                });

            modelBuilder.Entity("PatientFeedback.Entities.Coding", b =>
                {
                    b.HasOne("PatientFeedback.Entities.Diagnosis", null)
                        .WithMany("Codings")
                        .HasForeignKey("DiagnosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientFeedback.Entities.Contact", b =>
                {
                    b.HasOne("PatientFeedback.Entities.Patient", null)
                        .WithMany("Contacts")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientFeedback.Entities.Diagnosis", b =>
                {
                    b.HasOne("PatientFeedback.Entities.Appointment", "Appointment")
                        .WithMany("Diagnoses")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("PatientFeedback.Entities.Appointment", b =>
                {
                    b.Navigation("AppointmentFeedback")
                        .IsRequired();

                    b.Navigation("Diagnoses");
                });

            modelBuilder.Entity("PatientFeedback.Entities.AppointmentFeedback", b =>
                {
                    b.Navigation("AppointmentFeedbackQuestions");
                });

            modelBuilder.Entity("PatientFeedback.Entities.Diagnosis", b =>
                {
                    b.Navigation("Codings");
                });

            modelBuilder.Entity("PatientFeedback.Entities.Patient", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Appointments");

                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}