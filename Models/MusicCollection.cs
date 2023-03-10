namespace WebGraphQL.Models;
public class Base
{
    private Guid? _id;

    public Guid? Id
    {
        get { return _id ?? Guid.NewGuid(); }
        set { _id = value; }
    }
}

public class MusicCollection
{
    public List<MusicItem> Musics { get; set; } = new();
}

public class MusicItem : Base
{
    public string? Music { get; set; }
    public string? Comment { get; set; }
    public List<Artist> Artists { get; set; }
}

public class Artist : Base
{
    public string? Name { get; set; }
}