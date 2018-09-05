using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using CodedUiTest.Base;

namespace CodedUiTest.BenefitsEnrollment
{

    //========================================================================================================================================
    public class BenefitsEnrollment_Controls
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
        private AdminHtmlDocumentFrame adminHtmlDocumentFrame;

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
    //========================================================================================================================================
    public class AdminHtmlDocumentFrame : HtmlIFrame
    {
        private BenefitsEnrollmentScreen benefitsEnrollment_Screen;

        public AdminHtmlDocumentFrame(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "Home";
        }

        public BenefitsEnrollmentScreen BenefitsEnrollment_Screen
        {
            get
            {
                this.benefitsEnrollment_Screen = new BenefitsEnrollmentScreen(this);
                return this.benefitsEnrollment_Screen;
            }
        }
    };
    //========================================================================================================================================
    public class BenefitsEnrollmentScreen : HtmlDocument
    {       


        public BenefitsEnrollmentScreen(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/Secured/Admin/AdminManager.aspx";
        }

        //================================================== Tab Header ===============================================================

        private BenefitsEnrollmentTabHeader benefitsEnrollment_TabHeader;
        public BenefitsEnrollmentTabHeader BenefitsEnrollment_TabHeader
        {
            get
            {
                this.benefitsEnrollment_TabHeader = new BenefitsEnrollmentTabHeader(this);
                return this.benefitsEnrollment_TabHeader;
            }
        }
       
        //================================================== Common Objects ===============================================================
//1* BenefitPlanCode *
//2* BenefitLevelCode*
//3* PayPeriodPremium *
//4* MonthlyPremium
//5* EmployeeCost*
//6* EmployerCost*
//7* TotalCost*
//8* COBRACost*
//9* EnrollmentDate*_
//10* EligibilityOverrideDate*
//11* EligibleDate*_
//12* InGoodHealth*_
//13* OptOut*
//14* IsIneligibleForWaivedEarning*
//15* Recipient*
//16* Name*
//17* MonthlyOptOutAmount*
//18* PayPeriodOptOutAmount*
//19* PayEntityCode*_
//20* BenefitEndDate*
//21* Inactive*
//22* DeductionCode*_
//23* BenefitProcessingStatusCode*_
//24* BenefitTerminationReason*
//25* ACALowestCost*
//26* EnrollmentTypeCode_Input*_
//27* LifeEventTypeCode_Input
//28* LifeEventDate*
//29* LifeEventDescription*
//30* Add*
//31. Coverage Amount
//32. Elected Coverage Amount/Level
//33. NotificationMessage
        //  ________________________________________________ EmployeeBenefitEnrollment>___________________
        ////  ________________________________________________ 1* BenefitPlanCode *________________________________________________ 
        private HtmlEdit common_BenefitPlanCode;
        public HtmlEdit Commom_BenefitPlanCode
        {
            get
            {
                this.common_BenefitPlanCode = new HtmlEdit(this);
                //this.additionalDeathAndDisability_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_BenefitPlanCode_Input";
                //this.additionalDeathAndDisability_BenefitPlanCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitPlanCode_Input", PropertyExpressionOperator.Contains);
                this.common_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_BenefitPlanCode_Input";
                return this.common_BenefitPlanCode;
            }
        }
        ////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 2* BenefitLevelCode*________________________________________________ 
        private HtmlEdit common_BenefitLevelCode;
        public HtmlEdit Commom_BenefitLevelCode
        {
            get
            {
                this.common_BenefitLevelCode = new HtmlEdit(this);
                this.common_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_BenefitLevelCode_Input";
                return this.common_BenefitLevelCode;
            }
        }
        //////  ________________________________________________________________________________________________ 
        ////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 3* PayPeriodPremium *________________________________________________ 
        private HtmlEdit common_Benefit_PayPeriodPremium;
        public HtmlEdit Commom_Benefit_PayPeriodPremium
        {
            get
            {
                this.common_Benefit_PayPeriodPremium = new HtmlEdit(this);
                this.common_Benefit_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_PayPeriodPremium";
                return this.common_Benefit_PayPeriodPremium;
            }
        }
        //////  ________________________________________________________________________________________________ 

        //////  ________________________________________________________________________________________________ 
        ////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 4* MonthlyPremium*________________________________________________ 
        private HtmlEdit common_Benefit_MonthlyPremium;
        public HtmlEdit Commom_Benefit_MonthlyPremium
        {
            get
            {
                this.common_Benefit_MonthlyPremium = new HtmlEdit(this);
                this.common_Benefit_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_MonthlyPremium";
                return this.common_Benefit_MonthlyPremium;
            }
        }
  

         //////  ________________________________________________________________________________________________ 
        ////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 5* EmployeeCost*________________________________________________ 
        private HtmlEdit common_Benefit_EmployeeCost;
        public HtmlEdit Commom_Benefit_EmployeeCost
        {
            get
            {
                this.common_Benefit_EmployeeCost = new HtmlEdit(this);
                this.common_Benefit_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_EmployeeCost";
                return this.common_Benefit_EmployeeCost;
            }
        }
        //////  ________________________________________________________________________________________________ 
        //////  ________________________________________________________________________________________________ 
        ////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 6* EmployerCost*________________________________________________ 
        private HtmlEdit common_Benefit_EmployerCost;
        public HtmlEdit Commom_Benefit_EmployerCost
        {
            get
            {
                this.common_Benefit_EmployerCost = new HtmlEdit(this);
                this.common_Benefit_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_EmployerCost";
                return this.common_Benefit_EmployerCost;
            }
        }
        //////  ________________________________________________________________________________________________ 

        //////  ________________________________________________________________________________________________ 
        //////  ________________________________________________________________________________________________ 
        ////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 7* TotalCost*________________________________________________ 
        private HtmlEdit common_Benefit_TotalCost;
        public HtmlEdit Commom_Benefit_TotalCost
        {
            get
            {
                this.common_Benefit_TotalCost = new HtmlEdit(this);
                this.common_Benefit_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_TotalCost";
                return this.common_Benefit_TotalCost;
            }
        }
        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 8* COBRACost*________________________________________________ 
        private HtmlEdit common_Benefit_COBRACost;
        public HtmlEdit Commom_Benefit_COBRACost
        {
            get
            {
                this.common_Benefit_COBRACost = new HtmlEdit(this);
                this.common_Benefit_COBRACost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_COBRACost";
                return this.common_Benefit_COBRACost;
            }
        }
        //////  ________________________________________________________________________________________________ 
        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 9* EnrollmentDate*________________________________________________ 
        private HtmlEdit common_Benefit_EnrollmentDate;
        public HtmlEdit Commom_Benefit_EnrollmentDate
        {
            get
            {
                this.common_Benefit_EnrollmentDate = new HtmlEdit(this);
                this.common_Benefit_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_EnrollmentDate";
                return this.common_Benefit_EnrollmentDate;
            }
        }
        //////  ________________________________________________________________________________________________ 
        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 10* EligibilityOverrideDate*________________________________________________ 
        private HtmlEdit common_EligibilityOverrideDate;
        public HtmlEdit Commom_EligibilityOverrideDate
        {
            get
            {
                this.common_EligibilityOverrideDate = new HtmlEdit(this);
                this.common_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_EligibilityOverrideDate";
                return this.common_EligibilityOverrideDate;
            }
        }
        //////  ________________________________________________________________________________________________ 

        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 11* EligibleDate*________________________________________________ 
        private HtmlEdit common_Benefit_EligibleDate;
        public HtmlEdit Commom_Benefit_EligibleDate
        {
            get
            {
                this.common_Benefit_EligibleDate = new HtmlEdit(this);
                this.common_Benefit_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_EligibleDate";
                return this.common_Benefit_EligibleDate;
            }
        }
        //////  ________________________________________________________________________________________________ 

        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 12* InGoodHealth*________________________________________________ 
        private HtmlCheckBox common_Benefit_InGoodHealth;
        public HtmlCheckBox Common_Benefit_InGoodHealth
        {
            get
            {
                this.common_Benefit_InGoodHealth = new HtmlCheckBox(this);
                this.common_Benefit_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_InGoodHealth";
                return this.common_Benefit_InGoodHealth;
            }
        }
        //////  ________________________________________________________________________________________________ 
        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 13* OptOut*________________________________________________ 
        private HtmlCheckBox common_Benefit_OptOut;
        public HtmlCheckBox Common_Benefit_OptOut
        {
            get
            {
                this.common_Benefit_OptOut = new HtmlCheckBox(this);
                this.common_Benefit_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_OptOut";
                return this.common_Benefit_OptOut;
            }
        }
        //////  ________________________________________________________________________________________________ 

        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 14* IsIneligibleForWaivedEarning*________________________________________________ 
        private HtmlCheckBox common_Benefit_IsIneligibleForWaivedEarning;
        public HtmlCheckBox Common_Benefit_IsIneligibleForWaivedEarning
        {
            get
            {
                this.common_Benefit_IsIneligibleForWaivedEarning = new HtmlCheckBox(this);
                this.common_Benefit_IsIneligibleForWaivedEarning.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_IsIneligibleForWaivedEarning";
                return this.common_Benefit_IsIneligibleForWaivedEarning;
            }
        }
        //////  ________________________________________________________________________________________________   

        //////  ________________________________________________________________________________________________ 
        ////  ________________________________________________ 15* Recipient*________________________________________________ 
         private HtmlEdit common_Benefit_Recipient;
        public HtmlEdit Common_Benefit_Recipient
         {
             get
             {
                 this.common_Benefit_Recipient = new HtmlEdit(this);
                 this.common_Benefit_Recipient.SearchProperties.Add(HtmlEdit.PropertyNames.TagName, "SELECT");
                 this.common_Benefit_Recipient.SearchProperties.Add(HtmlEdit.PropertyNames.ControlType, "ComboBox");
                 this.common_Benefit_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl" + TestBase.GetTabValue() + "$ctl09";
                // this.common_Benefit_Recipient.SearchProperties.Add(HtmlEdit.PropertyNames.InnerText, "1");
                 //this.common_Benefit_Recipient.SearchProperties.Add(HtmlEdit.PropertyNames.TagInstance, "1");
                 return this.common_Benefit_Recipient;
             }
         }
        ////////  ________________________________________________________________________________________________   

        //////  ________________________________________________________________________________________________   

        //////  ________________________________________________________________________________________________ 
        ////  ________________________________________________ 16* Name*________________________________________________ 
        private HtmlEdit common_Benefit_Name;
        public HtmlEdit Common_Benefit_Name
        {
            get
            {
                this.common_Benefit_Name = new HtmlEdit(this);
                this.common_Benefit_Name.SearchProperties.Add(HtmlEdit.PropertyNames.TagName, "SELECT");
                this.common_Benefit_Name.SearchProperties.Add(HtmlEdit.PropertyNames.ControlType, "ComboBox");
                this.common_Benefit_Name.SearchProperties.Add(HtmlEdit.PropertyNames.TagName, "SELECT");
                this.common_Benefit_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl" + TestBase.GetTabValue() + "$ctl10";
                //this.common_Benefit_Name.SearchProperties.Add(HtmlEdit.PropertyNames.TagInstance, "2");
                return this.common_Benefit_Name;
            }
        }
        ////////  ______________________________________________________________________________________________
        ////////  ________________________________________________________________________________________________   


      
        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 17* MonthlyOptOutAmount*________________________________________________ 
        private HtmlEdit common_Benefit_MonthlyOptOutAmount;
        public HtmlEdit Commom_Benefit_MonthlyOptOutAmount
        {
            get
            {
                this.common_Benefit_MonthlyOptOutAmount = new HtmlEdit(this);
                this.common_Benefit_MonthlyOptOutAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_MonthlyOptOutAmount";
                return this.common_Benefit_MonthlyOptOutAmount;
            }
        }
        //////  ________________________________________________________________________________________________ 

        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 18* PayPeriodOptOutAmount*________________________________________________ 
        private HtmlEdit common_Benefit_PayPeriodOptOutAmount;
        public HtmlEdit Commom_Benefit_PayPeriodOptOutAmount
        {
            get
            {
                this.common_Benefit_PayPeriodOptOutAmount = new HtmlEdit(this);
                this.common_Benefit_PayPeriodOptOutAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_PayPeriodOptOutAmount";
                return this.common_Benefit_PayPeriodOptOutAmount;
            }
        }
        //////  ________________________________________________________________________________________________ 
        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 19* PayEntityCode*________________________________________________ 
        private HtmlEdit common_Benefit_PayEntityCode;
        public HtmlEdit Commom_Benefit_PayEntityCode
        {
            get
            {
                this.common_Benefit_PayEntityCode = new HtmlEdit(this);
                this.common_Benefit_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_PayEntityCode";
                return this.common_Benefit_PayEntityCode;
            }
        }
        //////  ________________________________________________________________________________________________ 

        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 20* BenefitEndDate*________________________________________________ 
        private HtmlEdit common_Benefit_BenefitEndDate;
        public HtmlEdit Commom_Benefit_BenefitEndDate
        {
            get
            {
                this.common_Benefit_BenefitEndDate = new HtmlEdit(this);
                this.common_Benefit_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_BenefitEndDate";
                return this.common_Benefit_BenefitEndDate;
            }
        }
        //////  ________________________________________________________________________________________________ 



        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 21* Inactive*________________________________________________ 
        private HtmlCheckBox common_Benefit_Inactive;
        public HtmlCheckBox Common_Benefit_Inactive
        {
            get
            {
                this.common_Benefit_Inactive = new HtmlCheckBox(this);
                this.common_Benefit_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_Inactive";
                return this.common_Benefit_Inactive;
            }
        }
        //////  ________________________________________________________________________________________________   


        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 22* DeductionCode*________________________________________________ 
        private HtmlEdit common_Benefit_DeductionCode;
        public HtmlEdit Commom_Benefit_DeductionCode
        {
            get
            {
                this.common_Benefit_DeductionCode = new HtmlEdit(this);
                this.common_Benefit_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_DeductionCode";
                return this.common_Benefit_DeductionCode;
            }
        }
        //////  ________________________________________________________________________________________________ 

        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 23* BenefitProcessingStatusCode*________________________________________________ 
        private HtmlEdit common_Benefit_BenefitProcessingStatusCode;
        public HtmlEdit Commom_Benefit_BenefitProcessingStatusCode
        {
            get
            {
                this.common_Benefit_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.common_Benefit_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_BenefitProcessingStatusCode";
                return this.common_Benefit_BenefitProcessingStatusCode;
            }
        }
        //////  ________________________________________________________________________________________________ 


