using Microsoft.EntityFrameworkCore;
using PatientFeedback.DTOs;
using PatientFeedback.DTOs.Enums;
using PatientFeedback.Entities;

namespace PatientFeedback;

public class PatientFeedbackContext : DbContext
{
    public PatientFeedbackContext(DbContextOptions<PatientFeedbackContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        var doctorId = Guid.NewGuid();
        var patientId = Guid.NewGuid();
        var appointmentId = Guid.NewGuid();
        var diagnosisId = Guid.NewGuid();

        var question1Id = Guid.NewGuid();
        var question2Id = Guid.NewGuid();
        var question3Id = Guid.NewGuid();
        
        var appointmentFeedbackId = Guid.NewGuid();

        modelBuilder.Entity<Doctor>().HasData(new List<Doctor>()
        {
            new ()
            {
                Id = doctorId,
                FamilyName = "Careful",
                GivenName = "Adam"
            }
        });
        
        modelBuilder.Entity<Patient>().HasData(new List<Patient>()
        {
            new ()
            {
                Id = patientId,
                Active = true,
                BirthDate = DateTime.UtcNow.AddYears(-25),
                FamilyName = "Tenderson",
                GivenName = "Tendo",
                Gender = "Male"
            }
        });

        modelBuilder.Entity<Address>().HasData(new List<Address>()
        {
            new ()
            {
                Id = Guid.NewGuid(),
                AddressType = "home",
                StreetAddress = "2222 Home Street",
                PatientId = patientId,
            }
        });
        
        modelBuilder.Entity<Contact>().HasData(new List<Contact>()
        {
            new ()
            {
                Id = Guid.NewGuid(),
                ContactSystem = ContactSystem.Email,
                Value = "tendo@tendoco.com",
                ContactType = ContactType.Work,
                PatientId = patientId,
            },
            new ()
            {
                Id = Guid.NewGuid(),
                ContactSystem = ContactSystem.Phone,
                Value = "555-555-2021",
                ContactType = ContactType.Mobile,
                PatientId = patientId,
            }
        });

        #region Seed Appointments
        
        modelBuilder.Entity<Appointment>().HasData(new List<Appointment>
        {
            new ()
            {
                Id = appointmentId,
                Status = "finished",
                AppointmentType = "Endocrinologist visit",
                Start = DateTime.UtcNow,
                End = DateTime.UtcNow.AddHours(2),
                DoctorId = doctorId,
                PatientId = patientId,
            }
        });
        
        modelBuilder.Entity<AppointmentFeedback>().HasData(new List<AppointmentFeedback>
        {
            new ()
            {
                Id = appointmentFeedbackId,
                AppointmentId = appointmentId,
            }
        });
        
        modelBuilder.Entity<AppointmentFeedbackQuestion>().HasData(new List<AppointmentFeedbackQuestion>
        {
            new ()
            {
                Id = Guid.NewGuid(),
                AppointmentFeedbackId = appointmentFeedbackId,
                FeedbackQuestionId = question1Id,
                Order = 1,
            },
            new ()
            {
                Id = Guid.NewGuid(),
                AppointmentFeedbackId = appointmentFeedbackId,
                FeedbackQuestionId = question2Id,
                Order = 2,
            },
            new ()
            {
                Id = Guid.NewGuid(),
                AppointmentFeedbackId = appointmentFeedbackId,
                FeedbackQuestionId = question3Id,
                Order = 3,
            }
        });
        
        #endregion
        
        #region Seed FeedbackQuestions
        
        modelBuilder.Entity<FeedbackQuestion>().HasData(new List<FeedbackQuestion>
        {
            new ()
            {
                Id = question1Id,
                Text = "Hi [patient_first_name], on a scale of 1-10, would you recommend Dr [doctor_last_name] to a friend or family member? 1 = Would not recommend, 10 = Would strongly recommend",
                QuestionType = QuestionType.Scale
            },
            new ()
            {
                Id = question2Id,
                Text = "Thank you. You were diagnosed with [diagnosis]. Did Dr [doctor_last_name] explain how to manage this diagnosis in a way you could understand?",
                QuestionType = QuestionType.YesNo
            },
            new ()
            {
                Id = question3Id,
                Text = "We appreciate the feedback, one last question: how do you feel about being diagnosed with [diagnosis]?",
                QuestionType = QuestionType.Text
            },
        });
        
        #endregion

        #region Seed Diagnoses

        modelBuilder.Entity<Diagnosis>().HasData(new List<Diagnosis>
        {
            new ()
            {
                Id = diagnosisId,
                AppointmentId = appointmentId,
                LastUpdated = DateTime.UtcNow,
                Status = "Final",
            }
        });
        
        modelBuilder.Entity<Coding>().HasData(new List<Coding>()
        {
            new ()
            {
                Id = Guid.NewGuid(),
                DiagnosisId = diagnosisId,
                System = "http://hl7.org/fhir/sid/icd-10",
                Code = "E10-E14.9",
                Name = "Diabetes without complications"
            }
        });

        #endregion
    }

    public DbSet<Address>? Addresses { get; set; }
    public DbSet<AppointmentFeedback>? AppointmentFeedbacks { get; set; }
    public DbSet<AppointmentFeedbackQuestion> AppointmentFeedbackQuestions { get; set; }
    public DbSet<Appointment>? Appointments { get; set; }
    public DbSet<Coding>? Codings { get; set; }
    public DbSet<Contact>? Contacts { get; set; }
    public DbSet<Diagnosis>? Diagnoses { get; set; }
    public DbSet<Doctor>? Doctors { get; set; }
    public DbSet<FeedbackAnswer>? FeedbackAnswers { get; set; }
    public DbSet<FeedbackQuestion>? FeedbackQuestions { get; set; }
    public DbSet<Patient>? Patients { get; set; }
}