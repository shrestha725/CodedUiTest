using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUiTest.EmployeeDeductions
{
  
    public class EmployeeDeductionsControls
    {
        private EmpowerBrowserWindow empowerBrowserWindow;

        public EmpowerBrowserWindow EmpowerBrowserWindow
        {
            get
            {
                this.empowerBrowserWindow = new EmpowerBrowserWindow();
                return this.empowerBrowserWindow;
            }
        }
    }

    //========================================================================================================================================

    public class EmpowerBrowserWindow : BrowserWindow
    {
        private EmpowerHtmlDocument empowerHtmlDocument;

        public EmpowerBrowserWindow()
        {

        }

        public EmpowerHtmlDocument EmpowerHtmlDocument
        {
            get
            {
                this.empowerHtmlDocument = new EmpowerHtmlDocument(this);
                return this.empowerHtmlDocument;
            }
        }
    };

    //========================================================================================================================================

    public class EmpowerHtmlDocument : HtmlDocument
    {
        private AdminHtmlDocumentFrame adminHtmlDocumentFrame;

        public EmpowerHtmlDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/HomePage.aspx";
        }

        public AdminHtmlDocumentFrame AdminHtmlDocumentFrame
        {
            get
            {
                this.adminHtmlDocumentFrame = new AdminHtmlDocumentFrame(this);
                return this.adminHtmlDocumentFrame;
            }
        }
    };

    public class AdminHtmlDocumentFrame : HtmlIFrame
    {
        private AdminHtmlDocument adminHtmlDocument;

        public AdminHtmlDocumentFrame(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "Home";
        }

        public AdminHtmlDocument AdminHtmlDocument
        {
            get
            {
                this.adminHtmlDocument = new AdminHtmlDocument(this);
                return this.adminHtmlDocument;
            }
        }
    };

    public class AdminHtmlDocument : HtmlDocument
    {
        //==================================================Deduction Fields===============================================================

        private HtmlEdit affiliation;
        private HtmlEdit schedule;
        private HtmlEdit partycode;
        private HtmlEdit deductionamount;
        private HtmlEdit deductionpercent;
        private HtmlEdit goalamount;
        private HtmlEdit goalseqnumber;
        private HtmlEdit prioritynumber;
        private HtmlEdit dedenddate;
        private HtmlCheckBox inactive;
        
        public AdminHtmlDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/Secured/Admin/AdminManager.aspx";
        }


        public HtmlEdit Affiliation
        {
            get
            {
                this.affiliation = new HtmlEdit(this);
                this.affiliation.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "DeductionAffiliationCode";
                return this.affiliation;
            }
        }
        public HtmlEdit Schedule
        {
            get
            {
                this.schedule = new HtmlEdit(this);
                this.schedule.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "ScheduleCode";
                return this.schedule;
            }
        }
        public HtmlEdit PartyCode
        {
            get
            {
                this.partycode = new HtmlEdit(this);
                this.partycode.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "PartyCode";
                return this.partycode;
            }
        }

        public HtmlEdit DeductionAmount
        {
            get
            {
                this.deductionamount = new HtmlEdit(this);
                this.deductionamount.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "DeductionAmount";
                return this.deductionamount;
            }
        }

        public HtmlEdit DeductionPercent
        {
            get
            {
                this.deductionpercent = new HtmlEdit(this);
                this.deductionpercent.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "DeductionPercent";
                return this.deductionpercent;
            }
        }

        public HtmlEdit GoalAmount
        {
            get
            {
                this.goalamount = new HtmlEdit(this);
                this.goalamount.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "GoalAmount";
                return this.goalamount;
            }
        }

        public HtmlEdit GoalSequenceNumber
        {
            get
            {
                this.goalseqnumber = new HtmlEdit(this);
                this.goalseqnumber.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "GoalSequenceNumber";
                return this.goalseqnumber;
            }
        }

        public HtmlEdit PriorityNumber
        {
            get
            {
                this.prioritynumber = new HtmlEdit(this);
                this.prioritynumber.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "PriorityNumber";
                return this.prioritynumber;
            }
        }

        public HtmlEdit DeductionEndDate
        {
            get
            {
                this.dedenddate = new HtmlEdit(this);
                this.dedenddate.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "DeductionEndDate";
                return this.dedenddate;
            }
        }

        public HtmlCheckBox Inactive
        {
            get
            {
                this.inactive = new HtmlCheckBox(this);
                this.inactive.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "ctl23_E_Deduction_Inactive";
                return this.inactive;
            }
        }

        //==================================================Direct Deposit Fields===============================================================

        private HtmlEdit directdeposit_countrycode;
        private HtmlEdit banktransitno;
        private HtmlEdit bankaccountno;
        private HtmlEdit bankname;
        private HtmlEdit checkingorsavings;
        private HtmlEdit prenotificationissuedate;
        private HtmlEdit allowedstartdate;

        public HtmlEdit DirectDepositCountryCode
        {
            get
            {
                this.directdeposit_countrycode = new HtmlEdit(this);
                this.directdeposit_countrycode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl28_E_DeductionDirectDepositExtension_CountryCode_Input";
                return this.directdeposit_countrycode;
            }
        }

        public HtmlEdit BankTransitNumber
        {
            get
            {
                this.banktransitno = new HtmlEdit(this);
                this.banktransitno.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "BankTransitNumber";
                return this.banktransitno;
            }
        }

        public HtmlEdit BankAccountNumber
        {
            get
            {
                this.bankaccountno = new HtmlEdit(this);
                this.bankaccountno.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "BankAccountNumber";
                return this.bankaccountno;
            }
        }

        public HtmlEdit BankName
        {
            get
            {
                this.bankname = new HtmlEdit(this);
                this.bankname.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "BankName";
                return this.bankname;
            }
        }

        public HtmlEdit CheckingOrSavings
        {
            get
            {
                this.checkingorsavings = new HtmlEdit(this);
                this.checkingorsavings.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "CheckingOrSavingsCode";
                return this.checkingorsavings;
            }
        }

        public HtmlEdit PreNotificationIssueDate
        {
            get
            {
                this.prenotificationissuedate = new HtmlEdit(this);
                this.prenotificationissuedate.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "PreNotificationIssueDate";
                return this.prenotificationissuedate;
            }
        }

        public HtmlEdit AllowedStartDate
        {
            get
            {
                this.allowedstartdate = new HtmlEdit(this);
                this.allowedstartdate.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "AllowedStartDate";
                return this.allowedstartdate;
            }
        }

        //==================================================Garnishments Fields===============================================================

        private HtmlEdit garnishment_countrycode;
        private HtmlEdit jurisdiction;
        private HtmlEdit subcategory;
        private HtmlEdit issueby;
        private HtmlEdit casenumber;
        private HtmlEdit fipscode;
        private HtmlEdit monthlygarnishmentamount;
        private HtmlEdit additionalexemptionamount;
        private HtmlEdit numberofexemptions;
        private HtmlEdit courtorderoverride;
        private HtmlEdit filingstatus;

        public HtmlEdit GarnishmentCountryCode
        {
            get
            {
                this.garnishment_countrycode = new HtmlEdit(this);
                this.garnishment_countrycode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl33_E_DeductionGarnishmentsExtension_CountryCode_Input";
                return this.garnishment_countrycode;
            }
        }

        public HtmlEdit JurisdictionCode
        {
            get
            {
                this.jurisdiction = new HtmlEdit(this);
                this.jurisdiction.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "JurisdictionCode";
                return this.jurisdiction;
            }
        }

        public HtmlEdit GarnishmentSubCategory
        {
            get
            {
                this.subcategory = new HtmlEdit(this);
                this.subcategory.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "GarnishmentSubCategory";
                return this.subcategory;
            }
        }

        public HtmlEdit IssueByJurisdictionCode
        {
            get
            {
                this.issueby = new HtmlEdit(this);
                this.issueby.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "IssueByJurisdictionCode";
                return this.issueby;
            }
        }

        public HtmlEdit CaseNumber
        {
            get
            {
                this.casenumber = new HtmlEdit(this);
                this.casenumber.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "CaseNumber";
                return this.casenumber;
            }
        }

        public HtmlEdit FIPSCode
        {
            get
            {
                this.fipscode = new HtmlEdit(this);
                this.fipscode.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "FIPSCode";
                return this.fipscode;
            }
        }

        public HtmlEdit MonthlyGarnishmentAmount
        {
            get
            {
                this.monthlygarnishmentamount = new HtmlEdit(this);
                this.monthlygarnishmentamount.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "MonthlyGarnishmentAmount";
                return this.monthlygarnishmentamount;
            }
        }

        public HtmlEdit AdditionalExemptionAmount
        {
            get
            {
                this.additionalexemptionamount = new HtmlEdit(this);
                this.additionalexemptionamount.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "AdditionalExemptionAmount";
                return this.additionalexemptionamount;
            }
        }

        public HtmlEdit NumberOfExemptions
        {
            get
            {
                this.numberofexemptions = new HtmlEdit(this);
                this.numberofexemptions.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "NumberOfExemptions";
                return this.numberofexemptions;
            }
        }

        public HtmlEdit CourtOrderOverride
        {
            get
            {
                this.courtorderoverride = new HtmlEdit(this);
                this.courtorderoverride.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "CourtOrderOverride";
                return this.courtorderoverride;
            }
        }

        public HtmlEdit FilingStatus
        {
            get
            {
                this.filingstatus = new HtmlEdit(this);
                this.filingstatus.SearchProperties[HtmlEdit.PropertyNames.FriendlyName] = "FilingStatus";
                return this.filingstatus;
            }
        }

        //==================================================Tab Header===============================================================
        
    //    private TabHeader tabHeader; 

    //    public TabHeader TabHeader
    //    {
    //        get
    //        {
    //            this.tabHeader = new TabHeader(this);                
    //            return this.tabHeader;
    //        }
    //    }

    };

    //public class TabHeader : HtmlDiv
    //{
    //    private HtmlHyperlink deductionTabLink;
    //    private HtmlHyperlink directdepositTabLink;
    //    private HtmlHyperlink garnishmentsTabLink;
 

    //    public TabHeader(UITestControl searchLimitContainer)
    //        : base(searchLimitContainer)
    //    {
    //        this.SearchProperties[HtmlDiv.PropertyNames.Id] = "_tab";
    //    }

    //    public HtmlHyperlink DeductionTabLink 
    //    {
    //        get
    //        {
    //            this.deductionTabLink = new HtmlHyperlink(this);
    //            this.deductionTabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Deduction";
    //            return this.deductionTabLink;
    //        }
    //    }
    //    public HtmlHyperlink DirectDepositTabLink
    //    {
    //        get
    //        {
    //            this.directdepositTabLink = new HtmlHyperlink(this);
    //            this.directdepositTabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Direct Deposit";
    //            return this.directdepositTabLink;
    //        }
    //    }
    //    public HtmlHyperlink GarnishmentsTabLink
    //    {
    //        get
    //        {
    //            this.garnishmentsTabLink = new HtmlHyperlink(this);
    //            this.garnishmentsTabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Garnishments";
    //            return this.garnishmentsTabLink;
    //        }
    //    }

    //};
}
