using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Text.RegularExpressions; 

namespace CodedUiTest.PayInformation
{
    public class PayInformationControls
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

    public class AdminHtmlDocumentFrame : HtmlIFrame
    {
        private PayInformationScreen payInformationScreen; 

        public AdminHtmlDocumentFrame(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "Home";
        }

        public PayInformationScreen PayInformationScreen
        {
            get
            {
                this.payInformationScreen = new PayInformationScreen(this);
                return this.payInformationScreen; 
            }
        }
    };

    public class PayInformationScreen : HtmlDocument
    {
        //================================================== Compensation Fields ===============================================================

        public PayInformationScreen(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/Secured/Admin/AdminManager.aspx";
        }

        //================================================ Header Controls ============================================================

        private HtmlEdit payInformation_PayEntity;
        public HtmlEdit PayInformation_PayEntity
        {
            get
            {
                this.payInformation_PayEntity = new HtmlEdit(this);
                //this.payInformation_PayEntity.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Earning_PayEntityCode_Input";
                this.payInformation_PayEntity.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_PayEntityCode_Input", PropertyExpressionOperator.Contains);
                return this.payInformation_PayEntity;
            }
        }

        private HtmlEdit payInformation_Earnings;
        public HtmlEdit PayInformation_Earnings
        {
            get
            {
                this.payInformation_Earnings = new HtmlEdit(this);
                //this.payInformation_Earnings.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl40_E_Earning_EarningsCode_Input";
                this.payInformation_Earnings.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_EarningsCode_Input", PropertyExpressionOperator.Contains);
                return this.payInformation_Earnings;
            }
        }

        //================================================== Tab Header ===============================================================

        private PayInformationTabHeader payInformationTabHeader;

        public PayInformationTabHeader PayInformationTabHeader
        {
            get
            {
                this.payInformationTabHeader = new PayInformationTabHeader(this);
                return this.payInformationTabHeader;
            }
        }

        //================================================== Compensation ===============================================================

        private HtmlEdit compensation_HourlySalariedCode;
        public HtmlEdit Compensation_HourlySalariedCode
        {
            get
            {
                this.compensation_HourlySalariedCode = new HtmlEdit(this);
                //this.compensation_HourlySalariedCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl19_E_Compensation_HourlySalariedCode_Input";
                this.compensation_HourlySalariedCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Compensation_HourlySalariedCode_Input",PropertyExpressionOperator.Contains);
                return this.compensation_HourlySalariedCode;
            }
        }

        private HtmlEdit compensation_HourlyRate;
        public HtmlEdit Compensation_HourlyRate
        {
            get
            {
                this.compensation_HourlyRate = new HtmlEdit(this);
                //this.compensation_HourlyRate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Compensation_HourlyRate";
                this.compensation_HourlyRate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Compensation_HourlyRate", PropertyExpressionOperator.Contains);
                return this.compensation_HourlyRate;
            }
        }

        private HtmlEdit compensation_PayPeriodSalary;
        public HtmlEdit Compensation_PayPeriodSalary
        {
            get
            {
                this.compensation_PayPeriodSalary = new HtmlEdit(this);
                //this.compensation_PayPeriodSalary.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Compensation_PayPeriodSalary";
                this.compensation_PayPeriodSalary.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Compensation_PayPeriodSalary", PropertyExpressionOperator.Contains);
                return this.compensation_PayPeriodSalary;
            }
        }

        private HtmlEdit compensation_StandardHours;
        public HtmlEdit Compensation_StandardHours 
        {
            get
            {
                this.compensation_StandardHours = new HtmlEdit(this);
                //this.compensation_StandardHours.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Compensation_StandardHours";
                this.compensation_StandardHours.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Compensation_StandardHours", PropertyExpressionOperator.Contains);
                return this.compensation_StandardHours;
            }
        }

        private HtmlEdit compensation_GuaranteedPayAmount;
        public HtmlEdit Compensation_GuaranteedPayAmount
        {
            get
            {
                this.compensation_GuaranteedPayAmount = new HtmlEdit(this);
                //this.compensation_GuaranteedPayAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Compensation_GuaranteedPayAmount";
                this.compensation_GuaranteedPayAmount.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Compensation_GuaranteedPayAmount", PropertyExpressionOperator.Contains);
                return this.compensation_GuaranteedPayAmount;
            }
        }

