using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using CodedUiTest.Base;

namespace CodedUiTest.EmployeeIdentification
{
  
    public class EmployeeIdentificationControls
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
        private EmployeeIdentificationScreen employeeIdentificationScreen; 

        public AdminHtmlDocumentFrame(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "Home";
        }

        public EmployeeIdentificationScreen EmployeeIdentificationScreen
        {
            get
            {
                this.employeeIdentificationScreen = new EmployeeIdentificationScreen(this);
                return this.employeeIdentificationScreen; 
            }
        }
    };

    public class EmployeeIdentificationScreen : HtmlDocument
    {
        //==================================================Personal Fields===============================================================

        private HtmlEdit firstName;
        private HtmlEdit middleInitial;
        private HtmlEdit lastName;
        private HtmlEdit namePrefix;
        private HtmlEdit nameSuffix;
        private HtmlEdit prefferedName;
        private HtmlEdit birthName;
        private HtmlEdit gender;
        private HtmlEdit maritalStatus;
        private HtmlEdit birthDate;
        private HtmlEdit age;
        private HtmlEdit birthCountry;
        private HtmlEdit birthPlace;
        private HtmlSpan personalNotificationMessage; 

        public EmployeeIdentificationScreen(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/Secured/Admin/AdminManager.aspx";
        }

        //==================================================Tab Header===============================================================

        private EmployeeIdentificationTabHeader employeeIdentificationTabHeader;

        public EmployeeIdentificationTabHeader EmployeeIdentificationTabHeader
        {
            get
            {
                this.employeeIdentificationTabHeader = new EmployeeIdentificationTabHeader(this);
                return this.employeeIdentificationTabHeader;
            }
        }

        //==================================================Personal===============================================================

        public HtmlEdit Personal_FirstName
        {
            get
            {
                this.firstName = new HtmlEdit(this);
                //this.firstName.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl" + TestBase.GetTabValue() + "E_Identification_FirstName";
                this.firstName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Identification_FirstName",PropertyExpressionOperator.Contains);
                return this.firstName;
            }
        }
        public HtmlEdit Personal_MiddleInitial
        {
            get
            {
                this.middleInitial = new HtmlEdit(this);
                this.middleInitial.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_MiddleInitial";
                return this.middleInitial;
            }
        }
        public HtmlEdit Personal_LastName
        {
            get
            {
                this.lastName = new HtmlEdit(this);
                //this.lastName.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_LastName";
                this.lastName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_E_Identification_LastName", PropertyExpressionOperator.Contains);
                return this.lastName;
            }
        }
        public HtmlEdit Personal_NamePrefix 
        {
            get
            {
                this.namePrefix = new HtmlEdit(this);
                this.namePrefix.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_NamePrefix"; 
                return this.namePrefix;
            }
        }
        public HtmlEdit Personal_NameSuffix
        {
            get 
            {
                this.nameSuffix = new HtmlEdit(this);
                this.nameSuffix.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_NameSuffix";
                return this.nameSuffix;
            }
        }
        public HtmlEdit Personal_PrefferedName
        {
            get
            {
                this.prefferedName = new HtmlEdit(this);
                this.prefferedName.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_PreferredGivenName";
                return this.prefferedName;
            }
        }
        public HtmlEdit Personal_BirthName 
        {
            get
            {
                this.birthName = new HtmlEdit(this);
                this.birthName.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_BirthName";
                return this.birthName;
            }
        }
        public HtmlEdit Personal_Gender 
        {
            get
            {
                this.gender = new HtmlEdit(this);
                this.gender.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_GenderCode_Input";
                return this.gender;
            }
        }
        public HtmlEdit Personal_MaritalStatus
        {
            get
            {
                this.maritalStatus = new HtmlEdit(this);
                this.maritalStatus.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_MaritalStatusCode_Input"; 
                return this.maritalStatus;
            }
        }
        public HtmlEdit Personal_BirthDate
        {
            get
            {
                this.birthDate = new HtmlEdit(this);
                this.birthDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_BirthDate";
                return this.birthDate;
            }
        }
        public HtmlEdit Personal_Age
        {
            get
            {
                this.age = new HtmlEdit(this);
                this.age.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_Age";
                return this.age;
            }
        }
        public HtmlEdit Personal_BirthCountry
        {
            get
            {
                this.birthCountry = new HtmlEdit(this);
                this.birthCountry.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_BirthCountryCode_Input";
                return this.birthCountry;
            }
        }
        public HtmlEdit Personal_BirthPlace
        {
            get
            {
                this.birthPlace = new HtmlEdit(this);
                this.birthPlace.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl25_E_Identification_BirthPlace";
                return this.birthPlace;
            }
        }
        public HtmlSpan Personal_PersonalNotificationMessage
        {
            get
            {
                this.personalNotificationMessage = new HtmlSpan(this);
                this.personalNotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl25_EmployeeIdentification_NotificationMessage";
                return this.personalNotificationMessage;
            }
        }

        //==================================================Address Fields===============================================================

        private HtmlEdit streetAddressLine1;
        private HtmlEdit streetAddressLine2;
        private HtmlEdit streetAddressLine3;
        private HtmlEdit city;
        private HtmlEdit county;
        private HtmlEdit state;
        private HtmlEdit postalCode;
        private HtmlEdit muncipality;
        private HtmlEdit province;
        private HtmlEdit schoolDistrict;
        private HtmlSpan addressNotificationMessage; 

        public HtmlEdit Address_StreetAddressLine1 
        {
            get
            {
                this.streetAddressLine1 = new HtmlEdit(this);
                //this.streetAddressLine1.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_StreetAddressLine1";//  old value
                this.streetAddressLine1.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl24_E_Address_StreetAddressLine1";
                return this.streetAddressLine1;
            }
        }
        public HtmlEdit Address_StreetAddressLine2
        {
            get
            {
                this.streetAddressLine2 = new HtmlEdit(this);
                this.streetAddressLine2.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_StreetAddressLine2";
                return this.streetAddressLine2;
            }
        }
        public HtmlEdit Address_StreetAddressLine3
        {
            get
            {
                this.streetAddressLine3 = new HtmlEdit(this);
                this.streetAddressLine3.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_StreetAddressLine3";
                return this.streetAddressLine3;
            }
        }
        public HtmlEdit Address_City 
        {
            get
            {
                this.city = new HtmlEdit(this);
                this.city.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_City";
                return this.city;
            }
        }
        public HtmlEdit Address_County
        {
            get
            {
                this.county = new HtmlEdit(this);
                this.county.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_County_Input";
                return this.county;
            }
        }
        public HtmlEdit Address_State
        {
            get
            {
                this.state = new HtmlEdit(this);
                this.state.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_StateCode_Input";
                return this.state;
            }
        }
        public HtmlEdit Address_PostalCode
        {
            get
            {
                this.postalCode = new HtmlEdit(this);
                this.postalCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_PostalCode";
                return this.postalCode;
            }
        }
        public HtmlEdit Address_Muncipality
        {
            get
            {
                this.muncipality = new HtmlEdit(this);
                this.muncipality.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_MunicipalityCode_Input";
                return this.muncipality;
            }
        }
        public HtmlEdit Address_Province
        {
            get 
            {
                this.province = new HtmlEdit(this);
                this.province.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_ProvinceCode_Input";
                return this.province;
            }
        }
        public HtmlEdit Address_SchoolDistrict
        {
            get
            {
                this.schoolDistrict = new HtmlEdit(this);
                this.schoolDistrict.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl29_E_Address_SchoolDistrictNumber_Input";
                return this.schoolDistrict;
            }
        }
        public HtmlSpan Address_AddressNotificationMessage 
        {
            get
            {
                this.addressNotificationMessage = new HtmlSpan(this);
                this.addressNotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl29_EmployeeHomeAddress_NotificationMessage";
                return this.addressNotificationMessage;
            }
        }

        //==================================================National ID===============================================================

        private HtmlEdit nationalIdNumber;
        private HtmlEdit i9StatusCode;       
        private HtmlCheckBox rightToWork;
        private HtmlEdit docACode;
        private HtmlEdit docAIssuingAuthority;
        private HtmlEdit docANumber;
        private HtmlEdit docAExpirationDate;
        private HtmlEdit docA2Number;
        private HtmlEdit docA2ExpirationDate;
        private HtmlEdit docBCode;
        private HtmlEdit docBIssuingAuthority;
        private HtmlEdit docBNumber;
        private HtmlEdit docBExpirationDate;
        private HtmlEdit docCCode;
        private HtmlEdit docCIssuingAuthority;
        private HtmlEdit docCNumber;
        private HtmlEdit docCExpirationDate;
        private HtmlSpan nationalIdNotificationMessage;

        public HtmlEdit NationalId_NationalIdNumber 
        {
            get
            {
                this.nationalIdNumber = new HtmlEdit(this);
                this.nationalIdNumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_NationalIDNumber";
                return this.nationalIdNumber;
            }
        }
        public HtmlEdit NationalId_I9StatusCode
        {
            get
            {
                this.i9StatusCode = new HtmlEdit(this);
                this.i9StatusCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_I_9_StatusCode_Input";
                return this.i9StatusCode;
            }
        }
        public HtmlCheckBox NationalId_RightToWork
        {
            get
            {
                this.rightToWork = new HtmlCheckBox(this);
                this.rightToWork.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl34_E_NationalID_RightToWork";
                return this.rightToWork;
            }
        }
        public HtmlEdit NationalId_DocACode
        {
            get
            {
                this.docACode = new HtmlEdit(this);
                this.docACode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocACode_Input";
                return this.docACode;
            }
        }
        public HtmlEdit NationalId_DocAIssuingAuthority
        {
            get
            {
                this.docAIssuingAuthority = new HtmlEdit(this);
                this.docAIssuingAuthority.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocAIssuingAuthority";
                return this.docAIssuingAuthority;
            }
        }
        public HtmlEdit NationalId_DocANumber
        {
            get
            {
                this.docANumber = new HtmlEdit(this);
                this.docANumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocANumber";
                return this.docANumber;
            }
        }
        public HtmlEdit NationalId_DocAExpirationDate
        {
            get
            {
                this.docAExpirationDate = new HtmlEdit(this);
                this.docAExpirationDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocAExpirationDate";
                return this.docAExpirationDate;
            }
        }
        public HtmlEdit NationalId_DocA2Number
        {
            get
            {
                this.docA2Number = new HtmlEdit(this);
                this.docA2Number.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocA2Number";
                return this.docA2Number;
            }
        }
        public HtmlEdit NationalId_DocA2ExpirationDate
        {
            get
            {
                this.docA2ExpirationDate = new HtmlEdit(this);
                this.docA2ExpirationDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocA2ExpirationDate";
                return this.docA2ExpirationDate;
            }
        }
        public HtmlEdit NationalId_DocBCode
        {
            get
            {
                this.docBCode = new HtmlEdit(this);
                this.docBCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocBCode_Input";
                return this.docBCode;
            }
        }
        public HtmlEdit NationalId_DocBIssuingAuthority 
        {
            get
            {
                this.docBIssuingAuthority = new HtmlEdit(this);
                this.docBIssuingAuthority.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocBIssuingAuthority";
                return this.docBIssuingAuthority;
            }
        }
        public HtmlEdit NationalId_DocBNumber
        {
            get
            {
                this.docBNumber = new HtmlEdit(this);
                this.docBNumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocBNumber";
                return this.docBNumber;
            }
        }
        public HtmlEdit NationalId_DocBExpirationDate
        {
            get
            {
                this.docBExpirationDate = new HtmlEdit(this);
                this.docBExpirationDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocBExpirationDate";
                return this.docBExpirationDate;
            }
        }
        public HtmlEdit NationalId_DocCCode
        {
            get
            {
                this.docCCode = new HtmlEdit(this);
                this.docCCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocCCode_Input";
                return this.docCCode;
            }
        }
        public HtmlEdit NationalId_DocCIssuingAuthority
        {
            get
            {
                this.docCIssuingAuthority = new HtmlEdit(this);
                this.docCIssuingAuthority.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocCIssuingAuthority";
                return this.docCIssuingAuthority;
            }
        }
        public HtmlEdit NationalId_DocCNumber
        {
            get
            {
                this.docCNumber = new HtmlEdit(this);
                this.docCNumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocCNumber";
                return this.docCNumber;
            }
        }
        public HtmlEdit NationalId_DocCExpirationDate
        {
            get
            {
                this.docCExpirationDate = new HtmlEdit(this);
                this.docCExpirationDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl34_E_NationalID_DocCExpirationDate";
                return this.docCExpirationDate;
            }
        }
        public HtmlSpan NationalId_NationalIdNotificationMessage 
        {
            get
            {
                this.nationalIdNotificationMessage = new HtmlSpan(this);
                this.nationalIdNotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl34_EmployeeNationalID_NotificationMessage";
                return this.nationalIdNotificationMessage;
            }
        }

        //==================================================Status===================================================================

        private HtmlEdit eventCode;
        private HtmlEdit statusReasonCode;
        private HtmlEdit projectedEndDate;
        private HtmlEdit originalHireDate;
        private HtmlEdit lengthOfServiceHireDate;
        private HtmlEdit dateOfLastHire;
        private HtmlEdit lengthOfServiceLastHire; 
        private HtmlEdit continuousServiceDate;
        private HtmlEdit lenghtOfServiceContinuousService;
        private HtmlEdit seniorityDate;
        private HtmlEdit medicalEligibilityDate; 
        private HtmlEdit lastServiceAwardDate;
        private HtmlEdit comments;
        private HtmlEdit bargainingUnitServiceDate;
        private HtmlEdit terminationDate;
        private HtmlEdit retiredDate;
        private HtmlEdit deceasedDate;
        private HtmlCheckBox withPay;
        private HtmlCheckBox supressBenefits;
        private HtmlCheckBox onProbation;
        private HtmlCheckBox supressAccurals; 
        private HtmlEdit accuralEligibilityDate;
        private HtmlSpan statusNotificationMessage;

        public HtmlEdit Status_EventCode
        {
            get
            {
                this.eventCode = new HtmlEdit(this);
                this.eventCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_EventCode_Input";
                return this.eventCode;
            }
        }
        public HtmlEdit Status_StatusReasonCode
        {
            get
            {
                this.statusReasonCode = new HtmlEdit(this);
                this.statusReasonCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_StatusReasonCode_Input";
                return this.statusReasonCode;
            }
        }
        public HtmlEdit Status_ProjectedEndDate
        {
            get
            {
                this.projectedEndDate = new HtmlEdit(this);
                this.projectedEndDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_ProjectedEndDate";
                return this.projectedEndDate;
            }
        }
        public HtmlEdit Status_OriginalHireDate
        {
            get
            {
                this.originalHireDate = new HtmlEdit(this);
                this.originalHireDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_OriginalHireDate";
                return this.originalHireDate;
            }
        }
        public HtmlEdit Status_LengthOfServiceHireDate
        {
            get
            {
                this.lengthOfServiceHireDate = new HtmlEdit(this);
                this.lengthOfServiceHireDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_LOSOriginalHireDate";
                return this.lengthOfServiceHireDate;
            }
        }
        public HtmlEdit Status_DateOfLastHire
        {
            get
            {
                this.dateOfLastHire = new HtmlEdit(this);
                this.dateOfLastHire.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_DateOfLastHire";
                return this.dateOfLastHire;
            }
        }
        public HtmlEdit Status_LengthOfServiceLastHire
        {
            get
            {
                this.lengthOfServiceLastHire = new HtmlEdit(this);
                this.lengthOfServiceLastHire.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_LOSDateOfLastHire";
                return this.lengthOfServiceLastHire;
            }
        }
        public HtmlEdit Status_ContinuousServiceDate
        {
            get
            {
                this.continuousServiceDate = new HtmlEdit(this);
                this.continuousServiceDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_ContinuousServiceDate";
                return this.continuousServiceDate;
            }
        }
        public HtmlEdit Status_LenghtOfServiceContinuousService
        {
            get
            {
                this.lenghtOfServiceContinuousService = new HtmlEdit(this);
                this.lenghtOfServiceContinuousService.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_LOSContinuousServiceDate";
                return this.lenghtOfServiceContinuousService;
            }
        }
        public HtmlEdit Status_SeniorityDate
        {
            get
            {
                this.seniorityDate = new HtmlEdit(this);
                this.seniorityDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_SeniorityDate";
                return this.seniorityDate;
            }
        }
        public HtmlEdit Status_MedicalEligibilityDate
        {
            get
            {
                this.medicalEligibilityDate = new HtmlEdit(this);
                this.medicalEligibilityDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_MedInsEligDate";
                return this.medicalEligibilityDate;
            }
        }
        public HtmlEdit Status_LastServiceAwardDate
        {
            get
            {
                this.lastServiceAwardDate = new HtmlEdit(this);
                this.lastServiceAwardDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_LastServiceAwardDate";
                return this.lastServiceAwardDate;
            }
        }
        public HtmlEdit Status_Comments
        {
            get
            {
                this.comments = new HtmlEdit(this);
                this.comments.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_Comments";
                return this.comments;
            }
        }
        public HtmlEdit Status_BargainingUnitServiceDate
        {
            get
            {
                this.bargainingUnitServiceDate = new HtmlEdit(this);
                this.bargainingUnitServiceDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_BargainingUnitServiceDate";
                return this.bargainingUnitServiceDate;
            }
        }
        public HtmlEdit Status_TerminationDate
        {
            get
            {
                this.terminationDate = new HtmlEdit(this);
                this.terminationDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_TerminationDate";
                return this.terminationDate;
            }
        }
        public HtmlEdit Status_RetiredDate
        {
            get
            {
                this.retiredDate = new HtmlEdit(this);
                this.retiredDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_RetiredDate";
                return this.retiredDate;
            }
        }
        public HtmlEdit Status_DeceasedDate
        {
            get
            {
                this.deceasedDate = new HtmlEdit(this);
                this.deceasedDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_DeceasedDate";
                return this.deceasedDate;
            }
        }
        public HtmlCheckBox Status_WithPay 
        {
            get
            {
                this.withPay = new HtmlCheckBox(this);
                this.withPay.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl39_E_Status_WithPay";
                return this.withPay;
            }
        }
        public HtmlCheckBox Status_supressBenefits
        {
            get
            {
                this.supressBenefits = new HtmlCheckBox(this);
                this.supressBenefits.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl39_E_Status_SuppressBenefits";
                return this.supressBenefits;
            }
        }
        public HtmlCheckBox Status_OnProbation
        {
            get
            {
                this.onProbation = new HtmlCheckBox(this);
                this.onProbation.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl39_E_Status_OnProbation";
                return this.onProbation;
            }
        }
        public HtmlCheckBox Status_SupressAccurals
        {
            get
            {
                this.supressAccurals = new HtmlCheckBox(this);
                this.supressAccurals.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl39_E_Status_SuppressAccruals";
                return this.supressAccurals;
            }
        }
        public HtmlEdit Status_AccuralEligibilityDate
        {
            get
            {
                this.accuralEligibilityDate = new HtmlEdit(this);
                this.accuralEligibilityDate.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl39_E_Status_AccrualEligibilityDate";
                return this.accuralEligibilityDate;
            }
        }
        public HtmlSpan Status_StatusNotificationMessage
        {
            get
            {
                this.statusNotificationMessage = new HtmlSpan(this);
                this.statusNotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl39_EmployeeStatus_NotificationMessage";
                return this.statusNotificationMessage;
            }
        }

        //==================================================Communication===================================================================

        private HtmlEdit contactName;
        private HtmlEdit telephone;
        private HtmlEdit extensionNumber;
        private HtmlCheckBox publishTelephone;
        private HtmlEdit emailAddress;
        private HtmlCheckBox publishEmail;
        private HtmlEdit pager;
        private HtmlCheckBox publishPager;
        private HtmlEdit mobilePhone;
        private HtmlCheckBox publishMobile;
        private HtmlSpan communicationNotificationMessage;

        public HtmlEdit Communication_ContactName
        {
            get
            {
                this.contactName = new HtmlEdit(this);
                this.contactName.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl43_E_Communication_ContactName";
                return this.eventCode;
            }
        }
        public HtmlEdit Communication_Telephone
        {
            get
            {
                this.telephone = new HtmlEdit(this);
                this.telephone.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl43_E_Communication_Telephone";
                return this.telephone;
            }
        }
        public HtmlEdit Communication_ExtensionNumber
        {
            get
            {
                this.extensionNumber = new HtmlEdit(this);
                this.extensionNumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl43_E_Communication_ExtensionNumber";
                return this.extensionNumber;
            }
        }
        public HtmlCheckBox Communication_PublishTelephone
        {
            get
            {
                this.publishTelephone = new HtmlCheckBox(this);
                this.publishTelephone.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl43_E_Communication_PublishTelephone";
                return this.publishTelephone;
            }
        }
        public HtmlEdit Communication_EmailAddress
        {
            get
            {
                this.emailAddress = new HtmlEdit(this);
                this.emailAddress.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl43_E_Communication_EmailAddress";
                return this.emailAddress;
            }
        }
        public HtmlCheckBox Communication_PublishEmail
        {
            get
            {
                this.publishEmail = new HtmlCheckBox(this);
                this.publishEmail.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl43_E_Communication_PublishEmail";
                return this.publishEmail;
            }
        }
        public HtmlEdit Communication_Pager
        {
            get
            {
                this.pager = new HtmlEdit(this);
                this.pager.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl43_E_Communication_Pager";
                return this.pager;
            }
        }
        public HtmlCheckBox Communication_PublishPager 
        {
            get
            {
                this.publishPager = new HtmlCheckBox(this);
                this.publishPager.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl43_E_Communication_Pager";
                return this.publishPager;
            }
        }
        public HtmlEdit Communication_MobilePhone
        {
            get
            {
                this.mobilePhone = new HtmlEdit(this);
                this.mobilePhone.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl43_E_Communication_MobilePhone";
                return this.mobilePhone;
            }
        }
        public HtmlCheckBox Communication_PublishMobile
        {
            get
            {
                this.publishMobile = new HtmlCheckBox(this);
                this.publishMobile.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl43_E_Communication_PublishMobile";
                return this.publishMobile;
            }
        }
        public HtmlSpan Communication_CommunicationNotificationMessage
        {
            get
            {
                this.communicationNotificationMessage = new HtmlSpan(this);
                this.communicationNotificationMessage.SearchProperties[HtmlSpan.PropertyNames.Id] = "ctl43_EmployeeCommunication_NotificationMessage";
                return this.communicationNotificationMessage;
            }
        }
    };

    public class EmployeeIdentificationTabHeader : HtmlDiv
    {
        private HtmlHyperlink personalTabLink;
        private HtmlHyperlink addresslTabLink;
        private HtmlHyperlink nationalIdTabLink;
        private HtmlHyperlink statusTabLink;
        private HtmlHyperlink communicationTabLink;

        public EmployeeIdentificationTabHeader(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "_tab";
        }

        public HtmlHyperlink PersonalTabLink 
        {
            get
            {
                this.personalTabLink = new HtmlHyperlink(this);
                this.personalTabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Personal";
                return this.personalTabLink;
            }
        }
        public HtmlHyperlink AddresslTabLink
        {
            get
            {
                this.addresslTabLink = new HtmlHyperlink(this);
                this.addresslTabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Address";
                return this.addresslTabLink;
            }
        }
        public HtmlHyperlink NationalIdTabLink
        {
            get
            {
                this.nationalIdTabLink = new HtmlHyperlink(this);
                this.nationalIdTabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "NationalID / I-9";
                return this.nationalIdTabLink;
            }
        }
        public HtmlHyperlink StatusTabLink
        {
            get
            {
                this.statusTabLink = new HtmlHyperlink(this);
                this.statusTabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Status";
                return this.statusTabLink;
            }
        }
        public HtmlHyperlink CommunicationTabLink
        {
            get
            {
                this.communicationTabLink = new HtmlHyperlink(this);
                this.communicationTabLink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Communication";
                return this.communicationTabLink;
            }
        }
    }; 
}
