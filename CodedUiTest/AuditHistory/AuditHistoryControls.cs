using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUiTest.AuditHistory
{
    public class AuditHistoryControls
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
        private AuditHistoryDiv auditHistoryDiv;
        private AuditHistoryTable auditHistoryTable; 

        public AdminHtmlDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/Secured/Admin/AdminManager.aspx";
        }

        public AuditHistoryDiv AuditHistoryDiv
        {
            get
            {
                this.auditHistoryDiv = new AuditHistoryDiv(this);
                return this.auditHistoryDiv;
            }
        }

        public AuditHistoryTable AuditHistoryTable
        {
            get
            {
                this.auditHistoryTable = new AuditHistoryTable(this);
                return this.auditHistoryTable;
            }
        }

    };

    public class AuditHistoryDiv : HtmlDiv
    {
        private HtmlDiv auditHistoryDiv;
        private HtmlCustom expandButton; 
        private HtmlCustom collapseButton;
        
        public AuditHistoryDiv(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Audit History ";
        }

        public HtmlCustom ExpandButton
        {
            get
            {
                this.expandButton = new HtmlCustom(this);
                this.expandButton.SearchProperties["TagName"] = "A";
                this.expandButton.SearchProperties["Id"] = null;
                this.expandButton.FilterProperties["ControlDefinition"] = "title=\"Expand\"";
                this.expandButton.FilterProperties["TagInstance"] = "1";
                return this.expandButton;
            }
        }

        public HtmlCustom CollapseButton
        {
            get
            {
                this.collapseButton = new HtmlCustom(this);
                this.collapseButton.FilterProperties["ControlDefinition"] = "title=\"Collapse\"";
                return this.collapseButton;
            }
        }        
    };

    public class AuditHistoryTable : HtmlTable
    {
        private HtmlCell firstRowEffectiveDateCell;
        private HtmlCell firstRowActivityCell;
        private HtmlCell firstRowChangedByCell;
        private HtmlCell firstChangedDateCell; 

        public AuditHistoryTable(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "HistoryViewStyle";
        }

        public HtmlCell FirstRowEffectiveDateCell
        {
            get
            {
                this.firstRowEffectiveDateCell = new HtmlCell(this);
                this.firstRowEffectiveDateCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "2";
                this.firstRowEffectiveDateCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                return this.firstRowEffectiveDateCell;
            }
        }
        public HtmlCell FirstRowActivityCell
        {
            get
            {
                this.firstRowActivityCell = new HtmlCell(this);
                this.firstRowActivityCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "2";
                this.firstRowActivityCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                return this.firstRowActivityCell;
            }
        }
        public HtmlCell FirstRowChangedByCell
        {
            get
            {
                this.firstRowChangedByCell = new HtmlCell(this);
                this.firstRowChangedByCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "2";
                this.firstRowChangedByCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "2";
                return this.firstRowChangedByCell;
            }
        }
        public HtmlCell FirstChangedDateCell 
        {
            get
            {
                this.firstChangedDateCell = new HtmlCell(this);
                this.firstChangedDateCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "2";
                this.firstChangedDateCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "3";
                return this.firstChangedDateCell;
            }
        }
        
    };
}
