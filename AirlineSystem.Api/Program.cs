using AirlineSystem.Api.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace AirlineSystem.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddCors(option =>
            {
                option.AddPolicy("AllowReactApp",
                  builder =>
                  {
                      builder.WithOrigins("http://localhost:3000")
                             .WithHeaders(new string[]
                             {

                                 HeaderNames.ContentType,
                                 HeaderNames.Authorization
                             })
                      .AllowAnyMethod();
                  }
                );
            });
            builder.Services.AddControllers().AddJsonOptions(x=>x.JsonSerializerOptions
            .ReferenceHandler = ReferenceHandler.IgnoreCycles);
            builder.Services.AddDependencyInjectConfigurations();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAuthentication(options =>
            {
                // add defaultAuthenitactionShema
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            { 
                // this domain name is from Auth0
                x.Authority = "dev-wnt15nmdmsxmosuh.us.auth0.com";
                x.Audience ="Airline-booking-apis.com";
            });

            var app = builder.Build();

            // Configure the HTTP  request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors("AllowReactApp");

            app.MapControllers();

            app.Run();
        }
    }
}
