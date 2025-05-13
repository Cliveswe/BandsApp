namespace BandsApp.Web.Models;

public class Band
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string  Description { get; set; }
    public Band(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public string GetAlbumCover()
    {
        return "~/Images/" + Name.ToLower()
            .Replace(" ", "")
            .Replace("'", "")
            .Replace("-", "")
            .Replace(".", "")
            .Replace("&", "")
            .Replace("!", "")
            .Replace(",", "")
            + ".jpg";
    }
}
