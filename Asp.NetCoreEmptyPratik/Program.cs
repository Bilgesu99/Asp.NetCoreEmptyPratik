var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();





var app = builder.Build();

// Statik Dosyalarýn kullanýmý için ekleme yapýyorum
app.UseStaticFiles(); // wwwroot klasöründeki statik dosyalarýn kullanýlmasýný saðlar



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}"
    );




app.Run();

// Controller: Ýstemciden gelen HTTP isteklerini karþýlayan ve ilgili iþlemleri yöneten sýnýflardýr.
// Action: Controller içerisinde bir iþlemi gerçekleþtiren metotlardýr. Örneðin, bir sayfanýn görüntülenmesi.
// Model: Uygulamadaki verileri temsil eden yapýlardýr. Genellikle veri tabaný ile çalýþýr.
// View: Kullanýcýya gösterilecek HTML sayfasýný içerir.
// Razor: Razor sayesinde C# kodlarýný doðrudan HTML içinde kullanabilir 
// RazorView: Razor ile oluþturulmuþ HTML sayfasýdýr. View'ler Razor ile dinamik hale getirilir.
// wwwroot: Uygulamanýn statik dosyalarýnýn (CSS, JS, resimler vb.) tutulduðu klasördür.
// builder.Build(): Uygulamanýn yapýlandýrýlmasýný tamamlar ve uygulamayý baþlatmaya hazýr hale getirir.
// app.Run(): Uygulamayý baþlatýr ve gelen HTTP isteklerini dinlemeye baþlar.

