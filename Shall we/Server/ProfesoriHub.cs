using Microsoft.AspNetCore.SignalR;
using Shallwe.Server.servisi;

namespace Shallwe.Server
{
    public class ProfesoriHub: Hub
{
    private ProfesorServis ProfesoriServis { init; get; }
    public ProfesoriHub(ProfesorServis profesoriServis)
    {
        ProfesoriServis = profesoriServis;
    }
    public async Task UzmiSveProfesore()
    {
            await Clients.Caller.SendAsync("TuJe", ProfesoriServis.DajSveProfesore());
    }

}
}
