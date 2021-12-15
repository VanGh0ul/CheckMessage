using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp04
{
    public class DBList
    {
        public const int MIN_STRING_LENGTH = 1;
        public const int MAX_STRING_LENGTH = 255;

		public int Id { get; set; }
		public string Server { get; set; }
		public string DatabaseName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Port { get; set; }
		public string MessageTableName { get; set; }
		public string LoginColumnName { get; set; }
		public string CountColumnName { get; set; }
		public int MessageTypeId { get; set; }
		public string MessageTypeName { get; set; }


		public static ObservableCollection<DBList> GetDbList()
		{

			MySqlConnection Conn = ConDB.GetMainConnection();
			MySqlCommand Query = Conn.CreateCommand();
			Query.CommandText = "select db.id,db.message_type_id,db.server,db.database_name,db.username,db.password," +
									   "db.port,db.message_table_name,db.login_column_name,db.count_column_name," +
									   "mt.name as messageType_name " +
									   "from DBList db inner join messageType mt on db.message_type_id = mt.id ";

			ObservableCollection<DBList> Result = new ObservableCollection<DBList>();

			MySqlDataReader Reader = null;

			try
			{

				Conn.Open();
				Reader = Query.ExecuteReader();

				while (Reader.Read())
					Result.Add(new DBList
					{

						Id = Reader.GetInt32("id"),
						Server = Reader.GetString("server"),
						DatabaseName = Reader.GetString("database_name"),
						Username = Reader.GetString("username"),
						Password = Reader.GetString("password"),
						Port = Reader.GetString("port"),
						MessageTableName = Reader.GetString("message_table_name"),
						LoginColumnName = Reader.GetString("login_column_name"),
						CountColumnName = Reader.GetString("count_column_name"),
						MessageTypeId = Reader.GetInt32("message_type_id"),
						MessageTypeName = Reader.GetString("messageType_name")



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

			private void Validate()
			{

				if (Server == String.Empty || Server.Length < MIN_STRING_LENGTH || Server.Length > MAX_STRING_LENGTH)
					throw new Exception(String.Format("Ip должно содержать от {0} до {1} символов", MIN_STRING_LENGTH, MAX_STRING_LENGTH));

				if (DatabaseName == String.Empty || DatabaseName.Length < MIN_STRING_LENGTH || DatabaseName.Length > MAX_STRING_LENGTH)
					throw new Exception(String.Format("Имя БД должно содержать от {0} до {1} символов", MIN_STRING_LENGTH, MAX_STRING_LENGTH));

				if (Username == String.Empty || Username.Length < MIN_STRING_LENGTH || Username.Length > MAX_STRING_LENGTH)
					throw new Exception(String.Format("Права должны содержать от {0} до {1} символов", MIN_STRING_LENGTH, MAX_STRING_LENGTH));

				if (Password == String.Empty || Password.Length < MIN_STRING_LENGTH || Password.Length > MAX_STRING_LENGTH)
					throw new Exception(String.Format("Пароль должно содержать от {0} до {1} символов", MIN_STRING_LENGTH, MAX_STRING_LENGTH));

				if (Port == String.Empty || Port.Length < MIN_STRING_LENGTH || Port.Length > MAX_STRING_LENGTH)
					throw new Exception(String.Format("Имя должно содержать от {0} до {1} символов", MIN_STRING_LENGTH, MAX_STRING_LENGTH));

				if (MessageTableName == String.Empty || MessageTableName.Length < MIN_STRING_LENGTH || MessageTableName.Length > MAX_STRING_LENGTH)
					throw new Exception(String.Format("Имя таблицы должно содержать от {0} до {1} символов", MIN_STRING_LENGTH, MAX_STRING_LENGTH));

				if (LoginColumnName == String.Empty || LoginColumnName.Length < MIN_STRING_LENGTH || LoginColumnName.Length > MAX_STRING_LENGTH)
					throw new Exception(String.Format("Название таблицы с логином должно содержать от {0} до {1} символов", MIN_STRING_LENGTH, MAX_STRING_LENGTH));

				if (CountColumnName == String.Empty || CountColumnName.Length < MIN_STRING_LENGTH || CountColumnName.Length > MAX_STRING_LENGTH)
					throw new Exception(String.Format("Название поля таблицы с сообщениями должно содержать от {0} до {1} символов", MIN_STRING_LENGTH, MAX_STRING_LENGTH));

				if (MessageTypeName == String.Empty)
					throw new Exception(String.Format("Выбирите 1 из пунктов в типах сообщения"));

		}

		public void Insert()
		{

			Validate();

			MySqlConnection Conn = ConDB.GetMainConnection();
			MySqlCommand Query = Conn.CreateCommand();
			
			Query.CommandText = 
				"INSERT INTO DBList" +
				"(server, port, username, password, database_name,message_table_name,login_column_name,count_column_name,message_type_id) " +
				"VALUES (" +
					"@server," +
					"@port," +
					"@username," +
					"@password," +
					"@database_name," +
					"@message_table_name," +
					"@login_column_name," +
					"@count_column_name," +
					"@message_type_id" +
				")";

			Query.Parameters.Add("@server", MySqlDbType.VarChar).Value = Server;
			Query.Parameters.Add("@port", MySqlDbType.VarChar).Value = Port;
			Query.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username;
			Query.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
			Query.Parameters.Add("@database_name", MySqlDbType.VarChar).Value = DatabaseName;
			Query.Parameters.Add("@message_table_name", MySqlDbType.VarChar).Value = MessageTableName;
			Query.Parameters.Add("@login_column_name", MySqlDbType.VarChar).Value = LoginColumnName;
			Query.Parameters.Add("@count_column_name", MySqlDbType.VarChar).Value = CountColumnName;
			Query.Parameters.Add("@message_type_id", MySqlDbType.Int32).Value = MessageTypeId;

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

		public void Delete()
		{

			MySqlConnection Conn = ConDB.GetMainConnection();
			MySqlCommand QueryDBlist = Conn.CreateCommand();


			QueryDBlist.CommandText = "delete from DBList where id = @id";
			QueryDBlist.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;

			try
			{

				Conn.Open();
				QueryDBlist.ExecuteNonQuery();

			}
			catch (Exception ex)
			{

				throw new Exception("Произошла ошибка при удалении отделения\n\n" + ex.Message);

			}
			finally
			{

				Conn.Close();
			}
		}

		public static void DeleteAll(IList<DBList> dbLists)
		{

			if (dbLists.Count > 0)
			{

				MySqlConnection Conn = ConDB.GetMainConnection();
				MySqlCommand Query = Conn.CreateCommand();

				// Составление массива ид удаляемых студентов
				string IdParamArray = "(@id0";
				Query.Parameters.Add("id0", MySqlDbType.Int32).Value = dbLists[0].Id;

				for (int i = 1; i < dbLists.Count; i++)
				{

					string NewIdName = "@id" + i.ToString();

					IdParamArray = String.Join(", ", IdParamArray, NewIdName);
					Query.Parameters.Add(NewIdName, MySqlDbType.Int32).Value = dbLists[i].Id;
				}

				IdParamArray += ")";

				Query.CommandText = "delete from DBList where id in " + IdParamArray;

				try
				{

					Conn.Open();
					Query.ExecuteNonQuery();

				}
				catch (Exception ex)
				{

					throw new Exception("Произошла ошибка при удалении бд\n\n" + ex.Message);

				}
				finally
				{

					Conn.Close();
				}
			}
		}





	}
}
