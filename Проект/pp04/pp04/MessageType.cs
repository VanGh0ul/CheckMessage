using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp04
{


	public class MessageType
    {
		public const int MIN_STRING_LENGTH = 1;
		public const int MAX_STRING_LENGTH = 255;

		public int Id { get; set; }
		public string Name { get; set; }

		public static ObservableCollection<MessageType> GetMessageTypes()
		{

			MySqlConnection Conn = ConDB.GetMainConnection();
			MySqlCommand Query = Conn.CreateCommand();

			Query.CommandText = "select id, name from messageType";

			ObservableCollection<MessageType> Result = new ObservableCollection<MessageType>();

			MySqlDataReader Reader = null;

			try
			{

				Conn.Open();
				Reader = Query.ExecuteReader();

				while (Reader.Read())
					Result.Add(new MessageType
					{

						Id = Reader.GetInt32("id"),
						Name = Reader.GetString("name"),
	
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

	}
}
