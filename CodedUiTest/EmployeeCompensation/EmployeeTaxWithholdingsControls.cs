using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUiTest.EmployeeTaxWithholdings
{
    public class EmployeeTaxWithholdingsControls
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

        public AdminHtmlDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/Secured/Admin/AdminManager.aspx";
        }
        
        //==================================================Address Fields===============================================================

        private HtmlEdit filingStatus;
        private HtmlEdit primaryExemptions;
        private HtmlEdit exemptionAmount;
        private HtmlEdit secondaryExemptions;
        private HtmlEdit secondaryExemptionsAmt;
        private HtmlEdit taxCalculationMethod;
        private HtmlEdit altTaxCalculationCode;
        private HtmlEdit reciprocityOverrideRule;
        private HtmlEdit additionalTaxAmount;
        private HtmlEdit flatTaxAmount;
        private HtmlEdit additionalTaxPercent;
        private HtmlEdit flatTaxPercent;
        private HtmlCheckBox doNotWithholdTax;
        private HtmlCheckBox nonResidCertOnFile;
        private HtmlCheckBox taxExempt;
        private HtmlCheckBox lockedByIRS;

        public HtmlEdit FilingStatus
        {
            get
            {
                this.filingStatus = new HtmlEdit(this);
                this.filingStatus.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_FilingStatusCode_Input";
                return this.filingStatus;
            }
        }

        public HtmlEdit PrimaryExemptions
        {
            get
            {
                this.primaryExemptions = new HtmlEdit(this);
                this.primaryExemptions.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_PrimaryExemptions";
                return this.primaryExemptions;
            }
        }

        public HtmlEdit ExemptionAmount
        {
            get
            {
                this.exemptionAmount = new HtmlEdit(this);
                this.exemptionAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_ExemptionAmount";
                return this.exemptionAmount;
            }
        }

        public HtmlEdit SecondaryExemptions
        {
            get
            {
                this.secondaryExemptions = new HtmlEdit(this);
                this.secondaryExemptions.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_SecondaryExemptions";
                return this.secondaryExemptions;
            }
        }

        public HtmlEdit SecondaryExemptionsAmt
        {
            get
            {
                this.secondaryExemptionsAmt = new HtmlEdit(this);
                this.secondaryExemptionsAmt.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_SecondaryExemptionsAmount";
                return this.secondaryExemptionsAmt;
            }
        }

        public HtmlEdit TaxCalculationMethod
        {
            get
            {
                this.taxCalculationMethod = new HtmlEdit(this);
                this.taxCalculationMethod.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_TaxCalculationMethodCode_Input";
                return this.taxCalculationMethod;
            }
        }

        public HtmlEdit AltTaxCalculationCode
        {
            get
            {
                this.altTaxCalculationCode = new HtmlEdit(this);
                this.altTaxCalculationCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_AltTaxCalculationMethodCode_Input";
                return this.altTaxCalculationCode;
            }
        }

        public HtmlEdit ReciprocityOverrideRule
        {
            get
            {
                this.reciprocityOverrideRule = new HtmlEdit(this);
                this.reciprocityOverrideRule.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_ReciprocityOverrideRuleCode_Input";
                return this.reciprocityOverrideRule;
            }
        }

        public HtmlEdit AdditionalTaxAmount
        {
            get
            {
                this.additionalTaxAmount = new HtmlEdit(this);
                this.additionalTaxAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_AdditionalTaxAmount";
                return this.additionalTaxAmount;
            }
        }

        public HtmlEdit FlatTaxAmount
        {
            get
            {
                this.flatTaxAmount = new HtmlEdit(this);
                this.flatTaxAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_FlatTaxAmount";
                return this.flatTaxAmount;
            }
        }

        public HtmlEdit AdditionalTaxPercent
        {
            get
            {
                this.additionalTaxPercent = new HtmlEdit(this);
                this.additionalTaxPercent.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_AdditionalTaxPercent";
                return this.additionalTaxPercent;
            }
        }

        public HtmlEdit FlatTaxPercent
        {
            get
            {
                this.flatTaxPercent = new HtmlEdit(this);
                this.flatTaxPercent.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_FlatTaxPercent";
                return this.flatTaxPercent;
            }
        }

        public HtmlCheckBox DoNotWithholdTax
        {
            get
            {
                this.doNotWithholdTax = new HtmlCheckBox(this);
                this.doNotWithholdTax.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_DoNotWithholdTax";
                return this.doNotWithholdTax;
            }
        }

        public HtmlCheckBox NonResidCertOnFile
        {
            get
            {
                this.nonResidCertOnFile = new HtmlCheckBox(this);
                this.nonResidCertOnFile.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_NonResidentCertificateOnFile";
                return this.nonResidCertOnFile;
            }
        }

        public HtmlCheckBox TaxExempt
        {
            get
            {
                this.taxExempt= new HtmlCheckBox(this);
                this.taxExempt.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_TaxExempt";
                return this.taxExempt;
            }
        }

        public HtmlCheckBox LockedByIRS
        {
            get
            {
                this.lockedByIRS = new HtmlCheckBox(this);
                this.lockedByIRS.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_JurisdictionWithholding_LockedByIRS";
                return this.lockedByIRS;
            }
        }      
        
    };
}
