using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;
using WebApiAdvance.DAL.EfCore;
using WebApiAdvance.DAL.UnitOfWork.Abstracts;
using WebApiAdvance.DAL.UnitOfWork.Concretes;
using WebApiAdvance.Entities.Auth;

namespace WebApiAdvance;

public static class ConfigurationService
{
    public static IServiceCollection AddApiConfigiration(this IServiceCollection services,IConfiguration configuration)
    {
        TokenOption tokenOption = configuration.GetSection("TokenOptions").Get<TokenOption>();
        services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("Default"));
        });
       services.AddAutoMapper(Assembly.GetExecutingAssembly());
       services.AddIdentity<AppUser, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
       services.AddAuthentication(opt =>
        {
            opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(opt =>
        {
            opt.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = tokenOption.Issuer,
                ValidAudience = tokenOption.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOption.SecurityKey)),
            };
        });
       services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
