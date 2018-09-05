using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUiTest.ToolBar
{
    public class ToolBarControls
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
        public AdminHtmlDocumentFrame adminHtmlDocumentFrame; 

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
        public AdminHtmlDocument adminHtmlDocument;

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

        //  ________________________________________________ Save___________________
        ////  ________________________________________________ ________________________________________________ 
        private HtmlImage save;
        public HtmlImage Save
        {
            get
            {
                this.save = new HtmlImage(this);
                //this.additionalDeathAndDisability_BenefitPlanCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitPlanCode_Input", PropertyExpressionOperator.Contains);
                this.save.SearchProperties[HtmlImage.PropertyNames.ControlType] = "Image";
                this.save.SearchProperties[HtmlImage.PropertyNames.TagName] = "IMG";
                this.save.SearchProperties[HtmlImage.PropertyNames.AbsolutePath] = "/Empower/images/SaveN.gif";
                
                return this.save;
            }
        }
        ////  ________________________________________________________________________________________________ 
        //  ________________________________________________ Save_____________________________________________

        


    };
}
