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
            ],
            "https://www.youtube.com/embed/aCyGvGEtOwc?si=brIF9hEsGHnB-FR1"
        ),
        new Band
        (
            2, "E-Type", "swedish",
            [
                "Last man standing",
                "Euro IV Fever",
                "Eurotipia"
            ],
            "https://www.youtube.com/embed/y-y3Ef6aTPY?si=dw6qAuPcAGs2RdRm"
        ),
        new Band
        (
            3, "Slipknot", "metal",
            [
                "Dhrenas",
                "Bella Lugxsi",
                "Iowa"
            ],
            "https://www.youtube.com/embed/5abamRO41fE?si=0Z4xTxJPtRKDWhNd"
        ),
    ];

    public Band? GetById(int id)
        => bands
        .SingleOrDefault(b => b.Id == id);


    public Band[] GetAll() {
        return bands
            .OrderBy(x => x.Name)
            .ToArray();
        }
    }
