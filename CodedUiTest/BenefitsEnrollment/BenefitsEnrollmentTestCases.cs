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
using System.IO;

namespace CodedUiTest.BenefitsEnrollment
{
    [CodedUITest]
    public class BenefitsEnrollmentTestCases :TestBase
    {
        private string benefitPlanCode;
        private string benefitLevelCode;
        private string payPeriodPremium;
        //private decimal coverageAmount = 0.00m;
        private string monthlyPremium;
        private string employeeCost;
        private string employerCost;
        private string totalCost;
        private string cobraCost;
        private string enrollmentDate;
        private string eligibilityOverrideDate;
        private string eligibleDate;
        private string electedCoverageAmount;
        private string payEntityCode;
        private string benefitEndDate;
        private string deductionCode;
        private string benefitProcessingStatusCode;// Remove later
        private string processingStatus;// Will be using this
        private bool inGoodHealth;
        private bool optOut;
        private bool inactive;
        private string benefitTerminationReason;
        private string enrollmentType;
        private string lifeEventType;
        private string lifeEventDate;
        private string lifeEventDescription;
        private string recipient;
        private string name;
        private string notificationMessage;

        private bool ineligibleForWaivedEarnings;
        private string monthlyOptOutAmount;
        private string payPeriodOptOutAmount;
        private string coverageAmount;
        private string ACLALowestCost;

       
        BenefitsEnrollment_Controls benefitsEnrollment_Controls = new BenefitsEnrollment_Controls();

        public string timeStamp = GetTimeStamp(DateTime.Now);

        //private TestContext testContextData;
        //public TestContext TestContextData
        //{
        //    get
        //    {
        //        return testContextData;
        //    }
        //    set
        //    {
        //        testContextData = value;
        //    }
        //}
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}
        //private TestContext testContextInstance;

        //string filename = "EMP_BenefitEnrollment_ADD.csv";
        //Console.WriteLine(filename);
        //Console.WriteLine(GetTabValue());
        //Playback.Wait(1000);

        //Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.BenefitsEnrollment_TabHeader.Dental_TabLink, MouseButtons.Left);
        //input_EmployeeNumber("20140101");
        //    Playback.Wait(12000);
        //    benefitPlanCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_BenefitPlanCode);

        //    Playback.Wait(10000);
        ///Console.WriteLine("Benefit plan code=" + benefitPlanCode);
        //Assert.AreEqual(TestContext.DataRow["BenefitPlanCode"].ToString(), benefitPlanCode);
        //coverageAmount = getDecimalText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_CoverageAmount);
        //coverageAmount = Math.Round((Decimal.Parse( getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_CoverageAmount))), 2);
        //coverageAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_CoverageAmount);
        //Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["CoverageAmount"]), coverageAmount);
        //Assert.AreEqual(string.Format("{0}", Convert.ToDateTime(TestContext.DataRow["EligibleDate"].ToString()).ToShortDateString()), eligibleDate);
        //Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["LifeEventdate"]), lifeEventDate);
        //if (!(inGoodHealth))
        //{
        //}

        //Login("998");
        //selectscreen_BenefitsEnrollment("Life");
        //input_EmployeeNumber("20140101");
        ////HeaderTestCases.SelectTab("Garnishments");
        ////HeaderTestCases.EnterEmployeeNumber("1177");

