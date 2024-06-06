namespace App.Domain.Enums
{
    public class Enums
    {
        public enum POSSessionStatus
        {
            active = 1,
            deactive = 2,
            bining = 3
        }
        public enum PersonTypes
        {
            customer = 1,
            supplier = 2
        }
        public enum ERPTool_CreateJournalEntry
        {
            entryFund = 1,
            puchases = 2,
            sales = 3,
            pos = 4,
            recsAndSettlements = 5
        }
        public enum SecurityApplicationAdditionalPriceIndexs
        {
            extraUsers = 1,
            extraEmployees = 2,
            extraPOS = 3,
            extraStores = 4,
            extraBranches = 5,
            extraCustomers = 6,
            extraSuppliers = 7,
            extraInvoices = 8
        }

        public enum ERPReportsActions
        {
            addNew = 0,
            Replace = 1,
            delete = 2
        }
        public enum Result
        {
            Failed = 0,
            Success = 1,
            Exist = 2,
            ReleatedData = 3,
            NoDefinedPeriods = 4,
            OverlappingPeriods = 5,
            ExistInOtherModule = 6,
            MissingSystemOption = 7,
            NoDataFound = 8,
            RequiredData = 9,
            CanNotBeDeleted = 10,
            ItemCodeExist = 11,
            NationalExist = 12,
            BarcodeExist = 13,
            SerialExist = 14,
            NationalItemCodeExist = 15,
            NotFound = 16,
            InActive = 17,
            NotExist = 18,
            NotTotalPaid = 19,
            NotFoundEmail = 20,
            QuantityNotavailable = 21,
            PaidOvershootNet = 22,
            CanNotBeUpdated = 23,
            CanNotAddCompositeItem = 24,
            InvoiceTotalReturned = 25,
            Deleted = 26,
            NoDataChanged = 27,
            SerialNotExist = 28,
            CanNotDeleteSerial = 29,
            UnAuthorized = 30,
            EnterExpiryDate = 31,
            EnterSerials = 32,
            itemNotUsedInSales = 33,
            MaximumLength = 34,
            InvoiceDeletedOrReturned = 35,
            MaxCountOfItems = 36,
            SerialsConflicted = 37,
            logout = 38,
            bindedTransfer = 39,
            periodEnded = 40,
            userLocked = 41,
            DeferredSale = 42,
            editingDate = 43,
        }

        public enum RepositoryActionStatus
        {
            Ok,
            Created,
            Updated,
            NotFound,
            Deleted,
            NothingModified,
            Error,
            BadRequest,
            UnAuthorized,
            ExistedBefore,
            NothingAdded,
            ImportScussfully,
            ImportWithErrors,
            UpdateFileScussfully,
            UpdateFileWithErrors,
            EmptyFile,
            IsShiftOpen,
            CanNotDelete
        }

        public enum Status
        {
            Active = 1,
            Inactive = 2
        }

        public enum FA_Nature
        {
            Debit = 1,
            Credit = 2
        }
        public enum FinalAccount
        {
            Budget = 1,
            IncomeList = 2
        }
        public enum HistoryTitle
        {
            Add = 1,
            Update = 2,
            Delete = 3,
            Print = 4
        }

        //
        public enum StepType
        {
            back = -1,
            next = 1,
            first = 0,
            last = -2
        }

        public enum UsedInSales
        {
            Used = 1,
            NotUsed = 2
        }

        public class TransactionTypeModel
        {
            public int id { get; set; }
            public string arabicName { get; set; }
            public string latinName { get; set; }
        }
        
        public enum PaymentType
        {
            all = 0,
            Complete = 1,// مسدد 
            Partial = 2, // جزئي
            Delay = 3,// اجل
        }
        
        public enum FinancialAccountRelationSettings
        {
            ChooseManualAccount = 1,
            CreateAccountAutomaticWithTheParentAccountId = 2,
            ChooseoneAccountTobeDefult = 3
        }
        public enum GLFinancialAccountRelation
        {
            customer = 1,
            supplier = 2,
            bank = 3,
            safe = 4,
            salesman = 5,
            employee = 6,
            OtherAuthorities = 7
        }


    }
}
