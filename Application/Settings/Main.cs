namespace Application.Settings
{
	public class Main : object
	{
		public const string KeyName = "Settings";

		public Main() : base()
		{
		}

		public int Age { get; set; }

		public float Salary { get; set; }

		public bool IsTeacher { get; set; }

		public string FullName { get; set; }

		public Company Company { get; set; }

		public string[] Courses { get; set; }
	}
}
