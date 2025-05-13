using BandsApp.Web.Models;
using System.Diagnostics.Metrics;

namespace BandsApp.Web.Services;

public class BandService
{
    private List<Band> bands = [
            new Band { Id = 0,
                Name = "Jackson 5",
                Description = "Jackson 5 are an American pop band composed of members of the Jackson family. The group was formed in Gary, Indiana in 1964, and originally consisted of brothers Jackie, Tito, Jermaine, Marlon, and Michael. The group were among the first African American performers to attain a crossover following.",
                Image = "Jackson5_500px.png",
                Albums = [
                    "Diana Ross Presents The Jackson 5 (1969)",
                    "ABC (1970)",
                    "Third Album (1970)",
                    "Jackson 5 Christmas Album (1970)",
                    "Maybe Tomorrow (1971)","Lookin\' Through the Windows (1972)",
                    "Skywriter (1973)","G.I.T.: Get It Together (1973)",
                    "Dancing Machine (1974)",
                    "Moving Violation (1975)"]
            },
            new Band { Id = 1, 
                Name = "BABYMETAL", 
                Description = "BABYMETAL is a Japanese kawaii metal band consisting of Suzuka Nakamoto as Su-metal, Moa Kikuchi as Moametal and Momoko Okazaki as Momometal. Their vocals are backed by heavy metal instrumentation, performed by a group of session musicians known as the Kami Band at performances.", 
                Image = "BABYMETAL_500px.png",
                Albums = [
                    "Babymetal (2014)", 
                    "Metal Resistance (2016)", 
                    "Metal Galaxy (2019)", 
                    "The Other One (2023)", 
                    "Metal Forth (2025)"]
            },
            new Band { Id = 2, 
                Name = "NWA", 
                Description = "NWA was an American hip hop group formed in Compton, California in 1987. Among the earliest and most significant figures of the gangsta rap subgenre, the group is widely considered one of the greatest and most influential acts in hip hop music.", 
                Image = "NWA_500px.png",
                Albums = [
                    "Straight Outta Compton (1989)",
                    "Niggaz4Life (1991)"]                
            }
        ];

    public Band? GetBandById(int Id) => bands
        .SingleOrDefault(b => b.Id == Id);

    public Band[] GetAllBands() => bands
        .OrderBy(b => b.Name)
        .ToArray();
}
