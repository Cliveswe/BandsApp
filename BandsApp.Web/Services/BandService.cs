using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    private List<Band> bands = [
        new Band(1, "Misery Business", "rock music"),
        new Band(2, "E-Type", "swedish"),
        new Band(3, "Slipknot", "metal"),
    ];

    public Band? GetById(int id)
        => bands
        .SingleOrDefault(b => b.Id == id);


    public Band[] GetAll()
    {
        return bands
            .OrderBy(x => x.Name)
            .ToArray();
    }
}
