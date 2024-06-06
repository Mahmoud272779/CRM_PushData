using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace App.Infrastructure.ERPContext;

public partial class ApexERPContext : DbContext
{
    private readonly IConfiguration _configuration;
    private string DBName = string.Empty;
    public ApexERPContext(IConfiguration configuration, string dBName)
    {
        _configuration = configuration;
        DBName = dBName;
    }

    public ApexERPContext(DbContextOptions<ApexERPContext> options)
        : base(options)
    {
    }
    #region dbsets
    public virtual DbSet<BarcodePrintFile> BarcodePrintFiles { get; set; }

    public virtual DbSet<ChatGroup> ChatGroups { get; set; }

    public virtual DbSet<ChatGroupMember> ChatGroupMembers { get; set; }

    public virtual DbSet<ChatMessage> ChatMessages { get; set; }

    public virtual DbSet<DeletedRecord> DeletedRecords { get; set; }

    public virtual DbSet<EditedItem> EditedItems { get; set; }

    public virtual DbSet<GlReciept> GlReciepts { get; set; }

    public virtual DbSet<GlbalanceForLastPeriod> GlbalanceForLastPeriods { get; set; }

    public virtual DbSet<Glbank> Glbanks { get; set; }

    public virtual DbSet<GlbanksHistory> GlbanksHistories { get; set; }

    public virtual DbSet<Glbranch> Glbranches { get; set; }

    public virtual DbSet<GlbranchHistory> GlbranchHistories { get; set; }

    public virtual DbSet<GlcostCenter> GlcostCenters { get; set; }

    public virtual DbSet<GlcostCenterHistory> GlcostCenterHistories { get; set; }

    public virtual DbSet<Glcurrency> Glcurrencies { get; set; }

    public virtual DbSet<GlcurrencyHistory> GlcurrencyHistories { get; set; }

    public virtual DbSet<GlfinancialAccount> GlfinancialAccounts { get; set; }

    public virtual DbSet<GlfinancialAccountForOpeningBalance> GlfinancialAccountForOpeningBalances { get; set; }

    public virtual DbSet<GlfinancialAccountHistory> GlfinancialAccountHistories { get; set; }

    public virtual DbSet<GlfinancialBranch> GlfinancialBranches { get; set; }

    public virtual DbSet<GlfinancialSetting> GlfinancialSettings { get; set; }

    public virtual DbSet<GlgeneralSetting> GlgeneralSettings { get; set; }

    public virtual DbSet<GlintegrationSetting> GlintegrationSettings { get; set; }

    public virtual DbSet<GljournalEntry> GljournalEntries { get; set; }

    public virtual DbSet<GljournalEntryDetail> GljournalEntryDetails { get; set; }

    public virtual DbSet<GljournalEntryDraft> GljournalEntryDrafts { get; set; }

    public virtual DbSet<GljournalEntryDraftDetail> GljournalEntryDraftDetails { get; set; }

    public virtual DbSet<GljournalEntryFile> GljournalEntryFiles { get; set; }

    public virtual DbSet<GljournalEntryFilesDraft> GljournalEntryFilesDrafts { get; set; }

    public virtual DbSet<GlotherAuthoritiesHistory> GlotherAuthoritiesHistories { get; set; }

    public virtual DbSet<GlpurchasesAndSalesSetting> GlpurchasesAndSalesSettings { get; set; }

    public virtual DbSet<GlrecHistory> GlrecHistories { get; set; }

    public virtual DbSet<GlrecieptCostCenter> GlrecieptCostCenters { get; set; }

    public virtual DbSet<GlrecieptFile> GlrecieptFiles { get; set; }

    public virtual DbSet<GlrecieptsHistory> GlrecieptsHistories { get; set; }

    public virtual DbSet<Glsafe> Glsaves { get; set; }

    public virtual DbSet<GlsafeHistory> GlsafeHistories { get; set; }

    public virtual DbSet<InvBarcodeHistory> InvBarcodeHistories { get; set; }

    public virtual DbSet<InvBarcodeItem> InvBarcodeItems { get; set; }

    public virtual DbSet<InvBarcodeTemplate> InvBarcodeTemplates { get; set; }

    public virtual DbSet<InvCategoriesHistory> InvCategoriesHistories { get; set; }

    public virtual DbSet<InvCategory> InvCategories { get; set; }

    public virtual DbSet<InvColor> InvColors { get; set; }

    public virtual DbSet<InvColorsHistory> InvColorsHistories { get; set; }

    public virtual DbSet<InvCommissionList> InvCommissionLists { get; set; }

    public virtual DbSet<InvCommissionListHistory> InvCommissionListHistories { get; set; }

    public virtual DbSet<InvCommissionSlide> InvCommissionSlides { get; set; }

    public virtual DbSet<InvCompanyDatum> InvCompanyData { get; set; }

    public virtual DbSet<InvDiscountAP> InvDiscountAPs { get; set; }

    public virtual DbSet<InvDiscountAPHistory> InvDiscountAPHistories { get; set; }

    public virtual DbSet<InvEmployee> InvEmployees { get; set; }

    public virtual DbSet<InvEmployeesBranch> InvEmployeesBranches { get; set; }

    public virtual DbSet<InvEmployeesHistory> InvEmployeesHistories { get; set; }

    public virtual DbSet<InvFundsBanksSafesDetail> InvFundsBanksSafesDetails { get; set; }

    public virtual DbSet<InvFundsBanksSafesHistory> InvFundsBanksSafesHistories { get; set; }

    public virtual DbSet<InvFundsBanksSafesMaster> InvFundsBanksSafesMasters { get; set; }

    public virtual DbSet<InvFundsCustomerSupplier> InvFundsCustomerSuppliers { get; set; }

    public virtual DbSet<InvGeneralSetting> InvGeneralSettings { get; set; }

    public virtual DbSet<InvJob> InvJobs { get; set; }

    public virtual DbSet<InvJobsHistory> InvJobsHistories { get; set; }

    public virtual DbSet<InvPaymentMethod> InvPaymentMethods { get; set; }

    public virtual DbSet<InvPaymentMethodsHistory> InvPaymentMethodsHistories { get; set; }

    public virtual DbSet<InvPerson> InvPersons { get; set; }

    public virtual DbSet<InvPersonLastPrice> InvPersonLastPrices { get; set; }

    public virtual DbSet<InvPersonsHistory> InvPersonsHistories { get; set; }

    public virtual DbSet<InvPurchaseAdditionalCostsRelation> InvPurchaseAdditionalCostsRelations { get; set; }

    public virtual DbSet<InvPurchasesAdditionalCost> InvPurchasesAdditionalCosts { get; set; }

    public virtual DbSet<InvPurchasesAdditionalCostsHistory> InvPurchasesAdditionalCostsHistories { get; set; }

    public virtual DbSet<InvSalesMan> InvSalesMen { get; set; }

    public virtual DbSet<InvSalesManHistory> InvSalesManHistories { get; set; }

    public virtual DbSet<InvSerialTransaction> InvSerialTransactions { get; set; }

    public virtual DbSet<InvSize> InvSizes { get; set; }

    public virtual DbSet<InvSizesHistory> InvSizesHistories { get; set; }

    public virtual DbSet<InvStorePlace> InvStorePlaces { get; set; }

    public virtual DbSet<InvStorePlacesHistory> InvStorePlacesHistories { get; set; }

    public virtual DbSet<InvStoresHistory> InvStoresHistories { get; set; }

    public virtual DbSet<InvStpItemCardHistory> InvStpItemCardHistories { get; set; }

    public virtual DbSet<InvStpItemCardPart> InvStpItemCardParts { get; set; }

    public virtual DbSet<InvStpItemCardSerial> InvStpItemCardSerials { get; set; }

    public virtual DbSet<InvStpItemColorSize> InvStpItemColorSizes { get; set; }

    public virtual DbSet<InvStpItemMaster> InvStpItemMasters { get; set; }

    public virtual DbSet<InvStpItemStore> InvStpItemStores { get; set; }

    public virtual DbSet<InvStpItemUnit> InvStpItemUnits { get; set; }

    public virtual DbSet<InvStpStore> InvStpStores { get; set; }

    public virtual DbSet<InvStpUnit> InvStpUnits { get; set; }