        //////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 24* BenefitTerminationReason*________________________________________________ 
        private HtmlEdit common_Benefit_BenefitTerminationReason;
        public HtmlEdit Commom_Benefit_BenefitTerminationReason
        {
            get
            {
                this.common_Benefit_BenefitTerminationReason = new HtmlEdit(this);
                this.common_Benefit_BenefitTerminationReason.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_BenefitTerminationReasonCode_Input";
                return this.common_Benefit_BenefitTerminationReason;
            }
        }
        //////  ________________________________________________________________________________________________
        /////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 25* ACALowestCost*________________________________________________ 
        private HtmlEdit common_Benefit_ACALowestCost;
        public HtmlEdit Commom_Benefit_ACALowestCost
        {
            get
            {
                this.common_Benefit_ACALowestCost = new HtmlEdit(this);
                this.common_Benefit_ACALowestCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_ACALowestCost";
                return this.common_Benefit_ACALowestCost;
            }
        }
        //////  ________________________________________________________________________________________________

        //////  ________________________________________________________________________________________________
        /////  ________________________________________________________________________________________________ 
        //  ________________________________________________ 26* EnrollmentTypeCode_Input*________________________________________________ 
        private HtmlEdit common_Benefit_EnrollmentTypeCode_Input;
        public HtmlEdit Commom_Benefit_EnrollmentTypeCode_Input
        {
            get
            {
                this.common_Benefit_EnrollmentTypeCode_Input = new HtmlEdit(this);
                this.common_Benefit_EnrollmentTypeCode_Input.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_EnrollmentTypeCode_Input";
                return this.common_Benefit_EnrollmentTypeCode_Input;
            }
        }
        //////  ________________________________________________________________________________________________

        //  ________________________________________________ 27* LifeEventTypeCode_Input*________________________________________________ 
        private HtmlEdit common_Benefit_LifeEventTypeCode_Input;
        public HtmlEdit Commom_Benefit_LifeEventTypeCode_Input
        {
            get
            {
                this.common_Benefit_LifeEventTypeCode_Input = new HtmlEdit(this);
                this.common_Benefit_LifeEventTypeCode_Input.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_LifeEventTypeCode_Input";
                return this.common_Benefit_LifeEventTypeCode_Input;
            }
        }
        //////  ________________________________________________________________________________________________

        //  ________________________________________________ 28* LifeEventDate*________________________________________________ 
        private HtmlEdit common_Benefit_LifeEventDate;
        public HtmlEdit Commom_Benefit_LifeEventDate
        {
            get
            {
                this.common_Benefit_LifeEventDate = new HtmlEdit(this);
                this.common_Benefit_LifeEventDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_LifeEventDate";
                return this.common_Benefit_LifeEventDate;
            }
        }
        //////  ________________________________________________________________________________________________

        //  ________________________________________________ 29* LifeEventDescription*________________________________________________ 
        private HtmlEdit common_Benefit_LifeEventDescription;
        public HtmlEdit Commom_Benefit_LifeEventDescription
        {
            get
            {
                this.common_Benefit_LifeEventDescription = new HtmlEdit(this);
                this.common_Benefit_LifeEventDescription.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_LifeEventDescription";
                return this.common_Benefit_LifeEventDescription;
            }
        }

        //////  ________________________________________________________________________________________________

        //  ________________________________________________ 30* Add*________________________________________________ 
        //////  ________________________________________________________________________________________________

        private HtmlControl common_Benifit_Add;
        public HtmlControl Common_Benefit_Add
        {
            get
            {
                this.common_Benifit_Add= new HtmlControl(this);
                this.common_Benifit_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_BenefitCoverageExtensionAdd";
                return this.common_Benifit_Add;
            }
        }




         //  ________________________________________________ _________________

        // _______________________________________________________________ 31. Coverage Amount  ______________________________________________________________________

        private HtmlEdit common_Benefit_CoverageAmount;
        public HtmlEdit Common_Benefit_CoverageAmount
        {
            get
            {
                this.common_Benefit_CoverageAmount = new HtmlEdit(this);
                //this.additionalDeathAndDisability_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_CoverageAmount";
                this.common_Benefit_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id]= "ctl" + TestBase.GetTabValue() + "_E_Benefit_CoverageAmount";
                return this.common_Benefit_CoverageAmount;
            }
        }
        //////  ________________________________________________________________________________________________
        // _______________________________________________________________ 32. Elected Coverage Amount/Level  ______________________________________________________________________

