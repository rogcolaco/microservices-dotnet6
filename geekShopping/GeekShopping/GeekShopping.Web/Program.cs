using GeekShopping.Web.Services;
using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Injeção do HTTP Client ProductAPI
builder.Services.AddHttpClient<IProductService, ProductService>(httpClient => { httpClient.BaseAddress = new(builder.Configuration["ServiceUrls:ProductAPI"]); });
//Injeção do HTTP Client CartAPI
builder.Services.AddHttpClient<ICartService, CartService>(httpClient => { httpClient.BaseAddress = new(builder.Configuration["ServiceUrls:CartAPI"]); });
//Injeção do HTTP Client CouponAPI
builder.Services.AddHttpClient<ICouponService, CouponService>(httpClient => { httpClient.BaseAddress = new(builder.Configuration["ServiceUrls:CouponAPI"]); });

//Adiciona autenticacao
builder.Services.AddAuthentication(options => {
    options.DefaultScheme = "Cookies";
    options.DefaultChallengeScheme = "oidc";
})
    .AddCookie("Cookies", c => c.ExpireTimeSpan = TimeSpan.FromMinutes(10))
    .AddOpenIdConnect("oidc", options => {
        options.Authority = builder.Configuration["ServiceUrls:IdentityServer"];
        options.GetClaimsFromUserInfoEndpoint = true;
        options.ClientId = "geek_shopping";
        options.ClientSecret = "my_super_secret";
        options.ResponseType = "code";
        options.ClaimActions.MapJsonKey("role", "role", "role");
        options.ClaimActions.MapJsonKey("sub", "sub", "sub");
        options.TokenValidationParameters.NameClaimType = "name";
        options.TokenValidationParameters.RoleClaimType = "role";
        options.Scope.Add("geek_shopping");
        options.SaveTokens = true;
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
}

//Indicação da aplicação para utilização de HTTPS
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//Indicação da aplicação para utilização de authentications
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
