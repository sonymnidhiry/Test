using CareerCloud.Pocos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CareerCloud.EntityFrameworkDataAccess
{
    class CareerCloudContext:DbContext 
    {
        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodePocos { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodePocos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            string _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
            optionsBuilder.UseSqlServer(_connStr);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantEducationPoco>
                (entity =>
                {
                    entity.HasOne(e => e.ApplicantProfile)
                    .WithMany(e => e.ApplicantEducations)
                    .HasForeignKey(e => e.Applicant);

                });

            modelBuilder.Entity<ApplicantJobApplicationPoco>
                (entity =>
                {
                    entity.HasOne(e => e.ApplicantProfile)
                    .WithMany(e => e.ApplicantJobApplications)
                    .HasForeignKey(e => e.Applicant);

                });
            modelBuilder.Entity<ApplicantJobApplicationPoco>
                (entity =>
                {
                    entity.HasOne(e => e.CompanyJob)
                    .WithMany(e => e.ApplicantJobApplications)
                    .HasForeignKey(e => e.Job);

                });
            modelBuilder.Entity<ApplicantProfilePoco>
                (entity =>
                {
                    entity.HasOne(e => e.SecurityLogin)
                    .WithMany(e => e.ApplicantProfiles)
                    .HasForeignKey(e => e.Login);

                });

            modelBuilder.Entity<ApplicantProfilePoco>
                (entity =>
                {
                    entity.HasOne(e => e.SystemCountryCode)
                    .WithMany(e => e.ApplicantProfiles)
                    .HasForeignKey(e => e.Country);

                });

            modelBuilder.Entity<ApplicantResumePoco>
                (entity =>
                {
                    entity.HasOne(e => e.ApplicantProfile)
                    .WithMany(e => e.ApplicantResumes)
                    .HasForeignKey(e => e.Applicant);

                });

            modelBuilder.Entity<ApplicantSkillPoco>
                (entity =>
                {
                    entity.HasOne(e => e.ApplicantProfile)
                    .WithMany(e => e.ApplicantSkills)
                    .HasForeignKey(e => e.Applicant);

                });
            modelBuilder.Entity<ApplicantWorkHistoryPoco>
                (entity =>
                {
                    entity.HasOne(e => e.ApplicantProfile)
                    .WithMany(e => e.ApplicantWorkHistories)
                    .HasForeignKey(e => e.Applicant);

                });
            modelBuilder.Entity<ApplicantWorkHistoryPoco>
                (entity =>
                {
                    entity.HasOne(e => e.SystemCountryCode)
                    .WithMany(e => e.ApplicantWorkHistories)
                    .HasForeignKey(e => e.CountryCode);

                });

            modelBuilder.Entity<CompanyDescriptionPoco>
                (entity =>
                {
                    entity.HasOne(e => e.SystemLanguageCode)
                    .WithMany(e => e.CompanyDescriptions)
                    .HasForeignKey(e => e.LanguageId);

                });
            modelBuilder.Entity<CompanyDescriptionPoco>
                (entity =>
                {
                    entity.HasOne(e => e.CompanyProfile)
                    .WithMany(e => e.CompanyDescriptions)
                    .HasForeignKey(e => e.Company);

                });

            modelBuilder.Entity<CompanyJobDescriptionPoco>
                (entity =>
                {
                    entity.HasOne(e => e.CompanyJob)
                    .WithMany(e => e.CompanyJobDescriptions)
                    .HasForeignKey(e => e.Job);

                });
            modelBuilder.Entity<CompanyJobEducationPoco>
                (entity =>
                {
                    entity.HasOne(e => e.CompanyJob)
                    .WithMany(e => e.CompanyJobEducations)
                    .HasForeignKey(e => e.Job);

                });
            modelBuilder.Entity<CompanyJobPoco>
                (entity =>
                {
                    entity.HasOne(e => e.CompanyProfile)
                    .WithMany(e => e.CompanyJobs)
                    .HasForeignKey(e => e.Company);

                });
            modelBuilder.Entity<CompanyJobSkillPoco>
                (entity =>
                {
                    entity.HasOne(e => e.CompanyJob)
                    .WithMany(e => e.CompanyJobSkills)
                    .HasForeignKey(e => e.Job);

                });
            modelBuilder.Entity<CompanyLocationPoco>
                (entity =>
                {
                    entity.HasOne(e => e.CompanyProfile)
                    .WithMany(e => e.CompanyLocations)
                    .HasForeignKey(e => e.Company);

                });
            modelBuilder.Entity<SecurityLoginsLogPoco>
                (entity =>
                {
                    entity.HasOne(e => e.SecurityLogin)
                    .WithMany(e => e.SecurityLoginsLogs)
                    .HasForeignKey(e => e.Login);

                });
            modelBuilder.Entity<SecurityLoginsRolePoco>
               (entity =>
               {
                   entity.HasOne(e => e.SecurityLogin)
                   .WithMany(e => e.SecurityLoginsRoles)
                   .HasForeignKey(e => e.Login);

               });
            modelBuilder.Entity<SecurityLoginsRolePoco>
               (entity =>
               {
                   entity.HasOne(e => e.SecurityRole)
                   .WithMany(e => e.SecurityLoginsRoles)
                   .HasForeignKey(e => e.Role);

               });




            base.OnModelCreating(modelBuilder);
        }

    }
}
