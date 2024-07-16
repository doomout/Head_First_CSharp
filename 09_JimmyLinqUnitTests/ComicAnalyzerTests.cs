using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_JimmyLinqUnitTests
{
    using _09_JimmyLinqRefactored;
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
    }
}
