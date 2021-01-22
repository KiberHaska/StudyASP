using AspLevel1.Domain.Entities;
using ASPlevel1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPlevel1.Infrastructure.Interfaces
{
    public interface IOrdersService
    {
        IEnumerable<Order> GetUserOrders(string userName);
        Order GetOrderById(int id);
        Order CreateOrder(OrderViewModel orderModel, CartViewModel transformCart, string userName);
    }
}
