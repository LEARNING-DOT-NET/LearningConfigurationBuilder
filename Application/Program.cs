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
			// SetBasePath & AddJsonFile & Bind needs:
			// using Microsoft.Extensions.Configuration;

			var configurationBuilder =
				new Microsoft.Extensions.Configuration.ConfigurationBuilder()
					.SetBasePath(System.IO.Directory.GetCurrentDirectory())
					.AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true)
					//.AddEnvironmentVariables()
					.Build();

			Settings.ApplicationSettings
				applicationSettings = new Settings.ApplicationSettings();

			configurationBuilder
				.GetSection(key: "Settings")
				.Bind(applicationSettings);

			System.Console.WriteLine($"Age: { applicationSettings.Age }");
			System.Console.WriteLine($"Salary: { applicationSettings.Salary }$");
			System.Console.WriteLine($"Teacher: { applicationSettings.IsTeacher }");
			System.Console.WriteLine($"Full Name: { applicationSettings.FullName }");

			System.Console.WriteLine();
			System.Console.WriteLine($"Courses:");

			foreach (var item in applicationSettings.Courses)
			{
				System.Console.Write($" { item }");
			}

			System.Console.WriteLine();
			System.Console.WriteLine();
			System.Console.WriteLine($"Company:");
			System.Console.WriteLine($" Name: { applicationSettings.Company.Name }");
			System.Console.WriteLine($" Employee Count: { applicationSettings.Company.EmployeeCount }");

			System.Console.WriteLine();
			System.Console.WriteLine();
			System.Console.Write($"Press any key to exit...");
			System.Console.ReadKey();
		}
	}
}
