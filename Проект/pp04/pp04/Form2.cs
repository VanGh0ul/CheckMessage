using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace pp04
{
    public partial class Form2 : Form
    {

        public const string PROPGRAM_TYPE_ID = "1";
        public const string BROWSER_TYPE_ID = "2";

        private NotifyIcon TrayIcon;

        /*
        private DataTable Users;
        private string SelectedLogin;
        */
        private Timer MessageTimer;

        private DataTable DbList;
        private string Login;

        public Form2()
        {
            InitializeComponent();

            MessageTimer = new Timer();
            MessageTimer.Tick += TimerTick;
            MessageTimer.Interval = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;

            GenerateNotifyIcon();
            TrayIcon.Visible = true;
        }

        public DataTable GetDbList()
        {

            DataTable Result = new DataTable();

            MySqlConnection Conn = ConDB.GetMainConnection();
            MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from dblist", Conn);

            Adapter.Fill(Result);

            return Result;
        }

        private void UpdateMessageData()
        {

            foreach (DataRow Row in DbList.Rows)
            {

                MySqlConnection Conn = ConDB.GetConnection(
                    Row["server"].ToString(),
                    Row["port"].ToString(),
                    Row["username"].ToString(),
                    Row["password"].ToString(),
                    Row["database_name"].ToString()
                );

                MySqlCommand Query = Conn.CreateCommand();

                Query.CommandText =
                    "select * from `" +
                    Row["message_table_name"] +
                    "` where `" +
                    Row["login_column_name"] +
                    "` like @un";

                Query.Parameters.Add("un", MySqlDbType.VarChar).Value = Login;

                MySqlDataReader Reader = null;

                try
                {

                    Conn.Open();
                    Reader = Query.ExecuteReader();

                    if (Reader.Read())
                    {

                        AlertType AType;

                        if (Row["message_type_id"].ToString() == PROPGRAM_TYPE_ID)

                            AType = AlertType.Program;

                        else
                            AType = AlertType.Web;

                        Alert(Row["database_name"].ToString(), Reader.GetString(Row["count_column_name"].ToString()), AType);

                        LCount.Text = Reader.GetString(Row["count_column_name"].ToString());// table.Rows[0]["message_count"].ToString();
                        LLogin.Text = Reader.GetString(Row["login_column_name"].ToString());// table.Rows[0]["login"].ToString();
                    }
                    else
                    {

                        LCount.Text = "Not found";// table.Rows[0]["message_count"].ToString();
                        LLogin.Text = "Not found";// table.Rows[0]["login"].ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    Reader?.Close();
                    Conn.Close();
                }
            }

            /*
            MySqlConnection Conn = conDB.GetConnection();
            MySqlCommand Query = Conn.CreateCommand();
            Query.CommandText = "select * from messageData where login LIKE concat(\"%\", @un, \"%\")";
            Query.Parameters.Add("un", MySqlDbType.VarChar).Value = SelectedLogin;

            MySqlDataReader Reader = null;

            try
            {

                Conn.Open();
                Reader = Query.ExecuteReader();

                if (Reader.Read())
                {
                    Alert(Reader.GetString("message_count"), Form_Alert.enmType.Message);

                    LCount.Text = Reader.GetString("message_count");// table.Rows[0]["message_count"].ToString();
                    LLogin.Text = Reader.GetString("login");// table.Rows[0]["login"].ToString();
                }
                else 
                {

                    LCount.Text = "Not found";// table.Rows[0]["message_count"].ToString();
                    LLogin.Text = "Not found";// table.Rows[0]["login"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                Reader?.Close();
                Conn.Close();
            }*/
        }

        private void TimerTick(Object s, Object args)
        {

            UpdateMessageData();

            //  MessageBox.Show("Tick");
        }

        private void GenerateNotifyIcon()
        {

            TrayIcon = new NotifyIcon();
            TrayIcon.Icon = Icon.FromHandle(pp04.Properties.Resources.tray_icon.GetHicon());
            TrayIcon.ContextMenuStrip = new ContextMenuStrip();

            TrayIcon.DoubleClick += new System.EventHandler(i_DoubleClick);


            void i_DoubleClick(object Sender, EventArgs e)
            {

                this.Show();

            }

            TrayIcon.ContextMenuStrip.Items.Add("Сообщения", null, delegate
            {

                this.Show();
            });

            TrayIcon.ContextMenuStrip.Items.Add("Выход", null, delegate
            {

                CloseFromTray = true;
                Close();
            });

            TrayIcon.ContextMenuStrip.Items.Add("Alert_test", null, delegate
            {

                Alert("dodik1", "1", AlertType.Program);
                Alert("dodik2", "1", AlertType.Web);
                Alert("dodik3", "1", AlertType.Program);

            });

        }


        private bool CloseFromTray = false;

        private void ClosingToTray(Object s, FormClosingEventArgs args)
        {

            if (!CloseFromTray)
            {
                args.Cancel = true;
                Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {

                DbList = GetDbList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

            DG.DataSource = DbList;

            DG.Columns[0].Width = 20;
        }
        /*
        private DataTable GetDGList()
        {
            DataTable dtList = new DataTable();

            MySqlConnection Conn = new conDB().getConnection();

            MySqlDataAdapter Adapter = new MySqlDataAdapter("select * from user", Conn);

            try {

                Adapter.Fill(dtList);

            } catch(Exception ex) {

                MessageBox.Show(ex.Message);
            } 

            return dtList;
        }

        */



        public void Alert(string title, string msg, AlertType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(title, msg, type);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // this.Alert("Hi,its John",Form_Alert.enmType.Message);

        }

        private void BSetLogin_Click(object sender, EventArgs e)
        {
            Login = tBlogin.Text.Trim();
            UpdateMessageData();
            MessageTimer.Start();
        }


        /*
private void ListDG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
{


   DataRow SelectedRow = Users.Rows[e.RowIndex];

   SelectedLogin = SelectedRow["login"].ToString();

   UpdateMessageData();

   if (!MessageTimer.Enabled)
       MessageTimer.Start();

   //MessageBox.Show();





   for (int i = 0; i < SelectedRow.ItemArray.Length; i++)
       MessageBox.Show(SelectedRow[i].ToString());

}
*/

    }
}
