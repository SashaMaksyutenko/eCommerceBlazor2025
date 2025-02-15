namespace eCommerceApp.Domain.Interfaces.CategorySpecifics
{
    public interface ICategory
    {
        Task<IEnumerable<Product>>GetProductsByCategory(Guid categoryId);
    }
}