        private HtmlEdit compensation_HourlyRateEquivalent;
        public HtmlEdit Compensation_HourlyRateEquivalent
        {
            get 
            {
                this.compensation_HourlyRateEquivalent = new HtmlEdit(this);
                //this.compensation_HourlyRateEquivalent.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Compensation_HourlyRateEquivalent";
                this.compensation_HourlyRateEquivalent.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Compensation_HourlyRateEquivalent", PropertyExpressionOperator.Contains);
                return this.compensation_HourlyRateEquivalent;
            }
        }

        private HtmlEdit compensation_MonthlyEquivalent;
        public HtmlEdit Compensation_MonthlyEquivalent
        {
            get
            {
                this.compensation_MonthlyEquivalent = new HtmlEdit(this);
                //this.compensation_MonthlyEquivalent.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Compensation_MonthlyEquivalent";
                this.compensation_MonthlyEquivalent.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Compensation_MonthlyEquivalent", PropertyExpressionOperator.Contains);
                return this.compensation_MonthlyEquivalent;
            }
        }

        private HtmlEdit compensation_AnnualEquivalent;
        public HtmlEdit Compensation_AnnualEquivalent 
        {
            get
            {
                this.compensation_AnnualEquivalent = new HtmlEdit(this);
                //this.compensation_AnnualEquivalent.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Compensation_AnnualEquivalent";
                this.compensation_AnnualEquivalent.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Compensation_AnnualEquivalent", PropertyExpressionOperator.Contains);
                return this.compensation_AnnualEquivalent;
            }
        }

        private HtmlCheckBox compensation_Inactive;
        public HtmlCheckBox Compensation_Inactive
        {
            get
            {
                this.compensation_Inactive = new HtmlCheckBox(this);
                //this.compensation_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl24_E_Compensation_Inactive";
                this.compensation_Inactive.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Compensation_Inactive", PropertyExpressionOperator.Contains);
                return this.compensation_Inactive;
            }
        }

        private HtmlEdit compensation_SalaryChangeReasonCode;
        public HtmlEdit Compensation_SalaryChangeReasonCode
        {
            get
            {
                this.compensation_SalaryChangeReasonCode = new HtmlEdit(this);
                //this.compensation_SalaryChangeReasonCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Compensation_SalaryChangeReasonCode_Input";
                this.compensation_SalaryChangeReasonCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Compensation_SalaryChangeReasonCode_Input", PropertyExpressionOperator.Contains);
                return this.compensation_SalaryChangeReasonCode;
            }
        }

        private HtmlSpan compensation_NotificationMessage;
        public HtmlSpan Compensation_NotificationMessage
        {
            get
            {
                this.compensation_NotificationMessage = new HtmlSpan(this);
                //this.compensation_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl24_EmployeeCompensation_NotificationMessage";
                this.compensation_NotificationMessage.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_EmployeeCompensation_NotificationMessage", PropertyExpressionOperator.Contains);
                return this.compensation_NotificationMessage;
            }
        }

        //================================================== Jobs Fields ===============================================================

        private HtmlCheckBox job_PrimaryWorkLocation;
        public HtmlCheckBox Jobs_PrimaryWorkLocation
        {
            get
            {
                this.job_PrimaryWorkLocation = new HtmlCheckBox(this);
                //this.job_PrimaryWorkLocation.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl29_E_Job_PrimaryWorkLocation";
                this.job_PrimaryWorkLocation.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Job_PrimaryWorkLocation", PropertyExpressionOperator.Contains); 
                return this.job_PrimaryWorkLocation;
            }
        }

        private HtmlEdit job_RegularOrTemporaryCode;
        public HtmlEdit Jobs_RegularOrTemporaryCode
        {
            get
            {
                this.job_RegularOrTemporaryCode = new HtmlEdit(this);
                //this.job_RegularOrTemporaryCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Job_RegularOrTemporaryCode_Input";
                this.job_RegularOrTemporaryCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Job_RegularOrTemporaryCode_Input", PropertyExpressionOperator.Contains); 
                return this.job_RegularOrTemporaryCode;
            }
        }

