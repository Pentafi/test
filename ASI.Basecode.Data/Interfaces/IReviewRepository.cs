using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Interfaces
{
    public interface IReviewRepository
    {
        IQueryable<Review> GetAllReviews();
        Task<Review> GetReviewById(int id);
        IQueryable<Review> GetReviewsByBook(Book book);
        IQueryable<Review> GetBookReview(string bookId);
        IQueryable<Review> GetReviews();
        void AddReview(Review review);
        void UpdateReview(Review update);
        void DeleteReview(int reviewId);
    }
}
