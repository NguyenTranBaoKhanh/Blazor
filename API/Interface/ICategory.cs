using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Share;

namespace API.Interface
{
    public interface ICategory
    {
        Task<IEnumerable<Category>> GetAll(CategorySearch query);

        Task<Category> Create(CategoryCreate category);

        Task<Category> Delete(int id);
        Task<Category> GetById(int id);
        Task<Category> Update(Category category);
    }
}