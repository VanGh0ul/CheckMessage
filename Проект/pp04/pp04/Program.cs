using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pp04
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          

            NotifyIcon i = new NotifyIcon();
            i.Visible = true;
            i.Icon = new System.Drawing.Icon(@"C:\Example_pp04\Проект\pp04\message_envelope_icon_176377.ico");
            i.ContextMenuStrip = new ContextMenuStrip();

            i.DoubleClick += new System.EventHandler(i_DoubleClick);

            Form2 frm2;

            void i_DoubleClick(object Sender, EventArgs e) {

                frm2 = new Form2();
                DialogResult dr = frm2.ShowDialog();
                 if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Ok");
                    
                }
               
            }

            i.ContextMenuStrip.Items.Add("Сообщения", null, delegate {

                

                frm2 = new Form2();
                   DialogResult dr = frm2.ShowDialog();
                   if (dr == DialogResult.OK)
                   {
                       MessageBox.Show("Ok");
                   }

            });

            i.ContextMenuStrip.Items.Add("Выход", null, delegate {

                i.Visible = false;
                Application.Exit();
            });

            

             void Alert(string msg, Form_Alert.enmType type)
            {
                Form_Alert frm = new Form_Alert();
                frm.showAlert(msg, type);
            }

            Alert("1", Form_Alert.enmType.Message);
            Alert("2", Form_Alert.enmType.Message);
            Alert("3", Form_Alert.enmType.Message);

            

            /* void button1_Click(object sender, EventArgs e)
            {

                this.Alert("Hi,its John", Form_Alert.enmType.Message);

            }*/



            Application.Run(new Form1());

            Application.Run();
        }
    }
}
