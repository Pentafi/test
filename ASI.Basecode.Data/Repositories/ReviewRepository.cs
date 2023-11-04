/*using System;
using ASI.Basecode.Data.Models;
using ASI.Basecode.Data.Interfaces;
using Basecode.Data.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
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
            return this.GetDbSet<Review>();
        }

        public Review GetReviewById(int id)
        {
            return this.GetDbSet<Review>().Find(id);
        }

        public void AddReview(Review review)
        {
            this.GetDbSet<Review>().Add(review);
            UnitOfWork.SaveChanges();
        }

        public void UpdateReview(Review review)
        {
            this.SetEntityState(review, EntityState.Modified);
            UnitOfWork.SaveChanges();
        }

        public void DeleteReview(int id)
        {
            var review = this.GetDbSet<Review>().Find(id);
            if (review != null)
            {
                this.GetDbSet<Review>().Remove(review);
                UnitOfWork.SaveChanges();
            }
        }

        public bool ReviewExists(int id)
        {
            return this.GetDbSet<Review>().Any(x => x.Id == id);
        }
    }
}
*/