
	App.Config
	Web.Config

	XML

		AppSettings:

			<appsettings>
				<add key="Age" value="20" />
			</appsettings>

			Flat Based!

	string ageString =
		System.Configuration.ConfigurationManager.Settings["Age"];

	int age = 0;

	if(string.IsNullOrEmpty(ageString) = false)
	{
		try
		{
			age =
				System.Convert.ToInt32(ageString);
		}
		catch
		{
		}
	}

-----------------------------------------------------------------------------------------

Create a new JSON configuration file for your console application and name it appsettings.json:

Add New Item -> Visual C# Items -> Web -> Markup -> JSON File -> appsettings.json

Write some contents to the json file.

Note: Be sure to right-click this file and select properties.
Change the “Copy to Output Directory” option to “Copy if newer”.

Install Below Packages:

Install-Package Microsoft.Extensions.Configuration.Binder

Install-Package Microsoft.Extensions.Configuration.Json
	Install-Package Microsoft.Extensions.Configuration

Install-Package Microsoft.Extensions.Configuration.FileExtensions
	Install-Package Microsoft.Extensions.Configuration

Optional:

Install-Package Microsoft.Extensions.Configuration.EnvironmentVariables
