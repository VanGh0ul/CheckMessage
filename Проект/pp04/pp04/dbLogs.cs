using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp04
{
    public class dbLogs
    {
		public string UserLogin { get; set; }
		public string PcName { get; set; }
		public DateTime LogDate { get; set; }
		public int ActionTypeId { get; set; }
		public string ActionTypeName { get; set; }

		public static ObservableCollection<dbLogs> GetDBlogs()
		{

			MySqlConnection Conn = ConDB.GetMainConnection();
			MySqlCommand Query = Conn.CreateCommand();

			Query.CommandText = "select dbL.action_type_id," +
									   "dbL.user_login," +
									   "dbL.pc_name," +
								       "dbL.log_date," +
									"at.name as actionType_name " +
								"from dbLogs dbL inner join actionType at on dbL.action_type_id = at.id ";

			ObservableCollection<dbLogs> Result = new ObservableCollection<dbLogs>();

			MySqlDataReader Reader = null;

			try
			{

				Conn.Open();
				Reader = Query.ExecuteReader();

				while (Reader.Read())
					Result.Add(new dbLogs
					{

						UserLogin = Reader.GetString("user_login"),
						PcName = Reader.GetString("pc_name"),
						LogDate = Reader.GetDateTime("log_date"),
						ActionTypeId = Reader.GetInt32("action_type_id"),
						ActionTypeName = Reader.GetString("actionType_name")

					});

			}
			catch
			{

				throw new Exception("Произошла ошибка при получении списка отделений");

			}
			finally
			{

				Reader?.Close();
				Conn.Close();
			}

			return Result;
		}


		public void Insert()
		{
			ValidateDel();

			MySqlConnection Conn = ConDB.GetMainConnection();
			MySqlCommand Query = Conn.CreateCommand();

			Query.CommandText =
				"INSERT INTO dbLogs" +
				"(user_login, pc_name, log_date,action_type_id) " +
				"VALUES (" +
					"@user_login," +
					"@pc_name," +
					"@log_date," +
					"@action_type_id" +
				")";

			Query.Parameters.Add("@user_login", MySqlDbType.VarChar).Value = UserLogin;
			Query.Parameters.Add("@pc_name", MySqlDbType.VarChar).Value = PcName;
			Query.Parameters.Add("@log_date", MySqlDbType.DateTime).Value = LogDate;
			Query.Parameters.Add("@action_type_id", MySqlDbType.VarChar).Value = ActionTypeId;

			try
			{

				Conn.Open();
				Query.ExecuteNonQuery();

			}
			catch (Exception ex)
			{

				throw new Exception("Произошла ошибка при добавлении базы\n\n" + ex.Message);

			}
			finally
			{

				Conn.Close();
			}
		}

		private void ValidateDel()
		{
			if (UserLogin == String.Empty)
				throw new Exception(String.Format("Для подтверждения установите логин в поле логина"));

		}
		

	}
}
