using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ServerWApp.Models;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var appSettings = configuration.GetSection("AppSettings");

// Add services to the container.


builder.Services.AddControllers();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<FoodContext>(option=>{
    option.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"));
});

builder.Services.AddIdentity<User,Role>().AddEntityFrameworkStores<FoodContext>();


// builder.Services.Configure<IdentityOptions>(options =>{ 
//     options.Password.RequireDigit= true; //sayısal değer
//     options.Password.RequireLowercase= true; //büyük harf
//     options.Password.RequireUppercase= true; //küçük harf
//     // options.Password.RequiredLength= 8; //min 8 karakter

//     // options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromMinutes(5);
//     // options.Lockout.MaxFailedAccessAttempts=5; // 5dk kitli
//     // options.Lockout.AllowedForNewUsers=true;

//     options.User.RequireUniqueEmail= true;
// });



builder.Services.AddIdentity<User, Role>()
.AddEntityFrameworkStores<FoodContext>()
.AddDefaultTokenProviders();

builder.Services.AddScoped<UserManager<User>>();



// builder.Services.AddControllers().AddNewtonsoftJson();

builder.// using Microsoft.AspNetCore.Authentication.Cookies;
Services.AddAuthentication(
    options =>
    {
        options.DefaultAuthenticateScheme= JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme= JwtBearerDefaults.AuthenticationScheme;

    })
    .AddJwtBearer(options =>{
        options.RequireHttpsMetadata= false;
        options.SaveToken= true;//tokeni cookiede sakla
        options.TokenValidationParameters=new TokenValidationParameters{
            ValidateIssuerSigningKey=true,//issuerin anahtarını doğrula
            IssuerSigningKey= new SymmetricSecurityKey(Encoding.ASCII.GetBytes(appSettings["Secret"]))
        };
    });


// CORS ayarları
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});



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

app.UseCors();

app.MapControllers();

app.Run();
