using System.Text;

namespace BandsApp.Web.Models;

public class Band
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description {get; set;}
    public string[] Albums { get; set; }

    public Band(int id, string name, string description, string[] albums)
    {
        Id = id;
        Name = name;
        Description = description;
        Albums = albums;
    }

    public string GetAlbumCover() {
        StringBuilder path = new();
        path.Append("~/Images/");
        path.Append(Name.ToLower()
            .Replace(" ", "")
            .Replace("'", "")
            .Replace("-", "")
            .Replace(".", "")
            .Replace("&", "")
            .Replace("!", "")
            .Replace(",", ""));

        path.Append(".jpg");
        return path.ToString();
        }
    }
