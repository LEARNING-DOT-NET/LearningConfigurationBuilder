Create a new JSON configuration file for your console application and name it appsettings.json:

Add New Item -> Visual C# Items -> Web -> Markup -> JSON File -> appsettings.json

Write some contents to the json file.

Note: Be sure to right-click this file and select properties.
Change the “Copy to Output Directory” option to “Copy if newer”.

Install Below Packages:

Install-Package Microsoft.Extensions.Configuration
Install-Package Microsoft.Extensions.Configuration.Json
Install-Package Microsoft.Extensions.Configuration.Binder
Install-Package Microsoft.Extensions.Configuration.FileExtensions

Optional:

Install-Package Microsoft.Extensions.Configuration.EnvironmentVariables
