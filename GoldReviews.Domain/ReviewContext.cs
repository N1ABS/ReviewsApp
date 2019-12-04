using System.Data.Entity;

namespace GoldReviews.Domain
{
    public class ReviewContext : DbContext
    {
        public ReviewContext() : base("name=ReviewDataContext")
        {
            
        }

        public virtual DbSet<Review> Reviews { get; set; }
    }
}