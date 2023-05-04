using Microsoft.EntityFrameworkCore;
using System.Linq;
using CRWBookStore.Data;

namespace CRWBookStore.Models {

    public class EFOrderRepository : IOrderRepository {
       
        private StoreDbContext context;


        public IQueryable<Order> Orders => context.Orders
                            .Include(o => o.Lines)
                            .ThenInclude(l => l.book);

    }
}
