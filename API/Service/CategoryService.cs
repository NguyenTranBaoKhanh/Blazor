using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interface;
using Microsoft.EntityFrameworkCore;
using Share;
using Share.Enums;

namespace API.Service
{
    public class CategoryService : ICategory
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Category> Create(CategoryCreate category)
        {
            var categoryNew = new Category(){
                Name = category.Name,
                DisplayOrder = category.DisplayOrder,
                Priority = (Priority)category.Priority,
            };
            await _dbContext.Categories.AddAsync(categoryNew);
            await _dbContext.SaveChangesAsync();
            return categoryNew;
        }

        public Task<Category> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAll(CategorySearch query)
        {
            var result = _dbContext.Categories.AsQueryable();
            if(!string.IsNullOrEmpty(query.Name)){
                result = result.Where(x => x.Name.Contains(query.Name));
            }
            if(query.Priority.HasValue){
                result = result.Where(x => x.Priority == query.Priority);
            }
            return result;
        }

        public async Task<Category> GetById(int id)
        {
            return await _dbContext.Categories.FindAsync(id);
        }

        public async Task<Category> Update(Category category)
        {
            _dbContext.Categories.Update(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }
    }
}