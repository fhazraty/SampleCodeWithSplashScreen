using DataAccessLayer;
using Model;
using System.Text;
using System.Text.Json;

namespace BusinessLayer
{
	public class StudentHelper
	{
		// ذخیره لیست به فرمت JSON
		public static void SaveAsJson(string filePath, List<Student> students)
		{
			var json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
			File.WriteAllText(filePath, json);
		}

		// بازیابی لیست از فرمت JSON
		public static List<Student> LoadFromJson(string filePath)
		{
			if (!File.Exists(filePath))
			{
				throw new FileNotFoundException("JSON file not found.");
			}

			var json = File.ReadAllText(filePath);
			return JsonSerializer.Deserialize<List<Student>>(json);
		}

		// ذخیره لیست به فرمت CSV به صورت دستی
		public static void SaveAsCsv(string filePath, List<Student> students)
		{
			var csv = new StringBuilder();

			// اضافه کردن سرستون‌ها
			csv.AppendLine("Firstname,Lastname,Age,StudentNo,Gender,Major");

			// اضافه کردن اطلاعات هر دانش‌آموز
			foreach (var student in students)
			{
				csv.AppendLine($"{student.Firstname},{student.Lastname},{student.Age},{student.StudentNo},{student.Gender},{student.Major}");
			}

			File.WriteAllText(filePath, csv.ToString());
		}

		// بازیابی لیست از فرمت CSV به صورت دستی
		public static List<Student> LoadFromCsv(string filePath)
		{
			if (!File.Exists(filePath))
			{
				throw new FileNotFoundException("CSV file not found.");
			}

			var students = new List<Student>();
			var lines = File.ReadAllLines(filePath);

			// پرش از سرستون‌ها (خط اول)
			foreach (var line in lines.Skip(1))
			{
				var values = line.Split(',');

				var student = new Student
				{
					Firstname = values[0],
					Lastname = values[1],
					Age = int.Parse(values[2]),
					StudentNo = values[3],
					Gender = (Gender)Enum.Parse(typeof(Gender), values[4]),
					Major = values[5]
				};

				students.Add(student);
			}

			return students;
		}

		// ذخیره لیست دانشجویان در پایگاه داده
		public static void SaveToDatabase(string connectionString, List<Student> students)
		{
			var sqlHelper = new SqlHelper<Student>(connectionString);

			sqlHelper.DeleteDataFromDatabase("DELETE FROM [dbo].[Students];", null);

			foreach (var student in students)
			{
				var query = "INSERT INTO Students (Firstname, Lastname, Age, StudentNo, Gender, Major) VALUES (@Firstname, @Lastname, @Age, @StudentNo, @Gender, @Major);";

				var parameters = new Dictionary<string, object>
				{
					{"@Firstname", student.Firstname},
					{"@Lastname", student.Lastname},
					{"@Age", student.Age},
					{"@StudentNo", student.StudentNo},
					{"@Gender", student.Gender.ToString()},
					{"@Major", student.Major}
				};

				sqlHelper.InsertDataIntoDatabase(query, parameters);
			}
		}

		// بارگذاری لیست دانشجویان از پایگاه داده
		public static List<Student> LoadFromDatabase(string connectionString)
		{
			var sqlHelper = new SqlHelper<Student>(connectionString);
			var query = "SELECT Firstname, Lastname, Age, StudentNo, Gender, Major FROM Students";

			return sqlHelper.ReadDataFromDatabase(query);
		}
	}
}
