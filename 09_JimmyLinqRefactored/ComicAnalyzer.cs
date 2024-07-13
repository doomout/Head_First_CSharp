using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _09_JimmyLinqRefactored
{
    internal static class ComicAnalyzer
    {
        private static PriceRange CalulatePriceRange(Comic comic)
        {
            if (Comic.Prices[comic.Issue] <= 100)
                return PriceRange.Cheap;
            else
                return PriceRange.Expensive;
        }
        public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics, IReadOnlyDictionary<int, decimal> prices)
        {
            IEnumerable<IGrouping<PriceRange, Comic>> grouped = 
                from comic in comics
                orderby prices[comic.Issue]
                group comic by CalulatePriceRange(comic) into priceGroup
                select priceGroup;
            
            return grouped;
        }

        public static IEnumerable<string> GetReviews(IEnumerable<Comic> comics, IEnumerable<Review> reviews)
        {
            var joined =
                from comic in comics
                orderby comic.Issue
                join review in reviews on comic.Issue equals review.Issue
                select $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.score: 0.00}";

            return joined;  
        }
    }
}
