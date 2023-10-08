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
    [Migration("20231008051435_UpdatingQuestionTextLookup")]
    partial class UpdatingQuestionTextLookup
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
                            Id = new Guid("3a9d44ef-ef88-40c7-94d0-acbc8f7cf5c2"),
                            AddressType = "home",
                            PatientId = new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"),
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
                            Id = new Guid("e739d74c-ee9a-418a-9b73-8ba33ade3dd8"),
                            AppointmentType = "Endocrinologist visit",
                            DoctorId = new Guid("0595a169-c30b-4643-b6ab-a0fb015dfccf"),
                            End = new DateTime(2023, 10, 8, 7, 14, 34, 909, DateTimeKind.Utc).AddTicks(770),
                            PatientId = new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"),
                            Start = new DateTime(2023, 10, 8, 5, 14, 34, 909, DateTimeKind.Utc).AddTicks(770),
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
                            Id = new Guid("a345de57-4482-407f-98e8-1a809cf8f59f"),
                            AppointmentId = new Guid("e739d74c-ee9a-418a-9b73-8ba33ade3dd8")
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
                            Id = new Guid("a0020c7f-9622-4378-aff4-1a8b70a14c18"),
                            AppointmentFeedbackId = new Guid("a345de57-4482-407f-98e8-1a809cf8f59f"),
                            FeedbackQuestionId = new Guid("2b48810a-3c83-4c85-96cd-5afa1c5f2c04"),
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("94464071-897b-486c-b4ab-ad5298ea4707"),
                            AppointmentFeedbackId = new Guid("a345de57-4482-407f-98e8-1a809cf8f59f"),
                            FeedbackQuestionId = new Guid("3c03fc88-71bf-40a1-b108-95a894ee3b2c"),
                            Order = 2
                        },
                        new
                        {
                            Id = new Guid("8cd18acd-b2c3-4ed6-9be8-5b12ddac9f4b"),
                            AppointmentFeedbackId = new Guid("a345de57-4482-407f-98e8-1a809cf8f59f"),
                            FeedbackQuestionId = new Guid("c0ba5f72-8efa-4ea3-9b31-48de48b5b94e"),
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
                            Id = new Guid("f6d0043c-0ac1-4bc3-9404-bbcde50deedc"),
                            Code = "E10-E14.9",
                            DiagnosisId = new Guid("9e398841-bb67-4764-932f-415be8789275"),
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
                            Id = new Guid("8e944b7e-e1e8-47c3-841d-b2fc1c56ce89"),
                            ContactSystem = 1,
                            ContactType = 1,
                            PatientId = new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"),
                            Value = "tendo@tendoco.com"
                        },
                        new
                        {
                            Id = new Guid("0fc14ca8-c50c-43c0-8afc-6784a437f656"),
                            ContactSystem = 0,
                            ContactType = 0,
                            PatientId = new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"),
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
                            Id = new Guid("9e398841-bb67-4764-932f-415be8789275"),
                            AppointmentId = new Guid("e739d74c-ee9a-418a-9b73-8ba33ade3dd8"),
                            LastUpdated = new DateTime(2023, 10, 8, 5, 14, 34, 909, DateTimeKind.Utc).AddTicks(910),
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
                            Id = new Guid("0595a169-c30b-4643-b6ab-a0fb015dfccf"),
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
                            Id = new Guid("2b48810a-3c83-4c85-96cd-5afa1c5f2c04"),
                            QuestionName = "DoctorRecommendRating",
                            QuestionType = 1,
                            Text = "Hi {patient_first_name}, on a scale of 1-10, would you recommend Dr {doctor_last_name} to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend"
                        },
                        new
                        {
                            Id = new Guid("3c03fc88-71bf-40a1-b108-95a894ee3b2c"),
                            QuestionName = "HelpfulDiagnosisExplanation",
                            QuestionType = 0,
                            Text = "Thank you. You were diagnosed with {diagnosis}. Did Dr {doctor_last_name} explain how to manage this diagnosis in a way you could understand?"
                        },
                        new
                        {
                            Id = new Guid("c0ba5f72-8efa-4ea3-9b31-48de48b5b94e"),
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
                            Id = new Guid("875192dc-9831-4549-bf05-e03c3d94c14d"),
                            Active = true,
                            BirthDate = new DateTime(1998, 10, 8, 5, 14, 34, 909, DateTimeKind.Utc).AddTicks(670),
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
