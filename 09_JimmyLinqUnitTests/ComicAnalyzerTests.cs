using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_JimmyLinqUnitTests
{
    using _09_JimmyLinqRefactored;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass] // �� Ŭ������ �׽�Ʈ Ŭ�������� ��Ÿ���ϴ�.
    public class ComicAnalyzerTests
    {
        // �׽�Ʈ�� ��ȭ ����� �����մϴ�.
        IEnumerable<Comic> testComics = new[]
        {
            new Comic() {Issue = 1, Name = "Issue 1"},
            new Comic() {Issue = 2, Name = "Issue 2"},
            new Comic() {Issue = 3, Name = "Issue 3"},
        };

        [TestMethod] // �� �޼���� �׽�Ʈ �޼������� ��Ÿ���ϴ�.
        public void ComicAnalyzer_Should_Group_Comics()
        {
            // �� ��ȭ�� ������ ������ ��ųʸ��Դϴ�.
            var prices = new Dictionary<int, decimal>()
            {
                { 1, 20M },    // Issue 1�� ������ 20
                { 2, 10M },    // Issue 2�� ������ 10
                { 3, 1000M }, // Issue 3�� ������ 1000
            };

            // ��ȭ�� ���ݿ� ���� �׷�ȭ�� ����� ����ϴ�.
            var groups = ComicAnalyzer.GroupComicsByPrice(testComics, prices);

            //Assert.AreEqual(���� ���, ���� ��� ��)
            Assert.AreEqual(2, groups.Count()); // �׷��� ������ 2������ Ȯ���մϴ�.
            Assert.AreEqual(PriceRange.Cheap, groups.First().Key); // ù ��° �׷��� Ű�� Cheap���� Ȯ���մϴ�.
            Assert.AreEqual(2, groups.First().First().Issue); // ù ��° �׷��� ù ��° ��ȭ�� Issue�� 2���� Ȯ���մϴ�.
            Assert.AreEqual("Issue 2", groups.First().First().Name); // ù ��° �׷��� ù ��° ��ȭ�� �̸��� "Issue 2"���� Ȯ���մϴ�.
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

            // ���� ����� ���� ����� ����մϴ�.
            for (int i = 0; i < expectedResults.Length; i++)
            {
                Console.WriteLine($"Expected: {expectedResults[i]}, Actual: {actualResults[i]}");
            }
            //����Ʈ ���� ��
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }
    }
}