        private HtmlEdit job_FullOrPartTimeCode;
        public HtmlEdit Jobs_FullOrPartTimeCode
        {
            get
            {
                this.job_FullOrPartTimeCode = new HtmlEdit(this);
                //this.job_FullOrPartTimeCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Job_FullOrPartTimeCode_Input";
                this.job_FullOrPartTimeCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Job_FullOrPartTimeCode_Input", PropertyExpressionOperator.Contains); 
                return this.job_FullOrPartTimeCode;
            }
        }

        private HtmlEdit job_ShiftCode;
        public HtmlEdit Jobs_ShiftCode 
        {
            get
            {
                this.job_ShiftCode = new HtmlEdit(this);
                //this.job_ShiftCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Job_ShiftCode_Input";
                this.job_ShiftCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Job_ShiftCode_Input", PropertyExpressionOperator.Contains); 
                return this.job_ShiftCode;
            }
        }

        private HtmlEdit job_ChangeReasonCode;
        public HtmlEdit Jobs_JobChangeReasonCode
        {
            get
            {
                this.job_ChangeReasonCode = new HtmlEdit(this);
                //this.job_ChangeReasonCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Job_JobChangeReasonCode_Input";
                this.job_ChangeReasonCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Job_JobChangeReasonCode_Input", PropertyExpressionOperator.Contains); 
                return this.job_ChangeReasonCode;
            }
        }

        private HtmlEdit job_ClassCode;
        public HtmlEdit Jobs_JobClassCode
        {
            get
            {
                this.job_ClassCode = new HtmlEdit(this);
                //this.job_ClassCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Job_JobClassCode_Input";
                this.job_ClassCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Job_JobClassCode_Input", PropertyExpressionOperator.Contains); 
                return this.job_ClassCode;
            }
        }

        private HtmlCheckBox job_DirectTipEmployee;
        public HtmlCheckBox Jobs_DirectTipEmployee
        {
            get
            {
                this.job_DirectTipEmployee = new HtmlCheckBox(this);
                //this.job_DirectTipEmployee.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl29_E_Job_DirectTipEmployee";
                this.job_DirectTipEmployee.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Job_DirectTipEmployee", PropertyExpressionOperator.Contains); 
                return this.job_DirectTipEmployee;
            }
        }

        private HtmlEdit job_WorkersCompensationCode;
        public HtmlEdit Jobs_WorkersCompensationCode
        {
            get
            {
                this.job_WorkersCompensationCode = new HtmlEdit(this);
                //this.job_WorkersCompensationCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Job_WorkersCompensationCode_Input";
                this.job_WorkersCompensationCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Job_WorkersCompensationCode_Input", PropertyExpressionOperator.Contains); 
                return this.job_WorkersCompensationCode;
            }
        }

        private HtmlEdit job_RateForJob;
        public HtmlEdit Jobs_RateForJob
        {
            get
            {
                this.job_RateForJob = new HtmlEdit(this);
                //this.job_RateForJob.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Job_RateForJob";
                this.job_RateForJob.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Job_RateForJob", PropertyExpressionOperator.Contains); 
                return this.job_RateForJob;
            }
        }

        private HtmlEdit job_Comments;
        public HtmlEdit Jobs_Comments
        {
            get
            {
                this.job_Comments = new HtmlEdit(this);
                //this.job_Comments.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Job_Comments";
                this.job_Comments.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Job_Comments", PropertyExpressionOperator.Contains); 
                return this.job_Comments;
            }
        }

        private HtmlCheckBox job_WorksFromHome;
        public HtmlCheckBox Job_WorksFromHome
        {
            get
            {
                this.job_WorksFromHome = new HtmlCheckBox(this);
                //this.job_WorksFromHome.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl29_E_Job_DirectTipEmployee";
                this.job_WorksFromHome.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Job_DirectTipEmployee", PropertyExpressionOperator.Contains); 
                return this.job_WorksFromHome;
            }
        }

