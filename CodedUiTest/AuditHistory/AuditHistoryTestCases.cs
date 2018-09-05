using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodedUiTest.Base;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUiTest.AuditHistory
{
    public class AuditHistoryTestCases
    {        
        public AuditHistoryControls AuditHistoryControls = new AuditHistoryControls();

        //==============================================================TEST CASES=====================================================================


        //==============================================================METHODS========================================================================

        public void ExpandAuditHistory()
        {
            if (AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryDiv.ExpandButton.Exists)
            {
                Mouse.Click(AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryDiv.ExpandButton, MouseButtons.Left);
            }
        }

        public void CollapseAuditHistory() 
        {
            if (AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryDiv.CollapseButton.Exists)
            {
                Mouse.Click(AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryDiv.CollapseButton, MouseButtons.Left);
            }
        }

        public string GetMostRecentAuditHistoryItem(string itemType)
        {
            //EffectiveDate
            //Activity
            //Changed By
            //Change Date

            string itemValue = "";

            switch(itemType){
                case("EffectiveDate"): itemValue = AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryTable.FirstRowEffectiveDateCell.InnerText;
                    //string nothing = "";
                    break;
                case ("Activity"): itemValue = AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryTable.FirstRowActivityCell.InnerText;
                    break;
                case ("Changed By"): itemValue = AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryTable.FirstRowChangedByCell.InnerText;
                    break;
                case ("Change Date"): itemValue = AuditHistoryControls.EmpowerBrowserWindow.EmpowerHtmlDocument.AdminHtmlDocumentFrame.AdminHtmlDocument.AuditHistoryTable.FirstChangedDateCell.InnerText;
                    break;
            }
            return itemValue;
        }
    }
}
