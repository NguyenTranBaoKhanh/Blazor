using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAssembly.Pages;
using Share;

namespace BlazorAssembly.Services
{
    public interface ICategoryApi
    {
        Task<List<CategoryDto>> GetAll(CategorySearch query);
        Task<CategoryDto> GetById(int id);

        Task<bool> Create(CategoryCreate category);
    }
}