        private HtmlEdit job_Percentage;
        public HtmlEdit Jobs_Percentage 
        {
            get
            {
                this.job_Percentage = new HtmlEdit(this);
                //this.job_Percentage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl29_E_Job_Percentage";
                this.job_Percentage.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_E_Job_Percentage", PropertyExpressionOperator.Contains); 
                return this.job_Percentage;
            }
        }

        private HtmlCheckBox job_NotApplicableToBenefits;
        public HtmlCheckBox Jobs_NotApplicableToBenefits
        {
            get
            {
                this.job_NotApplicableToBenefits = new HtmlCheckBox(this);
                //this.job_NotApplicableToBenefits.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl29_E_Job_NotApplicableToBenefits";
                this.job_NotApplicableToBenefits.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Job_NotApplicableToBenefits", PropertyExpressionOperator.Contains); 
                return this.job_NotApplicableToBenefits;
            }
        }

        private HtmlEdit job_CostCenterCode;
        public HtmlEdit Jobs_CostCenterCode 
        {
            get
            {
                this.job_CostCenterCode = new HtmlEdit(this);
                //this.job_CostCenterCode.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl29_E_Job_CostCenterCode_Input";
                this.job_CostCenterCode.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_E_Job_CostCenterCode_Input", PropertyExpressionOperator.Contains); 
                return this.job_CostCenterCode;
            }
        }

        private HtmlEdit job_LaborDistributionCode;
        public HtmlEdit Jobs_LaborDistributionCode 
        {
            get
            {
                this.job_LaborDistributionCode = new HtmlEdit(this);
                //this.job_LaborDistributionCode.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl29_E_Job_LaborDistributionCode_Input";
                this.job_LaborDistributionCode.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_E_Job_LaborDistributionCode_Input", PropertyExpressionOperator.Contains); 
                return this.job_LaborDistributionCode;
            }
        }

        private HtmlEdit job_PositionCode;
        public HtmlEdit Jobs_PositionCode 
        {
            get
            {
                this.job_PositionCode = new HtmlEdit(this);
                //this.job_PositionCode.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl29_E_Job_PositionCode_Input";
                this.job_PositionCode.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_E_Job_PositionCode_Input", PropertyExpressionOperator.Contains); 
                return this.job_PositionCode;
            }
        }

        private HtmlCheckBox job_Inactive;
        public HtmlCheckBox Jobs_Inactive
        {
            get
            {
                this.job_Inactive = new HtmlCheckBox(this);
                //this.job_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl29_E_Job_Inactive";
                this.job_Inactive.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Job_Inactive", PropertyExpressionOperator.Contains); 
                return this.job_Inactive;
            }
        }

        private HtmlSpan job_NotificationMessage;
        public HtmlSpan Jobs_NotificationMessage
        {
            get
            {
                this.job_NotificationMessage = new HtmlSpan(this);
                //this.job_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl29_EmployeeJob_NotificationMessage";
                this.job_NotificationMessage.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_EmployeeJob_NotificationMessage", PropertyExpressionOperator.Contains); 
                return this.job_NotificationMessage;
            }
        }

        //================================================== Job Allocation ===============================================================

        private HtmlEdit jobAllocation_JobCode_0;
        public HtmlEdit JobAllocation_JobCode_0 
        {
            get
            {
                this.jobAllocation_JobCode_0 = new HtmlEdit(this);
                //this.jobAllocation_JobCode_0.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl04_JobCode_Input";
                this.jobAllocation_JobCode_0.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl04_JobCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_JobCode_0;
            }
        }

        private HtmlEdit jobAllocation_WorkLocationCode_0;
        public HtmlEdit JobAllocation_WorkLocationCode_0
        {
            get
            {
                this.jobAllocation_WorkLocationCode_0 = new HtmlEdit(this);
                //this.jobAllocation_WorkLocationCode_0.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl04_WorkLocationCode_Input";
                this.jobAllocation_WorkLocationCode_0.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl04_WorkLocationCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_WorkLocationCode_0;
            }
        }

