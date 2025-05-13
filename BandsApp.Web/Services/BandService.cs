using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    private List<Band> bands = [
        new Band
        (
            1, "Paramore", "rock music",
            [
                "Riot",
                "Misery Business",
                "Sunday Bloody Sunday"
            ]
            
        ),
        new Band
        (
            2, "E-Type", "swedish",
            [
                "Last man standing",
                "Euro IV Fever",
                "Eurotipia"
            ]
        ),
        new Band
        (
            3, "Slipknot", "metal", 
            [
                "Dhrenas",
                "Bella Lugxsi",
                "Iowa"
            ]
        ),
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
