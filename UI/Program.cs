using Microsoft.AspNetCore.Authentication.Cookies;
using UI.ApiService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
{
    opt.Cookie.Name = "ETicaretPusulaCookie";
    opt.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    opt.Cookie.HttpOnly = true;
    opt.LoginPath = "/Login/Login";
    opt.LogoutPath = "/Login/Login";
    opt.AccessDeniedPath = "/Login/Login";
});

builder.Services.AddHttpClient<LoginApiService>(o =>
{
    o.BaseAddress = new Uri("https://localhost:7185/api/");//Api URL
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
