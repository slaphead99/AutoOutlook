using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using TestStack.White;
using TestStack.White.UIItems.Finders;
using TestStack.White.Factory;
using System.Runtime.InteropServices;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Threading;
using System.Linq;

namespace OutlookUIExampleTest
{
   // [TestClass]
    public class UnitTest1
    {
       // [TestMethod]
        public void TestMethod1()
        {
            // launch Outlook 2016 x86
            var outlookPath = Path.Combine(
              Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
            @"Microsoft Office\root\Office16\OUTLOOK.EXE");


            // launch Outlook 2013 x64
            //var outlookPath = Path.Combine(
            //  Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
            //@"Microsoft Office\Office15\OUTLOOK.EXE");


            var application = Application.Launch(outlookPath);

            // get explorer window
            //var explorer = application.GetWindow(
            //    SearchCriteria.ByClassName("rctrl_renwnd32"),
            //    InitializeOption.NoCache);


            // rctrl_renwnd32

            var explorer = application.GetWindow(
            SearchCriteria.ByClassName("rctrl_renwnd32"),
            InitializeOption.NoCache);

            // click "New E-mail" button to start composing new email
            //explorer.Get(SearchCriteria.ByText("New Email")).Click();

            explorer.Get(SearchCriteria.ByAutomationId("FileTabButton")).Click();


            explorer.Get(SearchCriteria.ByText("Open & Export")).Click();



            //// give Outlook time 
            Thread.Sleep(TimeSpan.FromSeconds(2));

            //NetUIStickyButton
            //  explorer.Get(SearchCriteria.ByText("Import/Export")).Click();
            explorer.Get(SearchCriteria.ByClassName("NetUIStickyButton").AndByText("Import/Export")).Click();


            //// give Outlook time 
            //Thread.Sleep(TimeSpan.FromSeconds(2));

            //impex.DoubleClick();

            explorer.Get(SearchCriteria.ByText("Export to a file")).Click();


            explorer.Get(SearchCriteria.ByText("Next >")).Click();



            explorer.Get(SearchCriteria.ByText("Next >")).Click();


            //TODO switch to Tasks - an ddnt forget teh OK
            explorer.Get(SearchCriteria.ByText("Tasks")).DoubleClick();

            //explorer.Get(SearchCriteria.ByText("Inbox")).DoubleClick();


            explorer.Get(SearchCriteria.ByText("Next >")).Click();



            //explorer.Get(SearchCriteria.ByText("Yes")).Click();


            explorer.Get(SearchCriteria.ByAutomationId("6")).Click();


            explorer.Get(SearchCriteria.ByText("Finish")).Click();



            explorer.Get(SearchCriteria.ByText("OK")).Click();




            //            explorer.Get(SearchCriteria.ByText(" Export")).Click();



            //// get composer window
            //var composer = application.GetWindow(
            //    SearchCriteria.ByClassName("rctrl_renwnd32").AndByText("Untitled - Message (HTML) "),
            //    InitializeOption.NoCache);            

            //// fill out "To" field
            //var toField = composer.Get(SearchCriteria.ByClassName("RichEdit20WPT").AndByText("To"));
            //toField.Enter("someone@example.com");

            //// fill out "Subject" field  class= RichEdit20WPT
            ////var subjectField = composer.Get(SearchCriteria.ByClassName("RichEdit20WPT").AndByText("Subject:"));
            //var subjectField = composer.Get(SearchCriteria.ByClassName("RichEdit20WPT").AndByText("Subject"));


            //subjectField.Enter("automated UI email");

            ////COntrolID = 00001005

            //// change focus to get Outlook process registered in running object table
            //// https://social.msdn.microsoft.com/Forums/office/en-US/0d8f9642-50bc-4656-af32-84d62068305d/outlook-2010-and-registering-in-the-running-object-table?forum=outlookdev
            //var windows = WindowFactory.Desktop.DesktopWindows();
            //var desktop = windows.Last().GetElement(SearchCriteria.ByClassName("SysListView32"));
            //desktop.SetFocus();

            //Outlook.Application outlookCom = Marshal.GetActiveObject("Outlook.Application") as Outlook.Application;

            //var sentMailItem = outlookCom.ActiveInspector().CurrentItem as Outlook.MailItem;
            //var body = sentMailItem.HTMLBody;
            //var index = body.IndexOf(@"</body", StringComparison.InvariantCultureIgnoreCase);
            //sentMailItem.HTMLBody = body.Insert(index, "this email was sent via automated UI");


            //composer.Get(SearchCriteria.ByText("Send").AndByClassName("Button")).Click();

            //// give Outlook time to send off the email
            //Thread.Sleep(TimeSpan.FromSeconds(5));

            application.WaitWhileBusy();
            explorer.Close();
        }
    }
}
