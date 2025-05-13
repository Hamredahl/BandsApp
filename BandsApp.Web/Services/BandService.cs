using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    private List<Band> bands = [
            new Band { Id = 0, Name = "Jackson 5", Description = "A pop-music group.", Image = "Jackson5_500px.png"},
            new Band { Id = 1, Name = "BABYMETAL", Description = "A J-Metal band.", Image = "BABYMETAL_500px.png"},
            new Band { Id = 2, Name = "NWA", Description = "Straight Outta Compton.", Image = "NWA_500px.png"}
        ];

    public Band? GetBandById(int Id) => bands
        .SingleOrDefault(b => b.Id == Id);

    public Band[] GetAllBands() => bands
        .OrderBy(b => b.Name)
        .ToArray();
}
