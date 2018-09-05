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
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUiTest.PayInformation
{
    [CodedUITest] 
    public class PayInformationTestCases
    {
        private int index_employeeNumber = 0;
        private int index_employeeName = 1;
        private int index_hourlySalariedCode = 2;
        private int index_hourlyRate = 3;
        private int index_payPeriodSalary = 4;
        private int index_standardHours = 5;
        private int index_guaranteedPayAmount = 6;
        private int index_hourlyRateEquivalent = 7;
        private int index_monthlyEquivalent = 8;
        private int index_annualEquivalent = 9;
        private int index_effectiveDate = 10;
        private int index_changedOn = 11;

        private string notificationMessage = "";

        private string[,] compensationSpecifications = new string[,]
        {
                {"20140101", "Allocation, Earnings A", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:20 PM"}, // 0
                {"20140102", "Allocation, Earnings B", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:22 PM"}, // 1
                {"20140103", "Allocation, Earnings C", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:22 PM"}, // 2
                {"20140104", "Allocation, Earnings D", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:22 PM"}, // 3
                {"20140105", "Allocation, Earnings E", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:22 PM"}, // 4
                {"20140106", "Allocation, Earnings F", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:22 PM"}, // 5
                {"20140107", "Allocation, Earnings G", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:23 PM"}, // 6
                {"20140108", "Allocation, Earnings H", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:24 PM"}, // 7
                {"20140109", "Allocation, Earnings I", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:24 PM"}, // 8
                {"20140110", "Allocation, Earnings J", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:24 PM"}, // 9
                {"20140111", "Allocation, Earnings K", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:32 PM"}, // 10
                {"20140112", "Allocation, Earnings L", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:34 PM"}, // 11
                {"20140113", "Allocation, Earnings M", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:34 PM"}, // 12
                {"20140114", "Allocation, Earnings N", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:34 PM"}, // 13
                {"20140115", "Allocation, Earnings O", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:34 PM"}, // 14
                {"20140116", "Allocation, Earnings P", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:35 PM"}, // 15
                {"20140117", "Allocation, Earnings Q", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:35 PM"}, // 16
                {"20140118", "Allocation, Earnings R", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:35 PM"}, // 17
                {"20140119", "Allocation, Earnings S", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:35 PM"}, // 18
                {"20140120", "Allocation, Earnings T", "Hourly", "20.0000", "1600.00", "80.00", ".0000", "20.0000", "3466.67", "41600.00", "1/2/2014", "2/25/2014 3:35 PM"}, // 19

                {"20140121", "Allocation, Earnings U", "Salary", "31.2500", "2500.00", "80.00", ".0000", "31.2500", "5000.00", "60000.00", "1/2/2014", "2/26/2014 5:29 PM"}, // 21
                {"20140122", "Allocation, Earnings V", "Salary", "31.2500", "2500.00", "80.00", "2500.0000", "31.2500", "5000.00", "60000.00", "1/3/2014", "7/15/2014 12:55 PM"}, // 22
                {"20140123", "Allocation, Earnings W", "Salary", "31.2500", "2500.00", "80.00", ".0000", "31.2500", "5000.00", "60000.00", "1/2/2014", "2/27/2014 7:54 AM"}, // 23
                {"20140124", "Allocation, Earnings X", "Salary", "31.2500", "2500.00", "80.00", ".0000", "31.2500", "5000.00", "60000.00", "1/2/2014", "2/27/2014 7:54 AM"}  // 24
        };

        TestBase TestBase = new TestBase();
        PayInformationControls payInformationControls = new PayInformationControls();

        private void Login()
        {
            TestBase.LaunchInternetExplorerWithEmpowerPayQA();
            TestBase.Login.LoginAsAdmin("998");
        }

        private void selectscreen_BenefitsEnrollment()
        {
            TestBase.LeftMenuTestCases.LeftMenuControls.EmpowerBrowserWindow.WaitForControlReady();
            TestBase.LeftMenuTestCases.ClickLeftMenuParentLink("Employee Benefits");

            TestBase.LeftMenuTestCases.LeftMenuControls.EmpowerBrowserWindow.EmpowerHtmlDocument.WaitForControlReady();
            TestBase.LeftMenuTestCases.ClickLeftMenuChildLink("Benefits Enrollment");

            TestBase.HeaderTestCases.HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.WaitForControlEnabled();
        }

        private void selectscreen_PayInformation()
        {
            TestBase.LeftMenuTestCases.ClickLeftMenuParentLink("Employee Compensation");

            TestBase.LeftMenuTestCases.LeftMenuControls.EmpowerBrowserWindow.EmpowerHtmlDocument.WaitForControlExist();
            TestBase.LeftMenuTestCases.LeftMenuControls.EmpowerBrowserWindow.EmpowerHtmlDocument.WaitForControlEnabled();
            TestBase.LeftMenuTestCases.LeftMenuControls.EmpowerBrowserWindow.EmpowerHtmlDocument.WaitForControlReady();

            TestBase.LeftMenuTestCases.ClickLeftMenuChildLink("Pay Information");

            TestBase.HeaderTestCases.HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.WaitForControlEnabled();
            TestBase.HeaderTestCases.HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.WaitForControlReady();
        }

        private void input_EmployeeNumber(string employeeNumber)
        {
            payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_HourlySalariedCode.WaitForControlExist();
            payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_HourlySalariedCode.WaitForControlEnabled();
            payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_HourlySalariedCode.WaitForControlReady();

            TestBase.HeaderTestCases.EnterEmployeeNumber(employeeNumber);

            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.AllThreads;
            Keyboard.SendKeys("{Enter}");
            payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.WaitForControlEnabled();
            payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.WaitForControlReady();
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.UIThreadOnly;

            payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.WaitForControlEnabled();
            payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.WaitForControlReady();
            payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.SetFocus();
        }

        private string getText(HtmlEdit editControl)
        {
            string text = editControl.Text;
            Debug.WriteLine(editControl.Id + ": " + text);
            return text;
        }


        [TestMethod] 
        public void VerifySavedData_PayInfo_Compensation()  
        {
            Login();
            selectscreen_PayInformation();

            for (int i = 17; i < 24; i++)
            {
                input_EmployeeNumber(compensationSpecifications[i, index_employeeNumber]);
                Mouse.Click(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.PayInformationTabHeader.Compensation_TabLink, MouseButtons.Left);
                Playback.Wait(12000);//  Added wait time
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_HourlySalariedCode.SetFocus();
                string hourlySalariedCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_HourlySalariedCode);
                Assert.AreEqual(compensationSpecifications[i, index_hourlySalariedCode], hourlySalariedCode);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_HourlyRate.SetFocus();
                string hourlyRate = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_HourlyRate);
                Assert.AreEqual(compensationSpecifications[i, index_hourlyRate], hourlyRate);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_PayPeriodSalary.SetFocus();
                string payPeriodSalary = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_PayPeriodSalary);
                Assert.AreEqual(compensationSpecifications[i, index_payPeriodSalary], payPeriodSalary);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_StandardHours.SetFocus();
                string standardHours = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_StandardHours);
                Assert.AreEqual(compensationSpecifications[i, index_standardHours], standardHours);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_GuaranteedPayAmount.SetFocus();
                string guaranteedPayAmount = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_GuaranteedPayAmount);
                Assert.AreEqual(compensationSpecifications[i, index_guaranteedPayAmount], guaranteedPayAmount);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_HourlyRateEquivalent.SetFocus();
                string hourlyRateEquivalent = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_HourlyRateEquivalent);
                Assert.AreEqual(compensationSpecifications[i, index_hourlyRateEquivalent], hourlyRateEquivalent);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_MonthlyEquivalent.SetFocus();
                string monthlyEquivalent = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_MonthlyEquivalent);
                Assert.AreEqual(compensationSpecifications[i, index_monthlyEquivalent], monthlyEquivalent);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_AnnualEquivalent.SetFocus();
                string annualEquivalent = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_AnnualEquivalent);
                Assert.AreEqual(compensationSpecifications[i, index_annualEquivalent], annualEquivalent);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_SalaryChangeReasonCode.SetFocus();
                string salaryChangeReasonCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_SalaryChangeReasonCode);
                string expected_salaryChangeReasonCode = "";
                Assert.AreEqual(salaryChangeReasonCode, expected_salaryChangeReasonCode);

                bool inactive = payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_Inactive.Checked;
                Assert.AreEqual(inactive, false);

                notificationMessage = payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Compensation_NotificationMessage.DisplayText;
                string expected_notificationMessage = string.Format("The above information is effective as of {0} and was changed on {1}", compensationSpecifications[i, index_effectiveDate], compensationSpecifications[i, index_changedOn]);
                Assert.AreEqual(notificationMessage, expected_notificationMessage);
            }

        }

        [TestMethod]
        public void VerifySavedData_PayInfo_Jobs()
        {
            Login();
            selectscreen_PayInformation();
        
            for (int i = 19; i < 21; i++)
            {
                selectscreen_PayInformation();
                input_EmployeeNumber(compensationSpecifications[i, index_employeeNumber]);
                Mouse.Click(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.PayInformationTabHeader.Jobs_TabLink, MouseButtons.Left);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_PrimaryWorkLocation.SetFocus();
                bool primaryWorkLocation = payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_PrimaryWorkLocation.Checked;
                //Assert.AreEqual(primaryWorkLocation, false);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_RegularOrTemporaryCode.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_FullOrPartTimeCode.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_ShiftCode.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_JobChangeReasonCode.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_JobClassCode.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_DirectTipEmployee.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_RateForJob.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_RateForJob.SetFocus();
                //payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_Comments.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Job_WorksFromHome.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_Percentage.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_NotApplicableToBenefits.SetFocus();

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_CostCenterCode.SetFocus();
                string costCenterCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_CostCenterCode);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_LaborDistributionCode.SetFocus();
                string laborDistributionCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_LaborDistributionCode);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_PositionCode.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_Inactive.SetFocus();
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_WorkersCompensationCode.SetFocus();

                //notificationMessage = payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Jobs_NotificationMessage.DisplayText;
                //string expected_notificationMessage = string.Format("The above information is effective as of {0} and was changed on {1}", compensationSpecifications[i, index_effectiveDate], compensationSpecifications[i, index_changedOn]);
                //Assert.AreEqual(notificationMessage, expected_notificationMessage);
            }

        }

        [TestMethod]
        public void VerifySavedData_PayInfo_JobAllocation()
        {
            string jobcode;
            string worklocationcode;
            string costCenterCode;
            string laborDistributionCode;
            string percentage;

            Login();
            selectscreen_PayInformation();
            Playback.Wait(12000);//  Added wait time
            //selectscreen_PayInformation();
            Mouse.Click(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.PayInformationTabHeader.JobAllocation_TabLink, MouseButtons.Left);

            for (int i = 5; i < 9; i++)
            {
                try
                {
                    input_EmployeeNumber(compensationSpecifications[i, index_employeeNumber]);
                    Playback.Wait(12000);//  Added wait time
                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_JobCode_0.SetFocus();
                    jobcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_JobCode_0);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_WorkLocationCode_0.SetFocus();
                    worklocationcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_WorkLocationCode_0);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_CostCenterCode_0.SetFocus();
                    costCenterCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_CostCenterCode_0);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_LaborDistributionCode_0.SetFocus();
                    laborDistributionCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_LaborDistributionCode_0);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_Percentage_0.SetFocus();
                    percentage = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_Percentage_0);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_JobCode_1.SetFocus();
                    jobcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_JobCode_1);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_WorkLocationCode_1.SetFocus();
                    worklocationcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_WorkLocationCode_1);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_CostCenterCode_1.SetFocus();
                    costCenterCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_CostCenterCode_1);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_LaborDistributionCode_1.SetFocus();
                    laborDistributionCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_LaborDistributionCode_1);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_Percentage_1.SetFocus();
                    percentage = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_Percentage_1);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_JobCode_2.SetFocus();
                    jobcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_JobCode_2);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_WorkLocationCode_2.SetFocus();
                    worklocationcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_WorkLocationCode_2);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_CostCenterCode_2.SetFocus();
                    costCenterCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_CostCenterCode_2);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_LaborDistributionCode_2.SetFocus();
                    laborDistributionCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_LaborDistributionCode_2);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_Percentage_2.SetFocus();
                    percentage = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_Percentage_2);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_JobCode_3.SetFocus();
                    jobcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_JobCode_3);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_WorkLocationCode_3.SetFocus();
                    worklocationcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_WorkLocationCode_3);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_CostCenterCode_3.SetFocus();
                    costCenterCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_CostCenterCode_3);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_LaborDistributionCode_3.SetFocus();
                    laborDistributionCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_LaborDistributionCode_3);

                    payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_Percentage_3.SetFocus();
                    percentage = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_Percentage_3);

                    //string percentageTotal = payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.JobAllocation_PercentageTotal.
                    //Assert.AreEqual(100, percentageTotal);
                }
                catch (Exception ex)
                {
                    string test = "";
                }
            }
        }

        [TestMethod]
        public void VerifySavedData_PayInfo_Earnings()
        {
            string jobcode;
            string worklocationcode;
            string costCenterCode;
            string laborDistributionCode;
            string schedule;
            string hours;
            string rate;
            string payAmount;
            string goalAmount;
            string goalSequenceNumber;
            string earningsEndDate;
            string notificationMessage;

            bool earningsInactive;

            Login();
            selectscreen_PayInformation();

            selectscreen_PayInformation();
            Mouse.Click(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.PayInformationTabHeader.Earnings_TabLink, MouseButtons.Left);

            for (int i = 19; i < 21; i++)
            {
                input_EmployeeNumber(compensationSpecifications[i, index_employeeNumber]);
                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_JobCode.SetFocus();
                jobcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_JobCode);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_WorkLocationCode.SetFocus();
                worklocationcode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_WorkLocationCode);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_CostCenterCode.SetFocus();
                costCenterCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_CostCenterCode);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_LaborDistributionCode.SetFocus();
                laborDistributionCode = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_LaborDistributionCode);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_PayAmount.SetFocus();
                payAmount = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_PayAmount);

                //payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_GoalAmount.SetFocus();
                //goalAmount = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_GoalAmount);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_GoalSequenceNumber.SetFocus();
                goalSequenceNumber = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_GoalSequenceNumber);

                payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_EarningsEndDate.SetFocus();
                earningsEndDate = getText(payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_EarningsEndDate);

                bool inactive = payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_EarningsInactive.Checked;
                Assert.AreEqual(inactive, false);

                notificationMessage = payInformationControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.PayInformationScreen.Earnings_NotificationMessage.DisplayText;

            }
        }

        [TestMethod]
        public void AlternateScreens_EmployeeCompensaton_EmployeeBenefits()
        {
            Login();

            for (int i = 10; i < 21; i++)
            {
                selectscreen_PayInformation();
                input_EmployeeNumber(compensationSpecifications[i, index_employeeNumber]);

                selectscreen_BenefitsEnrollment();
                Playback.Wait(10000);
            }
        }
    }
}