        //Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.BenefitsEnrollment_TabHeader.Life_TabLink, MouseButtons.Left);
        ////input_EmployeeNumber("20140101");
        private void Verify_CommonBenefitFields_SavedData()
        {
          

            benefitPlanCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_BenefitPlanCode); //1. benefitPlanCode
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["BenefitPlanCode"]), benefitPlanCode);
            benefitLevelCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_BenefitLevelCode);// 2 benefitLevelCode
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["BenefitLevelCode"]), benefitLevelCode);
            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_CoverageAmount.Exists)// 3. coverageAmount
            {
                coverageAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_CoverageAmount);
                Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["CoverageAmount"]), coverageAmount);
            }
            payPeriodPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_PayPeriodPremium);//4. PayPeriodPremium
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["payPeriodPremium"]), payPeriodPremium);
            monthlyPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_MonthlyPremium);//5. monthlyPremium
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["MonthlyPremium"]), monthlyPremium);
            employeeCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_EmployeeCost);// 6. employeeCost
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["EmployeeCost"]), employeeCost);
            employerCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_EmployerCost);//7. employerCost
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["EmployerCost"]), employerCost);
            totalCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_TotalCost);//8. totalCost
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["TotalCost"]), totalCost);
            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_ElectedCoverageAmount.Exists)//9. electedCoverageAmount
            {
                electedCoverageAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_ElectedCoverageAmount);
                Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["ElectedCoverageAmount"]), electedCoverageAmount);
            }
            enrollmentDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_EnrollmentDate);//10. enrollmentDate
            if (String.IsNullOrEmpty(TestContext.DataRow["EnrollmentDate"].ToString()))
            {
                Console.WriteLine("Input Data for 'EnrollmentDate' is empty in csv file");
            }
            else
            {
                Assert.AreEqual(string.Format("{0}", Convert.ToDateTime(TestContext.DataRow["EnrollmentDate"].ToString()).ToShortDateString()), enrollmentDate);
            }
            eligibilityOverrideDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_EligibilityOverrideDate);// 11. eligibilityOverrideDate
            if (String.IsNullOrEmpty(TestContext.DataRow["EligibilityOverrideDate"].ToString()))
            {
                Console.WriteLine("Input Data for 'EligibilityOverrideDate'  is empty in csv file");
            }
            else
            {
                Assert.AreEqual(string.Format("{0}", Convert.ToDateTime(TestContext.DataRow["EligibilityOverrideDate"].ToString()).ToShortDateString()), eligibilityOverrideDate);
            }
            eligibleDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_EligibleDate);// 12. eligibleDate
     
            if (String.IsNullOrEmpty(TestContext.DataRow["EligibleDate"].ToString()))
            {
                Console.WriteLine("Input Data for 'EligibleDate' is empty in csv file");
            }
            else
            {
                Assert.AreEqual(string.Format("{0}", Convert.ToDateTime(TestContext.DataRow["EligibleDate"].ToString()).ToShortDateString()), eligibleDate);
            }
            payEntityCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_PayEntityCode);// 13.  payEntityCode
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["PayEntityCode"]), payEntityCode);
            benefitEndDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_BenefitEndDate);//14. benefitEndDate
            if (String.IsNullOrEmpty(TestContext.DataRow["BenefitEndDate"].ToString()))
            {
                Console.WriteLine("Input Data for 'BenefitEndDate' is empty in csv file");
            }
            else
            {
                Assert.AreEqual(string.Format("{0}", Convert.ToDateTime(TestContext.DataRow["BenefitEndDate"].ToString()).ToShortDateString()), benefitEndDate);

            }
            
            deductionCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_DeductionCode);// 15. deductionCode 
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["DeductionCode"]), deductionCode);
            processingStatus = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_BenefitProcessingStatusCode);//16. processingStatus
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["ProcessingStatus"]), processingStatus);
            inGoodHealth = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_InGoodHealth.Checked;//17. inGoodHealth
            Assert.AreEqual(System.Convert.ToBoolean(TestContext.DataRow["InGoodHealth"]), inGoodHealth);
            optOut = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_OptOut.Checked;//18. optOut
            Assert.AreEqual(System.Convert.ToBoolean(TestContext.DataRow["OptOut"]), optOut);
            inactive = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_Inactive.Checked;//19. inactive
            Assert.AreEqual(System.Convert.ToBoolean(TestContext.DataRow["Inactive"]), inactive);

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_Recipient.Exists)
            {
                recipient = getInnerText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_Recipient).Trim();//20. recipient
                Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["Recipient"]), recipient);
            }
            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_Name.Exists)//21. name
            {
                name = getInnerText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_Name).Trim();
                Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["Name"]), name);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_Add.Exists)// 22. ADD
            {
                // Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_Add, MouseButtons.Left);/// dissabling this for the curent context
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_NotificationMessage.Exists)// 23. notificationMessage
            {
                notificationMessage = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_NotificationMessage.DisplayText.Trim();
                Assert.AreEqual(TestContext.DataRow["NotificationMessage"], notificationMessage);
            }

            benefitTerminationReason = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_BenefitTerminationReason);//24. BenefitTerminationReason
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["BenefitTerminationReason"]), benefitTerminationReason);

            enrollmentType = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_EnrollmentTypeCode_Input);//25.EnrollmentType
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["EnrollmentType"]), enrollmentType);

            lifeEventType = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_LifeEventTypeCode_Input);//26.LifeEventType
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["LifeEventType"]), lifeEventType);

            lifeEventDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_LifeEventDate);//27.LifeEventDate
          
            if (String.IsNullOrEmpty(TestContext.DataRow["LifeEventdate"].ToString()))
            {
                Console.WriteLine("Input Data for 'LifeEventDate' is empty in csv file");
            }
            else
            {
                Assert.AreEqual(string.Format("{0}", Convert.ToDateTime(TestContext.DataRow["LifeEventdate"].ToString()).ToShortDateString()), benefitEndDate);
            }

            lifeEventDescription = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_LifeEventDescription);//28. LifeEventDescription
            Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["LifeEventDescription"]), lifeEventDescription);
            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_COBRACost.Exists)
            {
                cobraCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_COBRACost);//29 COBRACost*
                Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["CobraCost"]), cobraCost);
            }


            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_IsIneligibleForWaivedEarning.Exists)
            {
                ineligibleForWaivedEarnings = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Common_Benefit_IsIneligibleForWaivedEarning.Checked;//30 IsIneligibleForWaivedEarning
                Assert.AreEqual(System.Convert.ToBoolean(TestContext.DataRow["IneligibleForWaivedEarnings"]), ineligibleForWaivedEarnings);
            }


            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_MonthlyOptOutAmount.Exists)
            {
                monthlyOptOutAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_MonthlyOptOutAmount);//31 MonthlyOptOutAmount
                Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["MonthlyOptOutAmount"]), monthlyOptOutAmount);
            }

            
            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_PayPeriodOptOutAmount.Exists)
            {
                payPeriodOptOutAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_PayPeriodOptOutAmount);//32 PayPeriodOptOutAmount
                Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["PayPeriodOptOutAmount"]), payPeriodOptOutAmount);
            }
            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_ACALowestCost.Exists)
            {
                ACLALowestCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Commom_Benefit_ACALowestCost);//33 ACALowestCost
                Assert.AreEqual(string.Format("{0:F2}", TestContext.DataRow["ACLALowestCost"]), ACLALowestCost);
            }

            //Playback.Wait(10000);
        }
         



        //TestBase TestBase = new TestBase();
        //BenefitsEnrollment_Controls benefitsEnrollment_Controls = new BenefitsEnrollment_Controls();

        //private void Login(string database)
        //{
        //    //LaunchInternetExplorerWithEmpowerPayQA();

        //    //// Delete cache (IE: Ctrl+Shift+Del)
        //    //Keyboard.SendKeys("^+{DEL}");
        //    //Keyboard.SendKeys("{D}");
        //    //Playback.Wait(30000);

        //    base.Login.LoginAsAdmin(database);
        //}

       // private void selectscreen_BenefitsEnrollment()
            private void selectscreen_BenefitsEnrollment(string BenefitName)
        {
            LeftMenuTestCases.LeftMenuControls.EmpowerBrowserWindow.WaitForControlReady();
            base.LeftMenuTestCases.ClickLeftMenuParentLink("Employee Benefit Enrollment");
            base.LeftMenuTestCases.LeftMenuControls.EmpowerBrowserWindow.EmpowerHtmlDocument.WaitForControlReady();

            //LeftMenuTestCases.ClickLeftMenuChildLink("Health Care");
            base.LeftMenuTestCases.ClickLeftMenuChildLink(BenefitName);

            base.HeaderTestCases.HeaderControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.WaitForControlEnabled(); // WaitForControlReady();
        }
        /*
        private void input_EmployeeNumber(string employeeNumber)
        {
            string employeeName = "";
            int i = 0;

            do
            {
                HeaderTestCases.EnterEmployeeNumber(employeeNumber);

                Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.AllThreads;
                benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.WaitForControlEnabled();
                benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.WaitForControlReady();
                Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.UIThreadOnly;

                Keyboard.SendKeys("{Enter}");

                benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.WaitForControlEnabled();
                benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.WaitForControlReady();
                benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.SetFocus();

                employeeName = HeaderTestCases.GetEmployeeNameTextBoxText();
                if (employeeName.Length == 0)
                {
                    i++;
                    Debug.WriteLine(i);
                }
            }
            while (employeeName.Length == 0 && i < 10);
            Debug.WriteLine(employeeName);
        }
        */

        private void input_EmployeeNumber(string employeeNumber)
        {
            benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Medical_BenefitPlanCode.WaitForControlExist();
            benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Medical_BenefitPlanCode.WaitForControlEnabled();
            benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.Medical_BenefitPlanCode.WaitForControlReady();

            HeaderTestCases.EnterEmployeeNumber(employeeNumber);

            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.AllThreads;
            Keyboard.SendKeys("{Enter}");
            benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.WaitForControlEnabled();
            benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.WaitForControlReady();
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.UIThreadOnly;

            benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.WaitForControlEnabled();
            benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.WaitForControlReady();
            benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.SetFocus();
        }

        private decimal getDecimalText(HtmlEdit editControl)
        {
            decimal decimalText = Math.Round(( Decimal.Parse(editControl.Text)), 2);
            //Debug.WriteLine(editControl.Id + ": " + text);
            return decimalText;
        }

        private string getText(HtmlEdit editControl)
        {
            string text = editControl.Text;
            Debug.WriteLine(editControl.Id + ": " + text);
            return text;
        }
        private string getInnerText(HtmlEdit editControl)
        {
            string InnerText = editControl.InnerText;
            Debug.WriteLine(editControl.Id + ": " + InnerText);
            return InnerText;
        }


        ///++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ BEGAIN METHOD +++  SelectTab_Additional_Death_Disability +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "C:\\AUTOMATION_PAY\\EmployeeBenefitEnrollment\\EMP_BenefitEnrollment_ADD.csv", "EMP_BenefitEnrollment_ADD#csv", DataAccessMethod.Sequential),
        DeploymentItem("EMP_BenefitEnrollment_ADD.csv")]//TestMethod]
        public void SelectTab_Additional_Death_Disability()//********************************************************************************************************************************************************
        {
            base.Login.LoginAsAdmin("");
           selectscreen_BenefitsEnrollment("Disability");
           Playback.Wait(8000);
           HeaderTestCases.SelectTab("AD&D");
           HeaderTestCases.EnterEmployeeNumber(TestContext.DataRow["EmployeeNumber"].ToString());//("20140101");
           Keyboard.SendKeys("{TAB}");
           Playback.Wait(10000);
           tabOrder = 4;////// This is the place to enter the tab number
           Playback.Wait(9000);
           Verify_CommonBenefitFields_SavedData();
           
        }
        ///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~END METHOD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~






        ///+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ BEGAIN METHOD +++++++SelectTab_Dental+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "C:\\AUTOMATION_PAY\\EmployeeBenefitEnrollment\\EMP_BenefitEnrollment_Dental.csv", "EMP_BenefitEnrollment_Dental#csv", DataAccessMethod.Sequential),
        DeploymentItem("EMP_BenefitEnrollment_Dental.csv")]//TestMethod]
        public void SelectTab_Dental()//****************************************************************************
        {           
        
            base.Login.LoginAsAdmin("");
            selectscreen_BenefitsEnrollment("Health Care");
            HeaderTestCases.SelectTab("Dental");
            HeaderTestCases.EnterEmployeeNumber(TestContext.DataRow["EmployeeNumber"].ToString());//("20140101");
            Keyboard.SendKeys("{TAB}");
            Playback.Wait(10000);
            tabOrder = 2;//  DENTAL ////// This is the place to enter the tab number
            Verify_CommonBenefitFields_SavedData();


        }
            ///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~END METHOD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
          
        

        [TestMethod]
        public void SelectTab_Dependent_Life()
        {


            base.Login.LoginAsAdmin("998");
            selectscreen_BenefitsEnrollment("Life");
            input_EmployeeNumber("20140101");

            Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.BenefitsEnrollment_TabHeader.DependentLife_TabLink, MouseButtons.Left);
            //input_EmployeeNumber("20140101");

            benefitPlanCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_BenefitPlanCode);
            benefitLevelCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_BenefitLevelCode);
            payPeriodPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_PayPeriodPremium);
            //coverageAmount = Decimal.Parse(getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_CoverageAmount));
            monthlyPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_MonthlyPremium);
            employeeCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_EmployeeCost);
            employerCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_EmployerCost);
            totalCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_TotalCost);
            electedCoverageAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_ElectedCoverageAmount);
            enrollmentDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_EnrollmentDate);
            eligibilityOverrideDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_EligibilityOverrideDate);
            eligibleDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_EligibleDate);
            payEntityCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_PayEntityCode);
            benefitEndDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_BenefitEndDate);
            deductionCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_DeductionCode);
            benefitProcessingStatusCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_BenefitProcessingStatusCode);

            inGoodHealth = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_InGoodHealth.Checked;
            optOut = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_OptOut.Checked;
            inactive = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_Inactive.Checked;

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_Recipient.Exists)
            {
                recipient = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_Recipient);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_Name.Exists)
            {
                name = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_Name);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_Add.Exists)
            {
                Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_Add, MouseButtons.Left);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_NotificationMessage.Exists)
            {
                notificationMessage = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.DependentLife_NotificationMessage.DisplayText;
            }
            Playback.Wait(10000);
        }

        [TestMethod]
        public void SelectTab_FSA_Dependent_Care()
        {
            base.Login.LoginAsAdmin("998");
            selectscreen_BenefitsEnrollment("Spending Accounts");
            input_EmployeeNumber("1962");

            Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.BenefitsEnrollment_TabHeader.FsaDependentCare_TabLink, MouseButtons.Left);
            //input_EmployeeNumber("1962");

            benefitPlanCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_BenefitPlanCode);
            benefitLevelCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_BenefitLevelCode);
            payPeriodPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_PayPeriodPremium);
            //coverageAmount = Decimal.Parse(getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_CoverageAmount));
            monthlyPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_MonthlyPremium);
            employeeCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_EmployeeCost);
            employerCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_EmployerCost);
            totalCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_TotalCost);
            electedCoverageAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_ElectedCoverageAmount);
            enrollmentDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_EnrollmentDate);
            eligibilityOverrideDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_EligibilityOverrideDate);
            eligibleDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_EligibleDate);
            payEntityCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_PayEntityCode);
            benefitEndDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_BenefitEndDate);
            deductionCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_DeductionCode);
            benefitProcessingStatusCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_BenefitProcessingStatusCode);

            inGoodHealth = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_InGoodHealth.Checked;
            optOut = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_OptOut.Checked;
            inactive = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_Inactive.Checked;

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_Recipient.Exists)
            {
                recipient = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_Recipient);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_Name.Exists)
            {
                name = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_Name);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_Add.Exists)
            {
                Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_Add, MouseButtons.Left);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_NotificationMessage.Exists)
            {
                notificationMessage = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaDependentCare_NotificationMessage.DisplayText;
            }
            Playback.Wait(10000);
        }

        [TestMethod]
        public void SelectTab_FSA_Medical()
        {
            base.Login.LoginAsAdmin("998");
            selectscreen_BenefitsEnrollment("Spending Accounts");
            input_EmployeeNumber("20140101");

            Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.BenefitsEnrollment_TabHeader.FsaMedical_TabLink, MouseButtons.Left);
            //input_EmployeeNumber("20140101");

            benefitPlanCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_BenefitPlanCode);
            benefitLevelCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_BenefitLevelCode);
            payPeriodPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_PayPeriodPremium);
            //coverageAmount = Decimal.Parse(getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_CoverageAmount));
            monthlyPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_MonthlyPremium);
            employeeCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_EmployeeCost);
            employerCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_EmployerCost);
            totalCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_TotalCost);
            electedCoverageAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_ElectedCoverageAmount);
            enrollmentDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_EnrollmentDate);
            eligibilityOverrideDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_EligibilityOverrideDate);
            eligibleDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_EligibleDate);
            payEntityCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_PayEntityCode);
            benefitEndDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_BenefitEndDate);
            deductionCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_DeductionCode);
            benefitProcessingStatusCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_BenefitProcessingStatusCode);

            inGoodHealth = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_InGoodHealth.Checked;
            optOut = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_OptOut.Checked;
            inactive = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_Inactive.Checked;

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_Recipient.Exists)
            {
                recipient = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_Recipient);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_Name.Exists)
            {
                name = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_Name);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_Add.Exists)
            {
                Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_Add, MouseButtons.Left);
            }

            if (benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_NotificationMessage.Exists)
            {
                notificationMessage = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.FsaMedical_NotificationMessage.DisplayText;
            }
            Playback.Wait(10000);
        }
        ///+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ BEGAIN METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        [TestMethod]                                                            //+BasicLife+//
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "C:\\AUTOMATION_PAY\\EmployeeBenefitEnrollment\\EMP_BenefitEnrollment_BasicLife.csv", "EMP_BenefitEnrollment_BasicLife#csv", DataAccessMethod.Sequential),
         DeploymentItem("EMP_BenefitEnrollment_BasicLife.csv")]//TestMethod
        public void SelectTab_BasicLife_VerifySavedData()
        {
           

            base.Login.LoginAsAdmin("");
            selectscreen_BenefitsEnrollment("Life");
            HeaderTestCases.SelectTab("Basic Life");
            HeaderTestCases.EnterEmployeeNumber(TestContext.DataRow["EmployeeNumber"].ToString());
            Keyboard.SendKeys("{TAB}");
            Playback.Wait(10000);
            tabOrder = 1;//  BASIC LIFE ////// This is the place to enter the tab number
            Verify_CommonBenefitFields_SavedData();
        }
        ///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~END METHOD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [TestMethod]
        public void SelectTab_Long_Term_Disability()
        {
            base.Login.LoginAsAdmin("998");
            selectscreen_BenefitsEnrollment("Disability");
            input_EmployeeNumber("20140101");

            Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.BenefitsEnrollment_TabHeader.LongTermDisability_TabLink, MouseButtons.Left);
            //input_EmployeeNumber("20140101");

            benefitPlanCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_BenefitPlanCode);
            benefitLevelCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_BenefitLevelCode);
            payPeriodPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_PayPeriodPremium);
            //coverageAmount = Decimal.Parse(getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_CoverageAmount));
            monthlyPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_MonthlyPremium);
            employeeCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_EmployeeCost);
            employerCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_EmployerCost);
            totalCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_TotalCost);
            electedCoverageAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_ElectedCoverageAmount);
            enrollmentDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_EnrollmentDate);
            eligibilityOverrideDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_EligibilityOverrideDate);
            eligibleDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_EligibleDate);
            payEntityCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_PayEntityCode);
            benefitEndDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_BenefitEndDate);
            deductionCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_DeductionCode);
            benefitProcessingStatusCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_BenefitProcessingStatusCode);

            inGoodHealth = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_InGoodHealth.Checked;
            optOut = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_OptOut.Checked;
            inactive = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.LongTermDisability_Inactive.Checked;
            Playback.Wait(10000);
        }
        ///+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ BEGAIN METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        [TestMethod]                                                              //Medical+//
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "C:\\AUTOMATION_PAY\\EmployeeBenefitEnrollment\\EMP_BenefitEnrollment_Medical.csv", "EMP_BenefitEnrollment_Medical#csv", DataAccessMethod.Sequential),
         DeploymentItem("EMP_BenefitEnrollment_Medical.csv")]//TestMethod]
        public void SelectTab_Medical()
        {
            base.Login.LoginAsAdmin("");
            selectscreen_BenefitsEnrollment("Health Care");
            HeaderTestCases.SelectTab("Medical");
            HeaderTestCases.EnterEmployeeNumber(TestContext.DataRow["EmployeeNumber"].ToString());
            Keyboard.SendKeys("{TAB}");
            Playback.Wait(10000);
            tabOrder = 1;//  Medical ////// This is the place to enter the tab number
            Verify_CommonBenefitFields_SavedData();
        }

            ///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~END METHOD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
           

        [TestMethod]
        public void SelectTab_Short_Term_Disability()
        {
            base.Login.LoginAsAdmin("998");
            selectscreen_BenefitsEnrollment("Disability");
            input_EmployeeNumber("1962");

            Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.BenefitsEnrollment_TabHeader.ShortTermDisability_TabLink, MouseButtons.Left);
            //input_EmployeeNumber("1962");

            benefitPlanCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_BenefitPlanCode);
            benefitLevelCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_BenefitLevelCode);
            payPeriodPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_PayPeriodPremium);
            //coverageAmount = Decimal.Parse(getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_CoverageAmount));
            monthlyPremium = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_MonthlyPremium);
            employeeCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_EmployeeCost);
            employerCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_EmployerCost);
            totalCost = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_TotalCost);
            electedCoverageAmount = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_ElectedCoverageAmount);
            enrollmentDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_EnrollmentDate);
            eligibilityOverrideDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_EligibilityOverrideDate);
            eligibleDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_EligibleDate);
            payEntityCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_PayEntityCode);
            benefitEndDate = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_BenefitEndDate);
            deductionCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_DeductionCode);
            benefitProcessingStatusCode = getText(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_BenefitProcessingStatusCode);

            inGoodHealth = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_InGoodHealth.Checked;
            optOut = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_OptOut.Checked;
            inactive = benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.ShortTermDisability_Inactive.Checked;
            Playback.Wait(10000);
        }

        [TestMethod]
        public void SelectTab_Spouse_Life()
        {
            base.Login.LoginAsAdmin("998");
            selectscreen_BenefitsEnrollment("Life");
            input_EmployeeNumber("20140101");

            Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.BenefitsEnrollment_TabHeader.SpouseLife_TabLink, MouseButtons.Left);
            //input_EmployeeNumber("20140101");

            Playback.Wait(10000);
        }

        [TestMethod]
        public void SelectTab_Supp_Life()
        {
            //Login("100304");
            //selectscreen_BenefitsEnrollment("Life");
            //input_EmployeeNumber("350");

            //Mouse.Click(benefitsEnrollment_Controls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.BenefitsEnrollment_Screen.BenefitsEnrollment_TabHeader.SuppLife_TabLink, MouseButtons.Left);
            ////input_EmployeeNumber("350");

            //Playback.Wait(10000);

            base.Login.LoginAsAdmin("100304");
            selectscreen_BenefitsEnrollment("Life");
            Playback.Wait(8000);
            HeaderTestCases.SelectTab("Supplemental Life");
            HeaderTestCases.EnterEmployeeNumber(TestContext.DataRow["EmployeeNumber"].ToString());//("20140101");
            Keyboard.SendKeys("{TAB}");
            Playback.Wait(10000);
            tabOrder = 4;////// This is the place to enter the tab number
            Playback.Wait(9000);
            Verify_CommonBenefitFields_SavedData();
        }
        ///+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ BEGAIN METHOD +++++++SelectTab_Vision++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "C:\\AUTOMATION_PAY\\EmployeeBenefitEnrollment\\EMP_BenefitEnrollment_Vision.csv", "EMP_BenefitEnrollment_Vision#csv", DataAccessMethod.Sequential),
         DeploymentItem("EMP_BenefitEnrollment_Vision.csv")]//TestMethod]
        public void SelectTab_Vision_Verify_SavedData()
        {
            base.Login.LoginAsAdmin("");
            selectscreen_BenefitsEnrollment("Health Care");
            //input_EmployeeNumber("20140101");
            HeaderTestCases.SelectTab("Vision");
            //HeaderTestCases.EnterEmployeeNumber("20140101");
            HeaderTestCases.EnterEmployeeNumber(TestContext.DataRow["EmployeeNumber"].ToString());
            Keyboard.SendKeys("{TAB}");
            Playback.Wait(10000);
            tabOrder = 3;//  VISION ////// This is the place to enter the tab number
            Verify_CommonBenefitFields_SavedData();

            ///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~END METHOD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        
        }

    }
}
