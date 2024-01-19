using System;
using System.Collections.Generic;

namespace EcomProjet3.Models
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
            ProductReviews = new HashSet<ProductReview>();
            Wishlists = new HashSet<Wishlist>();
        }

        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public string? Username { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Adress { get; set; }
        public string? PostCode { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? ImageUrl { get; set; }
        public int RoleId { get; set; }
        
        public DateTime CreatedDate { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
