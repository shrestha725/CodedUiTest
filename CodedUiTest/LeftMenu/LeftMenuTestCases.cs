using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUiTest.LeftMenu
{
    [CodedUITest]
    public class LeftMenuTestCases
    {
        public LeftMenuControls LeftMenuControls = new LeftMenuControls();

        //==============================================================TEST CASES=====================================================================
        
        
        //==============================================================METHODS========================================================================

        public void ClickLeftMenuParentLink(string parentLinkText) 
        {    
            HtmlSpan LeftMenuSpan = new HtmlSpan(LeftMenuControls.EmpowerBrowserWindow.EmpowerHtmlDocument);
            LeftMenuSpan.SearchProperties.Add(HtmlSpan.PropertyNames.DisplayText, parentLinkText);
            LeftMenuSpan.Find();

            Mouse.Click(LeftMenuSpan.GetParent(), MouseButtons.Left);
        }

        public void ClickLeftMenuChildLink(string childLinkText) 
        {           
            HtmlSpan LeftMenuSpan = new HtmlSpan(LeftMenuControls.EmpowerBrowserWindow.EmpowerHtmlDocument);
            LeftMenuSpan.SearchProperties.Add(HtmlSpan.PropertyNames.DisplayText, childLinkText);
            LeftMenuSpan.Find();

            Mouse.Click(LeftMenuSpan.GetParent(), MouseButtons.Left);
        }
    }
}
