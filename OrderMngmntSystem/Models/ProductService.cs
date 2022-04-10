using System.ComponentModel.DataAnnotations;

namespace OrderMngmntSystem
{
    public class ProductService
    {
        public string productName { get; set; }
        [Key]
        public int productId { get; set; }

        public string productCategory { get; set; }
    }
}
