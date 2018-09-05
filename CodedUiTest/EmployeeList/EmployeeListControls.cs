using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUiTest.EmployeeList
{
    public class EmployeeListControls
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
        private EmployeeListHtmlDocument employeeListHtmlDocument;

        public AdminHtmlDocumentFrame(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "Home";
        }

        public EmployeeListHtmlDocument EmployeeListHtmlDocument 
        {
            get
            {
                this.employeeListHtmlDocument = new EmployeeListHtmlDocument(this);
                return this.employeeListHtmlDocument;
            }
        }
    };

    public class EmployeeListHtmlDocument : HtmlDocument
    {
        private HtmlCheckBox includeActiveEmployees;
        private EmployeeListTable employeeListTable;
        private HtmlEdit pageNumberTextbox;
        private HtmlInputButton pagerGoButton; 

        public EmployeeListHtmlDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/Secured/Admin/AdminManager.aspx";
        }

        public HtmlCheckBox IncludeActiveEmployees
        {
            get 
            {
                this.includeActiveEmployees = new HtmlCheckBox(this);
                this.includeActiveEmployees.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "E_OnDemandCheckCompositeGridViewsPager_AllEmployeesCheckBox";
                return this.includeActiveEmployees;
            }
        }

        public EmployeeListTable EmployeeListTable
        {
            get
            {
                this.employeeListTable = new EmployeeListTable(this);
                return this.employeeListTable;
            }
        }

        public HtmlEdit PageNumberTextbox
        {
            get
            {
                this.pageNumberTextbox = new HtmlEdit(this);
                this.pageNumberTextbox.SearchProperties[HtmlEdit.PropertyNames.Id] = "E_OnDemandCheckCompositeGridViewsPager_E_OnDemandCheckCompositeGridViewsTabGridView0_ctl00_ctl21_ddlPick";
                return this.pageNumberTextbox;
            }
        }
        public HtmlInputButton PagerGoButton
        {
            get
            {
                this.pagerGoButton = new HtmlInputButton(this);
                this.pagerGoButton.SearchProperties[HtmlButton.PropertyNames.Id] = "E_OnDemandCheckCompositeGridViewsPager_E_OnDemandCheckCompositeGridViewsTabGridView0_ctl00_ctl14_btnGo";
                this.pagerGoButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Go";
                this.pagerGoButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                return this.pagerGoButton;
            }
        }

    }

    public class EmployeeListTable : HtmlTable
    {
        private HtmlInputButton gotoFirstButton;
        private HtmlInputButton gotoLastButton;
        private HtmlInputButton nextButton;
        private HtmlInputButton previousButton;
        private HtmlCell firstRow; 

        public EmployeeListTable(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "GridViewStyle";
        }

        public HtmlInputButton GotoFirstButton
        {
            get
            {
                this.gotoFirstButton = new HtmlInputButton(this);
                this.gotoFirstButton.FilterProperties["Src"] = "https://empowerpayqa.empowerpay.com/Empower/images/FirstArrow.gif";
                return this.gotoFirstButton; 
            }
        }
        public HtmlInputButton GotoLastButton
        {
            get
            {
                this.gotoLastButton = new HtmlInputButton(this);
                this.gotoLastButton.FilterProperties["Src"] = "https://empowerpayqa.empowerpay.com/Empower/images/LastArrow.gif";
                return this.gotoLastButton;
            }
        }
        public HtmlInputButton NextButton
        {
            get
            {
                this.nextButton = new HtmlInputButton(this);
                this.nextButton.FilterProperties["Src"] = "https://empowerpayqa.empowerpay.com/Empower/images/NextArrow.gif";
                return this.nextButton;
            }
        }
        public HtmlInputButton PreviousButton
        {
            get
            {
                this.previousButton = new HtmlInputButton(this);
                this.previousButton.FilterProperties["Src"] = "https://empowerpayqa.empowerpay.com/Empower/images/PrevArrow.gif";
                return this.previousButton;
            }
        }
        public HtmlCell FirstRow
        {
            get
            {
                this.firstRow = new HtmlCell(this);
                this.firstRow.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "2";
                this.firstRow.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                return this.firstRow;
            }
        }
    }
}
