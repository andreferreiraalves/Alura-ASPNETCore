using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface IItemPedidoRpository { }

    public class ItemPedidoRpository : BaseRepository<ItemPedido>, IItemPedidoRpository
    {
        public ItemPedidoRpository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
