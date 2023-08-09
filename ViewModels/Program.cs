var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


#region Summary
/*
 * Previous concept:
 * if we want to bind with single model with single view so  we can do by @model dir :
 * 
 * Today's concept:
 * bind multiple model with single view:
 * approcah:
 * 1-register your models in new model as properties : known as viewmodel:
 * 2-bind that model with view
 * 
 * Note: //we can't pass 2nd model as 2nd arg in view or we can't add another model dir
 */
#endregion
