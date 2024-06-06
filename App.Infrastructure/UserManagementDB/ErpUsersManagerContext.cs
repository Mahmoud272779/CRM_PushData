using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace App.Infrastructure.UserManagementDB;

public partial class ErpUsersManagerContext : DbContext
{
    private readonly IConfiguration _configuration;
    public ErpUsersManagerContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public ErpUsersManagerContext(DbContextOptions<ErpUsersManagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AdditionalPrice> AdditionalPrices { get; set; }

    public virtual DbSet<AdditionalPriceSubscription> AdditionalPriceSubscriptions { get; set; }

    public virtual DbSet<AdministrationPage> AdministrationPages { get; set; }

    public virtual DbSet<AdministrationRoleDetail> AdministrationRoleDetails { get; set; }

    public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }

    public virtual DbSet<App> Apps { get; set; }

    public virtual DbSet<ApplicationRole> ApplicationRoles { get; set; }

    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Bundle> Bundles { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<EmailSetting> EmailSettings { get; set; }

    public virtual DbSet<EmailsMessage> EmailsMessages { get; set; }

    public virtual DbSet<GeneralSetting> GeneralSettings { get; set; }

    public virtual DbSet<GenralSetting> GenralSettings { get; set; }

    public virtual DbSet<Hash> Hashes { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobParameter> JobParameters { get; set; }

    public virtual DbSet<JobQueue> JobQueues { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Posversion> Posversions { get; set; }

    public virtual DbSet<RecHistory> RecHistories { get; set; }

    public virtual DbSet<Rule> Rules { get; set; }

    public virtual DbSet<RulesDetail> RulesDetails { get; set; }

    public virtual DbSet<SalesPerson> SalesPersons { get; set; }

    public virtual DbSet<Schema> Schemas { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<Set> Sets { get; set; }

    public virtual DbSet<SigninLog> SigninLogs { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<SubReqPeriod> SubReqPeriods { get; set; }

    public virtual DbSet<UserApplication> UserApplications { get; set; }

    public virtual DbSet<UserApplicationApp> UserApplicationApps { get; set; }

    public virtual DbSet<UserApplicationCash> UserApplicationCashes { get; set; }

    public virtual DbSet<UserRequest> UserRequests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration["ConnectionStrings:UserManagerQLConnection"];
        optionsBuilder.UseSqlServer(connectionString);
    }
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasIndex(e => e.RuleId, "IX_Accounts_RuleId");

            entity.HasIndex(e => e.UserName, "IX_Accounts_UserName")
                .IsUnique()
                .HasFilter("([UserName] IS NOT NULL)");

            entity.Property(e => e.AccreditAppsAccounts)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.AccreditAppsTechnicals)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.AllowTrialperiod)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ArabicName).HasMaxLength(500);
            entity.Property(e => e.BindTrialAccounts)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ConfirmApps)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.UserName).HasMaxLength(200);

            entity.HasOne(d => d.Rule).WithMany(p => p.Accounts).HasForeignKey(d => d.RuleId);
        });

        modelBuilder.Entity<AdditionalPrice>(entity =>
        {
            entity.ToTable("additionalPrice");

            entity.HasIndex(e => e.ArabicName, "IX_additionalPrice_ArabicName").IsUnique();

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.ArabicName).HasMaxLength(500);
            entity.Property(e => e.LatinName).HasMaxLength(500);
            entity.Property(e => e.SpecialApps).HasColumnName("specialApps");

            entity.HasMany(d => d.Apps).WithMany(p => p.AdditionalPrices)
                .UsingEntity<Dictionary<string, object>>(
                    "AdditionalPriceApp",
                    r => r.HasOne<App>().WithMany().HasForeignKey("AppId"),
                    l => l.HasOne<AdditionalPrice>().WithMany().HasForeignKey("AdditionalPriceId"),
                    j =>
                    {
                        j.HasKey("AdditionalPriceId", "AppId");
                        j.ToTable("AdditionalPriceApps");
                        j.HasIndex(new[] { "AppId" }, "IX_AdditionalPriceApps_AppId");
                    });
        });

        modelBuilder.Entity<AdditionalPriceSubscription>(entity =>
        {
            entity.HasKey(e => new { e.AdditionalPriceId, e.SubRequestId });

            entity.ToTable("additionalPriceSubscription");

            entity.HasIndex(e => e.SubRequestId, "IX_additionalPriceSubscription_subRequestID");

            entity.Property(e => e.SubRequestId).HasColumnName("subRequestID");
            entity.Property(e => e.Count).HasColumnName("count");

            entity.HasOne(d => d.AdditionalPrice).WithMany(p => p.AdditionalPriceSubscriptions).HasForeignKey(d => d.AdditionalPriceId);

            entity.HasOne(d => d.SubRequest).WithMany(p => p.AdditionalPriceSubscriptions).HasForeignKey(d => d.SubRequestId);
        });

        modelBuilder.Entity<AdministrationPage>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.Property(e => e.Url).HasColumnName("URL");
        });

        modelBuilder.Entity<AdministrationRoleDetail>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.PageId });

            entity.HasIndex(e => e.PageId, "IX_AdministrationRoleDetails_PageId");

            entity.HasOne(d => d.Page).WithMany(p => p.AdministrationRoleDetails)
                .HasForeignKey(d => d.PageId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Role).WithMany(p => p.AdministrationRoleDetails)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<AggregatedCounter>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_HangFire_CounterAggregated");

            entity.ToTable("AggregatedCounter", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<App>(entity =>
        {
            entity.Property(e => e.ArabicName).HasMaxLength(500);
            entity.Property(e => e.LatinName).HasMaxLength(500);
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasMany(d => d.AppChildren).WithMany(p => p.AppParents)
                .UsingEntity<Dictionary<string, object>>(
                    "Appsrelation",
                    r => r.HasOne<App>().WithMany()
                        .HasForeignKey("AppChildId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    l => l.HasOne<App>().WithMany()
                        .HasForeignKey("AppParentId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("AppChildId", "AppParentId");
                        j.ToTable("Appsrelation");
                        j.HasIndex(new[] { "AppParentId" }, "IX_Appsrelation_appParentId");
                        j.IndexerProperty<int>("AppChildId").HasColumnName("appChildId");
                        j.IndexerProperty<int>("AppParentId").HasColumnName("appParentId");
                    });

            entity.HasMany(d => d.AppParents).WithMany(p => p.AppChildren)
                .UsingEntity<Dictionary<string, object>>(
                    "Appsrelation",
                    r => r.HasOne<App>().WithMany()
                        .HasForeignKey("AppParentId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    l => l.HasOne<App>().WithMany()
                        .HasForeignKey("AppChildId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("AppChildId", "AppParentId");
                        j.ToTable("Appsrelation");
                        j.HasIndex(new[] { "AppParentId" }, "IX_Appsrelation_appParentId");
                        j.IndexerProperty<int>("AppChildId").HasColumnName("appChildId");
                        j.IndexerProperty<int>("AppParentId").HasColumnName("appParentId");
                    });
        });

        modelBuilder.Entity<ApplicationRole>(entity =>
        {
            entity.ToTable("applicationRoles");
        });

        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.ToTable("applicationUsers");

            entity.HasIndex(e => e.CompanyId, "IX_applicationUsers_CompanyId");

            entity.HasIndex(e => e.RoleId, "IX_applicationUsers_RoleId");

            entity.Property(e => e.IsDefaultUser)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Company).WithMany(p => p.ApplicationUsers).HasForeignKey(d => d.CompanyId);

            entity.HasOne(d => d.Role).WithMany(p => p.ApplicationUsers).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");
        });

        modelBuilder.Entity<Bundle>(entity =>
        {
            entity.ToTable("bundles");

            entity.Property(e => e.AllowedNumberOfPos).HasColumnName("AllowedNumberOfPOS");
            entity.Property(e => e.BundlePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.IsInfinityNumbersOfApps).HasColumnName("isInfinityNumbersOfApps");
            entity.Property(e => e.IsInfinityNumbersOfBranchs).HasColumnName("isInfinityNumbersOfBranchs");
            entity.Property(e => e.IsInfinityNumbersOfCustomers).HasColumnName("isInfinityNumbersOfCustomers");
            entity.Property(e => e.IsInfinityNumbersOfEmployees).HasColumnName("isInfinityNumbersOfEmployees");
            entity.Property(e => e.IsInfinityNumbersOfInvoices).HasColumnName("isInfinityNumbersOfInvoices");
            entity.Property(e => e.IsInfinityNumbersOfPos).HasColumnName("isInfinityNumbersOfPOS");
            entity.Property(e => e.IsInfinityNumbersOfStores).HasColumnName("isInfinityNumbersOfStores");
            entity.Property(e => e.IsInfinityNumbersOfSuppliers).HasColumnName("isInfinityNumbersOfSuppliers");
            entity.Property(e => e.IsInfinityNumbersOfUsers).HasColumnName("isInfinityNumbersOfUsers");
            entity.Property(e => e.IsPosallowed).HasColumnName("IsPOSAllowed");
            entity.Property(e => e.Poscount).HasColumnName("POSCount");
            entity.Property(e => e.PriceOfMonth).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceOfOneYear).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceOfSixMonths).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceOfThreeMonths).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("companies");

            entity.HasIndex(e => e.BundleId, "IX_companies_BundleId");

            entity.HasOne(d => d.Bundle).WithMany(p => p.Companies).HasForeignKey(d => d.BundleId);
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Counter", "HangFire");

            entity.HasIndex(e => e.Key, "CX_HangFire_Counter").IsClustered();

            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<EmailSetting>(entity =>
        {
            entity.ToTable("emailSettings");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<EmailsMessage>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivationBody).HasColumnName("activationBody");
            entity.Property(e => e.ActivationSubject).HasColumnName("activationSubject");
        });

        modelBuilder.Entity<GeneralSetting>(entity =>
        {
            entity.ToTable("GeneralSetting");
        });

        modelBuilder.Entity<GenralSetting>(entity =>
        {
            entity.ToTable("genralSettings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountantEmail).HasColumnName("accountantEmail");
            entity.Property(e => e.GenralManagerEmail).HasColumnName("genralManagerEmail");
            entity.Property(e => e.NotificateClientForActiveSubscraptionInDays)
                .HasDefaultValueSql("((1))")
                .HasColumnName("notificateClientForActiveSubscraptionInDays");
            entity.Property(e => e.SalesManagerEmail).HasColumnName("salesManagerEmail");
            entity.Property(e => e.SendEmailForSalesManAfterActiveSubscrape)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("sendEmailForSalesManAfterActiveSubscrape");
            entity.Property(e => e.SendEmailToAccountantForActiveSubscraption)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("sendEmailToAccountantForActiveSubscraption");
            entity.Property(e => e.SendEmailToClientForActiveSubscraption)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("sendEmailToClientForActiveSubscraption");
            entity.Property(e => e.SendEmailToSalesManagerForActiveSubscraption)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("sendEmailToSalesManagerForActiveSubscraption");
            entity.Property(e => e.SendEmailToTechncalSupportForActiveSubscraption)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("sendEmailToTechncalSupportForActiveSubscraption");
            entity.Property(e => e.SendSmsforSalesManAfterActiveSubscrape)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("sendSMSForSalesManAfterActiveSubscrape");
            entity.Property(e => e.SendSmstoClientForActiveSubscraption)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("sendSMSToClientForActiveSubscraption");
            entity.Property(e => e.SendSmstoGenralManagerForActiveSubscraption)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("sendSMSToGenralManagerForActiveSubscraption");
        });

        modelBuilder.Entity<Hash>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Field }).HasName("PK_HangFire_Hash");

            entity.ToTable("Hash", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Field).HasMaxLength(100);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Job");

            entity.ToTable("Job", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName").HasFilter("([StateName] IS NOT NULL)");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.StateName).HasMaxLength(20);
        });

        modelBuilder.Entity<JobParameter>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Name }).HasName("PK_HangFire_JobParameter");

            entity.ToTable("JobParameter", "HangFire");

            entity.Property(e => e.Name).HasMaxLength(40);

            entity.HasOne(d => d.Job).WithMany(p => p.JobParameters)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_JobParameter_Job");
        });

        modelBuilder.Entity<JobQueue>(entity =>
        {
            entity.HasKey(e => new { e.Queue, e.Id }).HasName("PK_HangFire_JobQueue");

            entity.ToTable("JobQueue", "HangFire");

            entity.Property(e => e.Queue).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.FetchedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_List");

            entity.ToTable("List", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.Property(e => e.ArabicName).HasMaxLength(200);
            entity.Property(e => e.LatinName).HasMaxLength(200);

            entity.HasMany(d => d.Users).WithMany(p => p.Modules)
                .UsingEntity<Dictionary<string, object>>(
                    "InstalledModule",
                    r => r.HasOne<ApplicationUser>().WithMany().HasForeignKey("UserId"),
                    l => l.HasOne<Module>().WithMany().HasForeignKey("ModuleId"),
                    j =>
                    {
                        j.HasKey("ModuleId", "UserId");
                        j.ToTable("installedModules");
                        j.HasIndex(new[] { "UserId" }, "IX_installedModules_UserId");
                    });
        });

        modelBuilder.Entity<Posversion>(entity =>
        {
            entity.ToTable("POSVersions");
        });

        modelBuilder.Entity<RecHistory>(entity =>
        {
            entity.ToTable("RecHistory");

            entity.Property(e => e.Os).HasColumnName("OS");
        });

        modelBuilder.Entity<Rule>(entity =>
        {
            entity.Property(e => e.ArabicName).HasMaxLength(500);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.LatinName).HasMaxLength(500);
        });

        modelBuilder.Entity<RulesDetail>(entity =>
        {
            entity.HasKey(e => new { e.RuleId, e.FormName });

            entity.Property(e => e.CanAdd)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.CanDelete)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.CanEdit)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.CanOpen)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.CanPrint)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Rule).WithMany(p => p.RulesDetails).HasForeignKey(d => d.RuleId);
        });

        modelBuilder.Entity<SalesPerson>(entity =>
        {
            entity.Property(e => e.Email).HasColumnName("EMail");
        });

        modelBuilder.Entity<Schema>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK_HangFire_Schema");

            entity.ToTable("Schema", "HangFire");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Server");

            entity.ToTable("Server", "HangFire");

            entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

            entity.Property(e => e.Id).HasMaxLength(200);
            entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Value }).HasName("PK_HangFire_Set");

            entity.ToTable("Set", "HangFire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Value).HasMaxLength(256);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<SigninLog>(entity =>
        {
            entity.ToTable("signinLogs");

            entity.HasIndex(e => e.UserId, "IX_signinLogs_userID");

            entity.Property(e => e.IsLogout)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("isLogout");
            entity.Property(e => e.LogoutTime).HasColumnName("logoutTime");
            entity.Property(e => e.SigninTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("signinTime");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.UserId).HasColumnName("userID");

            entity.HasOne(d => d.User).WithMany(p => p.SigninLogs).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Id }).HasName("PK_HangFire_State");

            entity.ToTable("State", "HangFire");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Reason).HasMaxLength(100);

            entity.HasOne(d => d.Job).WithMany(p => p.States)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<SubReqPeriod>(entity =>
        {
            entity.ToTable("subReqPeriod");

            entity.HasIndex(e => e.CompanyId, "IX_subReqPeriod_CompanyID");

            entity.HasIndex(e => e.SubReqId, "IX_subReqPeriod_SubReqID");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Seen)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.SubReqId).HasColumnName("SubReqID");

            entity.HasOne(d => d.Company).WithMany(p => p.SubReqPeriods)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.SubReq).WithMany(p => p.SubReqPeriods)
                .HasForeignKey(d => d.SubReqId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UserApplication>(entity =>
        {
            entity.ToTable("UserApplication");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CDate).HasColumnName("cDate");
            entity.Property(e => e.CityName).HasColumnName("cityName");
            entity.Property(e => e.CompanyActivity).HasColumnName("companyActivity");
            entity.Property(e => e.CompanyLogin).HasColumnName("companyLogin");
            entity.Property(e => e.CompanyNameEn).HasColumnName("companyName_En");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.DatabaseName).HasColumnName("databaseName");
            entity.Property(e => e.EmployeesNumber).HasColumnName("employeesNumber");
            entity.Property(e => e.IsDatabaseCreating)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("isDatabaseCreating");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Username).HasColumnName("username");
            entity.Property(e => e.Vatno).HasColumnName("VATNO");
        });

        modelBuilder.Entity<UserApplicationApp>(entity =>
        {
            entity.ToTable("UserApplication_Apps");

            entity.HasIndex(e => e.AppId, "IX_UserApplication_Apps_AppID");

            entity.HasIndex(e => e.ReqId, "IX_UserApplication_Apps_ReqID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AppId).HasColumnName("AppID");
            entity.Property(e => e.ReqId).HasColumnName("ReqID");

            entity.HasOne(d => d.App).WithMany(p => p.UserApplicationApps)
                .HasForeignKey(d => d.AppId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Req).WithMany(p => p.UserApplicationApps).HasForeignKey(d => d.ReqId);
        });

        modelBuilder.Entity<UserApplicationCash>(entity =>
        {
            entity.ToTable("userApplication_Cash");

            entity.HasIndex(e => e.AccAccountId, "IX_userApplication_Cash_Acc_AccountID");

            entity.HasIndex(e => e.AccManagerId, "IX_userApplication_Cash_Acc_Manager_ID");

            entity.HasIndex(e => e.AccTechId, "IX_userApplication_Cash_Acc_Tech_ID");

            entity.HasIndex(e => e.BundlesId, "IX_userApplication_Cash_BundlesID");

            entity.HasIndex(e => e.UserApplicationId, "IX_userApplication_Cash_userApplicationID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccAccountDateTime).HasColumnName("Acc_Account_DateTime");
            entity.Property(e => e.AccAccountId).HasColumnName("Acc_AccountID");
            entity.Property(e => e.AccManagerDateTime).HasColumnName("Acc_Manager_DateTime");
            entity.Property(e => e.AccManagerId).HasColumnName("Acc_Manager_ID");
            entity.Property(e => e.AccTechDateTime).HasColumnName("Acc_Tech_DateTime");
            entity.Property(e => e.AccTechId).HasColumnName("Acc_Tech_ID");
            entity.Property(e => e.AccountantApproved).HasDefaultValueSql("((0))");
            entity.Property(e => e.AccountantRefuseNote).HasColumnName("accountantRefuseNote");
            entity.Property(e => e.AllowedNumberOfEmployeesOfBundle).HasColumnName("allowedNumberOfEmployeesOfBundle");
            entity.Property(e => e.AllowedNumberOfPosofBundle).HasColumnName("allowedNumberOfPOSOfBundle");
            entity.Property(e => e.AllowedNumberOfStoresOfBundle).HasColumnName("allowedNumberOfStoresOfBundle");
            entity.Property(e => e.AllowedNumberOfUsersOfBundle).HasColumnName("allowedNumberOfUsersOfBundle");
            entity.Property(e => e.BillingReceive).HasColumnName("billingReceive");
            entity.Property(e => e.BundlesId).HasColumnName("BundlesID");
            entity.Property(e => e.Cdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("cdate");
            entity.Property(e => e.ImageUrl).HasColumnName("imageURL");
            entity.Property(e => e.IsInfinityNumbersOfApps).HasColumnName("isInfinityNumbersOfApps");
            entity.Property(e => e.IsInfinityNumbersOfBranchs).HasColumnName("isInfinityNumbersOfBranchs");
            entity.Property(e => e.IsInfinityNumbersOfCustomers).HasColumnName("isInfinityNumbersOfCustomers");
            entity.Property(e => e.IsInfinityNumbersOfEmployees).HasColumnName("isInfinityNumbersOfEmployees");
            entity.Property(e => e.IsInfinityNumbersOfInvoices).HasColumnName("isInfinityNumbersOfInvoices");
            entity.Property(e => e.IsInfinityNumbersOfPos).HasColumnName("isInfinityNumbersOfPOS");
            entity.Property(e => e.IsInfinityNumbersOfStores).HasColumnName("isInfinityNumbersOfStores");
            entity.Property(e => e.IsInfinityNumbersOfSuppliers).HasColumnName("isInfinityNumbersOfSuppliers");
            entity.Property(e => e.IsInfinityNumbersOfUsers).HasColumnName("isInfinityNumbersOfUsers");
            entity.Property(e => e.IsTrail).HasColumnName("isTrail");
            entity.Property(e => e.ManagerConfirmation).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.Months).HasColumnName("months");
            entity.Property(e => e.PaymentDate).HasColumnName("paymentDate");
            entity.Property(e => e.PaymentNumber).HasColumnName("paymentNumber");
            entity.Property(e => e.RecNumber).HasColumnName("recNumber");
            entity.Property(e => e.SubReqType).HasColumnName("subReqType");
            entity.Property(e => e.SubTypeAr).HasColumnName("subTypeAr");
            entity.Property(e => e.SubTypeEn).HasColumnName("subTypeEN");
            entity.Property(e => e.TechnicalSupportApproved).HasDefaultValueSql("((0))");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TrasferVia).HasColumnName("trasferVia");
            entity.Property(e => e.UpgradeType).HasColumnName("upgradeType");
            entity.Property(e => e.UserApplicationId).HasColumnName("userApplicationID");
            entity.Property(e => e.Vat).HasColumnName("vat");

            entity.HasOne(d => d.AccAccount).WithMany(p => p.UserApplicationCashAccAccounts).HasForeignKey(d => d.AccAccountId);

            entity.HasOne(d => d.AccManager).WithMany(p => p.UserApplicationCashAccManagers).HasForeignKey(d => d.AccManagerId);

            entity.HasOne(d => d.AccTech).WithMany(p => p.UserApplicationCashAccTeches).HasForeignKey(d => d.AccTechId);

            entity.HasOne(d => d.Bundles).WithMany(p => p.UserApplicationCashes)
                .HasForeignKey(d => d.BundlesId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UserApplication).WithMany(p => p.UserApplicationCashes).HasForeignKey(d => d.UserApplicationId);
        });

        modelBuilder.Entity<UserRequest>(entity =>
        {
            entity.ToTable("UserRequest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdminFullName).HasMaxLength(100);
            entity.Property(e => e.AdminUserName).HasMaxLength(70);
            entity.Property(e => e.ArabicBankName).HasMaxLength(70);
            entity.Property(e => e.BankAccountNumber).HasMaxLength(70);
            entity.Property(e => e.BankIban)
                .HasMaxLength(70)
                .HasColumnName("BankIBAN");
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.CompanyActivity).HasMaxLength(200);
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.CompanyUniqueName).HasMaxLength(200);
            entity.Property(e => e.ConfirmedPassword).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(70);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.IsHrrequestsSelected).HasColumnName("IsHRRequestsSelected");
            entity.Property(e => e.IsPosselected).HasColumnName("IsPOSSelected");
            entity.Property(e => e.LatinBankName).HasMaxLength(70);
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.TaxNumber).HasMaxLength(70);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
