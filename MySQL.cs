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
		public bool checkConnection()
		{
			if(connection.State != ConnectionState.Open)
			{
				connect();
			}
			return (connection.State == ConnectionState.Open);
		}
		public void closeConnection()
		{
			if( connection != null )
			{
				connection.Clone();
			}
		}
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
		public void exWithoutResult(string query)
		{
			MySqlCommand command = new MySqlCommand(query, connection);
			checkConnection();
			command.ExecuteNonQuery();
		}
	}
}
