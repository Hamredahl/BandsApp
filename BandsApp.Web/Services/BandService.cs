using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    private List<Band> bands = [
            new Band { Id = 0, Name = "Jackson 5", Description = "A pop-music group."},
            new Band { Id = 1, Name = "Baby Metal", Description = "A J-Metal band."},
            new Band { Id = 2, Name = "NWA", Description = "Straight Outta Compton."}
        ];

    public Band? GetBandById(int Id) => bands
        .SingleOrDefault(b => b.Id == Id);

    public Band[] GetAllBands() => bands
        .OrderBy(b => b.Name)
        .ToArray();
}
