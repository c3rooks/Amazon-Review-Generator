using NUnit.Framework;
using CoreysAssessment.Services;
using System.Linq;
using Microsoft.AspNetCore.Routing;

namespace CoreysAssessment.Tests
{
    public class ReviewServiceTests
    {
        private ReviewService _reviewService;

        [SetUp]
        public void Setup()
        {
            _reviewService = new ReviewService();
        }

        [Test]
        public void LoadReviews_ShouldLoadReviewsCorrectly()
        {
            Assert.IsNotNull(_reviewService.Reviews);
            Assert.IsTrue(_reviewService.Reviews.Any());
        }


        // check if the review is not empty / private list fyi
        [Test]
        public void TrainMarkovChain_ShouldTrainCorrectly()
        {
            var review = _reviewService.GenerateReview();
            Assert.IsFalse(string.IsNullOrWhiteSpace(review));
        }

        [Test]
        public void GenerateReview_ShouldGenerateReview()
        {
            var review = _reviewService.GenerateReview();
            Assert.IsFalse(string.IsNullOrWhiteSpace(review));
        }

        [Test]
        public void GenerateReview_ShouldHaveExpectedLength()
        {
            var review = _reviewService.GenerateReview();
            Assert.IsTrue(review.Split(' ').Length <= 1000); // Assuming max length is 1000 words
        }

        [Test]
        public void GenerateReview_ShouldContainValidWords()
        {
            var review = _reviewService.GenerateReview();
            var words = review.Split(' ');
            // Check if the first word in the generated review exists in the training data.
            Assert.IsTrue(_reviewService.Reviews.Any(r => r.ReviewText.Contains(words[0])));
        }
    }
}
