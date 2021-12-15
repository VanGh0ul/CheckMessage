using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp04
{
    public class ActionType
    {
		public const int MIN_STRING_LENGTH = 1;
		public const int MAX_STRING_LENGTH = 255;

		public int Id { get; set; }
		public string Name { get; set; }

		public static ObservableCollection<ActionType> GetActionTypes()
		{

			MySqlConnection Conn = ConDB.GetMainConnection();
			MySqlCommand Query = Conn.CreateCommand();

			Query.CommandText = "select id, name from actionType";

			ObservableCollection<ActionType> Result = new ObservableCollection<ActionType>();

			MySqlDataReader Reader = null;

			try
			{

				Conn.Open();
				Reader = Query.ExecuteReader();

				while (Reader.Read())
					Result.Add(new ActionType
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

		private void Validate()
		{

			if (Name.Length < MIN_STRING_LENGTH || Name.Length > MAX_STRING_LENGTH)
				throw new Exception(String.Format("Имя должно содержать от {0} до {1} символов", MIN_STRING_LENGTH, MAX_STRING_LENGTH));
		}

	
	}
}
