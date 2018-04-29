using FSMS.Common;
using FSMS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSMS.UI
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoggedDetails.Loginuser = "Admin";
            LoggedDetails.LoggedUserId = 1;
            LoggedDetails.GroupOfCompanyID = 1;

            this.Hide();
            frm_main log = frm_main.getSingleton();
            log.Show();

        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            progressBar1.Show();
            backgroundWorker1.RunWorkerAsync();
            mainpanel.Enabled = false;
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            errorx.Invoke((MethodInvoker)delegate {
                errorx.Visible = false;
                lbl_message.ForeColor = Color.Black;
            });

            int sleeping = 200;
            System.Threading.Thread.Sleep(sleeping);
            lbl_message.Invoke((MethodInvoker)delegate {
                lbl_message.Text = "Initializeing database connection............";
                progressBar1.Value = 20;
            });
         
            if (SecurityRepository.CheckDBConnection())
            {
                System.Threading.Thread.Sleep(sleeping + 800);
                lbl_message.Invoke((MethodInvoker)delegate {
                    lbl_message.Text = "Initializeing System Variables .............";
                    progressBar1.Value = 40;
                });

                System.Threading.Thread.Sleep(sleeping + 400);
                lbl_message.Invoke((MethodInvoker)delegate {
                    lbl_message.Text = "Initializeing User Permission settings .............";
                    progressBar1.Value = 50;
                });
                System.Threading.Thread.Sleep(sleeping + 400);
                lbl_message.Invoke((MethodInvoker)delegate {
                    lbl_message.Text = "System Ready .............";
                    progressBar1.Value = 100;
                    mainpanel.Enabled = true;
                });
                System.Threading.Thread.Sleep(sleeping + 400);
                lbl_message.Invoke((MethodInvoker)delegate {
                    progressBar1.Visible = false;
                    lbl_message.Visible = false;
                });
            }
            else {
                
                lbl_message.Invoke((MethodInvoker)delegate {
                    errorx.Visible = true;
                    lbl_message.Text = "Database Connection Error .............";
                    lbl_message.ForeColor = Color.Red;
                });
                return;
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
