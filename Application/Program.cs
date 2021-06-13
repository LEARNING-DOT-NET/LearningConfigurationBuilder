using Microsoft.Extensions.Configuration;

namespace Application
{
	public static class Program
	{
		static Program()
		{
		}

		public static void Main()
		{
			// **************************************************
			var configurationBuilderTraditional =
				new Microsoft.Extensions.Configuration.ConfigurationBuilder()
					.SetBasePath(basePath: System.IO.Directory.GetCurrentDirectory())
					.AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true)
					//.AddEnvironmentVariables()
					.Build();

			string employeeCountString =
				configurationBuilderTraditional
				.GetSection(key: "Settings")
				.GetSection(key: "Company")
				.GetSection(key: "EmployeeCount")
				.Value
				;

			int employeeCount = 0;

			if (string.IsNullOrEmpty(employeeCountString) == false)
			{
				try
				{
					employeeCount =
						System.Convert.ToInt32(employeeCountString);
				}
				catch
				{
				}
			}
			// **************************************************

			// SetBasePath & AddJsonFile & Bind needs:
			// using Microsoft.Extensions.Configuration;

			var configurationBuilder =
				new Microsoft.Extensions.Configuration.ConfigurationBuilder()
					.SetBasePath(basePath: System.IO.Directory.GetCurrentDirectory())
					.AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true)
					//.AddEnvironmentVariables()
					.Build();

			var main = new Settings.Main();

			//configurationBuilder
			//	.GetSection(key: "Settings")
			//	.Bind(main);

			configurationBuilder
				.GetSection(key: Settings.Main.KeyName)
				.Bind(main);

			System.Console.WriteLine($"Age: { main.Age }");
			System.Console.WriteLine($"Salary: { main.Salary }$");
			System.Console.WriteLine($"Teacher: { main.IsTeacher }");
			System.Console.WriteLine($"Full Name: { main.FullName }");

			System.Console.WriteLine();
			System.Console.WriteLine($"Courses:");

			foreach (var item in main.Courses)
			{
				System.Console.Write($" { item }");
			}

			System.Console.WriteLine();
			System.Console.WriteLine();
			System.Console.WriteLine($"Company:");
			System.Console.WriteLine($" Name: { main.Company.Name }");
			System.Console.WriteLine($" Employee Count: { main.Company.EmployeeCount }");

			System.Console.WriteLine();
			System.Console.WriteLine();
			System.Console.Write($"Press any key to exit...");
			System.Console.ReadKey();
		}
	}
}
