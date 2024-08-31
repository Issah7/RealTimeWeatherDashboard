# RealTimeWeatherDashboard
Project Requirements:
1. Backend: ASP.NET core MVC
2. Frontend: HTML, CSS, JavaScript, Bootstrap for styling.
3. API Integration: Use a third-party weather API to fetch real-time weather data (e.g., OpenWeatherMap, WeatherAPI).

Create a New ASP.NET Core MVC Project:
1. Open Visual Studio.
2. Select "Create a new project."
3. Choose "ASP.NET Core Web Application" and choose "ASP.NET Core Web App (Model-View-Controller" template and click "Next."
4. Name your project "Your Desired Name".
5. Chose the location you want to save the project and click "Next"
6. Framework ".NET8.0(Long Term Support) and leave the rest to default and "Create"

Set Up API Integration
Register for a Weather API Key:
1. Go to a weather API provider like OpenWeatherMap or WeatherAPI.
2. Sign up and obtain an API key.

Create a Service for Weather API Integration:
1. In Visual Studio, create a new folder named Services.
2. Add a new class named WeatherService.cs
3. Make sure to replace "YOUR_API_KEY" with your actual API key.

Create the Weather Data Model
1. In the Models folder add a new class named 'WeatherData.cs'

Install Newtonsoft.Json Package:
Install the Newtonsoft.Json package via NuGet Package Manager to handle JSON deserialization

Create the Weather Controller or you can use the HomeController

Register the Service in Program.cs:
Add the following to the ConfigureServices method:
1. builder.Services.AddHttpClient<WeatherService>();

Edit the index.cshtml page in the Views folder

Create the Partial View:
In the shared folder, create a _WeatherPartial.cshtml:
