using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using WebApiAdvance.DAL.EfCore;
using WebApiAdvance.DAL.Repositories.Abstracts;
using WebApiAdvance.DAL.Repositories.Concretes.EFCore;
using WebApiAdvance.DAL.UnitOfWork.Abstracts;
using WebApiAdvance.DAL.UnitOfWork.Concretes;
using WebApiAdvance.Entities.Auth;
using WebApiAdvance.Validators.Products;

namespace WebApiAdvance
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
         
            builder.Services.AddControllers()
                .AddFluentValidation(opt =>
            {
                opt.ImplicitlyValidateChildProperties=true;
                opt.ImplicitlyValidateRootCollectionElements=true;
                opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                //opt.RegisterValidatorsFromAssemblyContaining<CreateProductDtoValidator>();
            })
                .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
); 
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {             
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });
                option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
            });
            builder.Services.AddApiConfigiration(builder.Configuration);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}