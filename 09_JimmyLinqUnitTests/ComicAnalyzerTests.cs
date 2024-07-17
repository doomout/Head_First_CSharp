using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_JimmyLinqUnitTests
{
    using _09_JimmyLinqRefactored;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass] // 이 클래스는 테스트 클래스임을 나타냅니다.
    public class ComicAnalyzerTests
    {
        // 테스트용 만화 목록을 정의합니다.
        IEnumerable<Comic> testComics = new[]
        {
            new Comic() {Issue = 1, Name = "Issue 1"},
            new Comic() {Issue = 2, Name = "Issue 2"},
            new Comic() {Issue = 3, Name = "Issue 3"},
        };

        [TestMethod] // 이 메서드는 테스트 메서드임을 나타냅니다.
        public void ComicAnalyzer_Should_Group_Comics()
        {
            // 각 만화의 가격을 정의한 딕셔너리입니다.
            var prices = new Dictionary<int, decimal>()
            {
                { 1, 20M },    // Issue 1의 가격은 20
                { 2, 10M },    // Issue 2의 가격은 10
                { 3, 1000M }, // Issue 3의 가격은 1000
            };

            // 만화를 가격에 따라 그룹화한 결과를 얻습니다.
            var groups = ComicAnalyzer.GroupComicsByPrice(testComics, prices);

            //Assert.AreEqual(예상 결과, 실제 결과 값)
            Assert.AreEqual(2, groups.Count()); // 그룹의 개수가 2개인지 확인합니다.
            Assert.AreEqual(PriceRange.Cheap, groups.First().Key); // 첫 번째 그룹의 키가 Cheap인지 확인합니다.
            Assert.AreEqual(2, groups.First().First().Issue); // 첫 번째 그룹의 첫 번째 만화의 Issue가 2인지 확인합니다.
            Assert.AreEqual("Issue 2", groups.First().First().Name); // 첫 번째 그룹의 첫 번째 만화의 이름이 "Issue 2"인지 확인합니다.
        }
        [TestMethod]
        public void ComicAnalyzer_Should_Generate_A_List_Of_Reviews()
        {
            var testReviews = new[]
            {
                new Review() { Issue = 1, Critic = Critics.MuddyCritic, Score = 14.5 },
                new Review() { Issue = 1, Critic = Critics.RottenTornadoes, Score = 59.93 },
                new Review() { Issue = 2, Critic = Critics.MuddyCritic, Score = 40.3 },
                new Review() { Issue = 2, Critic = Critics.RottenTornadoes, Score = 95.11 },
            };
            var expectedResults = new[]
            {
                "MuddyCritic rated #1 'Issue 1' 14.50",
                "RottenTornadoes rated #1 'Issue 1' 59.93",
                "MuddyCritic rated #2 'Issue 2' 40.30",
                "RottenTornadoes rated #2 'Issue 2' 95.11",
            };
            var actualResults = ComicAnalyzer.GetReviews(testComics, testReviews).ToList();

            // 예상 결과와 실제 결과를 출력합니다.
            for (int i = 0; i < expectedResults.Length; i++)
            {
                Console.WriteLine($"Expected: {expectedResults[i]}, Actual: {actualResults[i]}");
            }
            //리스트 끼리 비교
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }
    }
}
