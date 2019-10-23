using CasaDoCodigo.Models;
using System;
using System.Linq;

namespace CasaDoCodigo.Repositories
{
    public interface ICadastroRepository
    {
        Cadastro Update(int cadastroId, Cadastro novoCadastro);
    }

    public class CadastroRpository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRpository(ApplicationContext contexto) : base(contexto)
        {
        }

        public Cadastro Update(int cadastroId, Cadastro novoCadastro)
        {
            var cadastroDB = dbSet.Where(x => x.Id == cadastroId).SingleOrDefault();

            if (cadastroDB == null)
                throw new ArgumentNullException("cadastro");

            cadastroDB.Update(novoCadastro);
            contexto.SaveChanges();

            return cadastroDB;
        }
    }
}
