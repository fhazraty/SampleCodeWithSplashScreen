using Microsoft.Data.SqlClient;
using System.Reflection;

namespace DataAccessLayer
{
	/// <summary>
	/// کلاس کمک‌کننده برای عملیات پایگاه داده با استفاده از SQL و بازگرداندن نتایج به صورت یک لیست از اشیاء کلاس T
	/// </summary>
	public class SqlHelper<T> where T : class, new()
	{
		/// <summary>
		/// رشته اتصال به پایگاه داده
		/// </summary>
		public string ConnectionString { get; set; }

		/// <summary>
		/// سازنده‌ای که رشته اتصال را دریافت کرده و مقداردهی اولیه می‌کند
		/// </summary>
		/// <param name="connectionString">رشته اتصال به پایگاه داده</param>
		public SqlHelper(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		/// <summary>
		/// اجرای یک کوئری SELECT و بازگرداندن نتایج به صورت لیست از اشیاء کلاس T
		/// </summary>
		/// <param name="query">کوئری SQL برای اجرای SELECT</param>
		/// <returns>لیست نتایج به صورت اشیاء کلاس T</returns>
		public List<T> ReadDataFromDatabase(string query)
		{
			List<T> results = new List<T>();

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					connection.Open();
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							T instance = new T();
							foreach (PropertyInfo prop in typeof(T).GetProperties())
							{
								if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
								{
									prop.SetValue(instance, reader[prop.Name]);
								}
							}
							results.Add(instance);
						}
					}
				}
			}

			return results;
		}

		/// <summary>
		/// اجرای کوئری INSERT برای افزودن داده‌ها به پایگاه داده
		/// </summary>
		/// <param name="query">کوئری SQL برای اجرای INSERT</param>
		/// <param name="parameters">پارامترهای لازم برای کوئری</param>
		/// <returns>تعداد رکوردهای تأثیرگذار</returns>
		public int InsertDataIntoDatabase(string query, Dictionary<string, object> parameters)
		{
			return ExecuteNonQuery(query, parameters);
		}

		/// <summary>
		/// اجرای کوئری UPDATE برای بروزرسانی داده‌ها در پایگاه داده
		/// </summary>
		/// <param name="query">کوئری SQL برای اجرای UPDATE</param>
		/// <param name="parameters">پارامترهای لازم برای کوئری</param>
		/// <returns>تعداد رکوردهای تأثیرگذار</returns>
		public int UpdateDataInDatabase(string query, Dictionary<string, object> parameters)
		{
			return ExecuteNonQuery(query, parameters);
		}

		/// <summary>
		/// اجرای کوئری DELETE برای حذف داده‌ها از پایگاه داده
		/// </summary>
		/// <param name="query">کوئری SQL برای اجرای DELETE</param>
		/// <param name="parameters">پارامترهای لازم برای کوئری</param>
		/// <returns>تعداد رکوردهای تأثیرگذار</returns>
		public int DeleteDataFromDatabase(string query, Dictionary<string, object> parameters)
		{
			return ExecuteNonQuery(query, parameters);
		}

		/// <summary>
		/// اجرای یک کوئری که نیازی به نتیجه ندارد (مانند INSERT، UPDATE یا DELETE)
		/// </summary>
		/// <param name="query">کوئری SQL برای اجرا</param>
		/// <param name="parameters">پارامترهای لازم برای کوئری</param>
		/// <returns>تعداد رکوردهای تأثیرگذار</returns>
		private int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
		{
			int affectedRows = 0;

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					// افزودن پارامترها به کوئری
					if (parameters != null)
					{
						foreach (var param in parameters)
						{
							command.Parameters.AddWithValue(param.Key, param.Value);
						}
					}

					connection.Open();
					// اجرای کوئری و دریافت تعداد رکوردهای تأثیرگذار
					affectedRows = command.ExecuteNonQuery();
				}
			}

			return affectedRows;
		}
	}
}