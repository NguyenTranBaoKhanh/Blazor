using BlazorAssembly.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Share;
using Share.Enums;

namespace BlazorAssembly.Pages
{
    public partial class FetchCategory
    {
        // [Inject] private HttpClient Http { get; set; }
        [Inject] private ICategoryApi _categoryApi { get; set; }

        private List<CategoryDto> Categories;
        private CategorySearch categorySearch = new CategorySearch();
        protected override async Task OnInitializedAsync()
        {
            Categories = await _categoryApi.GetAll(categorySearch);
        }

        private async Task SearchForm(EditContext context){
            var name = categorySearch.Name;
            var pri = categorySearch.Priority;
            Categories = await _categoryApi.GetAll(categorySearch);
        }
    }

    
}