using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp04
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // monitorDB.WriteFirst();

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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String nameUser = login.Text;

            conDB db = new conDB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from user where name = @un", db.getConnection());
            
            command.Parameters.Add("@un",MySqlDbType.VarChar).Value = nameUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }




        }
    }
}
