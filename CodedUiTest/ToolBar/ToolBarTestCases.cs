using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUiTest.ToolBar
{
    public class ToolBarTestCases
    {
        //==============================================================TEST CASES=====================================================================


        //==============================================================METHODS========================================================================
        
        public void ClickToolBarIcon(string iconName)  
        {
            //"New"
            //"Save"
            //"Delete"
            //"Reverse"
            //"Refresh"
            //"FirstEmp"
            //"PrevEmp"
            //"NextEmp"
            //"LastEmp"

            ToolBarControls ToolBarControls = new ToolBarControls();

            ToolBarControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.WaitForControlReady();

            HtmlTable ToolBarTable = new HtmlTable(ToolBarControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument);
            ToolBarTable.SearchProperties.Add(HtmlTable.PropertyNames.Id, iconName);
            ToolBarTable.SearchProperties.Add(HtmlTable.PropertyNames.Class, "ToolbarButton");
            ToolBarTable.Find();

            HtmlImage ToolBarImage = new HtmlImage(ToolBarTable);
            ToolBarImage.SearchProperties.Add(HtmlImage.PropertyNames.Name, "defaultImage");
            ToolBarImage.Find();

            HtmlImage ToolBarImageHover = new HtmlImage(ToolBarTable);
            ToolBarImageHover.SearchProperties.Add(HtmlImage.PropertyNames.Name, "hoverImage");
            ToolBarImageHover.Find();

            Mouse.Hover(ToolBarImage);
            Mouse.Click(ToolBarImageHover, MouseButtons.Left);
        }
    }
}
