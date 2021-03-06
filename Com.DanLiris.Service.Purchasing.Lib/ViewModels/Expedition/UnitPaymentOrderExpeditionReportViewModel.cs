﻿using Com.DanLiris.Service.Purchasing.Lib.Enums;
using Com.DanLiris.Service.Purchasing.Lib.ViewModels.NewIntegrationViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.Expedition
{
    public class UnitPaymentOrderExpeditionReportViewModel
    {
        public string No { get; set; }
        public DateTimeOffset? Date { get; set; }
        public DateTimeOffset? DueDate { get; set; }
        public string InvoiceNo { get; set; }
        public NewSupplierViewModel Supplier { get; set; }
        public DivisionViewModel Division { get; set; }
        public ExpeditionPosition Position { get; set; }
        public DateTimeOffset? SendToVerificationDivisionDate { get; set; }
        public DateTimeOffset? VerificationDivisionDate { get; set; }
        public DateTimeOffset? VerifyDate { get; set; }
        public DateTimeOffset? SendDate { get; set; }
        public DateTimeOffset? CashierDivisionDate { get; set; }
        public string BankExpenditureNoteNo { get; set; }
        public DateTime LastModifiedUtc { get; set; }
    }

    public class UnitPaymentOrderExpeditionReportWrapper
    {
        public int Total { get; set; }
        public List<UnitPaymentOrderExpeditionReportViewModel> Data { get; set; }
    }
}
