using System.Linq;

namespace CRWBookStore.Models
{
    public interface IStoreRepository
    {
        public IQueryable<BookModel> Books { get; }
    }
}
