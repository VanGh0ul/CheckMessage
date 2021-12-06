using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int tempNoti = 1;

        private void Form1_Resize(object sender, EventArgs e)
        {
           

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;   

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            notifyIcon1.BalloonTipText = "Messages";
            notifyIcon1.BalloonTipTitle = "1 mess";

            if (tempNoti == 1)
            {
                notifyIcon2.Visible = false;
            }

        }


        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Alert("Hi,its John",Form_Alert.enmType.Message);
        }
    }
}