        private HtmlEdit jobAllocation_CostCenterCode_0;
        public HtmlEdit JobAllocation_CostCenterCode_0
        {
            get
            {
                this.jobAllocation_CostCenterCode_0 = new HtmlEdit(this);
                //this.jobAllocation_CostCenterCode_0.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl04_CostCenterCode_Input";
                this.jobAllocation_CostCenterCode_0.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl04_CostCenterCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_CostCenterCode_0;
            }
        }

        private HtmlEdit jobAllocation_LaborDistributionCode_0;
        public HtmlEdit JobAllocation_LaborDistributionCode_0
        {
            get
            {
                this.jobAllocation_LaborDistributionCode_0 = new HtmlEdit(this);
                //this.jobAllocation_LaborDistributionCode_0.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl04_LaborDistributionCode_Input";
                this.jobAllocation_LaborDistributionCode_0.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl04_LaborDistributionCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_LaborDistributionCode_0;
            }
        }

        private HtmlEdit jobAllocation_Percentage_0;
        public HtmlEdit JobAllocation_Percentage_0
        {
            get
            {
                this.jobAllocation_Percentage_0 = new HtmlEdit(this);
                //this.jobAllocation_Percentage_0.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl04_Percentage";
                this.jobAllocation_Percentage_0.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl04_Percentage", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_Percentage_0;
            }
        }

        private HtmlEdit jobAllocation_JobCode_1;
        public HtmlEdit JobAllocation_JobCode_1
        {
            get
            {
                this.jobAllocation_JobCode_1 = new HtmlEdit(this);
                //this.jobAllocation_JobCode_1.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl05_JobCode_Input";
                this.jobAllocation_JobCode_1.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl05_JobCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_JobCode_1;
            }
        }

        private HtmlEdit jobAllocation_WorkLocationCode_1;
        public HtmlEdit JobAllocation_WorkLocationCode_1
        {
            get
            {
                this.jobAllocation_WorkLocationCode_1 = new HtmlEdit(this);
                //this.jobAllocation_WorkLocationCode_1.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl05_WorkLocationCode_Input";
                this.jobAllocation_WorkLocationCode_1.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl05_WorkLocationCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_WorkLocationCode_1;
            }
        }

        private HtmlEdit jobAllocation_CostCenterCode_1;
        public HtmlEdit JobAllocation_CostCenterCode_1
        {
            get
            {
                this.jobAllocation_CostCenterCode_1 = new HtmlEdit(this);
                //this.jobAllocation_CostCenterCode_1.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl05_CostCenterCode_Input";
                this.jobAllocation_CostCenterCode_1.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl05_CostCenterCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_CostCenterCode_1;
            }
        }

        private HtmlEdit jobAllocation_LaborDistributionCode_1;
        public HtmlEdit JobAllocation_LaborDistributionCode_1
        {
            get
            {
                this.jobAllocation_LaborDistributionCode_1 = new HtmlEdit(this);
                //this.jobAllocation_LaborDistributionCode_1.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl05_LaborDistributionCode_Input";
                this.jobAllocation_LaborDistributionCode_1.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl05_LaborDistributionCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_LaborDistributionCode_1;
            }
        }

        private HtmlEdit jobAllocation_Percentage_1;
        public HtmlEdit JobAllocation_Percentage_1
        {
            get
            {
                this.jobAllocation_Percentage_1 = new HtmlEdit(this);
                //this.jobAllocation_Percentage_1.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl05_Percentage";
                this.jobAllocation_Percentage_1.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl05_Percentage", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_Percentage_1;
            }
        }

        private HtmlEdit jobAllocation_JobCode_2;
        public HtmlEdit JobAllocation_JobCode_2
        {
            get
            {
                this.jobAllocation_JobCode_2 = new HtmlEdit(this);
                //this.jobAllocation_JobCode_2.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl06_JobCode_Input";
                this.jobAllocation_JobCode_2.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl06_JobCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_JobCode_2;
            }
        }

