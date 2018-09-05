using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodedUiTest.Base;
using CodedUiTest.Login;
using CodedUiTest.LeftMenu;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using CodedUiTest.ToolBar;
using CodedUiTest.Header;


namespace CodedUiTest.EmployeeIdentification
{
    [CodedUITest] 
    public class EmployeeIdentificationTestCases : TestBase
    {
        
        EmployeeIdentificationControls EmployeeIdentificationControls = new EmployeeIdentificationControls();
        ToolBarControls ToolBarControls = new ToolBarControls();
        HeaderControls HeaderControls = new HeaderControls();

       // public string timeStamp = GetTimeStamp(DateTime.Now);

        //public void EnterFirstName(string FirstName)
        //{
        //    Personal_FirstName
        //}



        [TestMethod] 
        public void NavigateToEmployeeIdentificationScreenAndVerifyIfEmployeeNameIsDisplayedInHeaderAfterEnteringExistingEmployeeIdInCreateNewMode()  
        {            
            //LaunchInternetExplorerWithEmpowerPayQA();
            Login.LoginAsAdmin("998");
            LeftMenuTestCases.ClickLeftMenuParentLink("Employee Profile");
            LeftMenuTestCases.ClickLeftMenuChildLink("Identification");
            Playback.Wait(10000);
            EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.WaitForControlReady(10000);
            ToolBarTestCases.ClickToolBarIcon("New");
            Playback.Wait(9000);
           // ToolBarTestCases.ClickToolBarIcon("/Empower/images/NewN.gif");
            HeaderTestCases.EnterEmployeeNumber("9273");
            Keyboard.SendKeys("{Enter}");

            Playback.Wait(9000);

            string employeeName = HeaderTestCases.GetEmployeeNameTextBoxText();
            Assert.AreEqual(employeeName, "Harris, Nicole R");
      }

        [TestMethod]
        public void NavigateToEmployeeAddressScreenAndVerifyIfEmployeeStreetAddress1IsDisplayedInAddress1FieldAfterEnteringExistingEmployeeId() 
        {
            //LaunchInternetExplorerWithEmpowerPayQA();
            Login.LoginAsAdmin("998");
            LeftMenuTestCases.ClickLeftMenuParentLink("Employee Profile");
            LeftMenuTestCases.ClickLeftMenuChildLink("Identification");
            Playback.Wait(10000);
            EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.WaitForControlReady(30000);
            Mouse.Click(EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.EmployeeIdentificationTabHeader.AddresslTabLink, MouseButtons.Left);

            HeaderTestCases.EnterEmployeeNumber("9273");
            Keyboard.SendKeys("{Enter}");

        
            Playback.Wait(10000);

         
            //string streetAddress1 = "";
            string streetAddress1 = EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.Address_StreetAddressLine1.Text;
            Console.WriteLine(streetAddress1);

            Assert.AreEqual(streetAddress1, "100 Greenfield Road");
        }

        [TestMethod]
        public void NavigateToEmployeeIdentificationScreenExpandAuditHistoryAndVerifyEffectiveDate()
        {
            //LaunchInternetExplorerWithEmpowerPayQA();
            Login.LoginAsAdmin("998");
            LeftMenuTestCases.ClickLeftMenuParentLink("Employee Profile");
            LeftMenuTestCases.ClickLeftMenuChildLink("Identification");

            EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.EmployeeIdentificationTabHeader.PersonalTabLink.WaitForControlExist(5000);

            HeaderTestCases.EnterEmployeeNumber("9273");
            Keyboard.SendKeys("{Enter}");

            AuditHistoryTestCases.AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryDiv.ExpandButton.WaitForControlExist(5000);
            //Playback.Wait(2000);
            AuditHistoryTestCases.ExpandAuditHistory();
            AuditHistoryTestCases.AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryTable.WaitForControlExist(5000);

            Playback.Wait(2000);

            string effectiveDate = AuditHistoryTestCases.GetMostRecentAuditHistoryItem("EffectiveDate");
            Console.WriteLine(effectiveDate);
            Assert.AreEqual(effectiveDate, "12/6/2000");
        }

