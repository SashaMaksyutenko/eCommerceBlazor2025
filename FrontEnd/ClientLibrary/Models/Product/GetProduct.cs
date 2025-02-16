using ClientLibrary.Models.Category;

namespace ClientLibrary.Models.Product
{
    public class GetProduct:ProductBase
    {
        public Guid Id { get; set; }
        public GetCategory? Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsNew =>DateTime.Now<=CreatedDate.AddDays(7);
    }
}