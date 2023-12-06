using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;
using Basecode.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Repositories
{
    public class ReviewRepository : BaseRepository, IReviewRepository
    {
        public ReviewRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<Review> GetAllReviews()
        {
            return GetDbSet<Review>();
        }
        public async Task<Review> GetReviewById(int reviewId)
        {
            var review = await this.GetDbSet<Review>().Where(r => r.Id == reviewId).SingleOrDefaultAsync();

            return review;
        }

        public IQueryable<Review> GetBookReview(string bookId)
        {
            return GetDbSet<Review>().Where(r => r.BookId == bookId);
        }

        public IQueryable<Review> GetReviews()
        {
            return GetDbSet<Review>();
        }

        public IQueryable<Review> GetReviewsByBook(Book book)
        {
            return GetDbSet<Review>().Where(x => x.Id == book.Id);

        }

        public void AddReview(Review review)
        {
            GetDbSet<Review>().Add(review);
            UnitOfWork.SaveChanges();
        }

        public void DeleteReview(int id)
        {
            var review = GetDbSet<Review>().Find(id);

            if (review != null)
            {
                GetDbSet<Review>().Remove(review);
                UnitOfWork.SaveChanges();
            }

        }

        public void UpdateReview(Review review)
        {
            GetDbSet<Review>().Update(review);
            UnitOfWork.SaveChanges();
        }
        public bool ReviewExists(int id)
        {
            return GetDbSet<Review>().Any(x => x.Id == id);
        }
    }
}

