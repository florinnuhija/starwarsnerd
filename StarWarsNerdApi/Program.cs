using StarWarsNerdApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000") // Allow the frontend origin
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

// Add controller services
builder.Services.AddControllers();

// Swagger/OpenAPI setup
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Star Wars service
builder.Services.AddHttpClient<IStarWarsService, StarWarsService>();

var app = builder.Build();

// Use CORS
app.UseCors("AllowFrontend");

// Middleware to handle routing
app.UseRouting();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use HTTPS redirection if needed
// app.UseHttpsRedirection();

// Use authorization if needed (can be removed if not required)
app.UseAuthorization();

// Map controller routes
app.MapControllers();

app.Run();