    public virtual DbSet<InvUnitsHistory> InvUnitsHistories { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<InvoiceFile> InvoiceFiles { get; set; }

    public virtual DbSet<InvoiceMaster> InvoiceMasters { get; set; }

    public virtual DbSet<InvoiceMasterHistory> InvoiceMasterHistories { get; set; }

    public virtual DbSet<InvoicePaymentsMethod> InvoicePaymentsMethods { get; set; }

    public virtual DbSet<InvoiceSerialize> InvoiceSerializes { get; set; }

    public virtual DbSet<NotificationSeen> NotificationSeens { get; set; }

    public virtual DbSet<NotificationsMaster> NotificationsMasters { get; set; }

    public virtual DbSet<OfferPriceDetail> OfferPriceDetails { get; set; }

    public virtual DbSet<OfferPriceMaster> OfferPriceMasters { get; set; }

    public virtual DbSet<OtherAuthority> OtherAuthorities { get; set; }

    public virtual DbSet<OtherSetting> OtherSettings { get; set; }

    public virtual DbSet<OtherSettingsBank> OtherSettingsBanks { get; set; }

    public virtual DbSet<OtherSettingsSafe> OtherSettingsSafes { get; set; }

    public virtual DbSet<OtherSettingsStore> OtherSettingsStores { get; set; }

    public virtual DbSet<PermissionList> PermissionLists { get; set; }

    public virtual DbSet<PosOfflineDevice> PosOfflineDevices { get; set; }

    public virtual DbSet<Posdevice> Posdevices { get; set; }

    public virtual DbSet<PosinvSuspensionDetail> PosinvSuspensionDetails { get; set; }

    public virtual DbSet<PosinvoiceSuspension> PosinvoiceSuspensions { get; set; }

    public virtual DbSet<Possession> Possessions { get; set; }

    public virtual DbSet<PossessionHistory> PossessionHistories { get; set; }

    public virtual DbSet<PostouchSetting> PostouchSettings { get; set; }

    public virtual DbSet<RecHistory> RecHistories { get; set; }

    public virtual DbSet<ReportFile> ReportFiles { get; set; }

    public virtual DbSet<ReportManger> ReportMangers { get; set; }

    public virtual DbSet<Rule> Rules { get; set; }

    public virtual DbSet<ScreenName> ScreenNames { get; set; }

    public virtual DbSet<SignalR> SignalRs { get; set; }

    public virtual DbSet<SigninLog> SigninLogs { get; set; }

    public virtual DbSet<SubCodeLevel> SubCodeLevels { get; set; }

    public virtual DbSet<SystemHistoryLog> SystemHistoryLogs { get; set; }

    public virtual DbSet<TransferDataFromDeskTop> TransferDataFromDeskTops { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserAndPermission> UserAndPermissions { get; set; }

    public virtual DbSet<UserBranch> UserBranches { get; set; }

    public virtual DbSet<UsersForgetPassword> UsersForgetPasswords { get; set; }
    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = $"Data Source={_configuration["ApplicationSettings:Server"]};" +
                                   $"Initial Catalog={DBName};" +
                                   $"user id={_configuration["ApplicationSettings:UserId"]};" +
                                   $"password={_configuration["ApplicationSettings:Password"]};" +
                                   $"MultipleActiveResultSets=true;" +
                                   $"TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChatGroup>(entity =>
        {
            entity.ToTable("chatGroups");

            entity.HasIndex(e => e.GroupCreatorId, "IX_chatGroups_groupCreatorId");

            entity.Property(e => e.AllowReply).HasColumnName("allowReply");
            entity.Property(e => e.CanExit).HasColumnName("canExit");
            entity.Property(e => e.CreationDate).HasColumnName("creationDate");
            entity.Property(e => e.GroupCreatorId).HasColumnName("groupCreatorId");
            entity.Property(e => e.GroupImage).HasColumnName("groupImage");
            entity.Property(e => e.GroupName).HasColumnName("groupName");
            entity.Property(e => e.IsEnded).HasColumnName("isEnded");

            entity.HasOne(d => d.GroupCreator).WithMany(p => p.ChatGroups)
                .HasForeignKey(d => d.GroupCreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ChatGroupMember>(entity =>
        {
            entity.ToTable("chatGroupMembers");

            entity.HasIndex(e => e.GroupId, "IX_chatGroupMembers_groupId");

            entity.HasIndex(e => e.MemberId, "IX_chatGroupMembers_memberId");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");
            entity.Property(e => e.MemberId).HasColumnName("memberId");

            entity.HasOne(d => d.Group).WithMany(p => p.ChatGroupMembers)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Member).WithMany(p => p.ChatGroupMembers)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ChatMessage>(entity =>
        {
            entity.ToTable("chatMessages");

            entity.HasIndex(e => e.FromId, "IX_chatMessages_fromId");

            entity.HasIndex(e => e.GroupId, "IX_chatMessages_groupId");

            entity.HasIndex(e => e.ToId, "IX_chatMessages_toId");

            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DeleteDate).HasColumnName("deleteDate");
            entity.Property(e => e.FromId).HasColumnName("fromId");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.IsPrivate).HasColumnName("isPrivate");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Seen).HasColumnName("seen");
            entity.Property(e => e.SeenDate).HasColumnName("seenDate");
            entity.Property(e => e.ToId).HasColumnName("toId");

            entity.HasOne(d => d.From).WithMany(p => p.ChatMessageFroms)
                .HasForeignKey(d => d.FromId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Group).WithMany(p => p.ChatMessages).HasForeignKey(d => d.GroupId);

            entity.HasOne(d => d.To).WithMany(p => p.ChatMessageTos).HasForeignKey(d => d.ToId);
        });

        modelBuilder.Entity<DeletedRecord>(entity =>
        {
            entity.Property(e => e.Dtime).HasColumnName("DTime");
            entity.Property(e => e.RecordId).HasColumnName("RecordID");
        });

        modelBuilder.Entity<EditedItem>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.SizeId, e.BranchId });

