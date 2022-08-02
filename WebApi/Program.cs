using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//berke controller inside another controller çözüm
builder.Services.AddMvc().AddControllersAsServices();


builder.Services.AddControllers();
builder.Services.AddSingleton<IGuideService, GuideManager>();
builder.Services.AddSingleton<IGuideDal, EfGuideDal>();

builder.Services.AddControllers();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();

builder.Services.AddControllers();
builder.Services.AddSingleton<IGuideService, GuideManager>();
builder.Services.AddSingleton<IGuideDal, EfGuideDal>();


builder.Services.AddControllers();
builder.Services.AddSingleton<IKeywordService, KeywordManager>();
builder.Services.AddSingleton<IKeywordDal, EfKeywordDal>();

builder.Services.AddControllers();
builder.Services.AddSingleton<IPlatformService, PlatformManager>();
builder.Services.AddSingleton<IPlatformDal, EfPlatformDal>();

builder.Services.AddControllers();
builder.Services.AddSingleton<IContentService, ContentManager>();
builder.Services.AddSingleton<IContentDal, EfContentDal>();

builder.Services.AddControllers();
builder.Services.AddSingleton<IRoutingService, RoutingManager>();
builder.Services.AddSingleton<IRoutingDal, EfRoutingDal>();

builder.Services.AddControllers();
builder.Services.AddSingleton<IDocumentService, DocumentManager>();
builder.Services.AddSingleton<IDocumentDal, EfDocumentDal>();

builder.Services.AddControllers();
builder.Services.AddSingleton<ILanguageService, LanguageManager>();
builder.Services.AddSingleton<ILanguageDal, EfLanguageDal>();

builder.Services.AddControllers();
builder.Services.AddSingleton<IGuideKeywordService, GuideKeywordManager>();
builder.Services.AddSingleton<IGuideKeywordDal, EfGuideKeywordDal>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
