using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace pp04
{

    public enum AlertType
    {
        Program,
        Web
    }

    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }
        
        private Form_Alert.enmAction action;

        private int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:

                    timer1.Interval = 4000;
                    action = enmAction.close;
                    break;

                case Form_Alert.enmAction.start:

                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Form_Alert.enmAction.wait;
                        }
                    }

                break;

                case enmAction.close:

                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;

            }
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go lc");
        }

        private void BApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открыть приложение");
            //Открыть приложение
        }

        private void BWeb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открыть веб");
        }

        public void showAlert(string titleStr, string msg, AlertType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {

                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)

                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 25;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 140;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {

                case AlertType.Program:
                    BApp.Visible = true;
                    BWeb.Visible = false;
                    break;

                case AlertType.Web:
                    BApp.Visible = false;
                    BWeb.Visible = true;
                    break;

            }

            this.lblMsg.Text = msg;
            this.LTitle.Text = titleStr;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();


        }

    }
}
