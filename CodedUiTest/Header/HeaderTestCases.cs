using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUiTest.Header
{
    public class HeaderTestCases
    {
        public HeaderControls HeaderControls = new HeaderControls();

        //==============================================================TEST CASES=====================================================================
        

        //==============================================================METHODS========================================================================

        public void EnterEmployeeNumber(string employeenNumber)
        {                    
            if (HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.EmployeeNumber.Text == "-1")
            {
                HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.EmployeeNumberPendingSave.Text = employeenNumber;
            }
            else
            {
                HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.EmployeeNumber.Text = employeenNumber;
            }             
        }

        //public void EnterTextBox(string myValue)
        //{
        //    if (HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.myValue.Text == "-1")
        //    {
        //        HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.EmployeeNumberPendingSave.Text = myValue;
        //    }
        //    else
        //    {
        //        HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.EmployeeNumber.Text = myValue;
        //    }
        //}





        public string GetEmployeeNameTextBoxText()
        {
            string employeeName = "";
            
            employeeName = HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.EmployeeName.Text; 

            return employeeName;
        }

        public string GetPayEntityTextBoxText()
        {
            string payentityName = "";

            payentityName = HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.PayEntity.Text;

            return payentityName;
        }

        public string GetDeductionTextBoxText()
        {
            string deductionName = "";

            deductionName = HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.Deduction.Text;
            Console.WriteLine(deductionName);
            return deductionName;
        }

        public string GeEarningsTextBoxText()
        {
            string deductionName = "";

            deductionName = HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.Earnings.Text;

            return deductionName;
        }

        public void SelectTab(string PageName)
        {
            HtmlHyperlink uIPageHyperlink = new HtmlHyperlink(HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument);
            uIPageHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = PageName;
            Playback.Wait(5000);

            Mouse.Click(uIPageHyperlink, MouseButtons.Left);

        }

        public void SelectAddressType(string AddressType)
        {
            HtmlComboBox uIPageCombo = new HtmlComboBox(HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument);
            uIPageCombo.SearchProperties[HtmlComboBox.PropertyNames.InnerText] = AddressType;
            uIPageCombo.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ctl25_AddressTypeCodeID";
           
            Playback.Wait(5000);

            Mouse.Click(uIPageCombo, MouseButtons.Left);

        }
    }
}