        private HtmlEdit jobAllocation_WorkLocationCode_2;
        public HtmlEdit JobAllocation_WorkLocationCode_2
        {
            get
            {
                this.jobAllocation_WorkLocationCode_2 = new HtmlEdit(this);
                //this.jobAllocation_WorkLocationCode_2.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_JobAllocationExtensionGridID_ctl00_ctl06_WorkLocationCode_Input";
                this.jobAllocation_WorkLocationCode_2.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl06_WorkLocationCode_Input", PropertyExpressionOperator.Contains); 
                return this.jobAllocation_WorkLocationCode_2;                
            }
        }

        private HtmlEdit jobAllocation_CostCenterCode_2;
        public HtmlEdit JobAllocation_CostCenterCode_2
        {
            get
            {
                this.jobAllocation_CostCenterCode_2 = new HtmlEdit(this);
                //this.jobAllocation_CostCenterCode_2.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl06_CostCenterCode_Input";
                this.jobAllocation_CostCenterCode_2.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl06_CostCenterCode_Input", PropertyExpressionOperator.Contains);
                return this.jobAllocation_CostCenterCode_2;
            }
        }

        private HtmlEdit jobAllocation_LaborDistributionCode_2;
        public HtmlEdit JobAllocation_LaborDistributionCode_2
        {
            get
            {
                this.jobAllocation_LaborDistributionCode_2 = new HtmlEdit(this);
                //this.jobAllocation_LaborDistributionCode_2.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl06_LaborDistributionCode_Input";
                this.jobAllocation_LaborDistributionCode_2.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl06_LaborDistributionCode_Input", PropertyExpressionOperator.Contains);
                return this.jobAllocation_LaborDistributionCode_2;
            }
        }

        private HtmlEdit jobAllocation_Percentage_2;
        public HtmlEdit JobAllocation_Percentage_2
        {
            get
            {
                this.jobAllocation_Percentage_2 = new HtmlEdit(this);
                //this.jobAllocation_Percentage_2.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl06_Percentage";
                this.jobAllocation_Percentage_2.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl06_Percentage", PropertyExpressionOperator.Contains);
                return this.jobAllocation_Percentage_2;
            }
        }

        private HtmlEdit jobAllocation_JobCode_3;
        public HtmlEdit JobAllocation_JobCode_3
        {
            get
            {
                this.jobAllocation_JobCode_3 = new HtmlEdit(this);
                //this.jobAllocation_JobCode_3.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl07_JobCode_Input";
                this.jobAllocation_JobCode_3.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl07_JobCode_Input", PropertyExpressionOperator.Contains);
                return this.jobAllocation_JobCode_3;
            }
        }

        private HtmlEdit jobAllocation_WorkLocationCode_3;
        public HtmlEdit JobAllocation_WorkLocationCode_3
        {
            get
            {
                this.jobAllocation_WorkLocationCode_3 = new HtmlEdit(this);
                //this.jobAllocation_WorkLocationCode_3.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl07_WorkLocationCode_Input";
                this.jobAllocation_WorkLocationCode_3.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl07_WorkLocationCode_Input", PropertyExpressionOperator.Contains);
                return this.jobAllocation_WorkLocationCode_3;
            }
        }

        private HtmlEdit jobAllocation_CostCenterCode_3;
        public HtmlEdit JobAllocation_CostCenterCode_3
        {
            get
            {
                this.jobAllocation_CostCenterCode_3 = new HtmlEdit(this);
                //this.jobAllocation_CostCenterCode_3.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl07_CostCenterCode_Input";
                this.jobAllocation_CostCenterCode_3.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl07_CostCenterCode_Input", PropertyExpressionOperator.Contains);
                return this.jobAllocation_CostCenterCode_3;
            }
        }

        private HtmlEdit jobAllocation_LaborDistributionCode_3;
        public HtmlEdit JobAllocation_LaborDistributionCode_3
        {
            get
            {
                this.jobAllocation_LaborDistributionCode_3 = new HtmlEdit(this);
                //this.jobAllocation_LaborDistributionCode_3.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl07_LaborDistributionCode_Input";
                this.jobAllocation_LaborDistributionCode_3.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl07_LaborDistributionCode_Input", PropertyExpressionOperator.Contains);
                return this.jobAllocation_LaborDistributionCode_3;
            }
        }

