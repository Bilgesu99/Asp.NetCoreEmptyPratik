var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();





var app = builder.Build();

// Statik Dosyalar�n kullan�m� i�in ekleme yap�yorum
app.UseStaticFiles(); // wwwroot klas�r�ndeki statik dosyalar�n kullan�lmas�n� sa�lar



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}"
    );




app.Run();

// Controller: �stemciden gelen HTTP isteklerini kar��layan ve ilgili i�lemleri y�neten s�n�flard�r.
// Action: Controller i�erisinde bir i�lemi ger�ekle�tiren metotlard�r. �rne�in, bir sayfan�n g�r�nt�lenmesi.
// Model: Uygulamadaki verileri temsil eden yap�lard�r. Genellikle veri taban� ile �al���r.
// View: Kullan�c�ya g�sterilecek HTML sayfas�n� i�erir.
// Razor: Razor sayesinde C# kodlar�n� do�rudan HTML i�inde kullanabilir 
// RazorView: Razor ile olu�turulmu� HTML sayfas�d�r. View'ler Razor ile dinamik hale getirilir.
// wwwroot: Uygulaman�n statik dosyalar�n�n (CSS, JS, resimler vb.) tutuldu�u klas�rd�r.
// builder.Build(): Uygulaman�n yap�land�r�lmas�n� tamamlar ve uygulamay� ba�latmaya haz�r hale getirir.
// app.Run(): Uygulamay� ba�lat�r ve gelen HTTP isteklerini dinlemeye ba�lar.