        [TestMethod]
        public void NavigateToEmployeeIdentificationScreenAndTestEmployeeList()
        {
            //LaunchInternetExplorerWithEmpowerPayQA(); 
            Login.LoginAsAdmin("998");
            LeftMenuTestCases.ClickLeftMenuParentLink("Employee Profile");
            LeftMenuTestCases.ClickLeftMenuChildLink("Identification");

            EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.EmployeeIdentificationTabHeader.PersonalTabLink.WaitForControlExist(5000);

            EmployeeListTestCases.ClickEmployeeListGotoLastButton();
            Playback.Wait(5000);
            EmployeeListTestCases.ClickEmployeeListGotoPreviousButton();
            Playback.Wait(5000);
            EmployeeListTestCases.ClickEmployeeListGotoFirstButton();
            Playback.Wait(5000);
            EmployeeListTestCases.ClickEmployeeListGotoNextButton();
            Playback.Wait(5000);
            EmployeeListTestCases.ClickEmployeeListFirstRow();
            Playback.Wait(5000);
            string firstRowText = EmployeeListTestCases.GetEmployeeListFirstRowText();
            EmployeeListTestCases.NavigateToEmployeeListPage("4");            
        }

        //[TestMethod]
        //public void NavigateToEmployeeIdentificationScreenExpandAuditHistoryAndVerifyEffectiveDate()
        //{
        //    //LaunchInternetExplorerWithEmpowerPayQA();
        //    Login.LoginAsAdmin("998");
        //    LeftMenuTestCases.ClickLeftMenuParentLink("Employee Profile");
        //    LeftMenuTestCases.ClickLeftMenuChildLink("Identification");

        //    EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.EmployeeIdentificationTabHeader.PersonalTabLink.WaitForControlExist(5000);

        //    HeaderTestCases.EnterEmployeeNumber("9273");
        //    Keyboard.SendKeys("{Enter}");

        //    AuditHistoryTestCases.AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryDiv.ExpandButton.WaitForControlExist(5000);
        //    //Playback.Wait(2000);
        //    AuditHistoryTestCases.ExpandAuditHistory();
        //    AuditHistoryTestCases.AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryTable.WaitForControlExist(5000);

        //    Playback.Wait(2000);

        //    string effectiveDate = AuditHistoryTestCases.GetMostRecentAuditHistoryItem("EffectiveDate");
        //    Console.WriteLine(effectiveDate);
        //    Assert.AreEqual(effectiveDate, "12/6/2000");
        //}

        [TestMethod]
        public void CreateNewEmployee() 
        {

            string timeStamp = GetTimeStamp(DateTime.Now);
            Login.LoginAsAdmin("Paytest");
            LeftMenuTestCases.ClickLeftMenuParentLink("Employee Profile");
            LeftMenuTestCases.ClickLeftMenuChildLink("Identification");
            Playback.Wait(10000);
           //EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.EmployeeIdentificationTabHeader.PersonalTabLink.WaitForControlExist(5000);
            ToolBarTestCases.ClickToolBarIcon("New");
            //Playback.Wait(2000);
            ToolBarControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.Save.WaitForControlExist(5000);
            HeaderTestCases.EnterEmployeeNumber(timeStamp);
            Keyboard.SendKeys("{Enter}");
            Playback.Wait(2000);
          

            EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.Personal_FirstName.Text = "Automation";
            EmployeeIdentificationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.EmployeeIdentificationScreen.Personal_LastName.Text = "Testing";

            ToolBarTestCases.ClickToolBarIcon("Save");
            //ToolBarControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.Save.WaitForControlExist(5000);
            //string empName = getText(HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.EmployeeName);
            //string employeeName = HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.EmployeeName.Text;
            //Console.WriteLine(employeeName);
            Playback.Wait(10000);
            string empName = getText(HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.EmployeeName);
            Assert.AreEqual(empName, "Testing, Automation");
            //AuditHistoryTestCases.AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryDiv.ExpandButton.WaitForControlExist(5000);
            //Playback.Wait(2000);
            //AuditHistoryTestCases.ExpandAuditHistory();
            //AuditHistoryTestCases.AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryTable.WaitForControlExist(5000);
            HeaderTestCases.SelectTab("Address");
            ToolBarTestCases.ClickToolBarIcon("New");
            HeaderTestCases.SelectAddressType("Home address");
            HeaderTestCases.SelectAddressType("W2 address");

            Playback.Wait(2000);

            //string effectiveDate = AuditHistoryTestCases.GetMostRecentAuditHistoryItem("EffectiveDate");
            //Console.WriteLine(effectiveDate);
            //Assert.AreEqual(effectiveDate, "12/6/2000");
        }


    }
}


