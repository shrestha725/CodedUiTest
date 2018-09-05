using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodedUiTest.Base;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUiTest.Login
{
    public class LoginControls
    {
        private LoginBrowserWindow loginBrowserWindow;

        public LoginBrowserWindow LoginBrowserWindow
        {
            get
            {
                this.loginBrowserWindow = new LoginBrowserWindow();
                return this.loginBrowserWindow;
            }
        }        
    }

    //========================================================================================================================================

    public class LoginBrowserWindow : BrowserWindow 
    {
        private LoginHtmlDocument loginHtmlDocument;

        public LoginBrowserWindow()
        {            
            //this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
        }

        public LoginHtmlDocument LoginHtmlDocument
        {
            get
            {
                this.loginHtmlDocument = new LoginHtmlDocument(this);
                return this.loginHtmlDocument;
            }
        }        
    };

    //========================================================================================================================================

    public class LoginHtmlDocument : HtmlDocument
    {
        private HtmlEdit clientCode;
        private HtmlEdit userName;
        private HtmlEdit password;
        private HtmlInputButton loginButton; 

        public LoginHtmlDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {                                
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Empower Software™ - Sign On Page";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Empower/Default.aspx";            
            this.WindowTitles.Add("Empower Software™ - Sign On Page");            
        }
                
        public HtmlEdit ClientCode
        {
            get
            {
                this.clientCode = new HtmlEdit(this);
                this.clientCode.SearchProperties[HtmlEdit.PropertyNames.Id] = "ClientCodeTextBox";
                return this.clientCode;
            }
        }
        public HtmlEdit UserName
        {
            get
            {
                this.userName = new HtmlEdit(this);
                this.userName.SearchProperties[HtmlEdit.PropertyNames.Id] = "LoginUserName";
                return this.userName;
            }
        }
        public HtmlEdit Password 
        {
            get
            {
                this.password = new HtmlEdit(this);
                this.password.SearchProperties[HtmlEdit.PropertyNames.Id] = "LoginPassword";
                return this.password;
            }
        }
        public HtmlInputButton LoginButton
        {
            get
            {
                this.loginButton = new HtmlInputButton(this);
                this.loginButton.SearchProperties[HtmlButton.PropertyNames.Id] = "LoginButton";
                return this.loginButton;
            }
        }  
    };
     
}