            entity.Property(e => e.ItemId).HasColumnName("itemId");
            entity.Property(e => e.SizeId).HasColumnName("sizeId");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.Serialize).HasColumnName("serialize");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<GlReciept>(entity =>
        {
            entity.HasIndex(e => e.BankId, "IX_GlReciepts_BankId");

            entity.HasIndex(e => e.FinancialAccountId, "IX_GlReciepts_FinancialAccountId");

            entity.HasIndex(e => e.OtherAuthorityId, "IX_GlReciepts_OtherAuthorityId");

            entity.HasIndex(e => e.PaymentMethodId, "IX_GlReciepts_PaymentMethodId");

            entity.HasIndex(e => e.PersonId, "IX_GlReciepts_PersonId");

            entity.HasIndex(e => e.RectypeWithPayment, "IX_GlReciepts_RectypeWithPayment")
                .IsUnique()
                .HasFilter("([RectypeWithPayment] IS NOT NULL)");

            entity.HasIndex(e => e.SafeId, "IX_GlReciepts_SafeID");

            entity.HasIndex(e => e.SalesManId, "IX_GlReciepts_SalesManId");

            entity.Property(e => e.IsPartialPaid).HasColumnName("isPartialPaid");
            entity.Property(e => e.NoteAr).HasColumnName("NoteAR");
            entity.Property(e => e.NoteEn).HasColumnName("NoteEN");
            entity.Property(e => e.OtherSalesManId).HasColumnName("otherSalesManId");
            entity.Property(e => e.SafeId).HasColumnName("SafeID");

            entity.HasOne(d => d.Bank).WithMany(p => p.GlReciepts).HasForeignKey(d => d.BankId);

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.GlReciepts).HasForeignKey(d => d.FinancialAccountId);

            entity.HasOne(d => d.OtherAuthority).WithMany(p => p.GlReciepts).HasForeignKey(d => d.OtherAuthorityId);

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.GlReciepts)
                .HasForeignKey(d => d.PaymentMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Person).WithMany(p => p.GlReciepts).HasForeignKey(d => d.PersonId);

            entity.HasOne(d => d.Safe).WithMany(p => p.GlReciepts).HasForeignKey(d => d.SafeId);

            entity.HasOne(d => d.SalesMan).WithMany(p => p.GlReciepts).HasForeignKey(d => d.SalesManId);
        });

        modelBuilder.Entity<GlbalanceForLastPeriod>(entity =>
        {
            entity.ToTable("GLBalanceForLastPeriod");
        });

        modelBuilder.Entity<Glbank>(entity =>
        {
            entity.ToTable("GLBanks");

            entity.HasIndex(e => e.FinancialAccountId, "IX_GLBanks_FinancialAccountId");

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.Glbanks).HasForeignKey(d => d.FinancialAccountId);

            entity.HasMany(d => d.Branches).WithMany(p => p.Banks)
                .UsingEntity<Dictionary<string, object>>(
                    "GlbankBranch",
                    r => r.HasOne<Glbranch>().WithMany().HasForeignKey("BranchId"),
                    l => l.HasOne<Glbank>().WithMany().HasForeignKey("BankId"),
                    j =>
                    {
                        j.HasKey("BankId", "BranchId");
                        j.ToTable("GLBankBranch");
                        j.HasIndex(new[] { "BranchId" }, "IX_GLBankBranch_BranchId");
                    });
        });

        modelBuilder.Entity<GlbanksHistory>(entity =>
        {
            entity.ToTable("GLBanksHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_GLBanksHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.GlbanksHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<Glbranch>(entity =>
        {
            entity.ToTable("GLBranch");

            entity.Property(e => e.Utime).HasColumnName("UTime");

            entity.HasMany(d => d.FinancialAccounts).WithMany(p => p.Branches)
                .UsingEntity<Dictionary<string, object>>(
                    "GlfinancialAccountBranch",
                    r => r.HasOne<GlfinancialAccount>().WithMany().HasForeignKey("FinancialAccountId"),
                    l => l.HasOne<Glbranch>().WithMany().HasForeignKey("BranchId"),
                    j =>
                    {
                        j.HasKey("BranchId", "FinancialAccountId");
                        j.ToTable("GLFinancialAccountBranch");
                        j.HasIndex(new[] { "FinancialAccountId" }, "IX_GLFinancialAccountBranch_FinancialAccountId");
                    });

            entity.HasMany(d => d.People).WithMany(p => p.Branches)
                .UsingEntity<Dictionary<string, object>>(
                    "InvPersonsBranch",
                    r => r.HasOne<InvPerson>().WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    l => l.HasOne<Glbranch>().WithMany().HasForeignKey("BranchId"),
                    j =>
                    {
                        j.HasKey("BranchId", "PersonId");
                        j.ToTable("InvPersons_Branches");
                        j.HasIndex(new[] { "PersonId" }, "IX_InvPersons_Branches_PersonId");
                    });

            entity.HasMany(d => d.SalesMen).WithMany(p => p.Branches)
                .UsingEntity<Dictionary<string, object>>(
                    "InvSalesManBranch",
                    r => r.HasOne<InvSalesMan>().WithMany()
                        .HasForeignKey("SalesManId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    l => l.HasOne<Glbranch>().WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("BranchId", "SalesManId");
                        j.ToTable("InvSalesMan_Branches");
                        j.HasIndex(new[] { "SalesManId" }, "IX_InvSalesMan_Branches_SalesManId");
                    });
        });

        modelBuilder.Entity<GlbranchHistory>(entity =>
        {
            entity.ToTable("GLBranchHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_GLBranchHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.GlbranchHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<GlcostCenter>(entity =>
        {
            entity.ToTable("GLCostCenter");

            entity.HasIndex(e => e.ParentId, "IX_GLCostCenter_ParentId");

            entity.Property(e => e.CcNature).HasColumnName("CC_Nature");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);

            entity.HasMany(d => d.FinancialAccounts).WithMany(p => p.CostCenters)
                .UsingEntity<Dictionary<string, object>>(
                    "GlfinancialCost",
                    r => r.HasOne<GlfinancialAccount>().WithMany().HasForeignKey("FinancialAccountId"),
                    l => l.HasOne<GlcostCenter>().WithMany().HasForeignKey("CostCenterId"),
                    j =>
                    {
                        j.HasKey("CostCenterId", "FinancialAccountId");
                        j.ToTable("GLFinancialCost");
                        j.HasIndex(new[] { "FinancialAccountId" }, "IX_GLFinancialCost_FinancialAccountId");
                    });
        });

        modelBuilder.Entity<GlcostCenterHistory>(entity =>
        {
            entity.ToTable("GLCostCenterHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_GLCostCenterHistory_employeesId");

            entity.Property(e => e.CcNature).HasColumnName("CC_Nature");
            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.GlcostCenterHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<Glcurrency>(entity =>
        {
            entity.ToTable("GLCurrency");
        });

        modelBuilder.Entity<GlcurrencyHistory>(entity =>
        {
            entity.ToTable("GLCurrencyHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_GLCurrencyHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.GlcurrencyHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<GlfinancialAccount>(entity =>
        {
            entity.ToTable("GLFinancialAccount");

            entity.HasIndex(e => e.CurrencyId, "IX_GLFinancialAccount_CurrencyId");

            entity.HasIndex(e => e.ParentId, "IX_GLFinancialAccount_ParentId");

            entity.Property(e => e.AutoCoding).HasColumnName("autoCoding");
            entity.Property(e => e.FaNature).HasColumnName("FA_Nature");
            entity.Property(e => e.HasCostCenter).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Currency).WithMany(p => p.GlfinancialAccounts)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);
        });

        modelBuilder.Entity<GlfinancialAccountForOpeningBalance>(entity =>
        {
            entity.ToTable("GLFinancialAccountForOpeningBalance");
        });

        modelBuilder.Entity<GlfinancialAccountHistory>(entity =>
        {
            entity.ToTable("GLFinancialAccountHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_GLFinancialAccountHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");
            entity.Property(e => e.FaNature).HasColumnName("FA_Nature");

            entity.HasOne(d => d.Employees).WithMany(p => p.GlfinancialAccountHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<GlfinancialBranch>(entity =>
        {
            entity.HasKey(e => new { e.BranchId, e.FinancialId });

            entity.ToTable("GLFinancialBranch");

            entity.HasIndex(e => e.FinancialAccountId, "IX_GLFinancialBranch_FinancialAccountId");

            entity.HasOne(d => d.Branch).WithMany(p => p.GlfinancialBranches).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.GlfinancialBranches).HasForeignKey(d => d.FinancialAccountId);
        });

        modelBuilder.Entity<GlfinancialSetting>(entity =>
        {
            entity.ToTable("GLFinancialSetting");

            entity.HasIndex(e => e.FinancialAccountId, "IX_GLFinancialSetting_FinancialAccountId");

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.GlfinancialSettings).HasForeignKey(d => d.FinancialAccountId);
        });

        modelBuilder.Entity<GlgeneralSetting>(entity =>
        {
            entity.ToTable("GLGeneralSetting");

            entity.Property(e => e.EvaluationMethodOfEndOfPeriodStockType).HasColumnName("evaluationMethodOfEndOfPeriodStockType");
            entity.Property(e => e.IsFundsClosed).HasColumnName("isFundsClosed");
        });

        modelBuilder.Entity<GlintegrationSetting>(entity =>
        {
            entity.ToTable("GLIntegrationSettings");

            entity.HasIndex(e => e.GlbranchId, "IX_GLIntegrationSettings_GLBranchId");

            entity.HasIndex(e => e.GlfinancialAccountId, "IX_GLIntegrationSettings_GLFinancialAccountId");

            entity.Property(e => e.GlbranchId).HasColumnName("GLBranchId");
            entity.Property(e => e.GlfinancialAccountId).HasColumnName("GLFinancialAccountId");
            entity.Property(e => e.LinkingMethodId).HasColumnName("linkingMethodId");
            entity.Property(e => e.ScreenId).HasColumnName("screenId");

            entity.HasOne(d => d.Glbranch).WithMany(p => p.GlintegrationSettings).HasForeignKey(d => d.GlbranchId);

            entity.HasOne(d => d.GlfinancialAccount).WithMany(p => p.GlintegrationSettings)
                .HasForeignKey(d => d.GlfinancialAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<GljournalEntry>(entity =>
        {
            entity.ToTable("GLJournalEntry");

            entity.HasIndex(e => e.CurrencyId, "IX_GLJournalEntry_CurrencyId");

            entity.Property(e => e.Ftdate).HasColumnName("FTDate");

            entity.HasOne(d => d.Currency).WithMany(p => p.GljournalEntries)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasMany(d => d.FinancialAccounts).WithMany(p => p.JournalEntries)
                .UsingEntity<Dictionary<string, object>>(
                    "GljournalEntryDetailsAccount",
                    r => r.HasOne<GlfinancialAccount>().WithMany().HasForeignKey("FinancialAccountId"),
                    l => l.HasOne<GljournalEntry>().WithMany().HasForeignKey("JournalEntryId"),
                    j =>
                    {
                        j.HasKey("JournalEntryId", "FinancialAccountId");
                        j.ToTable("GLJournalEntryDetailsAccounts");
                        j.HasIndex(new[] { "FinancialAccountId" }, "IX_GLJournalEntryDetailsAccounts_FinancialAccountId");
                    });
        });

        modelBuilder.Entity<GljournalEntryDetail>(entity =>
        {
            entity.ToTable("GLJournalEntryDetails");

            entity.HasIndex(e => e.FinancialAccountId, "IX_GLJournalEntryDetails_FinancialAccountId");

            entity.HasIndex(e => e.JournalEntryId, "IX_GLJournalEntryDetails_JournalEntryId");

            entity.Property(e => e.IsCostSales).HasColumnName("isCostSales");
            entity.Property(e => e.IsStoreFund).HasColumnName("isStoreFund");

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.GljournalEntryDetails).HasForeignKey(d => d.FinancialAccountId);

            entity.HasOne(d => d.JournalEntry).WithMany(p => p.GljournalEntryDetails).HasForeignKey(d => d.JournalEntryId);
        });

        modelBuilder.Entity<GljournalEntryDraft>(entity =>
        {
            entity.ToTable("GLJournalEntryDraft");

            entity.Property(e => e.Ftdate).HasColumnName("FTDate");
        });

        modelBuilder.Entity<GljournalEntryDraftDetail>(entity =>
        {
            entity.ToTable("GLJournalEntryDraftDetails");

            entity.HasIndex(e => e.JournalEntryDraftId, "IX_GLJournalEntryDraftDetails_JournalEntryDraftId");

            entity.HasOne(d => d.JournalEntryDraft).WithMany(p => p.GljournalEntryDraftDetails).HasForeignKey(d => d.JournalEntryDraftId);
        });

        modelBuilder.Entity<GljournalEntryFile>(entity =>
        {
            entity.ToTable("GLJournalEntryFiles");

            entity.HasIndex(e => e.JournalEntryId, "IX_GLJournalEntryFiles_JournalEntryId");

            entity.HasOne(d => d.JournalEntry).WithMany(p => p.GljournalEntryFiles).HasForeignKey(d => d.JournalEntryId);
        });

        modelBuilder.Entity<GljournalEntryFilesDraft>(entity =>
        {
            entity.ToTable("GLJournalEntryFilesDraft");

            entity.HasIndex(e => e.JournalEntryDraftId, "IX_GLJournalEntryFilesDraft_JournalEntryDraftId");

            entity.HasOne(d => d.JournalEntryDraft).WithMany(p => p.GljournalEntryFilesDrafts).HasForeignKey(d => d.JournalEntryDraftId);
        });

        modelBuilder.Entity<GlotherAuthoritiesHistory>(entity =>
        {
            entity.ToTable("GLOtherAuthoritiesHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_GLOtherAuthoritiesHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");
            entity.Property(e => e.UserName).HasColumnName("userName");

            entity.HasOne(d => d.Employees).WithMany(p => p.GlotherAuthoritiesHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<GlpurchasesAndSalesSetting>(entity =>
        {
            entity.ToTable("GLPurchasesAndSalesSettings");

            entity.HasIndex(e => e.FinancialAccountId, "IX_GLPurchasesAndSalesSettings_FinancialAccountId");

            entity.HasIndex(e => e.BranchId, "IX_GLPurchasesAndSalesSettings_branchId");

            entity.Property(e => e.BranchId).HasColumnName("branchId");
            entity.Property(e => e.ReceiptElemntId).HasColumnName("ReceiptElemntID");

            entity.HasOne(d => d.Branch).WithMany(p => p.GlpurchasesAndSalesSettings).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.GlpurchasesAndSalesSettings).HasForeignKey(d => d.FinancialAccountId);
        });

        modelBuilder.Entity<GlrecHistory>(entity =>
        {
            entity.ToTable("GLRecHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_GLRecHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");
            entity.Property(e => e.Os).HasColumnName("OS");

            entity.HasOne(d => d.Employees).WithMany(p => p.GlrecHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<GlrecieptCostCenter>(entity =>
        {
            entity.ToTable("GLRecieptCostCenter");

            entity.HasIndex(e => e.CostCenterId, "IX_GLRecieptCostCenter_CostCenterId");

            entity.HasIndex(e => e.SupportId, "IX_GLRecieptCostCenter_SupportId");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.GlrecieptCostCenters)
                .HasForeignKey(d => d.CostCenterId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Support).WithMany(p => p.GlrecieptCostCenters)
                .HasForeignKey(d => d.SupportId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<GlrecieptFile>(entity =>
        {
            entity.ToTable("GLRecieptFiles");

            entity.HasIndex(e => e.RecieptId, "IX_GLRecieptFiles_RecieptId");

            entity.HasOne(d => d.Reciept).WithMany(p => p.GlrecieptFiles).HasForeignKey(d => d.RecieptId);
        });

        modelBuilder.Entity<GlrecieptsHistory>(entity =>
        {
            entity.ToTable("GLRecieptsHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_GLRecieptsHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");
            entity.Property(e => e.SafeIdorBank).HasColumnName("SafeIDOrBank");

            entity.HasOne(d => d.Employees).WithMany(p => p.GlrecieptsHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<Glsafe>(entity =>
        {
            entity.ToTable("GLSafe");

            entity.HasIndex(e => e.BranchId, "IX_GLSafe_BranchId");

            entity.HasIndex(e => e.FinancialAccountId, "IX_GLSafe_FinancialAccountId");

            entity.HasOne(d => d.Branch).WithMany(p => p.Glsaves)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.Glsaves).HasForeignKey(d => d.FinancialAccountId);
        });

        modelBuilder.Entity<GlsafeHistory>(entity =>
        {
            entity.ToTable("GLSafeHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_GLSafeHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.GlsafeHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvBarcodeHistory>(entity =>
        {
            entity.ToTable("InvBarcodeHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvBarcodeHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvBarcodeHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvBarcodeItem>(entity =>
        {
            entity.HasIndex(e => e.BarcodeId, "IX_InvBarcodeItems_BarcodeId");

            entity.HasOne(d => d.Barcode).WithMany(p => p.InvBarcodeItems)
                .HasForeignKey(d => d.BarcodeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvBarcodeTemplate>(entity =>
        {
            entity.HasKey(e => e.BarcodeId);

            entity.ToTable("InvBarcodeTemplate");
        });

        modelBuilder.Entity<InvCategoriesHistory>(entity =>
        {
            entity.ToTable("InvCategoriesHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvCategoriesHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvCategoriesHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvCategory>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_InvCategories_Code").IsUnique();

            entity.Property(e => e.Utime).HasColumnName("UTime");
        });

        modelBuilder.Entity<InvColor>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_InvColors_Code").IsUnique();
        });

        modelBuilder.Entity<InvColorsHistory>(entity =>
        {
            entity.ToTable("InvColorsHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvColorsHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvColorsHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvCommissionList>(entity =>
        {
            entity.ToTable("InvCommissionList");

            entity.HasIndex(e => e.Code, "IX_InvCommissionList_Code").IsUnique();
        });

        modelBuilder.Entity<InvCommissionListHistory>(entity =>
        {
            entity.ToTable("InvCommissionListHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvCommissionListHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvCommissionListHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvCommissionSlide>(entity =>
        {
            entity.HasIndex(e => e.CommissionId, "IX_InvCommissionSlides_CommissionId");

            entity.HasOne(d => d.Commission).WithMany(p => p.InvCommissionSlides)
                .HasForeignKey(d => d.CommissionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvCompanyDatum>(entity =>
        {
            entity.Property(e => e.ImageFile).HasColumnName("imageFile");
        });

        modelBuilder.Entity<InvDiscountAP>(entity =>
        {
            entity.ToTable("InvDiscount_A_P");

            entity.HasIndex(e => e.PersonId, "IX_InvDiscount_A_P_PersonId");

            entity.Property(e => e.RecieptsId).HasColumnName("recieptsId");

            entity.HasOne(d => d.Person).WithMany(p => p.InvDiscountAPs)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvDiscountAPHistory>(entity =>
        {
            entity.ToTable("InvDiscount_A_P_History");

            entity.HasIndex(e => e.EmployeesId, "IX_InvDiscount_A_P_History_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvDiscountAPHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvEmployee>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_InvEmployees_Code").IsUnique();

            entity.HasIndex(e => e.FinancialAccountId, "IX_InvEmployees_FinancialAccountId");

            entity.HasIndex(e => e.JobId, "IX_InvEmployees_JobId");

            entity.Property(e => e.Utime).HasColumnName("UTime");

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.InvEmployees).HasForeignKey(d => d.FinancialAccountId);

            entity.HasOne(d => d.Job).WithMany(p => p.InvEmployees)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvEmployeesBranch>(entity =>
        {
            entity.HasKey(e => new { e.EmployeeId, e.BranchId });

            entity.HasIndex(e => e.BranchId, "IX_InvEmployeesBranches_BranchId");

            entity.Property(e => e.Current).HasColumnName("current");

            entity.HasOne(d => d.Branch).WithMany(p => p.InvEmployeesBranches).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.Employee).WithMany(p => p.InvEmployeesBranches).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<InvEmployeesHistory>(entity =>
        {
            entity.ToTable("InvEmployeesHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvEmployeesHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvEmployeesHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvFundsBanksSafesDetail>(entity =>
        {
            entity.HasIndex(e => e.DocumentId, "IX_InvFundsBanksSafesDetails_DocumentId");

            entity.HasOne(d => d.Document).WithMany(p => p.InvFundsBanksSafesDetails)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvFundsBanksSafesHistory>(entity =>
        {
            entity.ToTable("InvFundsBanksSafesHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvFundsBanksSafesHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvFundsBanksSafesHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvFundsBanksSafesMaster>(entity =>
        {
            entity.HasKey(e => e.DocumentId);

            entity.ToTable("InvFundsBanksSafesMaster");

            entity.HasIndex(e => e.BankId, "IX_InvFundsBanksSafesMaster_BankId");

            entity.HasIndex(e => e.SafeId, "IX_InvFundsBanksSafesMaster_SafeId");

            entity.Property(e => e.IsBlock).HasColumnName("isBlock");

            entity.HasOne(d => d.Bank).WithMany(p => p.InvFundsBanksSafesMasters).HasForeignKey(d => d.BankId);

            entity.HasOne(d => d.Safe).WithMany(p => p.InvFundsBanksSafesMasters).HasForeignKey(d => d.SafeId);
        });

        modelBuilder.Entity<InvFundsCustomerSupplier>(entity =>
        {
            entity.ToTable("InvFundsCustomerSupplier");

            entity.HasIndex(e => e.PersonId, "IX_InvFundsCustomerSupplier_PersonId").IsUnique();

            entity.HasOne(d => d.Person).WithOne(p => p.InvFundsCustomerSupplier).HasForeignKey<InvFundsCustomerSupplier>(d => d.PersonId);
        });

        modelBuilder.Entity<InvGeneralSetting>(entity =>
        {
            entity.Property(e => e.AccrediteEndPeriod).HasColumnName("Accredite_EndPeriod");
            entity.Property(e => e.AccrediteStartPeriod).HasColumnName("Accredite_StartPeriod");
            entity.Property(e => e.AutoLogoutInMints).HasColumnName("autoLogoutInMints");
            entity.Property(e => e.BarcodeItemCodestart).HasColumnName("Barcode_ItemCodestart");
            entity.Property(e => e.BarcodeType).HasColumnName("barcodeType");
            entity.Property(e => e.CustomerDisplayActive).HasColumnName("CustomerDisplay_Active");
            entity.Property(e => e.CustomerDisplayCharNumber).HasColumnName("CustomerDisplay_CharNumber");
            entity.Property(e => e.CustomerDisplayCode).HasColumnName("CustomerDisplay_Code");
            entity.Property(e => e.CustomerDisplayDefaultWord).HasColumnName("CustomerDisplay_DefaultWord");
            entity.Property(e => e.CustomerDisplayLinesNumber).HasColumnName("CustomerDisplay_LinesNumber");
            entity.Property(e => e.CustomerDisplayPortNumber).HasColumnName("CustomerDisplay_PortNumber");
            entity.Property(e => e.CustomerDisplayScreenType).HasColumnName("CustomerDisplay_ScreenType");
            entity.Property(e => e.FundsBanks).HasColumnName("Funds_Banks");
            entity.Property(e => e.FundsCustomers).HasColumnName("Funds_Customers");
            entity.Property(e => e.FundsCustomersDate).HasColumnName("Funds_Customers_Date");
            entity.Property(e => e.FundsItems).HasColumnName("Funds_Items");
            entity.Property(e => e.FundsSafes).HasColumnName("Funds_Safes");
            entity.Property(e => e.FundsSupplires).HasColumnName("Funds_Supplires");
            entity.Property(e => e.FundsSuppliresDate).HasColumnName("Funds_Supplires_Date");
            entity.Property(e => e.OtherAutoExtractExpireDate).HasColumnName("Other_AutoExtractExpireDate");
            entity.Property(e => e.OtherConfirmeCustomerPhone).HasColumnName("Other_ConfirmeCustomerPhone");
            entity.Property(e => e.OtherConfirmeSupplierPhone).HasColumnName("Other_ConfirmeSupplierPhone");
            entity.Property(e => e.OtherDecimals).HasColumnName("Other_Decimals");
            entity.Property(e => e.OtherDemandLimitNotification).HasColumnName("Other_DemandLimitNotification");
            entity.Property(e => e.OtherExpireNotificationFlag).HasColumnName("Other_ExpireNotificationFlag");
            entity.Property(e => e.OtherExpireNotificationValue).HasColumnName("Other_ExpireNotificationValue");
            entity.Property(e => e.OtherItemsAutoCoding).HasColumnName("Other_ItemsAutoCoding");
            entity.Property(e => e.OtherMergeItemMethod).HasColumnName("otherMergeItemMethod");
            entity.Property(e => e.OtherMergeItems).HasColumnName("Other_MergeItems");
            entity.Property(e => e.OtherPrintSerials).HasColumnName("Other_PrintSerials");
            entity.Property(e => e.OtherUseRoundNumber).HasColumnName("Other_UseRoundNumber");
            entity.Property(e => e.OtherViewStorePlace).HasColumnName("Other_ViewStorePlace");
            entity.Property(e => e.OtherZeroPricesInItems).HasColumnName("Other_ZeroPricesInItems");
            entity.Property(e => e.PosActiveCashierCustody).HasColumnName("Pos_ActiveCashierCustody");
            entity.Property(e => e.PosActiveDiscount).HasColumnName("Pos_ActiveDiscount");
            entity.Property(e => e.PosActivePricesList).HasColumnName("Pos_ActivePricesList");
            entity.Property(e => e.PosDeferredSale).HasColumnName("Pos_DeferredSale");
            entity.Property(e => e.PosEditingOnDate).HasColumnName("Pos_EditingOnDate");
            entity.Property(e => e.PosExceedDiscountRatio).HasColumnName("Pos_ExceedDiscountRatio");
            entity.Property(e => e.PosExceedPrices).HasColumnName("Pos_ExceedPrices");
            entity.Property(e => e.PosExtractWithoutQuantity).HasColumnName("Pos_ExtractWithoutQuantity");
            entity.Property(e => e.PosIndividualCoding).HasColumnName("Pos_IndividualCoding");
            entity.Property(e => e.PosModifyPrices).HasColumnName("Pos_ModifyPrices");
            entity.Property(e => e.PosPreventEditingRecieptFlag).HasColumnName("Pos_PreventEditingRecieptFlag");
            entity.Property(e => e.PosPreventEditingRecieptValue).HasColumnName("Pos_PreventEditingRecieptValue");
            entity.Property(e => e.PosPriceIncludeVat).HasColumnName("Pos_PriceIncludeVat");
            entity.Property(e => e.PosPrintPreview).HasColumnName("Pos_PrintPreview");
            entity.Property(e => e.PosPrintWithEnding).HasColumnName("Pos_PrintWithEnding");
            entity.Property(e => e.PosUseLastPrice).HasColumnName("Pos_UseLastPrice");
            entity.Property(e => e.PurchaseUpdateItemsPricesAfterInvoice)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("Purchase_UpdateItemsPricesAfterInvoice");
            entity.Property(e => e.PurchasesActiveDiscount).HasColumnName("Purchases_ActiveDiscount");
            entity.Property(e => e.PurchasesModifyPrices).HasColumnName("Purchases_ModifyPrices");
            entity.Property(e => e.PurchasesPayTotalNet).HasColumnName("Purchases_PayTotalNet");
            entity.Property(e => e.PurchasesPriceIncludeVat).HasColumnName("Purchases_PriceIncludeVat");
            entity.Property(e => e.PurchasesPrintWithSave).HasColumnName("Purchases_PrintWithSave");
            entity.Property(e => e.PurchasesReturnWithoutQuantity).HasColumnName("Purchases_ReturnWithoutQuantity");
            entity.Property(e => e.PurchasesUseLastPrice).HasColumnName("Purchases_UseLastPrice");
            entity.Property(e => e.SalesActiveDiscount).HasColumnName("Sales_ActiveDiscount");
            entity.Property(e => e.SalesActivePricesList).HasColumnName("Sales_ActivePricesList");
            entity.Property(e => e.SalesExceedDiscountRatio).HasColumnName("Sales_ExceedDiscountRatio");
            entity.Property(e => e.SalesExceedPrices).HasColumnName("Sales_ExceedPrices");
            entity.Property(e => e.SalesExtractWithoutQuantity).HasColumnName("Sales_ExtractWithoutQuantity");
            entity.Property(e => e.SalesLinkRepresentCustomer).HasColumnName("Sales_LinkRepresentCustomer");
            entity.Property(e => e.SalesModifyPrices).HasColumnName("Sales_ModifyPrices");
            entity.Property(e => e.SalesPayTotalNet).HasColumnName("Sales_PayTotalNet");
            entity.Property(e => e.SalesPriceIncludeVat).HasColumnName("Sales_PriceIncludeVat");
            entity.Property(e => e.SalesPrintWithSave).HasColumnName("Sales_PrintWithSave");
            entity.Property(e => e.SalesUseLastPrice).HasColumnName("Sales_UseLastPrice");
            entity.Property(e => e.SecureSocketOptions).HasColumnName("secureSocketOptions");
            entity.Property(e => e.VatActive).HasColumnName("Vat_Active");
            entity.Property(e => e.VatDefaultValue).HasColumnName("Vat_DefaultValue");
        });

        modelBuilder.Entity<InvJob>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_InvJobs_Code").IsUnique();
        });

        modelBuilder.Entity<InvJobsHistory>(entity =>
        {
            entity.ToTable("InvJobsHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvJobsHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvJobsHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvPaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodId);

            entity.HasIndex(e => e.BankId, "IX_InvPaymentMethods_BankId");

            entity.HasIndex(e => e.Code, "IX_InvPaymentMethods_Code").IsUnique();

            entity.HasIndex(e => e.SafeId, "IX_InvPaymentMethods_SafeId");

            entity.Property(e => e.Utime).HasColumnName("UTime");

            entity.HasOne(d => d.Bank).WithMany(p => p.InvPaymentMethods).HasForeignKey(d => d.BankId);

            entity.HasOne(d => d.Safe).WithMany(p => p.InvPaymentMethods).HasForeignKey(d => d.SafeId);
        });

        modelBuilder.Entity<InvPaymentMethodsHistory>(entity =>
        {
            entity.ToTable("InvPaymentMethodsHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvPaymentMethodsHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvPaymentMethodsHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvPerson>(entity =>
        {
            entity.HasIndex(e => e.FinancialAccountId, "IX_InvPersons_FinancialAccountId");

            entity.HasIndex(e => e.InvEmployeesId, "IX_InvPersons_InvEmployeesId");

            entity.HasIndex(e => e.SalesManId, "IX_InvPersons_SalesManId");

            entity.Property(e => e.BuildingNumber).HasMaxLength(70);
            entity.Property(e => e.City).HasMaxLength(70);
            entity.Property(e => e.Country).HasMaxLength(70);
            entity.Property(e => e.Neighborhood).HasMaxLength(70);
            entity.Property(e => e.PostalNumber).HasMaxLength(70);
            entity.Property(e => e.StreetName).HasMaxLength(200);
            entity.Property(e => e.Utime).HasColumnName("UTime");

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.InvPeople).HasForeignKey(d => d.FinancialAccountId);

            entity.HasOne(d => d.InvEmployees).WithMany(p => p.InvPeople).HasForeignKey(d => d.InvEmployeesId);

            entity.HasOne(d => d.SalesMan).WithMany(p => p.InvPeople).HasForeignKey(d => d.SalesManId);
        });

        modelBuilder.Entity<InvPersonLastPrice>(entity =>
        {
            entity.ToTable("InvPersonLastPrice");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InvoiceTypeId).HasColumnName("invoiceTypeId");
            entity.Property(e => e.ItemId).HasColumnName("itemId");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.UnitId).HasColumnName("unitId");
        });

        modelBuilder.Entity<InvPersonsHistory>(entity =>
        {
            entity.ToTable("InvPersonsHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvPersonsHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvPersonsHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvPurchaseAdditionalCostsRelation>(entity =>
        {
            entity.HasKey(e => e.PurchaseAdditionalCostsId);

            entity.ToTable("InvPurchaseAdditionalCostsRelation");

            entity.HasIndex(e => e.AddtionalCostId, "IX_InvPurchaseAdditionalCostsRelation_AddtionalCostId");

            entity.HasIndex(e => e.InvoiceId, "IX_InvPurchaseAdditionalCostsRelation_InvoiceId");

            entity.Property(e => e.CodeOfflinePos).HasColumnName("CodeOfflinePOS");

            entity.HasOne(d => d.AddtionalCost).WithMany(p => p.InvPurchaseAdditionalCostsRelations)
                .HasForeignKey(d => d.AddtionalCostId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvPurchaseAdditionalCostsRelations)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvPurchasesAdditionalCost>(entity =>
        {
            entity.HasKey(e => e.PurchasesAdditionalCostsId);

            entity.HasIndex(e => e.Code, "IX_InvPurchasesAdditionalCosts_Code").IsUnique();

            entity.Property(e => e.Utime).HasColumnName("UTime");
        });

        modelBuilder.Entity<InvPurchasesAdditionalCostsHistory>(entity =>
        {
            entity.ToTable("InvPurchasesAdditionalCostsHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvPurchasesAdditionalCostsHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvPurchasesAdditionalCostsHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvSalesMan>(entity =>
        {
            entity.ToTable("InvSalesMan");

            entity.HasIndex(e => e.Code, "IX_InvSalesMan_Code").IsUnique();

            entity.HasIndex(e => e.CommissionListId, "IX_InvSalesMan_CommissionListId");

            entity.HasIndex(e => e.FinancialAccountId, "IX_InvSalesMan_FinancialAccountId");

            entity.HasOne(d => d.CommissionList).WithMany(p => p.InvSalesMen).HasForeignKey(d => d.CommissionListId);

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.InvSalesMen).HasForeignKey(d => d.FinancialAccountId);
        });

        modelBuilder.Entity<InvSalesManHistory>(entity =>
        {
            entity.ToTable("InvSalesManHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvSalesManHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvSalesManHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvSerialTransaction>(entity =>
        {
            entity.ToTable("InvSerialTransaction");

            entity.HasIndex(e => e.ItemId, "IX_InvSerialTransaction_ItemId");

            entity.HasIndex(e => e.StoreId, "IX_InvSerialTransaction_StoreId");

            entity.Property(e => e.IndexOfSerialForAdd).HasColumnName("indexOfSerialForAdd");
            entity.Property(e => e.IndexOfSerialForExtract).HasColumnName("indexOfSerialForExtract");

            entity.HasOne(d => d.Item).WithMany(p => p.InvSerialTransactions)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Store).WithMany(p => p.InvSerialTransactions)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvSize>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_InvSizes_Code").IsUnique();
        });

        modelBuilder.Entity<InvSizesHistory>(entity =>
        {
            entity.ToTable("InvSizesHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvSizesHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvSizesHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvStorePlace>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_InvStorePlaces_Code").IsUnique();
        });

        modelBuilder.Entity<InvStorePlacesHistory>(entity =>
        {
            entity.ToTable("InvStorePlacesHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvStorePlacesHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvStorePlacesHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvStoresHistory>(entity =>
        {
            entity.ToTable("InvStoresHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvStoresHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvStoresHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvStpItemCardHistory>(entity =>
        {
            entity.ToTable("InvStpItemCardHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvStpItemCardHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvStpItemCardHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvStpItemCardPart>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.PartId });

            entity.HasIndex(e => e.PartId, "IX_InvStpItemCardParts_PartId");

            entity.HasIndex(e => e.UnitId, "IX_InvStpItemCardParts_UnitId");

            entity.HasOne(d => d.Item).WithMany(p => p.InvStpItemCardPartItems).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Part).WithMany(p => p.InvStpItemCardPartParts)
                .HasForeignKey(d => d.PartId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Unit).WithMany(p => p.InvStpItemCardParts).HasForeignKey(d => d.UnitId);
        });

        modelBuilder.Entity<InvStpItemCardSerial>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.SerialNo });

            entity.HasIndex(e => e.SerialNo, "AK_InvStpItemCardSerials_SerialNo").IsUnique();

            entity.HasOne(d => d.Item).WithMany(p => p.InvStpItemCardSerials).HasForeignKey(d => d.ItemId);
        });

        modelBuilder.Entity<InvStpItemColorSize>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.UnitId, e.ColorId, e.SizeId });

            entity.ToTable("InvStpItemColorSize");

            entity.HasIndex(e => e.ColorId, "IX_InvStpItemColorSize_ColorId");

            entity.HasIndex(e => e.SizeId, "IX_InvStpItemColorSize_SizeId");

            entity.HasIndex(e => e.UnitId, "IX_InvStpItemColorSize_UnitId");

            entity.HasOne(d => d.Color).WithMany(p => p.InvStpItemColorSizes)
                .HasForeignKey(d => d.ColorId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Item).WithMany(p => p.InvStpItemColorSizes)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Size).WithMany(p => p.InvStpItemColorSizes)
                .HasForeignKey(d => d.SizeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Unit).WithMany(p => p.InvStpItemColorSizes)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.InvStpItemUnit).WithMany(p => p.InvStpItemColorSizes).HasForeignKey(d => new { d.ItemId, d.UnitId });
        });

        modelBuilder.Entity<InvStpItemMaster>(entity =>
        {
            entity.ToTable("InvStpItemMaster");

            entity.HasIndex(e => e.DefaultStoreId, "IX_InvStpItemMaster_DefaultStoreId");

            entity.HasIndex(e => e.GroupId, "IX_InvStpItemMaster_GroupId");

            entity.HasIndex(e => e.ItemCode, "IX_InvStpItemMaster_ItemCode").IsUnique();

            entity.HasIndex(e => e.NationalBarcode, "IX_InvStpItemMaster_NationalBarcode")
                .IsUnique()
                .HasFilter("([NationalBarcode] IS NOT NULL)");

            entity.Property(e => e.ApplyVat).HasColumnName("ApplyVAT");
            entity.Property(e => e.ArabicName).HasMaxLength(250);
            entity.Property(e => e.ItemCode).HasMaxLength(200);
            entity.Property(e => e.Utime).HasColumnName("UTime");
            entity.Property(e => e.Vat).HasColumnName("VAT");

            entity.HasOne(d => d.DefaultStore).WithMany(p => p.InvStpItemMasters)
                .HasForeignKey(d => d.DefaultStoreId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Group).WithMany(p => p.InvStpItemMasters).HasForeignKey(d => d.GroupId);
        });

        modelBuilder.Entity<InvStpItemStore>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.StoreId });

            entity.HasIndex(e => e.StoreId, "IX_InvStpItemStores_StoreId");

            entity.Property(e => e.DemandLimit).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.Item).WithMany(p => p.InvStpItemStores).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Store).WithMany(p => p.InvStpItemStores).HasForeignKey(d => d.StoreId);
        });

        modelBuilder.Entity<InvStpItemUnit>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.UnitId });

            entity.ToTable("InvStpItemUnit");

            entity.HasIndex(e => e.UnitId, "IX_InvStpItemUnit_UnitId");

            entity.HasOne(d => d.Item).WithMany(p => p.InvStpItemUnits).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Unit).WithMany(p => p.InvStpItemUnits).HasForeignKey(d => d.UnitId);
        });

        modelBuilder.Entity<InvStpStore>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_InvStpStores_Code").IsUnique();

            entity.HasIndex(e => e.GlbranchId, "IX_InvStpStores_GLBranchId");

            entity.Property(e => e.GlbranchId).HasColumnName("GLBranchId");
            entity.Property(e => e.Utime).HasColumnName("UTime");

            entity.HasOne(d => d.Glbranch).WithMany(p => p.InvStpStores).HasForeignKey(d => d.GlbranchId);

            entity.HasMany(d => d.Branches).WithMany(p => p.Stores)
                .UsingEntity<Dictionary<string, object>>(
                    "InvStoreBranch",
                    r => r.HasOne<Glbranch>().WithMany().HasForeignKey("BranchId"),
                    l => l.HasOne<InvStpStore>().WithMany().HasForeignKey("StoreId"),
                    j =>
                    {
                        j.HasKey("StoreId", "BranchId");
                        j.ToTable("InvStoreBranch");
                        j.HasIndex(new[] { "BranchId" }, "IX_InvStoreBranch_BranchId");
                    });
        });

        modelBuilder.Entity<InvStpUnit>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_InvStpUnits_Code").IsUnique();

            entity.Property(e => e.Utime).HasColumnName("UTime");
        });

        modelBuilder.Entity<InvUnitsHistory>(entity =>
        {
            entity.ToTable("InvUnitsHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvUnitsHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvUnitsHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasIndex(e => e.InvoiceId, "IX_InvoiceDetails_InvoiceId");

            entity.HasIndex(e => e.ItemId, "IX_InvoiceDetails_ItemId");

            entity.HasIndex(e => e.SizeId, "IX_InvoiceDetails_SizeId");

            entity.HasIndex(e => e.UnitId, "IX_InvoiceDetails_UnitId");

            entity.Property(e => e.BalanceBarcode).HasColumnName("balanceBarcode");
            entity.Property(e => e.CodeOfflinePos).HasColumnName("CodeOfflinePOS");
            entity.Property(e => e.ExpireDate).HasColumnType("date");
            entity.Property(e => e.IndexOfItem).HasColumnName("indexOfItem");
            entity.Property(e => e.IndexOfSerialNo).HasColumnName("indexOfSerialNo");
            entity.Property(e => e.ParentItemId).HasColumnName("parentItemId");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Item).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Size).WithMany(p => p.InvoiceDetails).HasForeignKey(d => d.SizeId);

            entity.HasOne(d => d.Unit).WithMany(p => p.InvoiceDetails).HasForeignKey(d => d.UnitId);
        });

        modelBuilder.Entity<InvoiceFile>(entity =>
        {
            entity.HasIndex(e => e.InvoiceId, "IX_InvoiceFiles_InvoiceId");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceFiles)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvoiceMaster>(entity =>
        {
            entity.HasKey(e => e.InvoiceId);

            entity.ToTable("InvoiceMaster");

            entity.HasIndex(e => e.BranchId, "IX_InvoiceMaster_BranchId");

            entity.HasIndex(e => e.EmployeeId, "IX_InvoiceMaster_EmployeeId");

            entity.HasIndex(e => e.InvoiceType, "IX_InvoiceMaster_InvoiceType")
                .IsUnique()
                .HasFilter("([InvoiceType] IS NOT NULL)");

            entity.HasIndex(e => e.PersonId, "IX_InvoiceMaster_PersonId");

            entity.HasIndex(e => e.SalesManId, "IX_InvoiceMaster_SalesManId");

            entity.HasIndex(e => e.StoreId, "IX_InvoiceMaster_StoreId");

            entity.HasIndex(e => e.StoreIdTo, "IX_InvoiceMaster_StoreIdTo");

            entity.Property(e => e.CodeOfflinePos).HasColumnName("CodeOfflinePOS");
            entity.Property(e => e.EmployeeId).HasDefaultValueSql("((1))");
            entity.Property(e => e.PossessionId).HasColumnName("POSSessionId");
            entity.Property(e => e.TransferNotesAr).HasColumnName("TransferNotesAR");
            entity.Property(e => e.TransferNotesEn).HasColumnName("TransferNotesEN");
            entity.Property(e => e.TransferStatus).HasColumnName("transferStatus");

            entity.HasOne(d => d.Branch).WithMany(p => p.InvoiceMasters)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Employee).WithMany(p => p.InvoiceMasters)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Person).WithMany(p => p.InvoiceMasters).HasForeignKey(d => d.PersonId);

            entity.HasOne(d => d.SalesMan).WithMany(p => p.InvoiceMasters).HasForeignKey(d => d.SalesManId);

            entity.HasOne(d => d.Store).WithMany(p => p.InvoiceMasterStores)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.StoreIdToNavigation).WithMany(p => p.InvoiceMasterStoreIdToNavigations).HasForeignKey(d => d.StoreIdTo);
        });

        modelBuilder.Entity<InvoiceMasterHistory>(entity =>
        {
            entity.ToTable("InvoiceMasterHistory");

            entity.HasIndex(e => e.EmployeesId, "IX_InvoiceMasterHistory_employeesId");

            entity.Property(e => e.EmployeesId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("employeesId");

            entity.HasOne(d => d.Employees).WithMany(p => p.InvoiceMasterHistories).HasForeignKey(d => d.EmployeesId);
        });

        modelBuilder.Entity<InvoicePaymentsMethod>(entity =>
        {
            entity.HasIndex(e => e.InvoiceId, "IX_InvoicePaymentsMethods_InvoiceId");

            entity.HasIndex(e => e.PaymentMethodId, "IX_InvoicePaymentsMethods_PaymentMethodId");

            entity.Property(e => e.CodeOfflinePos).HasColumnName("CodeOfflinePOS");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoicePaymentsMethods)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.InvoicePaymentsMethods)
                .HasForeignKey(d => d.PaymentMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InvoiceSerialize>(entity =>
        {
            entity.ToTable("InvoiceSerialize");
        });

        modelBuilder.Entity<NotificationSeen>(entity =>
        {
            entity.ToTable("NotificationSeen");

            entity.HasIndex(e => e.NotificationsMasterId, "IX_NotificationSeen_NotificationsMasterId");

            entity.HasIndex(e => e.UserId, "IX_NotificationSeen_UserId");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

            entity.HasOne(d => d.NotificationsMaster).WithMany(p => p.NotificationSeens)
                .HasForeignKey(d => d.NotificationsMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.NotificationSeens)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<NotificationsMaster>(entity =>
        {
            entity.ToTable("NotificationsMaster");

            entity.HasIndex(e => e.InsertedById, "IX_NotificationsMaster_insertedById");

            entity.HasIndex(e => e.SpecialUserId, "IX_NotificationsMaster_specialUserId");

            entity.Property(e => e.CDate).HasColumnName("cDate");
            entity.Property(e => e.InsertedById).HasColumnName("insertedById");
            entity.Property(e => e.IsSystem).HasColumnName("isSystem");
            entity.Property(e => e.PageId).HasColumnName("pageId");
            entity.Property(e => e.RouteUrl).HasColumnName("routeUrl");
            entity.Property(e => e.SpecialUserId).HasColumnName("specialUserId");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.TitleEn).HasColumnName("titleEn");

            entity.HasOne(d => d.InsertedBy).WithMany(p => p.NotificationsMasterInsertedBies).HasForeignKey(d => d.InsertedById);

            entity.HasOne(d => d.SpecialUser).WithMany(p => p.NotificationsMasterSpecialUsers).HasForeignKey(d => d.SpecialUserId);
        });

        modelBuilder.Entity<OfferPriceDetail>(entity =>
        {
            entity.HasIndex(e => e.InvoiceId, "IX_OfferPriceDetails_InvoiceId");

            entity.HasIndex(e => e.ItemId, "IX_OfferPriceDetails_ItemId");

            entity.HasIndex(e => e.SizeId, "IX_OfferPriceDetails_SizeId");

            entity.HasIndex(e => e.UnitId, "IX_OfferPriceDetails_UnitId");

            entity.Property(e => e.BalanceBarcode).HasColumnName("balanceBarcode");
            entity.Property(e => e.ExpireDate).HasColumnType("date");
            entity.Property(e => e.IndexOfItem).HasColumnName("indexOfItem");
            entity.Property(e => e.IndexOfSerialNo).HasColumnName("indexOfSerialNo");
            entity.Property(e => e.ParentItemId).HasColumnName("parentItemId");

            entity.HasOne(d => d.Invoice).WithMany(p => p.OfferPriceDetails)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Item).WithMany(p => p.OfferPriceDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Size).WithMany(p => p.OfferPriceDetails).HasForeignKey(d => d.SizeId);

            entity.HasOne(d => d.Unit).WithMany(p => p.OfferPriceDetails).HasForeignKey(d => d.UnitId);
        });

        modelBuilder.Entity<OfferPriceMaster>(entity =>
        {
            entity.HasKey(e => e.InvoiceId);

            entity.ToTable("OfferPriceMaster");

            entity.HasIndex(e => e.BranchId, "IX_OfferPriceMaster_BranchId");

            entity.HasIndex(e => e.EmployeeId, "IX_OfferPriceMaster_EmployeeId");

            entity.HasIndex(e => e.InvoiceType, "IX_OfferPriceMaster_InvoiceType")
                .IsUnique()
                .HasFilter("([InvoiceType] IS NOT NULL)");

            entity.HasIndex(e => e.PersonId, "IX_OfferPriceMaster_PersonId");

            entity.HasIndex(e => e.SalesManId, "IX_OfferPriceMaster_SalesManId");

            entity.HasIndex(e => e.StoreId, "IX_OfferPriceMaster_StoreId");

            entity.Property(e => e.EmployeeId).HasDefaultValueSql("((1))");
            entity.Property(e => e.TransferNotesAr).HasColumnName("TransferNotesAR");
            entity.Property(e => e.TransferNotesEn).HasColumnName("TransferNotesEN");
            entity.Property(e => e.TransferStatus).HasColumnName("transferStatus");

            entity.HasOne(d => d.Branch).WithMany(p => p.OfferPriceMasters)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Employee).WithMany(p => p.OfferPriceMasters)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Person).WithMany(p => p.OfferPriceMasters).HasForeignKey(d => d.PersonId);

            entity.HasOne(d => d.SalesMan).WithMany(p => p.OfferPriceMasters).HasForeignKey(d => d.SalesManId);

            entity.HasOne(d => d.Store).WithMany(p => p.OfferPriceMasters)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OtherAuthority>(entity =>
        {
            entity.HasIndex(e => e.BranchId, "IX_OtherAuthorities_BranchId");

            entity.HasIndex(e => e.FinancialAccountId, "IX_OtherAuthorities_FinancialAccountId");

            entity.HasOne(d => d.Branch).WithMany(p => p.OtherAuthorities).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.FinancialAccount).WithMany(p => p.OtherAuthorities).HasForeignKey(d => d.FinancialAccountId);
        });

        modelBuilder.Entity<OtherSetting>(entity =>
        {
            entity.ToTable("otherSettings");

            entity.HasIndex(e => e.UserAccountId, "IX_otherSettings_userAccountId");

            entity.Property(e => e.AccredditForAllUsers).HasColumnName("accredditForAllUsers");
            entity.Property(e => e.AllowCloseCloudPossession).HasColumnName("allowCloseCloudPOSSession");
            entity.Property(e => e.CanShowAllPossessions).HasColumnName("canShowAllPOSSessions");
            entity.Property(e => e.PosAddDiscount).HasColumnName("posAddDiscount");
            entity.Property(e => e.PosAllowCreditSales).HasColumnName("posAllowCreditSales");
            entity.Property(e => e.PosCashPayment).HasColumnName("posCashPayment");
            entity.Property(e => e.PosEditOtherPersonsInv).HasColumnName("posEditOtherPersonsInv");
            entity.Property(e => e.PosNetPayment).HasColumnName("posNetPayment");
            entity.Property(e => e.PosOtherPayment).HasColumnName("posOtherPayment");
            entity.Property(e => e.PosShowOtherPersonsInv).HasColumnName("posShowOtherPersonsInv");
            entity.Property(e => e.PosShowReportsOfOtherPersons).HasColumnName("posShowReportsOfOtherPersons");
            entity.Property(e => e.PurchaseShowBalanceOfPerson)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("purchaseShowBalanceOfPerson");
            entity.Property(e => e.PurchasesAddDiscount).HasColumnName("purchasesAddDiscount");
            entity.Property(e => e.PurchasesAllowCreditSales).HasColumnName("purchasesAllowCreditSales");
            entity.Property(e => e.PurchasesEditOtherPersonsInv).HasColumnName("purchasesEditOtherPersonsInv");
            entity.Property(e => e.PurchasesShowOtherPersonsInv).HasColumnName("purchasesShowOtherPersonsInv");
            entity.Property(e => e.PurchasesShowReportsOfOtherPersons).HasColumnName("purchasesShowReportsOfOtherPersons");
            entity.Property(e => e.SalesAddDiscount).HasColumnName("salesAddDiscount");
            entity.Property(e => e.SalesAllowCreditSales).HasColumnName("salesAllowCreditSales");
            entity.Property(e => e.SalesCashPayment).HasColumnName("salesCashPayment");
            entity.Property(e => e.SalesEditOtherPersonsInv).HasColumnName("salesEditOtherPersonsInv");
            entity.Property(e => e.SalesNetPayment).HasColumnName("salesNetPayment");
            entity.Property(e => e.SalesOtherPayment).HasColumnName("salesOtherPayment");
            entity.Property(e => e.SalesShowBalanceOfPerson)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))")
                .HasColumnName("salesShowBalanceOfPerson");
            entity.Property(e => e.SalesShowOtherPersonsInv).HasColumnName("salesShowOtherPersonsInv");
            entity.Property(e => e.SalesShowReportsOfOtherPersons).HasColumnName("salesShowReportsOfOtherPersons");
            entity.Property(e => e.ShowAllBranchesInCustomerInfo).HasColumnName("showAllBranchesInCustomerInfo");
            entity.Property(e => e.ShowAllBranchesInSuppliersInfo).HasColumnName("showAllBranchesInSuppliersInfo");
            entity.Property(e => e.ShowCustomersOfOtherUsers).HasColumnName("showCustomersOfOtherUsers");
            entity.Property(e => e.ShowDashboardForAllUsers).HasColumnName("showDashboardForAllUsers");
            entity.Property(e => e.ShowHistory).HasColumnName("showHistory");
            entity.Property(e => e.ShowOfferPricesOfOtherUser).HasColumnName("showOfferPricesOfOtherUser");
            entity.Property(e => e.UserAccountId).HasColumnName("userAccountId");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.OtherSettings).HasForeignKey(d => d.UserAccountId);
        });

        modelBuilder.Entity<OtherSettingsBank>(entity =>
        {
            entity.HasIndex(e => e.GLbankId, "IX_OtherSettingsBanks_gLBankId");

            entity.HasIndex(e => e.OtherSettingsId, "IX_OtherSettingsBanks_otherSettingsId");

            entity.Property(e => e.GLbankId).HasColumnName("gLBankId");
            entity.Property(e => e.OtherSettingsId).HasColumnName("otherSettingsId");

            entity.HasOne(d => d.GLbank).WithMany(p => p.OtherSettingsBanks).HasForeignKey(d => d.GLbankId);

            entity.HasOne(d => d.OtherSettings).WithMany(p => p.OtherSettingsBanks).HasForeignKey(d => d.OtherSettingsId);
        });

        modelBuilder.Entity<OtherSettingsSafe>(entity =>
        {
            entity.HasIndex(e => e.GLsafeId, "IX_OtherSettingsSafes_gLSafeId");

            entity.HasIndex(e => e.OtherSettingsId, "IX_OtherSettingsSafes_otherSettingsId");

            entity.Property(e => e.GLsafeId).HasColumnName("gLSafeId");
            entity.Property(e => e.OtherSettingsId).HasColumnName("otherSettingsId");

            entity.HasOne(d => d.GLsafe).WithMany(p => p.OtherSettingsSaves).HasForeignKey(d => d.GLsafeId);

            entity.HasOne(d => d.OtherSettings).WithMany(p => p.OtherSettingsSaves).HasForeignKey(d => d.OtherSettingsId);
        });

        modelBuilder.Entity<OtherSettingsStore>(entity =>
        {
            entity.HasIndex(e => e.InvStpStoresId, "IX_OtherSettingsStores_InvStpStoresId");

            entity.HasIndex(e => e.OtherSettingsId, "IX_OtherSettingsStores_otherSettingsId");

            entity.Property(e => e.OtherSettingsId).HasColumnName("otherSettingsId");

            entity.HasOne(d => d.InvStpStores).WithMany(p => p.OtherSettingsStores).HasForeignKey(d => d.InvStpStoresId);

            entity.HasOne(d => d.OtherSettings).WithMany(p => p.OtherSettingsStores).HasForeignKey(d => d.OtherSettingsId);
        });

        modelBuilder.Entity<PermissionList>(entity =>
        {
            entity.ToTable("permissionList");

            entity.Property(e => e.ArabicName).HasColumnName("arabicName");
            entity.Property(e => e.LatinName).HasColumnName("latinName");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Utime).HasColumnName("UTime");
        });

        modelBuilder.Entity<PosOfflineDevice>(entity =>
        {
            entity.ToTable("POS_OfflineDevices");
        });

        modelBuilder.Entity<Posdevice>(entity =>
        {
            entity.ToTable("POSDevices");

            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
        });

        modelBuilder.Entity<PosinvSuspensionDetail>(entity =>
        {
            entity.ToTable("POSInvSuspensionDetails");

            entity.HasIndex(e => e.InvoiceId, "IX_POSInvSuspensionDetails_InvoiceId");

            entity.HasIndex(e => e.ItemId, "IX_POSInvSuspensionDetails_ItemId");

            entity.HasIndex(e => e.SizeId, "IX_POSInvSuspensionDetails_SizeId");

            entity.HasIndex(e => e.UnitId, "IX_POSInvSuspensionDetails_UnitId");

            entity.Property(e => e.ExpireDate).HasColumnType("date");
            entity.Property(e => e.IndexOfItem).HasColumnName("indexOfItem");
            entity.Property(e => e.IndexOfSerialNo).HasColumnName("indexOfSerialNo");

            entity.HasOne(d => d.Invoice).WithMany(p => p.PosinvSuspensionDetails)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Item).WithMany(p => p.PosinvSuspensionDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Size).WithMany(p => p.PosinvSuspensionDetails).HasForeignKey(d => d.SizeId);

            entity.HasOne(d => d.Unit).WithMany(p => p.PosinvSuspensionDetails).HasForeignKey(d => d.UnitId);
        });

        modelBuilder.Entity<PosinvoiceSuspension>(entity =>
        {
            entity.HasKey(e => e.InvoiceId);

            entity.ToTable("POSInvoiceSuspension");

            entity.HasIndex(e => e.BranchId, "IX_POSInvoiceSuspension_BranchId");

            entity.HasIndex(e => e.EmployeeId, "IX_POSInvoiceSuspension_EmployeeId");

            entity.HasIndex(e => e.PersonId, "IX_POSInvoiceSuspension_PersonId");

            entity.HasIndex(e => e.SalesManId, "IX_POSInvoiceSuspension_SalesManId");

            entity.HasIndex(e => e.StoreId, "IX_POSInvoiceSuspension_StoreId");

            entity.Property(e => e.EmployeeId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Branch).WithMany(p => p.PosinvoiceSuspensions)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Employee).WithMany(p => p.PosinvoiceSuspensions)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Person).WithMany(p => p.PosinvoiceSuspensions).HasForeignKey(d => d.PersonId);

            entity.HasOne(d => d.SalesMan).WithMany(p => p.PosinvoiceSuspensions).HasForeignKey(d => d.SalesManId);

            entity.HasOne(d => d.Store).WithMany(p => p.PosinvoiceSuspensions)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Possession>(entity =>
        {
            entity.ToTable("POSSession");

            entity.HasIndex(e => e.EmployeeId, "IX_POSSession_employeeId");

            entity.HasIndex(e => e.SessionClosedById, "IX_POSSession_sessionClosedById");

            entity.HasIndex(e => e.SessionCode, "IX_POSSession_sessionCode").IsUnique();

            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.End).HasColumnName("end");
            entity.Property(e => e.SessionClosedById).HasColumnName("sessionClosedById");
            entity.Property(e => e.SessionCode).HasColumnName("sessionCode");
            entity.Property(e => e.SessionStatus).HasColumnName("sessionStatus");
            entity.Property(e => e.Start).HasColumnName("start");

            entity.HasOne(d => d.Employee).WithMany(p => p.PossessionEmployees).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.SessionClosedBy).WithMany(p => p.PossessionSessionClosedBies).HasForeignKey(d => d.SessionClosedById);
        });

        modelBuilder.Entity<PossessionHistory>(entity =>
        {
            entity.ToTable("POSSessionHistory");

            entity.HasIndex(e => e.PossessionId, "IX_POSSessionHistory_POSSessionId");

            entity.HasIndex(e => e.EmployeesId, "IX_POSSessionHistory_employeesId");

            entity.Property(e => e.ActionAr).HasColumnName("actionAr");
            entity.Property(e => e.ActionEn).HasColumnName("actionEn");
            entity.Property(e => e.EmployeesId).HasColumnName("employeesId");
            entity.Property(e => e.PossessionId).HasColumnName("POSSessionId");

            entity.HasOne(d => d.Employees).WithMany(p => p.PossessionHistories)
                .HasForeignKey(d => d.EmployeesId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Possession).WithMany(p => p.PossessionHistories)
                .HasForeignKey(d => d.PossessionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PostouchSetting>(entity =>
        {
            entity.ToTable("POSTouchSettings");

            entity.Property(e => e.PosTouchCategoryImgHeight).HasColumnName("PosTouch_CategoryImgHeight");
            entity.Property(e => e.PosTouchCategoryImgWidth).HasColumnName("PosTouch_CategoryImgWidth");
            entity.Property(e => e.PosTouchDisplayItemPrice).HasColumnName("PosTouch_DisplayItemPrice");
            entity.Property(e => e.PosTouchFontSize).HasColumnName("PosTouch_FontSize");
            entity.Property(e => e.PosTouchItemsImgHeight).HasColumnName("PosTouch_ItemsImgHeight");
            entity.Property(e => e.PosTouchItemsImgWidth).HasColumnName("PosTouch_ItemsImgWidth");
            entity.Property(e => e.PosTouchTableWidth).HasColumnName("PosTouch_TableWidth");
        });

        modelBuilder.Entity<RecHistory>(entity =>
        {
            entity.ToTable("RecHistory");

            entity.Property(e => e.Os).HasColumnName("OS");
        });

        modelBuilder.Entity<ReportFile>(entity =>
        {
            entity.ToTable("reportFiles");

            entity.Property(e => e.UTime)
                .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')")
                .HasColumnName("uTime");
        });

        modelBuilder.Entity<ReportManger>(entity =>
        {
            entity.ToTable("ReportManger");

            entity.HasIndex(e => e.ArabicFilenameId, "IX_ReportManger_ArabicFilenameId");

            entity.HasIndex(e => e.ScreenId, "IX_ReportManger_screenId");

            entity.Property(e => e.ScreenId).HasColumnName("screenId");

            entity.HasOne(d => d.ArabicFilename).WithMany(p => p.ReportMangers)
                .HasForeignKey(d => d.ArabicFilenameId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Screen).WithMany(p => p.ReportMangers)
                .HasForeignKey(d => d.ScreenId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Rule>(entity =>
        {
            entity.ToTable("rules");

            entity.HasIndex(e => e.PermissionListId, "IX_rules_permissionListId");

            entity.Property(e => e.ApplicationId).HasColumnName("applicationId");
            entity.Property(e => e.ArabicName).HasColumnName("arabicName");
            entity.Property(e => e.IsAdd).HasColumnName("isAdd");
            entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            entity.Property(e => e.IsEdit).HasColumnName("isEdit");
            entity.Property(e => e.IsPrint).HasColumnName("isPrint");
            entity.Property(e => e.IsShow).HasColumnName("isShow");
            entity.Property(e => e.IsVisible).HasColumnName("isVisible");
            entity.Property(e => e.LatinName).HasColumnName("latinName");
            entity.Property(e => e.MainFormCode).HasColumnName("mainFormCode");
            entity.Property(e => e.PermissionListId).HasColumnName("permissionListId");
            entity.Property(e => e.SubFormCode).HasColumnName("subFormCode");
            entity.Property(e => e.Utime).HasColumnName("UTime");

            entity.HasOne(d => d.PermissionList).WithMany(p => p.Rules).HasForeignKey(d => d.PermissionListId);
        });

        modelBuilder.Entity<ScreenName>(entity =>
        {
            entity.ToTable("screenNames");
        });

        modelBuilder.Entity<SignalR>(entity =>
        {
            entity.ToTable("signalR");

            entity.HasIndex(e => e.InvEmployeesId, "IX_signalR_InvEmployeesId");

            entity.Property(e => e.ConnectionId).HasColumnName("connectionId");
            entity.Property(e => e.IsOnline).HasColumnName("isOnline");

            entity.HasOne(d => d.InvEmployees).WithMany(p => p.SignalRs).HasForeignKey(d => d.InvEmployeesId);
        });

        modelBuilder.Entity<SigninLog>(entity =>
        {
            entity.ToTable("signinLogs");

            entity.HasIndex(e => e.UserAccountid, "IX_signinLogs_userAccountid");

            entity.Property(e => e.IsLocked).HasColumnName("isLocked");
            entity.Property(e => e.IsLogout).HasColumnName("isLogout");
            entity.Property(e => e.LastActionTime).HasColumnName("lastActionTime");
            entity.Property(e => e.LogoutDateTime).HasColumnName("logoutDateTime");
            entity.Property(e => e.SigninDateTime).HasColumnName("signinDateTime");
            entity.Property(e => e.StayLoggedin).HasColumnName("stayLoggedin");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.UserAccountid).HasColumnName("userAccountid");

            entity.HasOne(d => d.UserAccount).WithMany(p => p.SigninLogs).HasForeignKey(d => d.UserAccountid);
        });

        modelBuilder.Entity<SubCodeLevel>(entity =>
        {
            entity.HasIndex(e => e.GlgeneralSettingId, "IX_SubCodeLevels_GLGeneralSettingId");

            entity.Property(e => e.GlgeneralSettingId).HasColumnName("GLGeneralSettingId");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.GlgeneralSetting).WithMany(p => p.SubCodeLevels).HasForeignKey(d => d.GlgeneralSettingId);
        });

        modelBuilder.Entity<SystemHistoryLog>(entity =>
        {
            entity.HasIndex(e => e.BranchId, "IX_SystemHistoryLogs_BranchId");

            entity.HasIndex(e => e.EmployeesId, "IX_SystemHistoryLogs_employeesId");

            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EmployeesId).HasColumnName("employeesId");

            entity.HasOne(d => d.Branch).WithMany(p => p.SystemHistoryLogs).HasForeignKey(d => d.BranchId);

            entity.HasOne(d => d.Employees).WithMany(p => p.SystemHistoryLogs)
                .HasForeignKey(d => d.EmployeesId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TransferDataFromDeskTop>(entity =>
        {
            entity.ToTable("TransferDataFromDeskTop");
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.ToTable("userAccount");

            entity.HasIndex(e => e.EmployeesId, "IX_userAccount_employeesId");

            entity.HasIndex(e => e.PermissionListId, "IX_userAccount_permissionListId");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.EmployeesId).HasColumnName("employeesId");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.PermissionListId).HasColumnName("permissionListId");
            entity.Property(e => e.Username).HasColumnName("username");

            entity.HasOne(d => d.Employees).WithMany(p => p.UserAccounts)
                .HasForeignKey(d => d.EmployeesId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PermissionList).WithMany(p => p.UserAccounts).HasForeignKey(d => d.PermissionListId);
        });

        modelBuilder.Entity<UserAndPermission>(entity =>
        {
            entity.ToTable("UserAndPermission");

            entity.HasIndex(e => e.PermissionListId, "IX_UserAndPermission_permissionListId");

            entity.HasIndex(e => e.UserAccountId, "IX_UserAndPermission_userAccountId");

            entity.Property(e => e.PermissionListId).HasColumnName("permissionListId");
            entity.Property(e => e.UserAccountId).HasColumnName("userAccountId");
            entity.Property(e => e.Utime).HasColumnName("UTime");

            entity.HasOne(d => d.PermissionList).WithMany(p => p.UserAndPermissions).HasForeignKey(d => d.PermissionListId);

            entity.HasOne(d => d.UserAccount).WithMany(p => p.UserAndPermissions).HasForeignKey(d => d.UserAccountId);
        });

        modelBuilder.Entity<UserBranch>(entity =>
        {
            entity.ToTable("userBranches");

            entity.HasIndex(e => e.GlbranchId, "IX_userBranches_GLBranchId");

            entity.HasIndex(e => e.UserAccountId, "IX_userBranches_userAccountId");

            entity.Property(e => e.GlbranchId).HasColumnName("GLBranchId");
            entity.Property(e => e.UserAccountId).HasColumnName("userAccountId");

            entity.HasOne(d => d.Glbranch).WithMany(p => p.UserBranches)
                .HasForeignKey(d => d.GlbranchId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UserAccount).WithMany(p => p.UserBranches).HasForeignKey(d => d.UserAccountId);
        });

        modelBuilder.Entity<UsersForgetPassword>(entity =>
        {
            entity.ToTable("usersForgetPassword");

            entity.HasIndex(e => e.UserId, "IX_usersForgetPassword_userId");

            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.UsersForgetPasswords).HasForeignKey(d => d.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
