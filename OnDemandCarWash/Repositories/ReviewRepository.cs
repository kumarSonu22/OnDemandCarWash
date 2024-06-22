using Microsoft.EntityFrameworkCore;
using OnDemandCarWash.Data;
using OnDemandCarWash.Interfaces;
using OnDemandCarWash.Models;

namespace OnDemandCarWash.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDBContext _context;

        public ReviewRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Review> GetByIdAsync(int id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        public async Task<List<Review>> GetAllAsync()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task AddAsync(Review review)
        {
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Review review)
        {
            _context.Entry(review).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                await _context.SaveChangesAsync();
            }
        }
    }
}
