using varsity_nest_dotnet_backend.Services;

var builder = WebApplication.CreateBuilder(args);

// Registers MVC/API controllers with the application.
// This allows classes such as HealthController to receive HTTP requests.
builder.Services.AddControllers();
builder.Services.AddScoped<AccommodationService>();

// Adds the services required to generate Swagger documentation.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Builds the application using all the services we registered above.
var app = builder.Build();

// Only expose Swagger while developing the application.
// We do not necessarily want development tooling exposed in production.
if (app.Environment.IsDevelopment())
{
    // Generates the OpenAPI specification.
    app.UseSwagger();

    // Provides the browser-based Swagger UI.
    app.UseSwaggerUI();
}

// Redirects HTTP requests to HTTPS when HTTPS is configured.
app.UseHttpsRedirection();

// Enables ASP.NET Core authorization middleware.
// We will actually configure authentication and roles later.
app.UseAuthorization();

// Connects our controller classes to the application's request pipeline.
// Without this, /api/health would not reach HealthController.
app.MapControllers();

// Starts the web server and waits for incoming HTTP requests.
app.Run();