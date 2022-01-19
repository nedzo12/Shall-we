using Shall_we.Shared;

namespace Shallwe.Server.servisi
{
    public class ProfesorServis
{
    private Db Db { init; get; }
    public ProfesorServis(Db db)
    {
        Db = db;
    }
    public List<Profesor> DajSveProfesore()
        => Db.Profesori.ToList();

}
}
