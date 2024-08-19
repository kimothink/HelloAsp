var builder = WebApplication.CreateBuilder(args);

// 컨트롤러 서비스를 추가합니다.
builder.Services.AddControllersWithViews();

// AddConnections는 불필요할 수 있습니다. 만약 연결 서비스가 필요한 경우 여기에 추가할 수 있습니다.
// builder.Services.AddConnections();

var app = builder.Build();     
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}"
);


app.Run();