        private HtmlEdit jobAllocation_Percentage_3;
        public HtmlEdit JobAllocation_Percentage_3
        {
            get
            {
                this.jobAllocation_Percentage_3 = new HtmlEdit(this);
                //this.jobAllocation_Percentage_3.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl07_Percentage";
                this.jobAllocation_Percentage_3.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl07_Percentage", PropertyExpressionOperator.Contains);
                return this.jobAllocation_Percentage_3;
            }
        }

        private HtmlEdit jobAllocation_PercentageTotal;
        public HtmlEdit JobAllocation_PercentageTotal
        {
            get
            {
                this.jobAllocation_PercentageTotal = new HtmlEdit(this);
                //this.jobAllocation_PercentageTotal.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_JobAllocationExtensionGridID_ctl00_ctl03_ctl00_Total";
                this.jobAllocation_PercentageTotal.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_JobAllocationExtensionGridID_ctl00_ctl03_ctl00_Total", PropertyExpressionOperator.Contains);
                return this.jobAllocation_PercentageTotal;
            }
        }

        //================================================== Earnings ===================================================================

        private HtmlEdit earnings_Schedule;
        public HtmlEdit Earnings_Schedule
        {
            get
            {
                this.earnings_Schedule = new HtmlEdit(this);
                //this.earnings_Schedule.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_ScheduleCode_Input";
                this.earnings_Schedule.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_ScheduleCode_Input", PropertyExpressionOperator.Contains);
                return this.earnings_Schedule;
            }
        }

        private HtmlEdit earnings_Hours;
        public HtmlEdit Earnings_Hours
        {
            get
            {
                this.earnings_Hours = new HtmlEdit(this);
                //this.earnings_Hours.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_Hours";
                this.earnings_Hours.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_Hours", PropertyExpressionOperator.Contains);
                return this.earnings_Schedule;
                return this.earnings_Hours;
            }
        }

        private HtmlEdit earnings_Rate;
        public HtmlEdit Earnings_Rate
        {
            get
            {
                this.earnings_Rate = new HtmlEdit(this);
                //this.earnings_Rate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_Rate";
                this.earnings_Rate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_Rate", PropertyExpressionOperator.Contains);
                return this.earnings_Rate;
            }
        }

        private HtmlEdit earnings_PayAmount;
        public HtmlEdit Earnings_PayAmount
        {
            get
            {
                this.earnings_PayAmount = new HtmlEdit(this);
                //this.earnings_PayAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_PayAmount";
                this.earnings_PayAmount.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_PayAmount", PropertyExpressionOperator.Contains);
                return this.earnings_PayAmount;
            }
        }

        private HtmlEdit earnings_GoalAmount;
        public HtmlEdit Earnings_GoalAmount
        {
            get
            {
                this.earnings_GoalAmount = new HtmlEdit(this);
                //this.earnings_GoalAmount.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_GoalAmount";
                this.earnings_GoalAmount.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_GoalAmount", PropertyExpressionOperator.Contains);
                return this.earnings_GoalAmount;
            }
        }

        private HtmlEdit earnings_GoalSequenceNumber;
        public HtmlEdit Earnings_GoalSequenceNumber
        {
            get
            {
                this.earnings_GoalSequenceNumber = new HtmlEdit(this);
                //this.earnings_GoalSequenceNumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_GoalSequenceNumber";
                this.earnings_GoalSequenceNumber.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_GoalSequenceNumber", PropertyExpressionOperator.Contains);
                return this.earnings_GoalSequenceNumber;
            }
        }

        private HtmlEdit earnings_JobCode;
        public HtmlEdit Earnings_JobCode
        {
            get
            {
                this.earnings_JobCode = new HtmlEdit(this);
                //this.earnings_JobCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_JobCode_Input";
                this.earnings_JobCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_JobCode_Input", PropertyExpressionOperator.Contains);
                return this.earnings_JobCode;
            }
        }

