using WebGraphQL.Models;
using WebGraphQL.Services;

namespace WebGraphQL.QuerysAndMutations;

public class QueryMusicCollection
{
    public MusicCollection GetMusicCollection()
    {
        var musicCollection = MusicCollectionService.FromJson();

        return musicCollection;
    }
}