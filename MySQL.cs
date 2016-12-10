using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Zverev_Kursova_OBD
{
	/// <summary>
	/// Description of MySQL.
	/// </summary>
	public class MySQL
	{
		public static MySqlConnection connection;
		protected static MySqlConnectionStringBuilder connectionString;

		public MySQL()
		{
			connection = new MySqlConnection();
		}

		~MySQL()
		{
			closeConnection();
		}

/**
* Підключення до сервера
*/
		public void connect(string server = "", string user = "", string password = "", string database = "")
		{
			if( connectionString == null )
			{
				connectionString = new MySqlConnectionStringBuilder();
				connectionString.Server = server;
				connectionString.UserID = user;
				connectionString.Password = password;
				connectionString.Database = database;
			}
			connection.ConnectionString = connectionString.ConnectionString;
			connection.Open();
		}

/**
* Перевірка статусу з'єднання. Якщо з'єднання не відкрите, виконується повторне підключення
*/
		public bool checkConnection()
		{
			if(connection.State != ConnectionState.Open)
			{
				connect();
			}
			return (connection.State == ConnectionState.Open);
		}
		/**
* Закриття з'єднання
*/
		public void closeConnection()
		{
			if( connection != null )
			{
				connection.Clone();
			}
		}

/**
* Виконання операції з результатом (капітан очевидність каже, що це SELECT. нєжданчік, правда?)
*
* Об'єкт типу DataTable можна одразу вказувати в якості значення властивості DataSource для dataGridView
*/
		public DataTable exWithResult(string query)
		{
			MySqlCommand command = new MySqlCommand(query, connection);
			DataTable result = new DataTable();
			checkConnection();
			MySqlDataReader reader = command.ExecuteReader();
			if( reader.HasRows )
			{
				result.Load(reader);
			}
			return result;
		}
/**
* Виконання операції, що не повертає результату (INSERT, UPDATE, ALTER і т.д.)
*/
		public void exWithoutResult(string query)
		{
			MySqlCommand command = new MySqlCommand(query, connection);
			checkConnection();
			command.ExecuteNonQuery();
		}
	}
}
