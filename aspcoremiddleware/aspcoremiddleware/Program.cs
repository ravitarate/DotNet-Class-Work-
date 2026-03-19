var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");


// custom middleware 

app.Use(async (context,next)=>
 {
     await context.Response.WriteAsync("hello ravi");
     await next(context);
 });

app.Run(async (context)=>
{ await context.Response.WriteAsync("hel ravi");
});
