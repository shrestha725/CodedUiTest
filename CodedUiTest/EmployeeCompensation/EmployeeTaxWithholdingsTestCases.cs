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

namespace CodedUiTest.EmployeeTaxWithholdings
{
    [CodedUITest] 
    public class EmployeeTaxWithholdingsTestCases
    {
        TestBase TestBase = new TestBase();
        EmployeeTaxWithholdingsControls EmployeeTaxWithholdingsControls = new EmployeeTaxWithholdingsControls();

        //==============================================================TEST CASES=====================================================================
        [TestMethod] 
        public void NavigateToEmployeeTaxWithholdingsScreenAndFillInAllFieldsInCreateNewMode()  
        {            
            TestBase.LaunchInternetExplorerWithEmpowerPayQA();
            TestBase.Login.LoginAsAdmin("USSPOSCO");
            TestBase.LeftMenuTestCases.ClickLeftMenuParentLink("Employee Compensation");
            TestBase.LeftMenuTestCases.ClickLeftMenuChildLink("Tax Withholdings");
            Playback.Wait(3000);
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.WaitForControlReady(5000);

            TestBase.ToolBarTestCases.ClickToolBarIcon("New");
            TestBase.HeaderTestCases.EnterEmployeeNumber("77781");
            Keyboard.SendKeys("{Enter}");

            Playback.Wait(5000);
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.PrimaryExemptions.Text = "1";
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.ExemptionAmount.Text = "35.00";
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.SecondaryExemptions.Text = "2";
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.SecondaryExemptionsAmt.Text = "70.00";

            EnterTaxCalculationMethod("Flat");

            EnterReciprocityOverrideRule("Calc");

            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AdditionalTaxAmount.Text = "10.00";
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.FlatTaxAmount.SetFocus();
            Playback.Wait(2000);
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.FlatTaxAmount.Text = "20.00";
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AdditionalTaxPercent.SetFocus();
            Playback.Wait(2000);
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AdditionalTaxPercent.Text = "30.00";
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.FlatTaxPercent.SetFocus();
            Playback.Wait(2000);
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.FlatTaxPercent.Text = "40.00";
            Playback.Wait(2000);
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.DoNotWithholdTax.SetFocus();
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.DoNotWithholdTax.Checked = true;
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.NonResidCertOnFile.Checked = true;
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.TaxExempt.Checked = true;
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.LockedByIRS.Checked = true;
        }

        //==============================================================METHODS========================================================================
        public void EnterTaxCalculationMethod(string text)
        {
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.TaxCalculationMethod.SetFocus();
            Keyboard.SendKeys(text);
            Keyboard.SendKeys("{Enter}");
        }

        public void EnterReciprocityOverrideRule(string text)
        {
            EmployeeTaxWithholdingsControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.ReciprocityOverrideRule.SetFocus();
            Keyboard.SendKeys(text);
            Keyboard.SendKeys("{Enter}");
        }
    }
}
