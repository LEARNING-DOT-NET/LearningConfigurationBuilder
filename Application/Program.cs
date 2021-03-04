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

			Settings.Main
				main = new Settings.Main();

			configurationBuilder
				.GetSection(key: "Settings")
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
