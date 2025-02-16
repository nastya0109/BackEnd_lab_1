//файл, с помощью которого происходит запуск всего проекта

var builder = WebApplication.CreateBuilder(args); 

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//проверка, находимся ли мы в режиме отладки
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); //если мы не находимя в режиме разработке и хотим перейти на какие-то несуществующие страницы,
                                            //то у нас возникнет ошибка
    app.UseHsts();
}

//подключение дополнений
app.UseHttpsRedirection();  //подключеие переадресации  
app.UseStaticFiles();  //подключение статических файлов: стили и так далее

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); //запуск проекта
