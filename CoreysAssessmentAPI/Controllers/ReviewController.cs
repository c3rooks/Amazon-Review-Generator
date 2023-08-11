using Microsoft.AspNetCore.Mvc;
using System;
using CoreysAssessment.Services;

namespace CoreysAssessment.Controllers
{
[ApiController]
[Route("API")]
public class ReviewController : ControllerBase
{
    private readonly ReviewService _reviewService;

    public ReviewController(ReviewService reviewService)
    {
        _reviewService = reviewService;
    }

    [HttpGet("generate")]
    public IActionResult GenerateReview()
    {
        var review = _reviewService.GenerateReview();
        var starRating = new Random().Next(1, 6); 
        return Ok(new 
        {
            review = review,
            starRating = starRating
        });
    }
}
}
