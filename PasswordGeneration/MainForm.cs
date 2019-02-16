using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Outlook = Microsoft.Office.Interop.Outlook;

namespace PasswordGeneration {
    public partial class MainForm :Form {

        public MainForm() {
            InitializeComponent();
        }

        #region generate password
        public static string PasswordGenerator() {
            string Password = String.Empty;

            return Password;
        }
        #endregion

        #region Send email and reset server password
        public void GeneratePW_Click(object sender, EventArgs e) {
            string password = PasswordGenerator();
            int ifDone = SendEmail( password );

            if( ifDone == 1 ) {
                MessageBox.Show( "Email is sent succesfully", "Secure Me notification" );
                WriteLog( String.Format( "The email is successfully sent with your new password ({0})", password ) );
            } else {
                MessageBox.Show( "Email was not sent", "Secure Me notification" );
                WriteLog( "The email was not send" );
            }

            // TODO: Check upon passwords reset
            // get back to Hossam Barmawy
        }
        #endregion

        #region Send an Email with the new password
        public static int SendEmail(string password) {
            try {
                // Create the Outlook application.
                Outlook.Application oApp = new Outlook.Application();

                // Create a new mail item.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem( Outlook.OlItemType.olMailItem );

                // Set HTMLBody. 
                //add the body of the email
                oMsg.HTMLBody = String.Format( "Dear All, a new password was created upon your request ({0}) on ({1}).", password, GetTime() );

                //Subject line
                oMsg.Subject = "New password";

                // Add a recipient.
                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;

                // Change the recipient in the next line if necessary
                string ToEmail = "hossam.elbarmawy@ecs-co.com";
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add( ToEmail );
                oRecip.Resolve();

                // Send.
                ( (Outlook._MailItem)oMsg ).Send();
                WriteLog( String.Format( "Email sent to ({0}) asking for new password ({1}) on ({2}) .", ToEmail, password, GetTime() ) );
                System.Threading.Thread.Sleep( 1000 );

                return 1;
            } catch( Exception exc ) {
                WriteLog( String.Format( "Error in email sending was due to: {0}", exc.ToString() ) );
                return 0;
            }
        }
        #endregion

        #region Write log for successfull and unsuccessful events
        public static void WriteLog(string text) {
            string dirName = Path.GetDirectoryName( Assembly.GetExecutingAssembly().GetName().CodeBase ) + "\\log.txt";
            string localPath = new Uri( dirName ).LocalPath;
            using( StreamWriter sw = new StreamWriter( localPath, true ) ) {
                // write to file at localPath ( log.txt )
                sw.Write( Environment.NewLine + text + Environment.NewLine );
            }
        }
        #endregion

        #region Get current Date & Time
        public static string GetTime() {
            // return current date and time
            return DateTime.Now.ToString();
        }
        #endregion

    }
}

/*
 * SendEmail(String Password) related 
Add an attachment.
String sDisplayName = "MyAttachment";
int iPosition = (int)oMsg.Body.Length + 1;
int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
now attached the file
Outlook.Attachment oAttach = oMsg.Attachments.Add( @"C:\\fileName.jpg", iAttachType, iPosition, sDisplayName );
*/