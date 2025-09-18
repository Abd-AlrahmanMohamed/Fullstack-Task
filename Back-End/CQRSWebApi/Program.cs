using CQRSWebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register validators from the assembly where your validators are defined.



var configuration = builder.Configuration;
builder.Services.AddApiDependencies(configuration);
builder.Services.AddHandlerDependencie();
builder.Services.AddInfrastructureDependencies(configuration);
//builder.Services.RegisterHandlers();
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


//builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));

//builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
//builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

//mediator and fluentvalidation
//builder.Services.RegisterHandlers();
//builder.Services.AddMediatR(o => o.RegisterServicesFromAssembly(typeof(GetAllCustomProductsQueryHandler).Assembly));
//builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(MediatorRequest<,>));
//builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

//builder.Services.Validators();
//builder.Services.AddScoped<IUnityOfWork, UnityOfWork>();


//builder.Services.AddAutoMapper(typeof(MappingFiles));
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//})
//                .AddJwtBearer(o =>
//                {
//                    o.RequireHttpsMetadata = false;
//                    o.SaveToken = false;
//                    o.TokenValidationParameters = new TokenValidationParameters
//                    {
//                        ValidateIssuerSigningKey = true,
//                        ValidateIssuer = true,
//                        ValidateAudience = true,
//                        ValidateLifetime = true,
//                        ValidIssuer = builder.Configuration["JWT:Issuer"],
//                        ValidAudience = builder.Configuration["JWT:Audience"],
//                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
//                    };
//                });


builder.Services.AddControllers();

builder.Services.AddCors();
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

app.UseHttpsRedirection();
app.HandelException();

app.UseCors(c => c.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
