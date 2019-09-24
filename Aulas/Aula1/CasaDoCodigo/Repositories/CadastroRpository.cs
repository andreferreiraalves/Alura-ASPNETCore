using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface ICadastroRpository { }

    public class CadastroRpository : BaseRepository<Cadastro>, ICadastroRpository
    {
        public CadastroRpository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
