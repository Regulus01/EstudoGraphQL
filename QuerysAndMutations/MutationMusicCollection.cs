using WebGraphQL.Models;
using WebGraphQL.Services;

namespace WebGraphQL.QuerysAndMutations;

public class MutationMusicCollection
{
    public string AddMusicToCollection(MusicItem music)
    {
        var musicCollection = MusicCollectionService.FromJson();
        musicCollection.Musics.Add(music);
        MusicCollectionService.ToJson(musicCollection);
        
        return "OK";
    }
}