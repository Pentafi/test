using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;
using ASI.Basecode.Services.Interfaces;
using ASI.Basecode.Services.ServiceModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Services.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _repository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AddReview(ReviewViewModel model)
        {
            var review = new Review();
            _mapper.Map(review, model);
            _repository.AddReview(review);
        }

        public void DeleteReview(int Id)
        {
            _repository.DeleteReview(Id);
        }

        public IQueryable<Review> GetBookReview(string BookId)
        {
            return _repository.GetBookReview(BookId);
        }

        public IQueryable<Review> GetReviews()
        {
            return _repository.GetReviews();
        }

        public Task<Review> GetReviewsById(int Id)
        {
            return _repository.GetReviewById(Id);
        }

        public void UpdateReview(ReviewViewModel update)
        {
            var review = new Review();
            _mapper.Map(review, update);
            _repository.UpdateReview(review);
        }
    }
}
