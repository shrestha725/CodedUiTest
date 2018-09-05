using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUiTest.Header
{
    public class HeaderControls
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
        private HtmlEdit employeeNumber;
        private HtmlEdit employeeNumberPendingSave;
        private HtmlEdit employeeName;
        private HtmlEdit nationalId;
        private HtmlEdit payentity;
        private HtmlEdit deduction;
        private HtmlEdit earnings;

        public AdminHtmlDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/Secured/Admin/AdminManager.aspx";
        }


        public HtmlEdit EmployeeNumber
        {
            get
            {
                this.employeeNumber = new HtmlEdit(this);
                this.employeeNumber.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "EmployeeNumber", PropertyExpressionOperator.Contains);
                return this.employeeNumber;
            }
        }
        public HtmlEdit EmployeeNumberPendingSave 
        {
            get
            {
                this.employeeNumberPendingSave = new HtmlEdit(this);
                this.employeeNumberPendingSave.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "EmployeeNumberPendingSave", PropertyExpressionOperator.Contains);
                return this.employeeNumberPendingSave;
            }
        }
        public HtmlEdit EmployeeName 
        {
            get
            {
                this.employeeName = new HtmlEdit(this);
                //this.employeeName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "ctl20_E_Identification_EmployeeName_Input", PropertyExpressionOperator.Contains);
                this.employeeName.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl20_E_Identification_EmployeeName_Input";

                return this.employeeName;
            }
        }
        public HtmlEdit NationalId 
        {
            get
            {
                this.nationalId = new HtmlEdit(this);
                this.nationalId.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_NationalID", PropertyExpressionOperator.Contains);
                return this.nationalId;
            }
        }

        public HtmlEdit PayEntity
        {
            get
            {
                this.payentity = new HtmlEdit(this);
                this.payentity.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_PayEntityCode", PropertyExpressionOperator.Contains);
                return this.payentity;
            }
        }

        public HtmlEdit Deduction
        {
            get
            {
                this.deduction = new HtmlEdit(this);
                this.deduction.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_DeductionCode", PropertyExpressionOperator.Contains);
                this.deduction.SearchProperties.Add(HtmlEdit.PropertyNames.FriendlyName, "DeductionCode");
                this.deduction.SearchProperties.Add(HtmlEdit.PropertyNames.Class, "rcbInput radPreventDecorate");
                this.deduction.SearchProperties.Add(HtmlEdit.PropertyNames.TagName, "INPUT");
                //this.deduction.SearchProperties.Add(HtmlEdit.PropertyNames.TechnologyName, "Web");

                return this.deduction;
            }
        }

        public HtmlEdit Earnings
        {
            get
            {
                this.earnings = new HtmlEdit(this);
                this.earnings.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_EarningsCode", PropertyExpressionOperator.Contains);
                return this.earnings;
            }
        }
    };
}
