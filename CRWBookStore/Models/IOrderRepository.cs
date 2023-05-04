using CRWBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRWBookStore.Models
{
    public interface IOrderRepository
    {

        IQueryable<Order> Orders { get; }
    }
}
