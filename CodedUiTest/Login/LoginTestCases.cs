using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodedUiTest.Base;
//using CodedUiTest.Base;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUiTest.Login
{
    [CodedUITest]
    public class LoginTestCases 
    {
        public LoginControls LoginControls = new LoginControls();

        //==============================================================TEST CASES=====================================================================


        //==============================================================METHODS========================================================================
                
        public void LoginAsAdmin(string clientCode) 
        {
            //LoginControls.LoginBrowserWindow.LoginHtmlDocument.ClientCode.Text = clientCode;
            //LoginControls.LoginBrowserWindow.LoginHtmlDocument.UserName.Text = "Admin";
            //LoginControls.LoginBrowserWindow.LoginHtmlDocument.Password.Text = "FirstOne1?";
            //Mouse.Click(LoginControls.LoginBrowserWindow.LoginHtmlDocument.LoginButton, MouseButtons.Left);
            ///*****************************************************************************************************
            //BrowserWindow Browser = BrowserWindow.Launch("https://empowerpayqa.empowerpay.com");
            BrowserWindow Browser = BrowserWindow.Launch("https://localhost/Empower");
            ////Enter Client Code
            UITestControl ClientCode = new UITestControl(Browser);
            ClientCode.TechnologyName = "Web";
            ClientCode.SearchProperties.Add("ControlType", "Edit");
            ClientCode.SearchProperties.Add("Tagname", "INPUT");
            ClientCode.SearchProperties.Add("FriendlyName", "ClientCodeTextBox");

            if (string.IsNullOrEmpty(clientCode))
            {
                Keyboard.SendKeys(ClientCode, "998");
            }
            else
            {
                Keyboard.SendKeys(ClientCode, clientCode);
                //Keyboard.SendKeys(ClientCode, TestContext.DataRow["ClientID"].ToString());
            }
            //Enter UserID
            UITestControl UserID = new UITestControl(Browser);
            UserID.TechnologyName = "Web";
            UserID.SearchProperties.Add("ControlType", "Edit");
            UserID.SearchProperties.Add("Tagname", "INPUT");
            UserID.SearchProperties.Add("FriendlyName", "UsernameTextBox");
            Keyboard.SendKeys("{TAB}");
            Keyboard.SendKeys(UserID, "ashrestha@empowersoftware.com");
            //Keyboard.SendKeys(UserID, "Admin");
            //Keyboard.SendKeys(UserID, TestContext.DataRow["UserID"].ToString());


            //Enter Password
            UITestControl Password = new UITestControl(Browser);
            Password.TechnologyName = "Web";
            Password.SearchProperties.Add("ControlType", "Edit");
            Password.SearchProperties.Add("Tagname", "INPUT");
            Password.SearchProperties.Add("FriendlyName", "PasswordTextBox");
            Keyboard.SendKeys("{TAB}");
            //Keyboard.SendKeys(Password, "FirstOne1?");
            Keyboard.SendKeys(Password, "Puti123!");
            //Keyboard.SendKeys(Password, TestContext.DataRow["Password"].ToString());


            //Click Signin
            UITestControl SignIn = new UITestControl(Browser);
            SignIn.TechnologyName = "Web";
            SignIn.SearchProperties.Add("ControlType", "Button");
            SignIn.SearchProperties.Add("Tagname", "INPUT");
            SignIn.SearchProperties.Add("ValueAttribute", "Sign In");

            Mouse.Click(SignIn);
            /////this.UIMap.WelcomePageCheck();
            Playback.Wait(10000);
            ////+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        }

        private void SetFocus()
        {
            throw new NotImplementedException();
        }

        public UITestControl Browser { get; set; }
    }
}
