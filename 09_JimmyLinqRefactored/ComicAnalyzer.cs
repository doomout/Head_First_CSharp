using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _09_JimmyLinqRefactored
{
    public static class ComicAnalyzer
    {
        private static PriceRange CalulatePriceRange(Comic comic, IReadOnlyDictionary<int, decimal> prices)
        {
            if (prices[comic.Issue] < 100)
                return PriceRange.Cheap;
            else
                return PriceRange.Expensive;
        }
        public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics, IReadOnlyDictionary<int, decimal> prices)
        {
            /** 기존 Linq 코드
            IEnumerable<IGrouping<PriceRange, Comic>> grouped = 
                from comic in comics
                orderby prices[comic.Issue]
                group comic by CalulatePriceRange(comic, prices) into priceGroup
                select priceGroup;
            */
            //람다식으로 변환
            var grouped = comics
                                .OrderBy(comic => prices[comic.Issue])
                                .GroupBy(comic => CalulatePriceRange(comic, prices));

            return grouped;
        }

        public static IEnumerable<string> GetReviews(IEnumerable<Comic> comics, IEnumerable<Review> reviews)
        {
            /** 기존 Linq 코드
            var joined =
                from comic in comics
                orderby comic.Issue
                join review in reviews 
                on comic.Issue equals review.Issue
                select $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:F2}"; //F2는 소수점 2자리까지 표시하라는 뜻
            */
            //람다식으로 변환
            var joined =
                comics
                .OrderBy(comic => comic.Issue)
                .Join
                (
                    reviews,
                    comic => comic.Issue,
                    review => review.Issue,
                    (comic, review) => $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:F2}" // (comic, review)은 두 시퀀스의 모든 항목에 대해 반환한다.
                );

            return joined;  
        }
    }
}
