using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages;

public class ProductsBase : ComponentBase
{
    [Inject]
    public IProductService ProductService { get; set; }

    protected IEnumerable<ProductDto> Products { get; private set; }

    protected override async Task OnInitializedAsync()
    {
        Products = await ProductService.GetItems();
    }
}