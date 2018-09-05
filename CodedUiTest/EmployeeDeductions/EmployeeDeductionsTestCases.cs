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


namespace CodedUiTest.EmployeeDeductions
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class EmployeeDeductionsTestCases
    {
        TestBase TestBase = new TestBase();
        EmployeeDeductionsControls EmployeeDeductionsControls = new EmployeeDeductionsControls();
    
        [TestMethod]
        public void VerifyEmployeeDeductionCode()
        {
            TestBase.LaunchInternetExplorerWithEmpowerPayQA();
            TestBase.Login.LoginAsAdmin("998");
            TestBase.LeftMenuTestCases.ClickLeftMenuParentLink("Employee Compensation");
            TestBase.LeftMenuTestCases.ClickLeftMenuChildLink("Deductions");
            Playback.Wait(5000);

            TestBase.HeaderTestCases.EnterEmployeeNumber("6598565");
            Keyboard.SendKeys("{Enter}");

            Playback.Wait(12000);
            ///Assert.AreEqual("Bonus Dues", TestBase.HeaderTestCases.GetDeductionTextBoxText());
            Assert.AreEqual("Child Support", TestBase.HeaderTestCases.GetDeductionTextBoxText());
           

        }

        [TestMethod]
        public void VerifyEmployeeDirectDeposit()
        {
            TestBase.LaunchInternetExplorerWithEmpowerPayQA();
            TestBase.Login.LoginAsAdmin("998");
            TestBase.LeftMenuTestCases.ClickLeftMenuParentLink("Employee Compensation");
            TestBase.LeftMenuTestCases.ClickLeftMenuChildLink("Deductions");
            Playback.Wait(5000);

            TestBase.HeaderTestCases.SelectTab("Direct Deposit");
            TestBase.HeaderTestCases.EnterEmployeeNumber("21049");
            Keyboard.SendKeys("{Enter}");

            Playback.Wait(12000);

            Assert.AreEqual("Direct Deposit", TestBase.HeaderTestCases.GetDeductionTextBoxText());
        }


        [TestMethod]
        public void VerifyEmployeeGarnishments()
        {
            TestBase.LaunchInternetExplorerWithEmpowerPayQA();
            TestBase.Login.LoginAsAdmin("998");
            TestBase.LeftMenuTestCases.ClickLeftMenuParentLink("Employee Compensation");
            TestBase.LeftMenuTestCases.ClickLeftMenuChildLink("Deductions");
            Playback.Wait(5000);

            TestBase.HeaderTestCases.SelectTab("Garnishments");
            TestBase.HeaderTestCases.EnterEmployeeNumber("1177");
            Keyboard.SendKeys("{Enter}");

            Playback.Wait(10000);
            Assert.AreEqual("", TestBase.HeaderTestCases.GetDeductionTextBoxText());

        }
    }
}
