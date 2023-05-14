var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseDeveloperExceptionPage();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	try
	{
        app.UseSwagger();
        app.UseSwaggerUI();
        

    }
	catch (Exception ex)
	{

		var s= ex;
	}
   
}

app.UseAuthorization();

app.MapControllers();

app.Run();
