using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorAssembly.Pages;
using Share;

namespace BlazorAssembly.Services
{
    public class CategoryApi : ICategoryApi
    {
        public HttpClient _httpClient;

        public CategoryApi(HttpClient httpClient){
            _httpClient = httpClient;
        }

        public async Task<bool> Create(CategoryCreate category)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/Category", category);
            return result.IsSuccessStatusCode;
        }

        public async Task<List<CategoryDto>> GetAll(CategorySearch query)
        {
            var url =  $"/api/Category?Name={query.Name}&Priority={query.Priority}";
            var result = await _httpClient.GetFromJsonAsync<List<CategoryDto>>(url);
            return result;
        }

        public async Task<CategoryDto> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<CategoryDto>($"/api/Category/{id}");
            return result;
        }
    }
}