using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebGraphQL.Models;

namespace WebGraphQL.Services;

public static class MusicCollectionService
{
    private const string JsonFile = "musics.json";
    
    // Serializar
    public static void ToJson(MusicCollection musicCollection)
    {
        var jsonContent = JsonConvert.SerializeObject(musicCollection, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            },
            
            Formatting = Formatting.Indented
        });
        
        File.WriteAllText(JsonFile, jsonContent);
    }

    // Deserializar
    public static MusicCollection FromJson()
    {
        if (!File.Exists(JsonFile)) 
            return new MusicCollection();
        
        
        var jsonContent = File.ReadAllText(JsonFile, Encoding.UTF8);
        return JsonConvert.DeserializeObject<MusicCollection>(jsonContent);
    } 
}