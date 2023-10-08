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
    [Migration("20231008040632_UpdatingModelAndSeedData")]
    partial class UpdatingModelAndSeedData
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
                            Id = new Guid("dba2dee6-fc5c-42f7-8c4e-7262b807393b"),
                            AddressType = "home",
                            PatientId = new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"),
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
                            Id = new Guid("d3af5d90-3c97-4870-9e29-b037bf630d76"),
                            AppointmentType = "Endocrinologist visit",
                            DoctorId = new Guid("23efd273-bcfe-443f-ad1a-b625e612dff1"),
                            End = new DateTime(2023, 10, 8, 6, 6, 32, 373, DateTimeKind.Utc).AddTicks(8240),
                            PatientId = new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"),
                            Start = new DateTime(2023, 10, 8, 4, 6, 32, 373, DateTimeKind.Utc).AddTicks(8240),
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
                            Id = new Guid("0bc3b7fb-c5e9-4016-9d26-51ad552b1685"),
                            AppointmentId = new Guid("d3af5d90-3c97-4870-9e29-b037bf630d76")
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
                            Id = new Guid("b43d87ed-9523-41f5-926a-9ba159514928"),
                            AppointmentFeedbackId = new Guid("0bc3b7fb-c5e9-4016-9d26-51ad552b1685"),
                            FeedbackQuestionId = new Guid("6f3b8e33-3f09-46f2-b121-49b5aa881dad"),
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("6e197cc9-e121-4374-89ce-a8372b3d148a"),
                            AppointmentFeedbackId = new Guid("0bc3b7fb-c5e9-4016-9d26-51ad552b1685"),
                            FeedbackQuestionId = new Guid("fad52f3e-8681-4f5b-b8c3-e2cbf93d6c69"),
                            Order = 2
                        },
                        new
                        {
                            Id = new Guid("61b6e832-243b-4ef4-a017-8d5562f55ee3"),
                            AppointmentFeedbackId = new Guid("0bc3b7fb-c5e9-4016-9d26-51ad552b1685"),
                            FeedbackQuestionId = new Guid("2dc8dbe5-5c94-49a7-a49a-d23cc63b9494"),
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
                            Id = new Guid("babef60f-0ea9-40db-b237-b3247ac4172d"),
                            Code = "E10-E14.9",
                            DiagnosisId = new Guid("08fb0cb9-b60e-4540-a34a-207a2f202a77"),
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
                            Id = new Guid("2a758473-4b8e-4bdd-94af-d7eb337d1aa7"),
                            ContactSystem = 1,
                            ContactType = 1,
                            PatientId = new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"),
                            Value = "tendo@tendoco.com"
                        },
                        new
                        {
                            Id = new Guid("5eea83a8-3120-4122-a216-a84447c824f1"),
                            ContactSystem = 0,
                            ContactType = 0,
                            PatientId = new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"),
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
                            Id = new Guid("08fb0cb9-b60e-4540-a34a-207a2f202a77"),
                            AppointmentId = new Guid("d3af5d90-3c97-4870-9e29-b037bf630d76"),
                            LastUpdated = new DateTime(2023, 10, 8, 4, 6, 32, 373, DateTimeKind.Utc).AddTicks(8370),
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
                            Id = new Guid("23efd273-bcfe-443f-ad1a-b625e612dff1"),
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
                            Id = new Guid("6f3b8e33-3f09-46f2-b121-49b5aa881dad"),
                            QuestionName = "DoctorRecommendRating",
                            QuestionType = 1,
                            Text = "Hi {key=patient_first_name}, on a scale of 1-10, would you recommend Dr {key=doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend"
                        },
                        new
                        {
                            Id = new Guid("fad52f3e-8681-4f5b-b8c3-e2cbf93d6c69"),
                            QuestionName = "HelpfulDiagnosisExplanation",
                            QuestionType = 0,
                            Text = "Thank you. You were diagnosed with {key=diagnosis}. Did Dr {key=doctor_last_name} explain how to manage this diagnosis in a way you could understand?"
                        },
                        new
                        {
                            Id = new Guid("2dc8dbe5-5c94-49a7-a49a-d23cc63b9494"),
                            QuestionName = "DiagnosisReflection",
                            QuestionType = 2,
                            Text = "We appreciate the feedback, one last question: how do you feel about being diagnosed with {key=diagnosis}?"
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
                            Id = new Guid("62179558-da5c-4a06-9050-8148a08fb5c5"),
                            Active = true,
                            BirthDate = new DateTime(1998, 10, 8, 4, 6, 32, 373, DateTimeKind.Utc).AddTicks(8150),
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
                        .WithMany()
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

                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
