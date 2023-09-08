using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.JWT;
using EasyBank.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace EasyBank.DI
{
    public static class Dependences
    {
        public static void AuthConfig(this IServiceCollection services, WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Easy bank", Version = "v1" });

                var securitySchema = new OpenApiSecurityScheme
                {
                    Description = "Using the Authorization header with the Bearer scheme.",
                    Name = "Auth",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                };

                c.AddSecurityDefinition("Bearer", securitySchema);

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { securitySchema, new[] { "Bearer" } }
                });
            });

            builder.Services.AddAuthentication().AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = JwtData.ISSUER,
                    ValidAudience = JwtData.AUDIENCE,
                    IssuerSigningKey = JwtData.GetSymmetricSecurityKey()
                };
            });
        }

        public static void ScopedInjections(this IServiceCollection services, WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<EmployeeService>();
            builder.Services.AddScoped<EmployeeAuthService>();
            builder.Services.AddScoped<CardService>();

            builder.Services.AddScoped<IPasswordHasher<LoginDto>, PasswordHasher<LoginDto>>();
        }

        public static void DBInjections(this IServiceCollection services, WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("EasyBankDB"));
            });
        }
    }
}
