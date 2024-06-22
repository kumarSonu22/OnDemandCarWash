using Microsoft.EntityFrameworkCore;
using OnDemandCarWash.Data;
using OnDemandCarWash.Interfaces;
using OnDemandCarWash.Models;

namespace OnDemandCarWash.Repositories
{
        public class OrderRepository : IOrderRepository
        {
            private readonly ApplicationDBContext _context;

            public OrderRepository(ApplicationDBContext context)
            {
                _context = context;
            }

            public async Task<Order> GetByIdAsync(int id)
            {
                return await _context.Orders.FindAsync(id);
            }

            public async Task<List<Order>> GetAllAsync()
            {
                return await _context.Orders.ToListAsync();
            }

            public async Task AddAsync(Order order)
            {
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(Order order)
            {
                _context.Entry(order).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var order = await _context.Orders.FindAsync(id);
                if (order != null)
                {
                    _context.Orders.Remove(order);
                    await _context.SaveChangesAsync();
                }
            }
        }
}
