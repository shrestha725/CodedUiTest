using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUiTest.EmployeeList
{
    public class EmployeeListTestCases
    {
        public EmployeeListControls EmployeeListControls = new EmployeeListControls();

        //==============================================================TEST CASES=====================================================================


        //==============================================================METHODS========================================================================

        public void ClickEmployeeListGotoLastButton()
        {
            Mouse.Click(EmployeeListControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeListHtmlDocument.EmployeeListTable.GotoLastButton, MouseButtons.Left);
        }

        public void ClickEmployeeListGotoFirstButton()
        {
            Mouse.Click(EmployeeListControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeListHtmlDocument.EmployeeListTable.GotoFirstButton, MouseButtons.Left);
        }

        public void ClickEmployeeListGotoNextButton()
        {
            Mouse.Click(EmployeeListControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeListHtmlDocument.EmployeeListTable.NextButton, MouseButtons.Left);
        }

        public void ClickEmployeeListGotoPreviousButton()
        {
            Mouse.Click(EmployeeListControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeListHtmlDocument.EmployeeListTable.PreviousButton, MouseButtons.Left);
        }

        public void ClickEmployeeListFirstRow()
        {
            Mouse.Click(EmployeeListControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeListHtmlDocument.EmployeeListTable.FirstRow, MouseButtons.Left);
        }

        public string GetEmployeeListFirstRowText() 
        {
            string rowText = "";
            rowText = EmployeeListControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeListHtmlDocument.EmployeeListTable.FirstRow.InnerText;
            return rowText;
        }

        public void NavigateToEmployeeListPage(string pageNumber)
        {
            EmployeeListControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeListHtmlDocument.PageNumberTextbox.Text = pageNumber;
            Mouse.Click(EmployeeListControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeListHtmlDocument.PagerGoButton, MouseButtons.Left);
        }
    }
}
