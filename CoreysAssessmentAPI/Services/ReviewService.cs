using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CoreysAssessment.Models;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace CoreysAssessment.Services
{
    public class ReviewService
    {
        private readonly string _dataFilePath = Path.Combine("TrainingData", "Appliances_5.json");
        private Dictionary<string, List<string>> _transitions;
        public List<Review> Reviews { get; private set; }


        public ReviewService()
        {
            var reviews = new List<Review>();
            foreach (var line in File.ReadLines(_dataFilePath))
            {
                var review = JsonConvert.DeserializeObject<Review>(line);
                reviews.Add(review); // add to list of reviews
            }
            Reviews = reviews;
            TrainMarkovChain();
        }

        private void TrainMarkovChain()
        {
            _transitions = new Dictionary<string, List<string>>();
            foreach (var review in Reviews)
            {
                var words = review.ReviewText?.Split(' ') ?? new string[0];
                for (int i = 0; i < words.Length - 1; i++)
                {
                    if (!_transitions.ContainsKey(words[i]))
                    {
                        _transitions[words[i]] = new List<string>();
                    }
                    _transitions[words[i]].Add(words[i + 1]);
                }
            }
        }

        public string GenerateReview()
        {
            var currentWord = _transitions.Keys.ElementAt(new Random().Next(_transitions.Count));
            var review = new StringBuilder(currentWord); // use stringbuilder to build a mutable string 
            for (int i = 0; i < 1000; i++) // update to set the 1000 as property - how many words review has 
            {
                if (!_transitions.ContainsKey(currentWord))
                {
                    break; // check to see if the word exists, stop and return whatever text build up 
                }
                var nextWord = _transitions[currentWord][new Random().Next(_transitions[currentWord].Count)];
                review.Append(" " + nextWord);
                currentWord = nextWord;
            }
            return review.ToString();
        }
    }
}
