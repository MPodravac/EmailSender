using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailSender;

namespace WindowsFormsMail
{
    public partial class Form1 : Form
    {
        public string sEmail;
        public string sSubject;
        public string sBody;

        public Form1()
        {
            InitializeComponent();
        }

        private void inptMailTo_TextChanged(object sender, EventArgs e)
        {
            sEmail = inptMailTo.Text;
        }

        private void inptMailTitle_TextChanged(object sender, EventArgs e)
        {
            sSubject = inptMailTitle.Text;
        }

        private void inptMailBody_TextChanged(object sender, EventArgs e)
        {
            sBody = inptMailBody.Text;
        }

        private void btnMailSend_Click(object sender, EventArgs e)
        {
            MailClient MailClient = new MailClient();
            MailClient.SendEmail(sEmail, sSubject, sBody);
        }
    }
}
