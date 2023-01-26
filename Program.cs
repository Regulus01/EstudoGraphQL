using WebGraphQL.QuerysAndMutations;

var builder = WebApplication.CreateBuilder(args);


//Query consulta dados
//Mutation serve para gravar dados

//Registra as mutations e querys
builder.Services.AddGraphQLServer()
    .AddQueryType<QueryMusicCollection>()
    .AddMutationType<MutationMusicCollection>();

var app = builder.Build();

app.MapGraphQL(path: "/");

app.Run();



