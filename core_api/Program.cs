
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*
app.MapGet("/sk", async context =>
{
    await context.Response.WriteAsync("Hello from SKCore!");
});

*/

/*
// Middleware in the main pipeline
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Main Middleware Executed before Map. ");
    await next(); // Pass to the next middleware
});

// Map-specific middleware for '/testmap' path
app.Map("/testmap", MapCustomMiddleware);

void MapCustomMiddleware(IApplicationBuilder builder)
{
    builder.Use(async (context, next) =>
    {
        await context.Response.WriteAsync("Map Middleware 1 Executed for /testmap. ");
        await next(); // No other middleware after this in the Map branch
    });

    builder.Use(async (context, next) =>
    {
        await context.Response.WriteAsync("Map Middleware 2 Executed for /testmap. ");
        await next(); // No other middleware after this in the Map branch
    });
}

*/


/*
app.Use(async (context, next) =>
{

    await context.Response.WriteAsync("Inline (Use) Middleware Executed 1 ");
    await next(); // Pass to the next middleware

});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Inline (Use) Middleware Executed 2\n");
    await next(); // Pass to the next middleware
});

app.Run(async (context) =>
{

    await context.Response.WriteAsync("Inline (Run) Middleware Executed 1 ");

});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Inline (Run) Middleware Executed 2\n");
});
*/


/*
app.MapWhen(context => context.Request.Path.StartsWithSegments("/admin"), adminApp =>
{
    adminApp.Use(async (context, next) =>
    {
        // Middleware for requests that match "/admin"
        await context.Response.WriteAsync("Admin path accessed. ");
        await next(); // Call next middleware in the branch
    });
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Main pipeline executed. ");
    await next();
});
*/


/*
app.UseWhen(context => context.Request.Path.StartsWithSegments("/admin"), adminApp =>
{
    adminApp.Use(async (context, next) =>
    {
        // Middleware for requests that match "/admin"
        await context.Response.WriteAsync("Admin path accessed. ");
        await next(); // Call next middleware in the branch
    });
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Main pipeline executed. ");
    await next();
});
*/


/*
 
 app.MapWhen(context => context.Request.Path.StartsWithSegments("/secure"), secureApp =>
{
    secureApp.UseWhen(context => context.Request.Query.ContainsKey("token"), tokenApp =>
    {
        tokenApp.Use(async (context, next) =>
        {
            // Middleware for secure paths with a token query parameter
            await context.Response.WriteAsync("Secure area accessed with token. ");
            await next();
        });
    });

    secureApp.Use(async (context, next) =>
    {
        await context.Response.WriteAsync("Secure area accessed without token. ");
        await next();
    });
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Main pipeline executed. ");
    await next();
});

*/


/* .NET 8

app.MapGet("/hello", () => "Hello SKWorld !!").ShortCircuit();

app.MapGet("/_health", () => Results.Ok()).ShortCircuit();

app.MapShortCircuit(404, "/notfound");

*/


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
