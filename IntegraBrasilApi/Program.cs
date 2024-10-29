using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Mapping;
using IntegraBrasilApi.Rest;
using IntegraBrasilApi.Services;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
        //builder.Services.AddSingleton<IBancoServices, BancoServices>();
        builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>();

        builder.Services.AddAutoMapper(typeof(EnderecoMapping));

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
    }
}