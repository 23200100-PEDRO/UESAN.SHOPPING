using Microsoft
using System;
using System.Collections.Generic;
using System.Text;
using UESAN.SHOPPING.CORE.Core.Entities;
using UESAN.SHOPPING.CORE.Infrastructure.DATA;

namespace UESAN.SHOPPING.CORE.Infrastructure.Repositories
{
    public class CategoryRepository
    {
        private readonly StoreDbContext _context;
        
        public CategoryRepository(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>>GetCategories()
        {
            return await _context.Category.ToListAsync();
        }
        public async Task<Category> GetCategoryById(int id) {
            {
                return await _context.Category.Where(c => c.Id == id).FirstOrDefault
            }
            //Create Category
            public async Task UpdateCategory(Category category)
            {

            }
            //Update Category 
            public async Task UpdateCategory
            
    }
}
