using System;
using System.Collections.Generic;

namespace App.Infrastructure.ERPContext;

public partial class GlfinancialAccount
{
    public int Id { get; set; }

    public int CurrencyId { get; set; }

    public string? AccountCode { get; set; }

    public string? AutoCoding { get; set; }

    public int MainCode { get; set; }

    public int SubCode { get; set; }

    public int Status { get; set; }

    public int FaNature { get; set; }

    public int FinalAccount { get; set; }

    public double Credit { get; set; }

    public double Debit { get; set; }

    public double OpenningCredit { get; set; }

    public double OpenningDebit { get; set; }

    public string? Notes { get; set; }

    public int? ParentId { get; set; }

    public int? HasCostCenter { get; set; }

    public bool IsBlock { get; set; }

    public string? BrowserName { get; set; }

    public bool IsMain { get; set; }

    public int BranchId { get; set; }

    public string? LastTransactionAction { get; set; }

    public string? AddTransactionUser { get; set; }

    public string? AddTransactionDate { get; set; }

    public string? LastTransactionUser { get; set; }

    public string? LastTransactionDate { get; set; }

    public string? DeleteTransactionUser { get; set; }

    public string? DeleteTransactionDate { get; set; }

    public string? LastTransactionUserAr { get; set; }

    public string? LatinName { get; set; }

    public string? ArabicName { get; set; }

    public virtual Glcurrency Currency { get; set; } = null!;

    public virtual ICollection<GlReciept> GlReciepts { get; } = new List<GlReciept>();

    public virtual ICollection<Glbank> Glbanks { get; } = new List<Glbank>();

    public virtual ICollection<GlfinancialBranch> GlfinancialBranches { get; } = new List<GlfinancialBranch>();

    public virtual ICollection<GlfinancialSetting> GlfinancialSettings { get; } = new List<GlfinancialSetting>();

    public virtual ICollection<GlintegrationSetting> GlintegrationSettings { get; } = new List<GlintegrationSetting>();

    public virtual ICollection<GljournalEntryDetail> GljournalEntryDetails { get; } = new List<GljournalEntryDetail>();

    public virtual ICollection<GlpurchasesAndSalesSetting> GlpurchasesAndSalesSettings { get; } = new List<GlpurchasesAndSalesSetting>();

    public virtual ICollection<Glsafe> Glsaves { get; } = new List<Glsafe>();

    public virtual ICollection<InvEmployee> InvEmployees { get; } = new List<InvEmployee>();

    public virtual ICollection<InvPerson> InvPeople { get; } = new List<InvPerson>();

    public virtual ICollection<InvSalesMan> InvSalesMen { get; } = new List<InvSalesMan>();

    public virtual ICollection<GlfinancialAccount> InverseParent { get; } = new List<GlfinancialAccount>();

    public virtual ICollection<OtherAuthority> OtherAuthorities { get; } = new List<OtherAuthority>();

    public virtual GlfinancialAccount? Parent { get; set; }

    public virtual ICollection<Glbranch> Branches { get; } = new List<Glbranch>();

    public virtual ICollection<GlcostCenter> CostCenters { get; } = new List<GlcostCenter>();

    public virtual ICollection<GljournalEntry> JournalEntries { get; } = new List<GljournalEntry>();
}