        private HtmlEdit common_Benefit_ElectedCoverageAmount;
        public HtmlEdit Common_Benefit_ElectedCoverageAmount
        {
            get
            {
                this.common_Benefit_ElectedCoverageAmount = new HtmlEdit(this);
                //this.additionalDeathAndDisability_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_CoverageAmount";
                this.common_Benefit_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id]= "ctl" + TestBase.GetTabValue() + "_E_Benefit_ElectedCoverageAmount";
                return this.common_Benefit_ElectedCoverageAmount;
            }
        }
        //////  ________________________________________________________________________________________________
        //////  ________________________________________________________________________________________________
        // _______________________________________________________________ 33. NotificationMessage ______________________________________________________________________

        private HtmlSpan common_Benefit_NotificationMessage;
        public HtmlSpan Common_Benefit_NotificationMessage
        {
            get
            {
                this.common_Benefit_NotificationMessage = new HtmlSpan(this);
                //this.additionalDeathAndDisability_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl76_BenefitAdd_NotificationMessage";
                this.common_Benefit_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_BenefitADD_NotificationMessage";
                return this.common_Benefit_NotificationMessage;
            }
        }

        //////  ________________________________________________________________________________________________
        //////  ________________________________________________________________________________________________
      








        
        
        
        //================================================== A D & D ===============================================================
        private HtmlEdit additionalDeathAndDisability_BenefitPlanCode;
        public HtmlEdit AdditionalDeathAndDisability_BenefitPlanCode
        {
            get
            {
                this.additionalDeathAndDisability_BenefitPlanCode = new HtmlEdit(this);
                //this.additionalDeathAndDisability_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_BenefitPlanCode_Input";
                //this.additionalDeathAndDisability_BenefitPlanCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitPlanCode_Input", PropertyExpressionOperator.Contains);
                this.additionalDeathAndDisability_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "_E_Benefit_BenefitPlanCode_Input";
                return this.additionalDeathAndDisability_BenefitPlanCode;
            }
        }

        private HtmlEdit additionalDeathAndDisability_BenefitLevelCode;
        public HtmlEdit AdditionalDeathAndDisability_BenefitLevelCode
        {
            get
            {
                this.additionalDeathAndDisability_BenefitLevelCode = new HtmlEdit(this);
                //this.additionalDeathAndDisability_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_BenefitLevelCode_Input";
                this.additionalDeathAndDisability_BenefitLevelCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitLevelCode_Input", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_BenefitLevelCode;
            }
        }

        private HtmlEdit additionalDeathAndDisability_CoverageAmount;
        public HtmlEdit AdditionalDeathAndDisability_CoverageAmount
        {
            get
            {
                this.additionalDeathAndDisability_CoverageAmount = new HtmlEdit(this);
                //this.additionalDeathAndDisability_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_CoverageAmount";
                this.additionalDeathAndDisability_CoverageAmount.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_CoverageAmount", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_CoverageAmount;
            }
        }

        private HtmlEdit additionalDeathAndDisability_PayPeriodPremium;
        public HtmlEdit AdditionalDeathAndDisability_PayPeriodPremium
        {
            get
            {
                this.additionalDeathAndDisability_PayPeriodPremium = new HtmlEdit(this);
                //this.additionalDeathAndDisability_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_PayPeriodPremium";
                this.additionalDeathAndDisability_PayPeriodPremium.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_PayPeriodPremium", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_PayPeriodPremium;
            }
        }

        private HtmlEdit additionalDeathAndDisability_MonthlyPremium;
        public HtmlEdit AdditionalDeathAndDisability_MonthlyPremium
        {
            get
            {
                this.additionalDeathAndDisability_MonthlyPremium = new HtmlEdit(this);
                //this.additionalDeathAndDisability_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_MonthlyPremium";
                this.additionalDeathAndDisability_MonthlyPremium.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_MonthlyPremium", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_MonthlyPremium;
            }
        }

        private HtmlEdit additionalDeathAndDisability_EmployeeCost;
        public HtmlEdit AdditionalDeathAndDisability_EmployeeCost
        {
            get
            {
                this.additionalDeathAndDisability_EmployeeCost = new HtmlEdit(this);
                //this.additionalDeathAndDisability_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_EmployeeCost";
                this.additionalDeathAndDisability_EmployeeCost.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EmployeeCost", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_EmployeeCost;
            }
        }

        private HtmlEdit additionalDeathAndDisability_EmployerCost;
        public HtmlEdit AdditionalDeathAndDisability_EmployerCost
        {
            get
            {
                this.additionalDeathAndDisability_EmployerCost = new HtmlEdit(this);
                //this.additionalDeathAndDisability_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_EmployerCost";
                this.additionalDeathAndDisability_EmployerCost.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EmployerCost", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_EmployerCost;
            }
        }

        private HtmlEdit additionalDeathAndDisability_TotalCost;
        public HtmlEdit AdditionalDeathAndDisability_TotalCost
        {
            get
            {
                this.additionalDeathAndDisability_TotalCost = new HtmlEdit(this);
                //this.additionalDeathAndDisability_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_TotalCost";
                this.additionalDeathAndDisability_TotalCost.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_TotalCost", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_TotalCost;
            }
        }

        private HtmlEdit additionalDeathAndDisability_ElectedCoverageAmount;
        public HtmlEdit AdditionalDeathAndDisability_ElectedCoverageAmount
        {
            get
            {
                this.additionalDeathAndDisability_ElectedCoverageAmount = new HtmlEdit(this);
                //this.additionalDeathAndDisability_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_ElectedCoverageAmount";
                this.additionalDeathAndDisability_ElectedCoverageAmount.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_ElectedCoverageAmount", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_ElectedCoverageAmount;
            }
        }

        private HtmlEdit additionalDeathAndDisability_EnrollmentDate;
        public HtmlEdit AdditionalDeathAndDisability_EnrollmentDate
        {
            get
            {
                this.additionalDeathAndDisability_EnrollmentDate = new HtmlEdit(this);
                //this.additionalDeathAndDisability_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_EnrollmentDate";
                this.additionalDeathAndDisability_EnrollmentDate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EnrollmentDate", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_EnrollmentDate;
            }
        }

        private HtmlEdit additionalDeathAndDisability_EligibilityOverrideDate;
        public HtmlEdit AdditionalDeathAndDisability_EligibilityOverrideDate
        {
            get
            {
                this.additionalDeathAndDisability_EligibilityOverrideDate = new HtmlEdit(this);
                //this.additionalDeathAndDisability_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_EligibilityOverrideDate";
                this.additionalDeathAndDisability_EligibilityOverrideDate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EligibilityOverrideDate", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_EligibilityOverrideDate;
            }
        }

        private HtmlEdit additionalDeathAndDisability_EligibleDate;
        public HtmlEdit AdditionalDeathAndDisability_EligibleDate
        {
            get
            {
                this.additionalDeathAndDisability_EligibleDate = new HtmlEdit(this);
                //this.additionalDeathAndDisability_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_EligibleDate";
                this.additionalDeathAndDisability_EligibleDate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EligibleDate", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_EligibleDate;
            }
        }

        private HtmlCheckBox additionalDeathAndDisability_InGoodHealth;
        public HtmlCheckBox AdditionalDeathAndDisability_InGoodHealth
        {
            get
            {
                this.additionalDeathAndDisability_InGoodHealth = new HtmlCheckBox(this);
                //this.additionalDeathAndDisability_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl76_E_Benefit_InGoodHealth";
                this.additionalDeathAndDisability_InGoodHealth.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Benefit_InGoodHealth", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_InGoodHealth;
            }
        }

        private HtmlCheckBox additionalDeathAndDisability_OptOut;
        public HtmlCheckBox AdditionalDeathAndDisability_OptOut
        {
            get
            {
                this.additionalDeathAndDisability_OptOut = new HtmlCheckBox(this);
                //this.additionalDeathAndDisability_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl76_E_Benefit_OptOut";
                this.additionalDeathAndDisability_OptOut.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Benefit_OptOut", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_OptOut;
            }
        }

        private HtmlEdit additionalDeathAndDisability_PayEntityCode;
        public HtmlEdit AdditionalDeathAndDisability_PayEntityCode
        {
            get
            {
                this.additionalDeathAndDisability_PayEntityCode = new HtmlEdit(this);
                //this.additionalDeathAndDisability_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_PayEntityCode";
                this.additionalDeathAndDisability_PayEntityCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_PayEntityCode", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_PayEntityCode;
            }
        }

        private HtmlEdit additionalDeathAndDisability_BenefitEndDate;
        public HtmlEdit AdditionalDeathAndDisability_BenefitEndDate
        {
            get
            {
                this.additionalDeathAndDisability_BenefitEndDate = new HtmlEdit(this);
                //this.additionalDeathAndDisability_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_BenefitEndDate";
                this.additionalDeathAndDisability_BenefitEndDate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitEndDate", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_BenefitEndDate;
            }
        }

        private HtmlCheckBox additionalDeathAndDisability_Inactive;
        public HtmlCheckBox AdditionalDeathAndDisability_Inactive
        {
            get
            {
                this.additionalDeathAndDisability_Inactive = new HtmlCheckBox(this);
                //this.additionalDeathAndDisability_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl76_E_Benefit_Inactive";
                this.additionalDeathAndDisability_Inactive.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Benefit_Inactive", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_Inactive;
            }
        }

        private HtmlEdit additionalDeathAndDisability_DeductionCode;
        public HtmlEdit AdditionalDeathAndDisability_DeductionCode
        {
            get
            {
                this.additionalDeathAndDisability_DeductionCode = new HtmlEdit(this);
                //this.additionalDeathAndDisability_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_DeductionCode";
                this.additionalDeathAndDisability_DeductionCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_DeductionCode", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_DeductionCode;
            }
        }

        private HtmlEdit additionalDeathAndDisability_BenefitProcessingStatusCode;
        public HtmlEdit AdditionalDeathAndDisability_BenefitProcessingStatusCode
        {
            get
            {
                this.additionalDeathAndDisability_BenefitProcessingStatusCode = new HtmlEdit(this);
                //this.additionalDeathAndDisability_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl76_E_Benefit_BenefitProcessingStatusCode";
                this.additionalDeathAndDisability_BenefitProcessingStatusCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitProcessingStatusCode", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit additionalDeathAndDisability_Recipient;
        public HtmlEdit AdditionalDeathAndDisability_Recipient
        {
            get
            {
                this.additionalDeathAndDisability_Recipient = new HtmlEdit(this);
                //this.additionalDeathAndDisability_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl76$ctl09";
                this.additionalDeathAndDisability_Recipient.SearchProperties.Add(HtmlEdit.PropertyNames.Name, "$ctl09", PropertyExpressionOperator.Contains);
                this.additionalDeathAndDisability_Recipient.SearchProperties.Add(HtmlEdit.PropertyNames.TagName,"SELECT");
                this.additionalDeathAndDisability_Recipient.SearchProperties.Add(HtmlEdit.PropertyNames.TagInstance, "1");
                return this.additionalDeathAndDisability_Recipient;
            }
        }

        private HtmlEdit additionalDeathAndDisability_Name;
        public HtmlEdit AdditionalDeathAndDisability_Name
        {
            get
            {
                this.additionalDeathAndDisability_Name = new HtmlEdit(this);
                //this.additionalDeathAndDisability_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl76$ctl10";
                this.additionalDeathAndDisability_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl34$ctl10";
                this.additionalDeathAndDisability_Recipient.SearchProperties.Add(HtmlEdit.PropertyNames.TagInstance, "2");
                return this.additionalDeathAndDisability_Name;
            }
        }

        private HtmlControl additionalDeathAndDisability_Add;
        public HtmlControl AdditionalDeathAndDisability_Add
        {
            get
            {
                this.additionalDeathAndDisability_Add = new HtmlControl(this);
                //this.additionalDeathAndDisability_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl76_BenefitCoverageExtensionAdd";
                this.additionalDeathAndDisability_Add.SearchProperties.Add(HtmlControl.PropertyNames.Id, "_BenefitCoverageExtensionAdd", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_Add;
            }
        }

        private HtmlSpan additionalDeathAndDisability_NotificationMessage;
        public HtmlSpan AdditionalDeathAndDisability_NotificationMessage
        {
            get
            {
                this.additionalDeathAndDisability_NotificationMessage = new HtmlSpan(this);
                //this.additionalDeathAndDisability_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl76_BenefitAdd_NotificationMessage";
                this.additionalDeathAndDisability_NotificationMessage.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_BenefitAdd_NotificationMessage", PropertyExpressionOperator.Contains);
                return this.additionalDeathAndDisability_NotificationMessage;
            }
        }

        //=================================================== Dental ===============================================================
        //===================================================  ===============================================================
        private HtmlEdit dental_BenefitPlanCode;
        public HtmlEdit Dental_BenefitPlanCode
        {
            get
            {
                this.dental_BenefitPlanCode = new HtmlEdit(this);
                //this.dental_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_BenefitPlanCode_Input";
                //this.dental_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Benefit_BenefitPlanCode_Input";
                this.dental_BenefitPlanCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitPlanCode_Input", PropertyExpressionOperator.Contains);
                return this.dental_BenefitPlanCode;
            }
        }

        private HtmlEdit Denta_lBenefitLevelCode;
        public HtmlEdit Dental_BenefitLevelCode
        {
            get
            {
                this.Denta_lBenefitLevelCode = new HtmlEdit(this);
                //this.Denta_lBenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_BenefitLevelCode_Input";
                this.Denta_lBenefitLevelCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitLevelCode_Input", PropertyExpressionOperator.Contains);
                return this.Denta_lBenefitLevelCode;
            }
        }

        private HtmlEdit dental_PayPeriodPremium;
        public HtmlEdit Dental_PayPeriodPremium
        {
            get
            {
                this.dental_PayPeriodPremium = new HtmlEdit(this);
                //this.dental_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_PayPeriodPremium";
                this.dental_PayPeriodPremium.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_PayPeriodPremium", PropertyExpressionOperator.Contains);
                return this.dental_PayPeriodPremium;
            }
        }

        private HtmlEdit dental_MonthlyPremium;
        public HtmlEdit Dental_MonthlyPremium
        {
            get
            {
                this.dental_MonthlyPremium = new HtmlEdit(this);
                //this.dental_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_MonthlyPremium";
                this.dental_MonthlyPremium.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_MonthlyPremium", PropertyExpressionOperator.Contains);
                return this.dental_MonthlyPremium;
            }
        }

        private HtmlEdit dental_EmployeeCost;
        public HtmlEdit Dental_EmployeeCost
        {
            get
            {
                this.dental_EmployeeCost = new HtmlEdit(this);
                //this.dental_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_EmployeeCost";
                this.dental_EmployeeCost.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EmployeeCost", PropertyExpressionOperator.Contains);
                return this.dental_EmployeeCost;
            }
        }

        private HtmlEdit dental_EmployerCost;
        public HtmlEdit Dental_EmployerCost
        {
            get
            {
                this.dental_EmployerCost = new HtmlEdit(this);
                //this.dental_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_EmployerCost";
                this.dental_EmployerCost.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EmployerCost", PropertyExpressionOperator.Contains);
                return this.dental_EmployerCost;
            }
        }

        private HtmlEdit dental_TotalCost;
        public HtmlEdit Dental_TotalCost
        {
            get
            {
                this.dental_TotalCost = new HtmlEdit(this);
                //this.dental_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_TotalCost";
                this.dental_TotalCost.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_TotalCost", PropertyExpressionOperator.Contains);
                return this.dental_TotalCost;
            }
        }

        private HtmlEdit dental_COBRACost;
        public HtmlEdit Dental_COBRACost
        {
            get
            {
                this.dental_COBRACost = new HtmlEdit(this);
                //this.dental_COBRACost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_COBRACost";
                this.dental_COBRACost.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_COBRACost", PropertyExpressionOperator.Contains);
                return this.dental_COBRACost;
            }
        }

        private HtmlEdit dental_EnrollmentDate;
        public HtmlEdit Dental_EnrollmentDate
        {
            get
            {
                this.dental_EnrollmentDate = new HtmlEdit(this);
                //this.dental_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_EnrollmentDate";
                this.dental_EnrollmentDate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EnrollmentDate", PropertyExpressionOperator.Contains);
                return this.dental_EnrollmentDate;
            }
        }

        private HtmlEdit dental_EligibilityOverrideDate;
        public HtmlEdit Dental_EligibilityOverrideDate
        {
            get
            {
                this.dental_EligibilityOverrideDate = new HtmlEdit(this);
                //this.dental_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_EligibilityOverrideDate";
                this.dental_EligibilityOverrideDate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EligibilityOverrideDate", PropertyExpressionOperator.Contains);
                return this.dental_EligibilityOverrideDate;
            }
        }

        private HtmlEdit dental_EligibleDate;
        public HtmlEdit Dental_EligibleDate
        {
            get
            {
                this.dental_EligibleDate = new HtmlEdit(this);
                //this.dental_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_EligibleDate";
                this.dental_EligibleDate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_EligibleDate", PropertyExpressionOperator.Contains);
                return this.dental_EligibleDate;
            }
        }

        private HtmlCheckBox dental_InGoodHealth;
        public HtmlCheckBox Dental_InGoodHealth
        {
            get
            {
                this.dental_InGoodHealth = new HtmlCheckBox(this);
                //this.dental_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl36_E_Benefit_InGoodHealth";
                this.dental_InGoodHealth.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Benefit_InGoodHealth", PropertyExpressionOperator.Contains);
                return this.dental_InGoodHealth;
            }
        }

        private HtmlCheckBox dental_OptOut;
        public HtmlCheckBox Dental_OptOut
        {
            get
            {
                this.dental_OptOut = new HtmlCheckBox(this);
                //this.dental_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl36_E_Benefit_OptOut";
                this.dental_OptOut.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Benefit_OptOut", PropertyExpressionOperator.Contains);
                return this.dental_OptOut;
            }
        }

        private HtmlEdit dental_PayEntityCode;
        public HtmlEdit Dental_PayEntityCode
        {
            get
            {
                this.dental_PayEntityCode = new HtmlEdit(this);
                //this.dental_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_PayEntityCode";
                this.dental_PayEntityCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_PayEntityCode", PropertyExpressionOperator.Contains);
                return this.dental_PayEntityCode;
            }
        }

        private HtmlEdit dental_BenefitEndDate;
        public HtmlEdit Dental_BenefitEndDate
        {
            get
            {
                this.dental_BenefitEndDate = new HtmlEdit(this);
                //this.dental_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_BenefitEndDate";
                this.dental_BenefitEndDate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitEndDate", PropertyExpressionOperator.Contains);
                return this.dental_BenefitEndDate;
            }
        }

        private HtmlCheckBox dental_Inactive;
        public HtmlCheckBox Dental_Inactive
        {
            get
            {
                this.dental_Inactive = new HtmlCheckBox(this);
                //this.dental_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl36_E_Benefit_Inactive";
                this.dental_Inactive.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Benefit_Inactive", PropertyExpressionOperator.Contains);
                return this.dental_Inactive;
            }
        }

        private HtmlEdit dental_DeductionCode;
        public HtmlEdit Dental_DeductionCode
        {
            get
            {
                this.dental_DeductionCode = new HtmlEdit(this);
                //this.dental_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_DeductionCode";
                this.dental_DeductionCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_DeductionCode", PropertyExpressionOperator.Contains);
                return this.dental_DeductionCode;
            }
        }

        private HtmlEdit dental_BenefitProcessingStatusCode;
        public HtmlEdit Dental_BenefitProcessingStatusCode
        {
            get
            {
                this.dental_BenefitProcessingStatusCode = new HtmlEdit(this);
                //this.dental_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl36_E_Benefit_BenefitProcessingStatusCode";
                this.dental_BenefitProcessingStatusCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Benefit_BenefitProcessingStatusCode", PropertyExpressionOperator.Contains);
                return this.dental_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit dental_Recipient;
        public HtmlEdit Dental_Recipient
        {
            get
            {
                this.dental_Recipient = new HtmlEdit(this);
                //this.dental_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl36$ctl09";
                this.dental_Recipient.SearchProperties.Add(HtmlEdit.PropertyNames.Name, "ctl09", PropertyExpressionOperator.Contains);
                return this.dental_Recipient;
            }
        }

        private HtmlEdit dental_Name;
        public HtmlEdit Dental_Name
        {
            get
            {
                this.dental_Name = new HtmlEdit(this);
                //this.dental_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl36$ctl10";
                this.dental_Name.SearchProperties.Add(HtmlEdit.PropertyNames.Name, "ctl10", PropertyExpressionOperator.Contains);
                return this.dental_Name;
            }
        }

        private HtmlControl dental_Add;
        public HtmlControl Dental_Add
        {
            get
            {
                this.dental_Add = new HtmlControl(this);
                //this.dental_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl36$BenefitCoverageExtensionAdd";
                //this.dental_Add.SearchProperties.Add(HtmlControl.PropertyNames.Id, "_BenefitCoverageExtensionAdd", PropertyExpressionOperator.Contains);
                this.dental_Add.SearchProperties[HtmlControl.PropertyNames.ValueAttribute]="Add";
                return this.dental_Add;
            }
        }

        private HtmlSpan dental_NotificationMessage;
        public HtmlSpan Dental_NotificationMessage
        {
            get
            {
                this.dental_NotificationMessage = new HtmlSpan(this);
                //this.dental_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl36_Benefitdental_NotificationMessage";
                this.dental_NotificationMessage.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_Benefitdental_NotificationMessage", PropertyExpressionOperator.Contains);
                return this.dental_NotificationMessage;
            }
        }

        //=============================================== Dependent Life ===========================================================
        private HtmlEdit dependentLife_BenefitPlanCode;
        public HtmlEdit DependentLife_BenefitPlanCode
        {
            get
            {
                this.dependentLife_BenefitPlanCode = new HtmlEdit(this);
                this.dependentLife_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_BenefitPlanCode_Input";
                return this.dependentLife_BenefitPlanCode;
            }
        }

        private HtmlEdit dependentLife_BenefitLevelCode;
        public HtmlEdit DependentLife_BenefitLevelCode
        {
            get
            {
                this.dependentLife_BenefitLevelCode = new HtmlEdit(this);
                this.dependentLife_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_BenefitLevelCode_Input";
                return this.dependentLife_BenefitLevelCode;
            }
        }

        private HtmlEdit dependentLife_CoverageAmount;
        public HtmlEdit DependentLife_CoverageAmount
        {
            get
            {
                this.dependentLife_CoverageAmount = new HtmlEdit(this);
                this.dependentLife_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_CoverageAmount";
                return this.dependentLife_CoverageAmount;
            }
        }

        private HtmlEdit dependentLife_PayPeriodPremium;
        public HtmlEdit DependentLife_PayPeriodPremium
        {
            get
            {
                this.dependentLife_PayPeriodPremium = new HtmlEdit(this);
                this.dependentLife_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_PayPeriodPremium";
                return this.dependentLife_PayPeriodPremium;
            }
        }

        private HtmlEdit dependentLife_MonthlyPremium;
        public HtmlEdit DependentLife_MonthlyPremium
        {
            get
            {
                this.dependentLife_MonthlyPremium = new HtmlEdit(this);
                this.dependentLife_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_MonthlyPremium";
                return this.dependentLife_MonthlyPremium;
            }
        }

        private HtmlEdit dependentLife_EmployeeCost;
        public HtmlEdit DependentLife_EmployeeCost
        {
            get
            {
                this.dependentLife_EmployeeCost = new HtmlEdit(this);
                this.dependentLife_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_EmployeeCost";
                return this.dependentLife_EmployeeCost;
            }
        }

        private HtmlEdit dependentLife_EmployerCost;
        public HtmlEdit DependentLife_EmployerCost
        {
            get
            {
                this.dependentLife_EmployerCost = new HtmlEdit(this);
                this.dependentLife_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_EmployerCost";
                return this.dependentLife_EmployerCost;
            }
        }

        private HtmlEdit dependentLife_TotalCost;
        public HtmlEdit DependentLife_TotalCost
        {
            get
            {
                this.dependentLife_TotalCost = new HtmlEdit(this);
                this.dependentLife_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_TotalCost";
                return this.dependentLife_TotalCost;
            }
        }

        private HtmlEdit dependentLife_ElectedCoverageAmount;
        public HtmlEdit DependentLife_ElectedCoverageAmount
        {
            get
            {
                this.dependentLife_ElectedCoverageAmount = new HtmlEdit(this);
                this.dependentLife_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_ElectedCoverageAmount";
                return this.dependentLife_ElectedCoverageAmount;
            }
        }

        private HtmlEdit dependentLife_EnrollmentDate;
        public HtmlEdit DependentLife_EnrollmentDate
        {
            get
            {
                this.dependentLife_EnrollmentDate = new HtmlEdit(this);
                this.dependentLife_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_EnrollmentDate";
                return this.dependentLife_EnrollmentDate;
            }
        }

        private HtmlEdit dependentLife_EligibilityOverrideDate;
        public HtmlEdit DependentLife_EligibilityOverrideDate
        {
            get
            {
                this.dependentLife_EligibilityOverrideDate = new HtmlEdit(this);
                this.dependentLife_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_EligibilityOverrideDate";
                return this.dependentLife_EligibilityOverrideDate;
            }
        }

        private HtmlEdit dependentLife_EligibleDate;
        public HtmlEdit DependentLife_EligibleDate
        {
            get
            {
                this.dependentLife_EligibleDate = new HtmlEdit(this);
                this.dependentLife_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_EligibleDate";
                return this.dependentLife_EligibleDate;
            }
        }

        private HtmlCheckBox dependentLife_InGoodHealth;
        public HtmlCheckBox DependentLife_InGoodHealth
        {
            get
            {
                this.dependentLife_InGoodHealth = new HtmlCheckBox(this);
                this.dependentLife_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl56_E_Benefit_InGoodHealth";
                return this.dependentLife_InGoodHealth;
            }
        }

        private HtmlCheckBox dependentLife_OptOut;
        public HtmlCheckBox DependentLife_OptOut
        {
            get
            {
                this.dependentLife_OptOut = new HtmlCheckBox(this);
                this.dependentLife_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl56_E_Benefit_OptOut";
                return this.dependentLife_OptOut;
            }
        }

        private HtmlEdit dependentLife_PayEntityCode;
        public HtmlEdit DependentLife_PayEntityCode
        {
            get
            {
                this.dependentLife_PayEntityCode = new HtmlEdit(this);
                this.dependentLife_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_PayEntityCode";
                return this.dependentLife_PayEntityCode;
            }
        }

        private HtmlEdit dependentLife_BenefitEndDate;
        public HtmlEdit DependentLife_BenefitEndDate
        {
            get
            {
                this.dependentLife_BenefitEndDate = new HtmlEdit(this);
                this.dependentLife_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_BenefitEndDate";
                return this.dependentLife_BenefitEndDate;
            }
        }

        private HtmlCheckBox dependentLife_Inactive;
        public HtmlCheckBox DependentLife_Inactive
        {
            get
            {
                this.dependentLife_Inactive = new HtmlCheckBox(this);
                this.dependentLife_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl56_E_Benefit_Inactive";
                return this.dependentLife_Inactive;
            }
        }

        private HtmlEdit dependentLife_DeductionCode;
        public HtmlEdit DependentLife_DeductionCode
        {
            get
            {
                this.dependentLife_DeductionCode = new HtmlEdit(this);
                this.dependentLife_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_DeductionCode";
                return this.dependentLife_DeductionCode;
            }
        }

        private HtmlEdit dependentLife_BenefitProcessingStatusCode;
        public HtmlEdit DependentLife_BenefitProcessingStatusCode
        {
            get
            {
                this.dependentLife_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.dependentLife_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl56_E_Benefit_BenefitProcessingStatusCode";
                return this.dependentLife_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit dependentLife_Recipient;
        public HtmlEdit DependentLife_Recipient
        {
            get
            {
                this.dependentLife_Recipient = new HtmlEdit(this);
                this.dependentLife_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl56$ctl09";
                return this.dependentLife_Recipient;
            }
        }

        private HtmlEdit dependentLife_Name;
        public HtmlEdit DependentLife_Name
        {
            get
            {
                this.dependentLife_Name = new HtmlEdit(this);
                this.dependentLife_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl56$ctl10";
                return this.dependentLife_Name;
            }
        }

        private HtmlControl dependentLife_Add;
        public HtmlControl DependentLife_Add
        {
            get
            {
                this.dependentLife_Add = new HtmlControl(this);
                this.dependentLife_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl56_BenefitCoverageExtensionAdd";
                return this.dependentLife_Add;
            }
        }

        private HtmlSpan dependentLife_NotificationMessage;
        public HtmlSpan DependentLife_NotificationMessage
        {
            get
            {
                this.dependentLife_NotificationMessage = new HtmlSpan(this);
                this.dependentLife_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl56_BenefitLifeNotificationMessage";
                return this.dependentLife_NotificationMessage;
            }
        }

        //============================================= FSA Dependent Care =========================================================
        private HtmlEdit fsaDependentCare_BenefitPlanCode;
        public HtmlEdit FsaDependentCare_BenefitPlanCode
        {
            get
            {
                this.fsaDependentCare_BenefitPlanCode = new HtmlEdit(this);
                this.fsaDependentCare_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_BenefitPlanCode_Input";
                return this.fsaDependentCare_BenefitPlanCode;
            }
        }

        private HtmlEdit fsaDependentCare_BenefitLevelCode;
        public HtmlEdit FsaDependentCare_BenefitLevelCode
        {
            get
            {
                this.fsaDependentCare_BenefitLevelCode = new HtmlEdit(this);
                this.fsaDependentCare_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_BenefitLevelCode_Input";
                return this.fsaDependentCare_BenefitLevelCode;
            }
        }

        private HtmlEdit fsaDependentCare_CoverageAmount;
        public HtmlEdit FsaDependentCare_CoverageAmount
        {
            get
            {
                this.fsaDependentCare_CoverageAmount = new HtmlEdit(this);
                this.fsaDependentCare_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_CoverageAmount";
                return this.fsaDependentCare_CoverageAmount;
            }
        }

        private HtmlEdit fsaDependentCare_PayPeriodPremium;
        public HtmlEdit FsaDependentCare_PayPeriodPremium
        {
            get
            {
                this.fsaDependentCare_PayPeriodPremium = new HtmlEdit(this);
                this.fsaDependentCare_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_PayPeriodPremium";
                return this.fsaDependentCare_PayPeriodPremium;
            }
        }

        private HtmlEdit fsaDependentCare_MonthlyPremium;
        public HtmlEdit FsaDependentCare_MonthlyPremium
        {
            get
            {
                this.fsaDependentCare_MonthlyPremium = new HtmlEdit(this);
                this.fsaDependentCare_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_MonthlyPremium";
                return this.fsaDependentCare_MonthlyPremium;
            }
        }

        private HtmlEdit fsaDependentCare_EmployeeCost;
        public HtmlEdit FsaDependentCare_EmployeeCost
        {
            get
            {
                this.fsaDependentCare_EmployeeCost = new HtmlEdit(this);
                this.fsaDependentCare_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_EmployeeCost";
                return this.fsaDependentCare_EmployeeCost;
            }
        }

        private HtmlEdit fsaDependentCare_EmployerCost;
        public HtmlEdit FsaDependentCare_EmployerCost
        {
            get
            {
                this.fsaDependentCare_EmployerCost = new HtmlEdit(this);
                this.fsaDependentCare_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_EmployerCost";
                return this.fsaDependentCare_EmployerCost;
            }
        }

        private HtmlEdit fsaDependentCare_TotalCost;
        public HtmlEdit FsaDependentCare_TotalCost
        {
            get
            {
                this.fsaDependentCare_TotalCost = new HtmlEdit(this);
                this.fsaDependentCare_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_TotalCost";
                return this.fsaDependentCare_TotalCost;
            }
        }

        private HtmlEdit fsaDependentCare_ElectedCoverageAmount;
        public HtmlEdit FsaDependentCare_ElectedCoverageAmount
        {
            get
            {
                this.fsaDependentCare_ElectedCoverageAmount = new HtmlEdit(this);
                this.fsaDependentCare_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_ElectedCoverageAmount";
                return this.fsaDependentCare_ElectedCoverageAmount;
            }
        }

        private HtmlEdit fsaDependentCare_EnrollmentDate;
        public HtmlEdit FsaDependentCare_EnrollmentDate
        {
            get
            {
                this.fsaDependentCare_EnrollmentDate = new HtmlEdit(this);
                this.fsaDependentCare_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_EnrollmentDate";
                return this.fsaDependentCare_EnrollmentDate;
            }
        }

        private HtmlEdit fsaDependentCare_EligibilityOverrideDate;
        public HtmlEdit FsaDependentCare_EligibilityOverrideDate
        {
            get
            {
                this.fsaDependentCare_EligibilityOverrideDate = new HtmlEdit(this);
                this.fsaDependentCare_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_EligibilityOverrideDate";
                return this.fsaDependentCare_EligibilityOverrideDate;
            }
        }

        private HtmlEdit fsaDependentCare_EligibleDate;
        public HtmlEdit FsaDependentCare_EligibleDate
        {
            get
            {
                this.fsaDependentCare_EligibleDate = new HtmlEdit(this);
                this.fsaDependentCare_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_EligibleDate";
                return this.fsaDependentCare_EligibleDate;
            }
        }

        private HtmlCheckBox fsaDependentCare_InGoodHealth;
        public HtmlCheckBox FsaDependentCare_InGoodHealth
        {
            get
            {
                this.fsaDependentCare_InGoodHealth = new HtmlCheckBox(this);
                this.fsaDependentCare_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl64_E_Benefit_InGoodHealth";
                return this.fsaDependentCare_InGoodHealth;
            }
        }

        private HtmlCheckBox fsaDependentCare_OptOut;
        public HtmlCheckBox FsaDependentCare_OptOut
        {
            get
            {
                this.fsaDependentCare_OptOut = new HtmlCheckBox(this);
                this.fsaDependentCare_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl64_E_Benefit_OptOut";
                return this.fsaDependentCare_OptOut;
            }
        }

        private HtmlEdit fsaDependentCare_PayEntityCode;
        public HtmlEdit FsaDependentCare_PayEntityCode
        {
            get
            {
                this.fsaDependentCare_PayEntityCode = new HtmlEdit(this);
                this.fsaDependentCare_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_PayEntityCode";
                return this.fsaDependentCare_PayEntityCode;
            }
        }

        private HtmlEdit fsaDependentCare_BenefitEndDate;
        public HtmlEdit FsaDependentCare_BenefitEndDate
        {
            get
            {
                this.fsaDependentCare_BenefitEndDate = new HtmlEdit(this);
                this.fsaDependentCare_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_BenefitEndDate";
                return this.fsaDependentCare_BenefitEndDate;
            }
        }

        private HtmlCheckBox fsaDependentCare_Inactive;
        public HtmlCheckBox FsaDependentCare_Inactive
        {
            get
            {
                this.fsaDependentCare_Inactive = new HtmlCheckBox(this);
                this.fsaDependentCare_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl64_E_Benefit_Inactive";
                return this.fsaDependentCare_Inactive;
            }
        }

        private HtmlEdit fsaDependentCare_DeductionCode;
        public HtmlEdit FsaDependentCare_DeductionCode
        {
            get
            {
                this.fsaDependentCare_DeductionCode = new HtmlEdit(this);
                this.fsaDependentCare_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_DeductionCode";
                return this.fsaDependentCare_DeductionCode;
            }
        }

        private HtmlEdit fsaDependentCare_BenefitProcessingStatusCode;
        public HtmlEdit FsaDependentCare_BenefitProcessingStatusCode
        {
            get
            {
                this.fsaDependentCare_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.fsaDependentCare_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl64_E_Benefit_BenefitProcessingStatusCode";
                return this.fsaDependentCare_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit fsaDependentCare_Recipient;
        public HtmlEdit FsaDependentCare_Recipient
        {
            get
            {
                this.fsaDependentCare_Recipient = new HtmlEdit(this);
                this.fsaDependentCare_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl64$ctl09";
                return this.fsaDependentCare_Recipient;
            }
        }

        private HtmlEdit fsaDependentCare_Name;
        public HtmlEdit FsaDependentCare_Name
        {
            get
            {
                this.fsaDependentCare_Name = new HtmlEdit(this);
                this.fsaDependentCare_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl64$ctl10";
                return this.fsaDependentCare_Name;
            }
        }

        private HtmlControl fsaDependentCare_Add;
        public HtmlControl FsaDependentCare_Add
        {
            get
            {
                this.fsaDependentCare_Add = new HtmlControl(this);
                this.fsaDependentCare_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl64_BenefitCoverageExtensionAdd";
                return this.fsaDependentCare_Add;
            }
        }

        private HtmlSpan fsaDependentCare_NotificationMessage;
        public HtmlSpan FsaDependentCare_NotificationMessage
        {
            get
            {
                this.fsaDependentCare_NotificationMessage = new HtmlSpan(this);
                this.fsaDependentCare_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl64_BenefitFSA_Dependent_CareNotificationMessage";
                return this.fsaDependentCare_NotificationMessage;
            }
        }

        //================================================ FSA Medical =============================================================
        private HtmlEdit fsaMedical_BenefitPlanCode;
        public HtmlEdit FsaMedical_BenefitPlanCode
        {
            get
            {
                this.fsaMedical_BenefitPlanCode = new HtmlEdit(this);
                this.fsaMedical_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_BenefitPlanCode_Input";
                return this.fsaMedical_BenefitPlanCode;
            }
        }

        private HtmlEdit fsaMedical_BenefitLevelCode;
        public HtmlEdit FsaMedical_BenefitLevelCode
        {
            get
            {
                this.fsaMedical_BenefitLevelCode = new HtmlEdit(this);
                this.fsaMedical_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_BenefitLevelCode_Input";
                return this.fsaMedical_BenefitLevelCode;
            }
        }

        private HtmlEdit fsaMedical_CoverageAmount;
        public HtmlEdit FsaMedical_CoverageAmount
        {
            get
            {
                this.fsaMedical_CoverageAmount = new HtmlEdit(this);
                this.fsaMedical_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_CoverageAmount";
                return this.fsaMedical_CoverageAmount;
            }
        }

        private HtmlEdit fsaMedical_PayPeriodPremium;
        public HtmlEdit FsaMedical_PayPeriodPremium
        {
            get
            {
                this.fsaMedical_PayPeriodPremium = new HtmlEdit(this);
                this.fsaMedical_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_PayPeriodPremium";
                return this.fsaMedical_PayPeriodPremium;
            }
        }

        private HtmlEdit fsaMedical_MonthlyPremium;
        public HtmlEdit FsaMedical_MonthlyPremium
        {
            get
            {
                this.fsaMedical_MonthlyPremium = new HtmlEdit(this);
                this.fsaMedical_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_MonthlyPremium";
                return this.fsaMedical_MonthlyPremium;
            }
        }

        private HtmlEdit fsaMedical_EmployeeCost;
        public HtmlEdit FsaMedical_EmployeeCost
        {
            get
            {
                this.fsaMedical_EmployeeCost = new HtmlEdit(this);
                this.fsaMedical_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_EmployeeCost";
                return this.fsaMedical_EmployeeCost;
            }
        }

        private HtmlEdit fsaMedical_EmployerCost;
        public HtmlEdit FsaMedical_EmployerCost
        {
            get
            {
                this.fsaMedical_EmployerCost = new HtmlEdit(this);
                this.fsaMedical_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_EmployerCost";
                return this.fsaMedical_EmployerCost;
            }
        }

        private HtmlEdit fsaMedical_TotalCost;
        public HtmlEdit FsaMedical_TotalCost
        {
            get
            {
                this.fsaMedical_TotalCost = new HtmlEdit(this);
                this.fsaMedical_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_TotalCost";
                return this.fsaMedical_TotalCost;
            }
        }

        private HtmlEdit fsaMedical_ElectedCoverageAmount;
        public HtmlEdit FsaMedical_ElectedCoverageAmount
        {
            get
            {
                this.fsaMedical_ElectedCoverageAmount = new HtmlEdit(this);
                this.fsaMedical_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_ElectedCoverageAmount";
                return this.fsaMedical_ElectedCoverageAmount;
            }
        }

        private HtmlEdit fsaMedical_EnrollmentDate;
        public HtmlEdit FsaMedical_EnrollmentDate
        {
            get
            {
                this.fsaMedical_EnrollmentDate = new HtmlEdit(this);
                this.fsaMedical_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_EnrollmentDate";
                return this.fsaMedical_EnrollmentDate;
            }
        }

        private HtmlEdit fsaMedical_EligibilityOverrideDate;
        public HtmlEdit FsaMedical_EligibilityOverrideDate
        {
            get
            {
                this.fsaMedical_EligibilityOverrideDate = new HtmlEdit(this);
                this.fsaMedical_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_EligibilityOverrideDate";
                return this.fsaMedical_EligibilityOverrideDate;
            }
        }

        private HtmlEdit fsaMedical_EligibleDate;
        public HtmlEdit FsaMedical_EligibleDate
        {
            get
            {
                this.fsaMedical_EligibleDate = new HtmlEdit(this);
                this.fsaMedical_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_EligibleDate";
                return this.fsaMedical_EligibleDate;
            }
        }

        private HtmlCheckBox fsaMedical_InGoodHealth;
        public HtmlCheckBox FsaMedical_InGoodHealth
        {
            get
            {
                this.fsaMedical_InGoodHealth = new HtmlCheckBox(this);
                this.fsaMedical_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl60_E_Benefit_InGoodHealth";
                return this.fsaMedical_InGoodHealth;
            }
        }

        private HtmlCheckBox fsaMedical_OptOut;
        public HtmlCheckBox FsaMedical_OptOut
        {
            get
            {
                this.fsaMedical_OptOut = new HtmlCheckBox(this);
                this.fsaMedical_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl60_E_Benefit_OptOut";
                return this.fsaMedical_OptOut;
            }
        }

        private HtmlEdit fsaMedical_PayEntityCode;
        public HtmlEdit FsaMedical_PayEntityCode
        {
            get
            {
                this.fsaMedical_PayEntityCode = new HtmlEdit(this);
                this.fsaMedical_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_PayEntityCode";
                return this.fsaMedical_PayEntityCode;
            }
        }

        private HtmlEdit fsaMedical_BenefitEndDate;
        public HtmlEdit FsaMedical_BenefitEndDate
        {
            get
            {
                this.fsaMedical_BenefitEndDate = new HtmlEdit(this);
                this.fsaMedical_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_BenefitEndDate";
                return this.fsaMedical_BenefitEndDate;
            }
        }

        private HtmlCheckBox fsaMedical_Inactive;
        public HtmlCheckBox FsaMedical_Inactive
        {
            get
            {
                this.fsaMedical_Inactive = new HtmlCheckBox(this);
                this.fsaMedical_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl60_E_Benefit_Inactive";
                return this.fsaMedical_Inactive;
            }
        }

        private HtmlEdit fsaMedical_DeductionCode;
        public HtmlEdit FsaMedical_DeductionCode
        {
            get
            {
                this.fsaMedical_DeductionCode = new HtmlEdit(this);
                this.fsaMedical_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_DeductionCode";
                return this.fsaMedical_DeductionCode;
            }
        }

        private HtmlEdit fsaMedical_BenefitProcessingStatusCode;
        public HtmlEdit FsaMedical_BenefitProcessingStatusCode
        {
            get
            {
                this.fsaMedical_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.fsaMedical_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl60_E_Benefit_BenefitProcessingStatusCode";
                return this.fsaMedical_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit fsaMedical_Recipient;
        public HtmlEdit FsaMedical_Recipient
        {
            get
            {
                this.fsaMedical_Recipient = new HtmlEdit(this);
                this.fsaMedical_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl60$ctl09";
                return this.fsaMedical_Recipient;
            }
        }

        private HtmlEdit fsaMedical_Name;
        public HtmlEdit FsaMedical_Name
        {
            get
            {
                this.fsaMedical_Name = new HtmlEdit(this);
                this.fsaMedical_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl60$ctl10";
                return this.fsaMedical_Name;
            }
        }

        private HtmlControl fsaMedical_Add;
        public HtmlControl FsaMedical_Add
        {
            get
            {
                this.fsaMedical_Add = new HtmlControl(this);
                this.fsaMedical_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl60_BenefitCoverageExtensionAdd";
                return this.fsaMedical_Add;
            }
        }

        private HtmlSpan fsaMedical_NotificationMessage;
        public HtmlSpan FsaMedical_NotificationMessage
        {
            get
            {
                this.fsaMedical_NotificationMessage = new HtmlSpan(this);
                this.fsaMedical_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl60_BenefitFSA_medical_NotificationMessage";
                return this.fsaMedical_NotificationMessage;
            }
        }

        //==================================================== Life ================================================================
        private HtmlEdit life_BenefitPlanCode;
        public HtmlEdit Life_BenefitPlanCode
        {
            get
            {
                this.life_BenefitPlanCode = new HtmlEdit(this);
                this.life_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_BenefitPlanCode_Input";
                return this.life_BenefitPlanCode;
            }
        }

        private HtmlEdit life_BenefitLevelCode;
        public HtmlEdit Life_BenefitLevelCode
        {
            get
            {
                this.life_BenefitLevelCode = new HtmlEdit(this);
                this.life_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_BenefitLevelCode_Input";
                return this.life_BenefitLevelCode;
            }
        }

        private HtmlEdit life_CoverageAmount;
        public HtmlEdit Life_CoverageAmount
        {
            get
            {
                this.life_CoverageAmount = new HtmlEdit(this);
                this.life_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_CoverageAmount";
                return this.life_CoverageAmount;
            }
        }

        private HtmlEdit life_PayPeriodPremium;
        public HtmlEdit Life_PayPeriodPremium
        {
            get
            {
                this.life_PayPeriodPremium = new HtmlEdit(this);
                this.life_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_PayPeriodPremium";
                return this.life_PayPeriodPremium;
            }
        }

        private HtmlEdit life_MonthlyPremium;
        public HtmlEdit Life_MonthlyPremium
        {
            get
            {
                this.life_MonthlyPremium = new HtmlEdit(this);
                this.life_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_MonthlyPremium";
                return this.life_MonthlyPremium;
            }
        }

        private HtmlEdit life_EmployeeCost;
        public HtmlEdit Life_EmployeeCost
        {
            get
            {
                this.life_EmployeeCost = new HtmlEdit(this);
                this.life_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_EmployeeCost";
                return this.life_EmployeeCost;
            }
        }

        private HtmlEdit life_EmployerCost;
        public HtmlEdit Life_EmployerCost
        {
            get
            {
                this.life_EmployerCost = new HtmlEdit(this);
                this.life_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_EmployerCost";
                return this.life_EmployerCost;
            }
        }

        private HtmlEdit life_TotalCost;
        public HtmlEdit Life_TotalCost
        {
            get
            {
                this.life_TotalCost = new HtmlEdit(this);
                this.life_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_TotalCost";
                return this.life_TotalCost;
            }
        }

        private HtmlEdit life_ElectedCoverageAmount;
        public HtmlEdit Life_ElectedCoverageAmount
        {
            get
            {
                this.life_ElectedCoverageAmount = new HtmlEdit(this);
                this.life_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_ElectedCoverageAmount";
                return this.life_ElectedCoverageAmount;
            }
        }

        private HtmlEdit life_EnrollmentDate;
        public HtmlEdit Life_EnrollmentDate
        {
            get
            {
                this.life_EnrollmentDate = new HtmlEdit(this);
                this.life_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_EnrollmentDate";
                return this.life_EnrollmentDate;
            }
        }

        private HtmlEdit life_EligibilityOverrideDate;
        public HtmlEdit Life_EligibilityOverrideDate
        {
            get
            {
                this.life_EligibilityOverrideDate = new HtmlEdit(this);
                this.life_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_EligibilityOverrideDate";
                return this.life_EligibilityOverrideDate;
            }
        }

        private HtmlEdit life_EligibleDate;
        public HtmlEdit Life_EligibleDate
        {
            get
            {
                this.life_EligibleDate = new HtmlEdit(this);
                this.life_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_EligibleDate";
                return this.life_EligibleDate;
            }
        }

        private HtmlCheckBox life_InGoodHealth;
        public HtmlCheckBox Life_InGoodHealth
        {
            get
            {
                this.life_InGoodHealth = new HtmlCheckBox(this);
                this.life_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl44_E_Benefit_InGoodHealth";
                return this.life_InGoodHealth;
            }
        }

        private HtmlCheckBox life_OptOut;
        public HtmlCheckBox Life_OptOut
        {
            get
            {
                this.life_OptOut = new HtmlCheckBox(this);
                this.life_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl44_E_Benefit_OptOut";
                return this.life_OptOut;
            }
        }


        private HtmlEdit life_PayEntityCode;
        public HtmlEdit Life_PayEntityCode
        {
            get
            {
                this.life_PayEntityCode = new HtmlEdit(this);
                this.life_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_PayEntityCode";
                return this.life_PayEntityCode;
            }
        }

        private HtmlEdit life_BenefitEndDate;
        public HtmlEdit Life_BenefitEndDate
        {
            get
            {
                this.life_BenefitEndDate = new HtmlEdit(this);
                this.life_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_BenefitEndDate";
                return this.life_BenefitEndDate;
            }
        }

        private HtmlCheckBox life_Inactive;
        public HtmlCheckBox Life_Inactive
        {
            get
            {
                this.life_Inactive = new HtmlCheckBox(this);
                this.life_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl44_E_Benefit_Inactive";
                return this.life_Inactive;
            }
        }

        private HtmlEdit life_DeductionCode;
        public HtmlEdit Life_DeductionCode
        {
            get
            {
                this.life_DeductionCode = new HtmlEdit(this);
                this.life_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_DeductionCode";
                return this.life_DeductionCode;
            }
        }

        private HtmlEdit life_BenefitProcessingStatusCode;
        public HtmlEdit Life_BenefitProcessingStatusCode
        {
            get
            {
                this.life_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.life_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl44_E_Benefit_BenefitProcessingStatusCode";
                return this.life_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit life_Recipient;
        public HtmlEdit Life_Recipient
        {
            get
            {
                this.life_Recipient = new HtmlEdit(this);
                this.life_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl44$ctl09";
                return this.life_Recipient;
            }
        }

        private HtmlEdit life_Name;
        public HtmlEdit Life_Name
        {
            get
            {
                this.life_Name = new HtmlEdit(this);
                this.life_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl44$ctl10";
                return this.life_Name;
            }
        }

        private HtmlControl life_Add;
        public HtmlControl Life_Add
        {
            get
            {
                this.life_Add = new HtmlControl(this);
                this.life_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl44_BenefitCoverageExtensionAdd";
                return this.life_Add;
            }
        }

        private HtmlSpan life_NotificationMessage;
        public HtmlSpan Life_NotificationMessage
        {
            get
            {
                this.life_NotificationMessage = new HtmlSpan(this);
                this.life_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl44_BenefitLifeNotificationMessage";
                return this.life_NotificationMessage;
            }
        }

        //=========================================== Long Term Disability =========================================================

        private HtmlEdit longTermDisability_BenefitPlanCode;
        public HtmlEdit LongTermDisability_BenefitPlanCode
        {
            get
            {
                this.longTermDisability_BenefitPlanCode = new HtmlEdit(this);
                this.longTermDisability_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_BenefitPlanCode_Input";
                return this.longTermDisability_BenefitPlanCode;
            }
        }

        private HtmlEdit longTermDisability_BenefitLevelCode;
        public HtmlEdit LongTermDisability_BenefitLevelCode
        {
            get
            {
                this.longTermDisability_BenefitLevelCode = new HtmlEdit(this);
                this.longTermDisability_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_BenefitLevelCode_Input";
                return this.longTermDisability_BenefitLevelCode;
            }
        }

        private HtmlEdit longTermDisability_CoverageAmount;
        public HtmlEdit LongTermDisability_CoverageAmount
        {
            get
            {
                this.longTermDisability_CoverageAmount = new HtmlEdit(this);
                this.longTermDisability_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_CoverageAmount";
                return this.longTermDisability_CoverageAmount;
            }
        }

        private HtmlEdit longTermDisability_PayPeriodPremium;
        public HtmlEdit LongTermDisability_PayPeriodPremium
        {
            get
            {
                this.longTermDisability_PayPeriodPremium = new HtmlEdit(this);
                this.longTermDisability_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_PayPeriodPremium";
                return this.longTermDisability_PayPeriodPremium;
            }
        }

        private HtmlEdit longTermDisability_MonthlyPremium;
        public HtmlEdit LongTermDisability_MonthlyPremium
        {
            get
            {
                this.longTermDisability_MonthlyPremium = new HtmlEdit(this);
                this.longTermDisability_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_MonthlyPremium";
                return this.longTermDisability_MonthlyPremium;
            }
        }

        private HtmlEdit longTermDisability_EmployeeCost;
        public HtmlEdit LongTermDisability_EmployeeCost
        {
            get
            {
                this.longTermDisability_EmployeeCost = new HtmlEdit(this);
                this.longTermDisability_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_EmployeeCost";
                return this.longTermDisability_EmployeeCost;
            }
        }

        private HtmlEdit longTermDisability_EmployerCost;
        public HtmlEdit LongTermDisability_EmployerCost
        {
            get
            {
                this.longTermDisability_EmployerCost = new HtmlEdit(this);
                this.longTermDisability_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_EmployerCost";
                return this.longTermDisability_EmployerCost;
            }
        }

        private HtmlEdit longTermDisability_TotalCost;
        public HtmlEdit LongTermDisability_TotalCost
        {
            get
            {
                this.longTermDisability_TotalCost = new HtmlEdit(this);
                this.longTermDisability_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_TotalCost";
                return this.longTermDisability_TotalCost;
            }
        }

        private HtmlEdit longTermDisability_ElectedCoverageAmount;
        public HtmlEdit LongTermDisability_ElectedCoverageAmount
        {
            get
            {
                this.longTermDisability_ElectedCoverageAmount = new HtmlEdit(this);
                this.longTermDisability_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_ElectedCoverageAmount";
                return this.longTermDisability_ElectedCoverageAmount;
            }
        }

        private HtmlEdit longTermDisability_EnrollmentDate;
        public HtmlEdit LongTermDisability_EnrollmentDate
        {
            get
            {
                this.longTermDisability_EnrollmentDate = new HtmlEdit(this);
                this.longTermDisability_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_EnrollmentDate";
                return this.longTermDisability_EnrollmentDate;
            }
        }

        private HtmlEdit longTermDisability_EligibilityOverrideDate;
        public HtmlEdit LongTermDisability_EligibilityOverrideDate
        {
            get
            {
                this.longTermDisability_EligibilityOverrideDate = new HtmlEdit(this);
                this.longTermDisability_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_EligibilityOverrideDate";
                return this.longTermDisability_EligibilityOverrideDate;
            }
        }

        private HtmlEdit longTermDisability_EligibleDate;
        public HtmlEdit LongTermDisability_EligibleDate
        {
            get
            {
                this.longTermDisability_EligibleDate = new HtmlEdit(this);
                this.longTermDisability_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_EligibleDate";
                return this.longTermDisability_EligibleDate;
            }
        }

        private HtmlCheckBox longTermDisability_InGoodHealth;
        public HtmlCheckBox LongTermDisability_InGoodHealth
        {
            get
            {
                this.longTermDisability_InGoodHealth = new HtmlCheckBox(this);
                this.longTermDisability_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl72_E_Benefit_InGoodHealth";
                return this.longTermDisability_InGoodHealth;
            }
        }

        private HtmlCheckBox longTermDisability_OptOut;
        public HtmlCheckBox LongTermDisability_OptOut
        {
            get
            {
                this.longTermDisability_OptOut = new HtmlCheckBox(this);
                this.longTermDisability_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl72_E_Benefit_OptOut";
                return this.longTermDisability_OptOut;
            }
        }

        private HtmlEdit longTermDisability_PayEntityCode;
        public HtmlEdit LongTermDisability_PayEntityCode
        {
            get
            {
                this.longTermDisability_PayEntityCode = new HtmlEdit(this);
                this.longTermDisability_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_PayEntityCode";
                return this.longTermDisability_PayEntityCode;
            }
        }

        private HtmlEdit longTermDisability_BenefitEndDate;
        public HtmlEdit LongTermDisability_BenefitEndDate
        {
            get
            {
                this.longTermDisability_BenefitEndDate = new HtmlEdit(this);
                this.longTermDisability_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_BenefitEndDate";
                return this.longTermDisability_BenefitEndDate;
            }
        }

        private HtmlCheckBox longTermDisability_Inactive;
        public HtmlCheckBox LongTermDisability_Inactive
        {
            get
            {
                this.longTermDisability_Inactive = new HtmlCheckBox(this);
                this.longTermDisability_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl72_E_Benefit_Inactive";
                return this.longTermDisability_Inactive;
            }
        }

        private HtmlEdit longTermDisability_DeductionCode;
        public HtmlEdit LongTermDisability_DeductionCode
        {
            get
            {
                this.longTermDisability_DeductionCode = new HtmlEdit(this);
                this.longTermDisability_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_DeductionCode";
                return this.longTermDisability_DeductionCode;
            }
        }

        private HtmlEdit longTermDisability_BenefitProcessingStatusCode;
        public HtmlEdit LongTermDisability_BenefitProcessingStatusCode
        {
            get
            {
                this.longTermDisability_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.longTermDisability_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl72_E_Benefit_BenefitProcessingStatusCode";
                return this.longTermDisability_BenefitProcessingStatusCode;
            }
        }

        private HtmlSpan longTermDisability_NotificationMessage;
        public HtmlSpan LongTermDisability_NotificationMessage
        {
            get
            {
                this.longTermDisability_NotificationMessage = new HtmlSpan(this);
                this.longTermDisability_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl72_BenefitLongTermCare_NotificationMessage";
                return this.longTermDisability_NotificationMessage;
            }
        }

        //================================================== Medical ===============================================================

        private HtmlEdit medical_BenefitPlanCode;
        public HtmlEdit Medical_BenefitPlanCode
        {
            get
            {
                this.medical_BenefitPlanCode = new HtmlEdit(this);
                this.medical_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_BenefitPlanCode_Input";
                return this.medical_BenefitPlanCode;
            }
        }

        private HtmlEdit medical_BenefitLevelCode;
        public HtmlEdit Medical_BenefitLevelCode
        {
            get
            {
                this.medical_BenefitLevelCode = new HtmlEdit(this);
                this.medical_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_BenefitLevelCode_Input";
                return this.medical_BenefitLevelCode;
            }
        }

        private HtmlEdit medical_PayPeriodPremium;
        public HtmlEdit Medical_PayPeriodPremium
        {
            get
            {
                this.medical_PayPeriodPremium = new HtmlEdit(this);
                this.medical_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_PayPeriodPremium";
                return this.medical_PayPeriodPremium;
            }
        }

        private HtmlEdit medical_MonthlyPremium;
        public HtmlEdit Medical_MonthlyPremium
        {
            get
            {
                this.medical_MonthlyPremium = new HtmlEdit(this);
                this.medical_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_MonthlyPremium";
                return this.medical_MonthlyPremium;
            }
        }

        private HtmlEdit medical_EmployeeCost;
        public HtmlEdit Medical_EmployeeCost
        {
            get
            {
                this.medical_EmployeeCost = new HtmlEdit(this);
                this.medical_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_EmployeeCost";
                return this.medical_EmployeeCost;
            }
        }

        private HtmlEdit medical_EmployerCost;
        public HtmlEdit Medical_EmployerCost
        {
            get
            {
                this.medical_EmployerCost = new HtmlEdit(this);
                this.medical_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_EmployerCost";
                return this.medical_EmployerCost;
            }
        }

        private HtmlEdit medical_TotalCost;
        public HtmlEdit Medical_TotalCost
        {
            get
            {
                this.medical_TotalCost = new HtmlEdit(this);
                this.medical_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_TotalCost";
                return this.medical_TotalCost;
            }
        }

        private HtmlEdit medical_COBRACost;
        public HtmlEdit Medical_COBRACost
        {
            get
            {
                this.medical_COBRACost = new HtmlEdit(this);
                this.medical_COBRACost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_COBRACost";
                return this.medical_COBRACost;
            }
        }

        private HtmlEdit medical_EnrollmentDate;
        public HtmlEdit Medical_EnrollmentDate
        {
            get
            {
                this.medical_EnrollmentDate = new HtmlEdit(this);
                this.medical_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_EnrollmentDate";
                return this.medical_EnrollmentDate;
            }
        }

        private HtmlEdit medical_EligibilityOverrideDate;
        public HtmlEdit Medical_EligibilityOverrideDate
        {
            get
            {
                this.medical_EligibilityOverrideDate = new HtmlEdit(this);
                this.medical_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_EligibilityOverrideDate";
                return this.medical_EligibilityOverrideDate;
            }
        }

        private HtmlEdit medical_EligibleDate;
        public HtmlEdit Medical_EligibleDate
        {
            get
            {
                this.medical_EligibleDate = new HtmlEdit(this);
                this.medical_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_EligibleDate";
                return this.medical_EligibleDate;
            }
        }

        private HtmlCheckBox medical_InGoodHealth;
        public HtmlCheckBox Medical_InGoodHealth
        {
            get
            {
                this.medical_InGoodHealth = new HtmlCheckBox(this);
                this.medical_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl32_E_Benefit_InGoodHealth";
                return this.medical_InGoodHealth;
            }
        }

        private HtmlCheckBox medical_OptOut;
        public HtmlCheckBox Medical_OptOut
        {
            get
            {
                this.medical_OptOut = new HtmlCheckBox(this);
                this.medical_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl32_E_Benefit_OptOut";
                return this.medical_OptOut;
            }
        }

        private HtmlCheckBox medical_IsIneligibleForWaivedEarnings;
        public HtmlCheckBox Medical_IsIneligibleForWaivedEarnings
        {
            get
            {
                this.medical_IsIneligibleForWaivedEarnings = new HtmlCheckBox(this);
                this.medical_IsIneligibleForWaivedEarnings.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl32_E_Benefit_IsIneligibleForWaivedEarnings";
                return this.medical_IsIneligibleForWaivedEarnings;
            }
        }

        private HtmlEdit medical_MonthlyOptOutAmount;
        public HtmlEdit Medical_MonthlyOptOutAmount
        {
            get
            {
                this.medical_MonthlyOptOutAmount = new HtmlEdit(this);
                this.medical_MonthlyOptOutAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_MonthlyOptOutAmount";
                return this.medical_MonthlyOptOutAmount;
            }
        }

        private HtmlEdit medical_PayPeriodOptOutAmount;
        public HtmlEdit Medical_PayPeriodOptOutAmount
        {
            get
            {
                this.medical_PayPeriodOptOutAmount = new HtmlEdit(this);
                this.medical_PayPeriodOptOutAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_PayPeriodOptOutAmount";
                return this.medical_PayPeriodOptOutAmount;
            }
        }

        private HtmlEdit medical_PayEntityCode;
        public HtmlEdit Medical_PayEntityCode
        {
            get
            {
                this.medical_PayEntityCode = new HtmlEdit(this);
                this.medical_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_PayEntityCode";
                return this.medical_PayEntityCode;
            }
        }

        private HtmlEdit medical_BenefitEndDate;
        public HtmlEdit Medical_BenefitEndDate
        {
            get
            {
                this.medical_BenefitEndDate = new HtmlEdit(this);
                this.medical_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_BenefitEndDate";
                return this.medical_BenefitEndDate;
            }
        }

        private HtmlCheckBox medical_Inactive;
        public HtmlCheckBox Medical_Inactive
        {
            get
            {
                this.medical_Inactive = new HtmlCheckBox(this);
                this.medical_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl32_E_Benefit_Inactive";
                return this.medical_Inactive;
            }
        }

        private HtmlEdit medical_DeductionCode;
        public HtmlEdit Medical_DeductionCode
        {
            get
            {
                this.medical_DeductionCode = new HtmlEdit(this);
                this.medical_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_DeductionCode";
                return this.medical_DeductionCode;
            }
        }

        private HtmlEdit medical_BenefitProcessingStatusCode;
        public HtmlEdit Medical_BenefitProcessingStatusCode
        {
            get
            {
                this.medical_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.medical_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl32_E_Benefit_BenefitProcessingStatusCode";
                return this.medical_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit medical_Recipient;
        public HtmlEdit Medical_Recipient
        {
            get
            {
                this.medical_Recipient = new HtmlEdit(this);
                this.medical_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl32$ctl09";
                return this.medical_Recipient;
            }
        }

        private HtmlEdit medical_Name;
        public HtmlEdit Medical_Name
        {
            get
            {
                this.medical_Name = new HtmlEdit(this);
                this.medical_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl32$ctl10";
                return this.medical_Name;
            }
        }

        private HtmlControl medical_Add;
        public HtmlControl Medical_Add
        {
            get
            {
                this.medical_Add = new HtmlControl(this);
                this.medical_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl32_BenefitCoverageExtensionAdd";
                return this.medical_Add;
            }
        }

        private HtmlSpan medical_NotificationMessage;
        public HtmlSpan Medical_NotificationMessage
        {
            get
            {
                this.medical_NotificationMessage = new HtmlSpan(this);
                this.medical_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl32_BenefitMedical_NotificationMessage";
                return this.medical_NotificationMessage;
            }
        }

        //=========================================== Short Term Disability ========================================================

        private HtmlEdit shortTermDisability_BenefitPlanCode;
        public HtmlEdit ShortTermDisability_BenefitPlanCode
        {
            get
            {
                this.shortTermDisability_BenefitPlanCode = new HtmlEdit(this);
                this.shortTermDisability_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_BenefitPlanCode_Input";
                return this.shortTermDisability_BenefitPlanCode;
            }
        }

        private HtmlEdit shortTermDisability_BenefitLevelCode;
        public HtmlEdit ShortTermDisability_BenefitLevelCode
        {
            get
            {
                this.shortTermDisability_BenefitLevelCode = new HtmlEdit(this);
                this.shortTermDisability_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_BenefitLevelCode_Input";
                return this.shortTermDisability_BenefitLevelCode;
            }
        }

        private HtmlEdit shortTermDisability_CoverageAmount;
        public HtmlEdit ShortTermDisability_CoverageAmount
        {
            get
            {
                this.shortTermDisability_CoverageAmount = new HtmlEdit(this);
                this.shortTermDisability_CoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_CoverageAmount";
                return this.shortTermDisability_CoverageAmount;
            }
        }

        private HtmlEdit shortTermDisability_PayPeriodPremium;
        public HtmlEdit ShortTermDisability_PayPeriodPremium
        {
            get
            {
                this.shortTermDisability_PayPeriodPremium = new HtmlEdit(this);
                this.shortTermDisability_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_PayPeriodPremium";
                return this.shortTermDisability_PayPeriodPremium;
            }
        }

        private HtmlEdit shortTermDisability_MonthlyPremium;
        public HtmlEdit ShortTermDisability_MonthlyPremium
        {
            get
            {
                this.shortTermDisability_MonthlyPremium = new HtmlEdit(this);
                this.shortTermDisability_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_MonthlyPremium";
                return this.shortTermDisability_MonthlyPremium;
            }
        }

        private HtmlEdit shortTermDisability_EmployeeCost;
        public HtmlEdit ShortTermDisability_EmployeeCost
        {
            get
            {
                this.shortTermDisability_EmployeeCost = new HtmlEdit(this);
                this.shortTermDisability_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_EmployeeCost";
                return this.shortTermDisability_EmployeeCost;
            }
        }

        private HtmlEdit shortTermDisability_EmployerCost;
        public HtmlEdit ShortTermDisability_EmployerCost
        {
            get
            {
                this.shortTermDisability_EmployerCost = new HtmlEdit(this);
                this.shortTermDisability_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_EmployerCost";
                return this.shortTermDisability_EmployerCost;
            }
        }

        private HtmlEdit shortTermDisability_TotalCost;
        public HtmlEdit ShortTermDisability_TotalCost
        {
            get
            {
                this.shortTermDisability_TotalCost = new HtmlEdit(this);
                this.shortTermDisability_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_TotalCost";
                return this.shortTermDisability_TotalCost;
            }
        }

        private HtmlEdit shortTermDisability_ElectedCoverageAmount;
        public HtmlEdit ShortTermDisability_ElectedCoverageAmount
        {
            get
            {
                this.shortTermDisability_ElectedCoverageAmount = new HtmlEdit(this);
                this.shortTermDisability_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_ElectedCoverageAmount";
                return this.shortTermDisability_ElectedCoverageAmount;
            }
        }

        private HtmlEdit shortTermDisability_EnrollmentDate;
        public HtmlEdit ShortTermDisability_EnrollmentDate
        {
            get
            {
                this.shortTermDisability_EnrollmentDate = new HtmlEdit(this);
                this.shortTermDisability_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_EnrollmentDate";
                return this.shortTermDisability_EnrollmentDate;
            }
        }

        private HtmlEdit shortTermDisability_EligibilityOverrideDate;
        public HtmlEdit ShortTermDisability_EligibilityOverrideDate
        {
            get
            {
                this.shortTermDisability_EligibilityOverrideDate = new HtmlEdit(this);
                this.shortTermDisability_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_EligibilityOverrideDate";
                return this.shortTermDisability_EligibilityOverrideDate;
            }
        }

        private HtmlEdit shortTermDisability_EligibleDate;
        public HtmlEdit ShortTermDisability_EligibleDate
        {
            get
            {
                this.shortTermDisability_EligibleDate = new HtmlEdit(this);
                this.shortTermDisability_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_EligibleDate";
                return this.shortTermDisability_EligibleDate;
            }
        }

        private HtmlCheckBox shortTermDisability_InGoodHealth;
        public HtmlCheckBox ShortTermDisability_InGoodHealth
        {
            get
            {
                this.shortTermDisability_InGoodHealth = new HtmlCheckBox(this);
                this.shortTermDisability_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl68_E_Benefit_InGoodHealth";
                return this.shortTermDisability_InGoodHealth;
            }
        }

        private HtmlCheckBox shortTermDisability_OptOut;
        public HtmlCheckBox ShortTermDisability_OptOut
        {
            get
            {
                this.shortTermDisability_OptOut = new HtmlCheckBox(this);
                this.shortTermDisability_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl68_E_Benefit_OptOut";
                return this.shortTermDisability_OptOut;
            }
        }

        private HtmlEdit shortTermDisability_PayEntityCode;
        public HtmlEdit ShortTermDisability_PayEntityCode
        {
            get
            {
                this.shortTermDisability_PayEntityCode = new HtmlEdit(this);
                this.shortTermDisability_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_PayEntityCode";
                return this.shortTermDisability_PayEntityCode;
            }
        }

        private HtmlEdit shortTermDisability_BenefitEndDate;
        public HtmlEdit ShortTermDisability_BenefitEndDate
        {
            get
            {
                this.shortTermDisability_BenefitEndDate = new HtmlEdit(this);
                this.shortTermDisability_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_BenefitEndDate";
                return this.shortTermDisability_BenefitEndDate;
            }
        }

        private HtmlCheckBox shortTermDisability_Inactive;
        public HtmlCheckBox ShortTermDisability_Inactive
        {
            get
            {
                this.shortTermDisability_Inactive = new HtmlCheckBox(this);
                this.shortTermDisability_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl68_E_Benefit_Inactive";
                return this.shortTermDisability_Inactive;
            }
        }

        private HtmlEdit shortTermDisability_DeductionCode;
        public HtmlEdit ShortTermDisability_DeductionCode
        {
            get
            {
                this.shortTermDisability_DeductionCode = new HtmlEdit(this);
                this.shortTermDisability_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_DeductionCode";
                return this.shortTermDisability_DeductionCode;
            }
        }

        private HtmlEdit shortTermDisability_BenefitProcessingStatusCode;
        public HtmlEdit ShortTermDisability_BenefitProcessingStatusCode
        {
            get
            {
                this.shortTermDisability_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.shortTermDisability_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl68_E_Benefit_BenefitProcessingStatusCode";
                return this.shortTermDisability_BenefitProcessingStatusCode;
            }
        }

        private HtmlSpan shortTermDisability_NotificationMessage;
        public HtmlSpan ShortTermDisability_NotificationMessage
        {
            get
            {
                this.shortTermDisability_NotificationMessage = new HtmlSpan(this);
                this.shortTermDisability_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl68_BenefitShortTermCare_NotificationMessage";
                return this.shortTermDisability_NotificationMessage;
            }
        }


        //================================================ Spouse Life =============================================================

        private HtmlEdit spouseLife_BenefitPlanCode;
        public HtmlEdit SpouseLife_BenefitPlanCode
        {
            get
            {
                this.spouseLife_BenefitPlanCode = new HtmlEdit(this);
                this.spouseLife_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_BenefitPlanCode_Input";
                return this.spouseLife_BenefitPlanCode;
            }
        }

        private HtmlEdit spouseLife_BenefitLevelCode;
        public HtmlEdit SpouseLife_BenefitLevelCode
        {
            get
            {
                this.spouseLife_BenefitLevelCode = new HtmlEdit(this);
                this.spouseLife_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_BenefitLevelCode_Input";
                return this.spouseLife_BenefitLevelCode;
            }
        }

        private HtmlEdit spouseLife_PayPeriodPremium;
        public HtmlEdit SpouseLife_PayPeriodPremium
        {
            get
            {
                this.spouseLife_PayPeriodPremium = new HtmlEdit(this);
                this.spouseLife_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_PayPeriodPremium";
                return this.spouseLife_PayPeriodPremium;
            }
        }

        private HtmlEdit spouseLife_MonthlyPremium;
        public HtmlEdit SpouseLife_MonthlyPremium
        {
            get
            {
                this.spouseLife_MonthlyPremium = new HtmlEdit(this);
                this.spouseLife_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_MonthlyPremium";
                return this.spouseLife_MonthlyPremium;
            }
        }

        private HtmlEdit spouseLife_EmployeeCost;
        public HtmlEdit SpouseLife_EmployeeCost
        {
            get
            {
                this.spouseLife_EmployeeCost = new HtmlEdit(this);
                this.spouseLife_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_EmployeeCost";
                return this.spouseLife_EmployeeCost;
            }
        }

        private HtmlEdit spouseLife_EmployerCost;
        public HtmlEdit SpouseLife_EmployerCost
        {
            get
            {
                this.spouseLife_EmployerCost = new HtmlEdit(this);
                this.spouseLife_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_EmployerCost";
                return this.spouseLife_EmployerCost;
            }
        }

        private HtmlEdit spouseLife_TotalCost;
        public HtmlEdit SpouseLife_TotalCost
        {
            get
            {
                this.spouseLife_TotalCost = new HtmlEdit(this);
                this.spouseLife_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_TotalCost";
                return this.spouseLife_TotalCost;
            }
        }

        private HtmlEdit spouseLife_ElectedCoverageAmount;
        public HtmlEdit SpouseLife_ElectedCoverageAmount
        {
            get
            {
                this.spouseLife_ElectedCoverageAmount = new HtmlEdit(this);
                this.spouseLife_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_ElectedCoverageAmount";
                return this.spouseLife_ElectedCoverageAmount;
            }
        }

        private HtmlEdit spouseLife_EnrollmentDate;
        public HtmlEdit SpouseLife_EnrollmentDate
        {
            get
            {
                this.spouseLife_EnrollmentDate = new HtmlEdit(this);
                this.spouseLife_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_EnrollmentDate";
                return this.spouseLife_EnrollmentDate;
            }
        }

        private HtmlEdit spouseLife_EligibilityOverrideDate;
        public HtmlEdit SpouseLife_EligibilityOverrideDate
        {
            get
            {
                this.spouseLife_EligibilityOverrideDate = new HtmlEdit(this);
                this.spouseLife_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_EligibilityOverrideDate";
                return this.spouseLife_EligibilityOverrideDate;
            }
        }

        private HtmlEdit spouseLife_EligibleDate;
        public HtmlEdit SpouseLife_EligibleDate
        {
            get
            {
                this.spouseLife_EligibleDate = new HtmlEdit(this);
                this.spouseLife_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_EligibleDate";
                return this.spouseLife_EligibleDate;
            }
        }

        private HtmlCheckBox spouseLife_InGoodHealth;
        public HtmlCheckBox SpouseLife_InGoodHealth
        {
            get
            {
                this.spouseLife_InGoodHealth = new HtmlCheckBox(this);
                this.spouseLife_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl52_E_Benefit_InGoodHealth";
                return this.spouseLife_InGoodHealth;
            }
        }

        private HtmlCheckBox spouseLife_OptOut;
        public HtmlCheckBox SpouseLife_OptOut
        {
            get
            {
                this.spouseLife_OptOut = new HtmlCheckBox(this);
                this.spouseLife_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl52_E_Benefit_OptOut";
                return this.spouseLife_OptOut;
            }
        }

        private HtmlEdit spouseLife_PayEntityCode;
        public HtmlEdit SpouseLife_PayEntityCode
        {
            get
            {
                this.spouseLife_PayEntityCode = new HtmlEdit(this);
                this.spouseLife_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_PayEntityCode";
                return this.spouseLife_PayEntityCode;
            }
        }

        private HtmlEdit spouseLife_BenefitEndDate;
        public HtmlEdit SpouseLife_BenefitEndDate
        {
            get
            {
                this.spouseLife_BenefitEndDate = new HtmlEdit(this);
                this.spouseLife_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_BenefitEndDate";
                return this.spouseLife_BenefitEndDate;
            }
        }

        private HtmlCheckBox spouseLife_Inactive;
        public HtmlCheckBox SpouseLife_Inactive
        {
            get
            {
                this.spouseLife_Inactive = new HtmlCheckBox(this);
                this.spouseLife_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl52_E_Benefit_Inactive";
                return this.spouseLife_Inactive;
            }
        }

        private HtmlEdit spouseLife_DeductionCode;
        public HtmlEdit SpouseLife_DeductionCode
        {
            get
            {
                this.spouseLife_DeductionCode = new HtmlEdit(this);
                this.spouseLife_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_DeductionCode";
                return this.spouseLife_DeductionCode;
            }
        }

        private HtmlEdit spouseLife_BenefitProcessingStatusCode;
        public HtmlEdit SpouseLife_BenefitProcessingStatusCode
        {
            get
            {
                this.spouseLife_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.spouseLife_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl52_E_Benefit_BenefitProcessingStatusCode";
                return this.spouseLife_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit spouseLife_Recipient;
        public HtmlEdit SpouseLife_Recipient
        {
            get
            {
                this.spouseLife_Recipient = new HtmlEdit(this);
                this.spouseLife_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl52$ctl09";
                return this.spouseLife_Recipient;
            }
        }

        private HtmlEdit spouseLife_Name;
        public HtmlEdit SpouseLife_Name
        {
            get
            {
                this.spouseLife_Name = new HtmlEdit(this);
                this.spouseLife_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl52$ctl10";
                return this.spouseLife_Name;
            }
        }

        private HtmlControl spouseLife_Add;
        public HtmlControl SpouseLife_Add
        {
            get
            {
                this.spouseLife_Add = new HtmlControl(this);
                this.spouseLife_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl52_BenefitCoverageExtensionAdd";
                return this.spouseLife_Add;
            }
        }

        private HtmlSpan spouseLife_NotificationMessage;
        public HtmlSpan SpouseLife_NotificationMessage
        {
            get
            {
                this.spouseLife_NotificationMessage = new HtmlSpan(this);
                this.spouseLife_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl52_Benefitvision_NotificationMessage";
                return this.spouseLife_NotificationMessage;
            }
        }

        //================================================= Supp Life ==============================================================
        private HtmlEdit suppLife_BenefitPlanCode;
        public HtmlEdit SuppLife_BenefitPlanCode
        {
            get
            {
                this.suppLife_BenefitPlanCode = new HtmlEdit(this);
                this.suppLife_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_BenefitPlanCode_Input";
                return this.suppLife_BenefitPlanCode;
            }
        }

        private HtmlEdit suppLife_BenefitLevelCode;
        public HtmlEdit SuppLife_BenefitLevelCode
        {
            get
            {
                this.suppLife_BenefitLevelCode = new HtmlEdit(this);
                this.suppLife_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_BenefitLevelCode_Input";
                return this.suppLife_BenefitLevelCode;
            }
        }

        private HtmlEdit suppLife_PayPeriodPremium;
        public HtmlEdit SuppLife_PayPeriodPremium
        {
            get
            {
                this.suppLife_PayPeriodPremium = new HtmlEdit(this);
                this.suppLife_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_PayPeriodPremium";
                return this.suppLife_PayPeriodPremium;
            }
        }

        private HtmlEdit suppLife_MonthlyPremium;
        public HtmlEdit SuppLife_MonthlyPremium
        {
            get
            {
                this.suppLife_MonthlyPremium = new HtmlEdit(this);
                this.suppLife_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_MonthlyPremium";
                return this.suppLife_MonthlyPremium;
            }
        }

        private HtmlEdit suppLife_EmployeeCost;
        public HtmlEdit SuppLife_EmployeeCost
        {
            get
            {
                this.suppLife_EmployeeCost = new HtmlEdit(this);
                this.suppLife_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_EmployeeCost";
                return this.suppLife_EmployeeCost;
            }
        }

        private HtmlEdit suppLife_EmployerCost;
        public HtmlEdit SuppLife_EmployerCost
        {
            get
            {
                this.suppLife_EmployerCost = new HtmlEdit(this);
                this.suppLife_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_EmployerCost";
                return this.suppLife_EmployerCost;
            }
        }

        private HtmlEdit suppLife_TotalCost;
        public HtmlEdit SuppLife_TotalCost
        {
            get
            {
                this.suppLife_TotalCost = new HtmlEdit(this);
                this.suppLife_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_TotalCost";
                return this.suppLife_TotalCost;
            }
        }

        private HtmlEdit suppLife_ElectedCoverageAmount;
        public HtmlEdit SuppLife_ElectedCoverageAmount
        {
            get
            {
                this.suppLife_ElectedCoverageAmount = new HtmlEdit(this);
                this.suppLife_ElectedCoverageAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_ElectedCoverageAmount";
                return this.suppLife_ElectedCoverageAmount;
            }
        }

        private HtmlEdit suppLife_EnrollmentDate;
        public HtmlEdit SuppLife_EnrollmentDate
        {
            get
            {
                this.suppLife_EnrollmentDate = new HtmlEdit(this);
                this.suppLife_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_EnrollmentDate";
                return this.suppLife_EnrollmentDate;
            }
        }

        private HtmlEdit suppLife_EligibilityOverrideDate;
        public HtmlEdit SuppLife_EligibilityOverrideDate
        {
            get
            {
                this.suppLife_EligibilityOverrideDate = new HtmlEdit(this);
                this.suppLife_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_EligibilityOverrideDate";
                return this.suppLife_EligibilityOverrideDate;
            }
        }

        private HtmlEdit suppLife_EligibleDate;
        public HtmlEdit SuppLife_EligibleDate
        {
            get
            {
                this.suppLife_EligibleDate = new HtmlEdit(this);
                this.suppLife_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_EligibleDate";
                return this.suppLife_EligibleDate;
            }
        }

        private HtmlCheckBox suppLife_InGoodHealth;
        public HtmlCheckBox SuppLife_InGoodHealth
        {
            get
            {
                this.suppLife_InGoodHealth = new HtmlCheckBox(this);
                this.suppLife_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl48_E_Benefit_InGoodHealth";
                return this.suppLife_InGoodHealth;
            }
        }

        private HtmlCheckBox suppLife_OptOut;
        public HtmlCheckBox SuppLife_OptOut
        {
            get
            {
                this.suppLife_OptOut = new HtmlCheckBox(this);
                this.suppLife_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl48_E_Benefit_OptOut";
                return this.suppLife_OptOut;
            }
        }

        private HtmlEdit suppLife_PayEntityCode;
        public HtmlEdit SuppLife_PayEntityCode
        {
            get
            {
                this.suppLife_PayEntityCode = new HtmlEdit(this);
                this.suppLife_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_PayEntityCode";
                return this.suppLife_PayEntityCode;
            }
        }

        private HtmlEdit suppLife_BenefitEndDate;
        public HtmlEdit SuppLife_BenefitEndDate
        {
            get
            {
                this.suppLife_BenefitEndDate = new HtmlEdit(this);
                this.suppLife_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_BenefitEndDate";
                return this.suppLife_BenefitEndDate;
            }
        }

        private HtmlCheckBox suppLife_Inactive;
        public HtmlCheckBox SuppLife_Inactive
        {
            get
            {
                this.suppLife_Inactive = new HtmlCheckBox(this);
                this.suppLife_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl48_E_Benefit_Inactive";
                return this.suppLife_Inactive;
            }
        }

        private HtmlEdit suppLife_DeductionCode;
        public HtmlEdit SuppLife_DeductionCode
        {
            get
            {
                this.suppLife_DeductionCode = new HtmlEdit(this);
                this.suppLife_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_DeductionCode";
                return this.suppLife_DeductionCode;
            }
        }

        private HtmlEdit suppLife_BenefitProcessingStatusCode;
        public HtmlEdit SuppLife_BenefitProcessingStatusCode
        {
            get
            {
                this.suppLife_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.suppLife_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl48_E_Benefit_BenefitProcessingStatusCode";
                return this.suppLife_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit suppLife_Recipient;
        public HtmlEdit SuppLife_Recipient
        {
            get
            {
                this.suppLife_Recipient = new HtmlEdit(this);
                this.suppLife_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl48$ctl09";
                return this.suppLife_Recipient;
            }
        }

        private HtmlEdit suppLife_Name;
        public HtmlEdit SuppLife_Name
        {
            get
            {
                this.suppLife_Name = new HtmlEdit(this);
                this.suppLife_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl48$ctl10";
                return this.suppLife_Name;
            }
        }

        private HtmlControl suppLife_Add;
        public HtmlControl SuppLife_Add
        {
            get
            {
                this.suppLife_Add = new HtmlControl(this);
                this.suppLife_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl40_BenefitCoverageExtensionAdd";
                return this.suppLife_Add;
            }
        }

        private HtmlSpan suppLife_NotificationMessage;
        public HtmlSpan SuppLife_NotificationMessage
        {
            get
            {
                this.suppLife_NotificationMessage = new HtmlSpan(this);
                this.suppLife_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl48_Benefitvision_NotificationMessage";
                return this.suppLife_NotificationMessage;
            }
        }

        //=================================================== Vision ===============================================================
        private HtmlEdit vision_BenefitPlanCode;
        public HtmlEdit Vision_BenefitPlanCode
        {
            get
            {
                this.vision_BenefitPlanCode = new HtmlEdit(this);
                this.vision_BenefitPlanCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_BenefitPlanCode_Input";
                return this.vision_BenefitPlanCode;
            }
        }

        private HtmlEdit vision_BenefitLevelCode;
        public HtmlEdit Vision_BenefitLevelCode
        {
            get
            {
                this.vision_BenefitLevelCode = new HtmlEdit(this);
                this.vision_BenefitLevelCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_BenefitLevelCode_Input";
                return this.vision_BenefitLevelCode;
            }
        }

        private HtmlEdit vision_PayPeriodPremium;
        public HtmlEdit Vision_PayPeriodPremium
        {
            get
            {
                this.vision_PayPeriodPremium = new HtmlEdit(this);
                this.vision_PayPeriodPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_PayPeriodPremium";
                return this.vision_PayPeriodPremium;
            }
        }

        private HtmlEdit vision_MonthlyPremium;
        public HtmlEdit Vision_MonthlyPremium
        {
            get
            {
                this.vision_MonthlyPremium = new HtmlEdit(this);
                this.vision_MonthlyPremium.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_MonthlyPremium";
                return this.vision_MonthlyPremium;
            }
        }

        private HtmlEdit vision_EmployeeCost;
        public HtmlEdit Vision_EmployeeCost
        {
            get
            {
                this.vision_EmployeeCost = new HtmlEdit(this);
                this.vision_EmployeeCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_EmployeeCost";
                return this.vision_EmployeeCost;
            }
        }

        private HtmlEdit vision_EmployerCost;
        public HtmlEdit Vision_EmployerCost
        {
            get
            {
                this.vision_EmployerCost = new HtmlEdit(this);
                this.vision_EmployerCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_EmployerCost";
                return this.vision_EmployerCost;
            }
        }

        private HtmlEdit vision_TotalCost;
        public HtmlEdit Vision_TotalCost
        {
            get
            {
                this.vision_TotalCost = new HtmlEdit(this);
                this.vision_TotalCost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_TotalCost";
                return this.vision_TotalCost;
            }
        }

        private HtmlEdit vision_COBRACost;
        public HtmlEdit Vision_COBRACost
        {
            get
            {
                this.vision_COBRACost = new HtmlEdit(this);
                this.vision_COBRACost.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_COBRACost";
                return this.vision_COBRACost;
            }
        }

        private HtmlEdit vision_EnrollmentDate;
        public HtmlEdit Vision_EnrollmentDate
        {
            get
            {
                this.vision_EnrollmentDate = new HtmlEdit(this);
                this.vision_EnrollmentDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_EnrollmentDate";
                return this.vision_EnrollmentDate;
            }
        }

        private HtmlEdit vision_EligibilityOverrideDate;
        public HtmlEdit Vision_EligibilityOverrideDate
        {
            get
            {
                this.vision_EligibilityOverrideDate = new HtmlEdit(this);
                this.vision_EligibilityOverrideDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_EligibilityOverrideDate";
                return this.vision_EligibilityOverrideDate;
            }
        }

        private HtmlEdit vision_EligibleDate;
        public HtmlEdit Vision_EligibleDate
        {
            get
            {
                this.vision_EligibleDate = new HtmlEdit(this);
                this.vision_EligibleDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_EligibleDate";
                return this.vision_EligibleDate;
            }
        }

        private HtmlCheckBox vision_InGoodHealth;
        public HtmlCheckBox Vision_InGoodHealth
        {
            get
            {
                this.vision_InGoodHealth = new HtmlCheckBox(this);
                this.vision_InGoodHealth.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl40_E_Benefit_InGoodHealth";
                return this.vision_InGoodHealth;
            }
        }

        private HtmlCheckBox vision_OptOut;
        public HtmlCheckBox Vision_OptOut
        {
            get
            {
                this.vision_OptOut = new HtmlCheckBox(this);
                this.vision_OptOut.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl40_E_Benefit_OptOut";
                return this.vision_OptOut;
            }
        }

        private HtmlEdit vision_PayEntityCode;
        public HtmlEdit Vision_PayEntityCode
        {
            get
            {
                this.vision_PayEntityCode = new HtmlEdit(this);
                this.vision_PayEntityCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_PayEntityCode";
                return this.vision_PayEntityCode;
            }
        }

        private HtmlEdit vision_BenefitEndDate;
        public HtmlEdit Vision_BenefitEndDate
        {
            get
            {
                this.vision_BenefitEndDate = new HtmlEdit(this);
                this.vision_BenefitEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_BenefitEndDate";
                return this.vision_BenefitEndDate;
            }
        }

        private HtmlCheckBox vision_Inactive;
        public HtmlCheckBox Vision_Inactive
        {
            get
            {
                this.vision_Inactive = new HtmlCheckBox(this);
                this.vision_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl40_E_Benefit_Inactive";
                return this.vision_Inactive;
            }
        }

        private HtmlEdit vision_DeductionCode;
        public HtmlEdit Vision_DeductionCode
        {
            get
            {
                this.vision_DeductionCode = new HtmlEdit(this);
                this.vision_DeductionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_DeductionCode";
                return this.vision_DeductionCode;
            }
        }

        private HtmlEdit vision_BenefitProcessingStatusCode;
        public HtmlEdit Vision_BenefitProcessingStatusCode
        {
            get
            {
                this.vision_BenefitProcessingStatusCode = new HtmlEdit(this);
                this.vision_BenefitProcessingStatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Benefit_BenefitProcessingStatusCode";
                return this.vision_BenefitProcessingStatusCode;
            }
        }

        private HtmlEdit vision_Recipient;
        public HtmlEdit Vision_Recipient
        {
            get
            {
                this.vision_Recipient = new HtmlEdit(this);
                this.vision_Recipient.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl40$ctl09";
                return this.vision_Recipient;
            }
        }

        private HtmlEdit vision_Name;
        public HtmlEdit Vision_Name
        {
            get
            {
                this.vision_Name = new HtmlEdit(this);
                this.vision_Name.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl40$ctl10";
                return this.vision_Name;
            }
        }

        private HtmlControl vision_Add;
        public HtmlControl Vision_Add
        {
            get
            {
                this.vision_Add = new HtmlControl(this);
                this.vision_Add.SearchProperties[HtmlControl.PropertyNames.Id] = "ctl40_BenefitCoverageExtensionAdd";
                return this.vision_Add;
            }
        }

        private HtmlSpan vision_NotificationMessage;
        public HtmlSpan Vision_NotificationMessage
        {
            get
            {
                this.vision_NotificationMessage = new HtmlSpan(this);
                this.vision_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl40_Benefitvision_NotificationMessage";
                return this.vision_NotificationMessage;
            }
        }


        public HtmlEdit Common_Benefit_EmployeeCost { get; set; }

        public HtmlEdit Common_Benefit_EmployerCost { get; set; }

        public HtmlEdit Common_Benefit_TotalCost { get; set; }

        public HtmlEdit Common_Benefit_COBRACost { get; set; }

        public HtmlEdit Common_benefit_EnrollmentDate { get; set; }

        public HtmlEdit Common_Benefit_EligibilityOverrideDate { get; set; }

        public HtmlEdit Common_benefit_EligibleDate { get; set; }

        public HtmlEdit Common_Benefit_PayEntityCode { get; set; }

        public HtmlEdit Common_Benefit__BenefitEndDate { get; set; }

        public HtmlEdit Common_Benefit_BenefitEndDate { get; set; }

        public HtmlEdit Common_Benefit_DeductionCode { get; set; }

        public HtmlEdit Common_BenefitProcessingStatusCode { get; set; }
    };

    //================================================== Tabs ===================================================================

    public class BenefitsEnrollmentTabHeader : HtmlDiv
    {
        public BenefitsEnrollmentTabHeader(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "_tab";
        }

        private HtmlHyperlink additionalDeathAndDisability_TabLink;
        public HtmlHyperlink AdditionalDeathAndDisability_TabLink
        {
            get
            {
                this.additionalDeathAndDisability_TabLink = new HtmlHyperlink(this);
                this.additionalDeathAndDisability_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "A D & D";
                return this.additionalDeathAndDisability_TabLink;
            }
        }

        private HtmlHyperlink dental_TabLink;
        public HtmlHyperlink Dental_TabLink
        {
            get
            {
                this.dental_TabLink = new HtmlHyperlink(this);
                this.dental_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Dental";
                return this.dental_TabLink;
            }
        }

        private HtmlHyperlink dependentLife_TabLink;
        public HtmlHyperlink DependentLife_TabLink
        {
            get
            {
                this.dependentLife_TabLink = new HtmlHyperlink(this);
                this.dependentLife_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Dependent Life";
                return this.dependentLife_TabLink;
            }
        }

        private HtmlHyperlink fsaDependentCare_TabLink;
        public HtmlHyperlink FsaDependentCare_TabLink
        {
            get
            {
                this.fsaDependentCare_TabLink = new HtmlHyperlink(this);
                this.fsaDependentCare_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "FSA Dependent Care";
                return this.fsaDependentCare_TabLink;
            }
        }

        private HtmlHyperlink fsaMedical_TabLink;
        public HtmlHyperlink FsaMedical_TabLink
        {
            get
            {
                this.fsaMedical_TabLink = new HtmlHyperlink(this);
                this.fsaMedical_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "FSA Medical";
                return this.fsaMedical_TabLink;
            }
        }

        private HtmlHyperlink life_TabLink;
        public HtmlHyperlink Life_TabLink
        {
            get
            {
                this.life_TabLink = new HtmlHyperlink(this);
                this.life_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Life";
                return this.life_TabLink;
            }
        }

        private HtmlHyperlink longTermDisability_TabLink;
        public HtmlHyperlink LongTermDisability_TabLink
        {
            get
            {
                this.longTermDisability_TabLink = new HtmlHyperlink(this);
                this.longTermDisability_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Long Term Disability";
                return this.longTermDisability_TabLink;
            }
        }

        private HtmlHyperlink medical_TabLink;
        public HtmlHyperlink Medical_TabLink
        {
            get
            {
                this.medical_TabLink = new HtmlHyperlink(this);
                this.medical_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Medical";
                return this.medical_TabLink;
            }
        }

        private HtmlHyperlink shortTermDisability_TabLink;
        public HtmlHyperlink ShortTermDisability_TabLink
        {
            get
            {
                this.shortTermDisability_TabLink = new HtmlHyperlink(this);
                this.shortTermDisability_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Short Term Disability";
                return this.shortTermDisability_TabLink;
            }
        }

        private HtmlHyperlink spouseLife_TabLink;
        public HtmlHyperlink SpouseLife_TabLink
        {
            get
            {
                this.spouseLife_TabLink = new HtmlHyperlink(this);
                this.spouseLife_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Spouse Life";
                return this.spouseLife_TabLink;
            }
        }

        private HtmlHyperlink suppLife_TabLink;
        public HtmlHyperlink SuppLife_TabLink
        {
            get
            {
                this.suppLife_TabLink = new HtmlHyperlink(this);
                this.suppLife_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Supp Life";
                return this.suppLife_TabLink;
            }
        }

        private HtmlHyperlink vision_TabLink;
        public HtmlHyperlink Vision_TabLink
        {
            get
            {
                this.vision_TabLink = new HtmlHyperlink(this);
                this.vision_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Vision";
                return this.vision_TabLink;
            }
        }

    };
}

