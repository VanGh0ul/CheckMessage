using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

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

        public static DateTime Now;

        public string Login;

        private ObservableCollection<MessageType> MessageTypes;
        private ObservableCollection<DBList> Databases;

        private DataGridViewTextBoxColumn GenerateColumn(string name, string source) {

            DataGridViewTextBoxColumn NewColumn = new DataGridViewTextBoxColumn();
            NewColumn.HeaderText = name;
            NewColumn.DataPropertyName = source;

            return NewColumn;
        }

        private void GenerateGrid() {

            DG.AutoGenerateColumns = false;

            DG.Columns.AddRange(
                GenerateColumn("№", "Id"),
                GenerateColumn("Сервер", "Server"),
                GenerateColumn("Имя БД", "DatabaseName"),
                GenerateColumn("Права", "Username"),
                GenerateColumn("Пароль", "Password"),
                GenerateColumn("Порт", "Port"),
                GenerateColumn("Имя таблицы", "MessageTableName"),
                GenerateColumn("Логин в таблице", "LoginColumnName"),
                GenerateColumn("Таблица с сообщениями", "CountColumnName"),
                GenerateColumn("Тип", "MessageTypeName")

            );
        }

        public Form2()
        {
            InitializeComponent();

            MessageTimer = new Timer();
            MessageTimer.Tick += TimerTick;
            MessageTimer.Interval = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;

            GenerateNotifyIcon();
            TrayIcon.Visible = true;

            GenerateGrid();
        }
        
        private void UpdateMessageData()
        {

            foreach (DBList Db in Databases)
            {

                MySqlConnection Conn = ConDB.GetConnection(
                    Db.Server,
                    Db.Port,
                    Db.Username,
                    Db.Password,
                    Db.DatabaseName
                );

                MySqlCommand Query = Conn.CreateCommand();

                Query.CommandText =
                    "select * from `" +
                    Db.MessageTableName +
                    "` where `" +
                    Db.LoginColumnName +
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

                        if (Db.MessageTypeId.ToString() == PROPGRAM_TYPE_ID)

                            AType = AlertType.Program;

                        else
                            AType = AlertType.Web;

                        Alert(Db.DatabaseName, Reader.GetString(Db.CountColumnName), AType);

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

        private void RefreshGrid()
        {

            try
            {

                Databases = DBList.GetDbList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

            DG.DataSource = Databases;
            DG.Columns[0].Width = 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {

                MessageTypes = MessageType.GetMessageTypes();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

            CbMessageTypes.DisplayMember = "Name";
            CbMessageTypes.DataSource = MessageTypes;

            RefreshGrid();
        }



        public void Alert(string title, string msg, AlertType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(title, msg, type);
        }

      

        //Установка логина
        private void BSetLogin_Click(object sender, EventArgs e)
        {

            ValidateLogin();
            try
            {
                Login = tBlogin.Text.Trim();

                UpdateMessageData();
                MessageTimer.Start();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ValidateLogin()
        {
            if (Login == String.Empty)
            {
                MessageBox.Show("Установите логин в поле логина");
                return;
            }
                
        }


        //Добавить
        private void BAdd_Click(object sender, EventArgs e)
        {
            Validate();

            Now = DateTime.Now;

            MessageType SelectedType = (MessageType)CbMessageTypes.SelectedItem;

            if (SelectedType == null)
            {

                MessageBox.Show("Выберите тип сообщения");
                return;
            }

            try
            {

                new DBList
                {

                    Server = tBSrvIp.Text.Trim(),

                    DatabaseName = tBDBname.Text.Trim(),

                    Username = tBUsername.Text.Trim(),

                    Password = tBDBpass.Text.Trim(),

                    Port = tBDBport.Text.Trim(),

                   
                    LoginColumnName = tBLoginColTabName.Text.Trim(),
                    CountColumnName = tBCountColName.Text.Trim(),

                    MessageTableName = tBTableName.Text.Trim(),
                    MessageTypeId = SelectedType.Id

                }.Insert();

                //создание логов
                new dbLogs
                {
                    UserLogin = tBlogin.Text.Trim(),
                    PcName = Environment.MachineName.Trim(),
                    LogDate = Now,
                    ActionTypeId = 1

                }.Insert();

                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Не все данные введены",ex.Message);
                return;
            }

            RefreshGrid();
        }


        //Удалить
        private void BDel_Click(object sender, EventArgs e)
        {
           

            Now = DateTime.Now;

           
            if (MessageBox.Show("Подтверждение", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                List<DBList> SelectedItems = new List<DBList>();

                foreach (DataGridViewCell Cell in DG.SelectedCells) {

                    SelectedItems.Add((DBList)(Cell.OwningRow).DataBoundItem);
                }

                

                try
                {
                    
                    DBList.DeleteAll(SelectedItems);

                    new dbLogs
                    {
                        UserLogin = tBlogin.Text.Trim(),
                        PcName = Environment.MachineName.Trim(),
                        LogDate = Now,
                        ActionTypeId = 2

                    }.Insert();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        
            RefreshGrid();

        }

   

    }
}