        private HtmlEdit earnings_WorkLocationCode;
        public HtmlEdit Earnings_WorkLocationCode
        {
            get
            {
                this.earnings_WorkLocationCode = new HtmlEdit(this);
                //this.earnings_WorkLocationCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_WorkLocationCode_Input";
                this.earnings_WorkLocationCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_WorkLocationCode_Input", PropertyExpressionOperator.Contains);
                return this.earnings_WorkLocationCode;
            }
        }

        private HtmlEdit earnings_CostCenterCode;
        public HtmlEdit Earnings_CostCenterCode
        {
            get
            {
                this.earnings_CostCenterCode = new HtmlEdit(this);
                //this.earnings_CostCenterCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_CostCenterCode_Input";
                this.earnings_CostCenterCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_CostCenterCode_Input", PropertyExpressionOperator.Contains);
                return this.earnings_CostCenterCode;
            }
        }

        private HtmlEdit earnings_LaborDistributionCode;
        public HtmlEdit Earnings_LaborDistributionCode
        {
            get
            {
                this.earnings_LaborDistributionCode = new HtmlEdit(this);
                //this.earnings_LaborDistributionCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_LaborDistributionCode_Input";
                this.earnings_LaborDistributionCode.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_LaborDistributionCode_Input", PropertyExpressionOperator.Contains);
                return this.earnings_LaborDistributionCode;
            }
        }

        private HtmlEdit earnings_EarningsEndDate;
        public HtmlEdit Earnings_EarningsEndDate
        {
            get
            {
                this.earnings_EarningsEndDate = new HtmlEdit(this);
                //this.earnings_EarningsEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Earning_EarningsEndDate";
                this.earnings_EarningsEndDate.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Earning_EarningsEndDate", PropertyExpressionOperator.Contains);
                return this.earnings_EarningsEndDate;
            }
        }

        private HtmlCheckBox earnings_Inactive;
        public HtmlCheckBox Earnings_EarningsInactive
        {
            get
            {
                this.earnings_Inactive = new HtmlCheckBox(this);
                //this.earnings_Inactive.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl39_E_Earning_Inactive";
                this.earnings_Inactive.SearchProperties.Add(HtmlCheckBox.PropertyNames.Id, "_E_Earning_Inactive", PropertyExpressionOperator.Contains);
                return this.earnings_Inactive;
            }
        }


        private HtmlSpan earnings_NotificationMessage;
        public HtmlSpan Earnings_NotificationMessage
        {
            get
            {
                this.earnings_NotificationMessage = new HtmlSpan(this);
                //this.earnings_NotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl39_EmployeeEarnings_NotificationMessage";
                this.earnings_NotificationMessage.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_EmployeeEarnings_NotificationMessage", PropertyExpressionOperator.Contains);
                return this.earnings_NotificationMessage;
            }
        }

    };

    //================================================== Tabs ===================================================================

    public class PayInformationTabHeader : HtmlDiv
    {
        public PayInformationTabHeader(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "_tab";
        }

        private HtmlHyperlink compensation_TabLink;
        public HtmlHyperlink Compensation_TabLink
        {
            get
            {
                this.compensation_TabLink = new HtmlHyperlink(this);
                this.compensation_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Compensation";
                return this.compensation_TabLink;
            }
        }

        private HtmlHyperlink jobs_TabLink;
        public HtmlHyperlink Jobs_TabLink
        {
            get
            {
                this.jobs_TabLink = new HtmlHyperlink(this);
                this.jobs_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Jobs";
                return this.jobs_TabLink;
            }
        }

        private HtmlHyperlink jobAllocation_TabLink;
        public HtmlHyperlink JobAllocation_TabLink
        {
            get
            {
                this.jobAllocation_TabLink = new HtmlHyperlink(this);
                this.jobAllocation_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Job Allocation";
                return this.jobAllocation_TabLink;
            }
        }

        private HtmlHyperlink earnings_TabLink;
        public HtmlHyperlink Earnings_TabLink
        {
            get
            {
                this.earnings_TabLink = new HtmlHyperlink(this);
                this.earnings_TabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Earnings";
                return this.earnings_TabLink;
            }
        }

    };
}

