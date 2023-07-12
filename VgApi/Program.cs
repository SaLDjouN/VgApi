using VgApi.Models;
using VgApi;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
////if (app.Environment.IsDevelopment())
////{
////    app.UseSwagger();
////    app.UseSwaggerUI();
////}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

Console.WriteLine("COUCOU");

//using (var context = new ExempleContext())
//{
//    var genre = new Genre
//    {
//        Name = "RPG"
//    };
//    var genre2 = new Genre { Name = "Non-RPG" };
//    context.Genres.Add(genre);
//    context.Genres.Add(genre2);
//    context.SaveChanges();
//}

using(var context = new ExempleContext())
{
    context.Games.Add(new Game
        {
            Titre = "Final Fantasy VI",
            Release_Yr = 1992,
            Rating = 5,
            GenreID = 2,
            Description = "très sympa pas comme Emilie"
    });
    context.Games.Add(new Game
    {
        Titre = "Mario Kart 8",
        Release_Yr = 2009, 
        Rating = 4,
        GenreID = 3,
        Description = "plutot sympa comme emilie mais bien trop rarement"
    });

    context.SaveChanges();
}
