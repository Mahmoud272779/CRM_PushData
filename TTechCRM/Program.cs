using App.APIs.Swagger;
using App.Core.ServicesDI;
using App.Infrastructure.AppDI;
using Hangfire;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
ServicesDI.AddApplicationDI(builder.Services);
AppDI.AddInfrastructureDI(builder.Services, builder.Configuration);

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "TTECH-CRM", Version = "v1" });
    options.OperationFilter<SwaggerFilter>();
    options.CustomSchemaIds(type => type.ToString().Replace("+", "."));// A solution for The same schemaId is already used for type(bla bla bla )exception
                                                                       //options.DescribeAllEnumsAsStrings();
    //var filePath = Path.Combine("C:\\", "CRM.API.xml");
    //if (!File.Exists(filePath))
    //{
    //    File.Create(filePath).Close();
    //}
    //options.IncludeXmlComments(filePath);

    // Swagger 2.+ support
    var security = new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                    //{"Bearer", new string[] { }},
                };


    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });
    options.AddSecurityRequirement(security);
});

builder.Services.AddMvc().AddNewtonsoftJson(option =>
{
    option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

});
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//}

app.UseRateLimiter();
app.UseDeveloperExceptionPage();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TTech CRM V1/");
    c.DocumentTitle = "TTECH CRM Documentation";
    c.DocExpansion(DocExpansion.None);
});

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseHangfireDashboard("/HangFireDashboard");

app.Run();
