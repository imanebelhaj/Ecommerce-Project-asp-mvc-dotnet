using System;
using System.Collections.Generic;

namespace EcomProjet3.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
            ProductReviews = new HashSet<ProductReview>();
            Wishlists = new HashSet<Wishlist>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public string? ProductDescription { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
